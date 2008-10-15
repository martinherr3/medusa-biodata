using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Biodata.DTO;

namespace Biodata.WinForm
{
    public enum EstadoAccion
    {
        Nuevo,
        Modificar,
        Eliminar
    }

    public partial class frmPaciente : frmBase 
    {
        private EstadoAccion _MyEstadoAccion;

        public EstadoAccion MyEstadoAccion
        {
            get { return _MyEstadoAccion; }
            set { _MyEstadoAccion = value; }
        }

        public frmPaciente()
        {
            InitializeComponent();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            CrearColumnas();
            BuscarPacientes();
        }

        private void BuscarPacientes()
        {
            try
            {
                PacienteDTO wPaciente = new PacienteDTO();

                List<PacienteDTO> wPacientes = wPaciente.Llenar();
                
                dgvPacientes.DataSource = null;
                dgvPacientes.DataSource = wPacientes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void CrearColumnas()
        {
            try
            {
                dgvPacientes.AutoGenerateColumns = false;
                dgvPacientes.Columns.Clear();
                dgvPacientes.Columns.Add("ID", "ID");
                dgvPacientes.Columns[0].DataPropertyName = "ID";
                //dgvPacientes.Columns[0].Visible = false;
                dgvPacientes.Columns.Add("Nombre", "Nombre");
                dgvPacientes.Columns[1].DataPropertyName = "Nombre";
                dgvPacientes.Columns.Add("Apellido", "Apellido");
                dgvPacientes.Columns[2].DataPropertyName = "Apellido";

                dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RegistrarPaciente();
        }

        private void RegistrarPaciente()
        {
            PacienteDTO wPaciente = new PacienteDTO();
            wPaciente.Nombre = txtNombre.Text;
            wPaciente.Apellido = txtApellido.Text;
            wPaciente.Direccion = txtDireccion.Text;
            //wPaciente.FechaNacimiento = dtpFechaNacimiento.Value.ToString();
            wPaciente.NumDocumento = txtDocumento.Text;
            wPaciente.Sexo = txtSexo.Text;
            wPaciente.Comentario = txtComentario.Text;

            if (MyEstadoAccion == EstadoAccion.Nuevo) //Nuevo
            {
                wPaciente.Insertar();
            }
            else //Modificar
            {
                wPaciente.ID = Convert.ToInt32(txtID.Text);
                wPaciente.Modificar();
            }

            BuscarPacientes(); 
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevoPaciente();
        }

        private void NuevoPaciente()
        {
            MyEstadoAccion = EstadoAccion.Nuevo;
            HabilitarControles(true);
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            txtDocumento.Text = "";
            txtSexo.Text = "";
            txtComentario.Text = "";
        }

        private void HabilitarControles(Boolean pValor)
        {
            txtNombre.Enabled = pValor;
            txtApellido.Enabled = pValor;
            txtDireccion.Enabled = pValor;
            dtpFechaNacimiento.Enabled = pValor;
            txtDocumento.Enabled = pValor;
            txtSexo.Enabled = pValor;
            txtComentario.Enabled = pValor;
        }

        private void btnModficar_Click(object sender, EventArgs e)
        {
            ModificarPaciente();
            MyEstadoAccion = EstadoAccion.Modificar;
        }

        private void ModificarPaciente()
        {
            PacienteDTO wPaciente = (PacienteDTO)dgvPacientes.CurrentRow.DataBoundItem;

            txtID.Text = wPaciente.ID.ToString();
            txtNombre.Text = wPaciente.Nombre;
            txtApellido.Text = wPaciente.Apellido;
            txtDireccion.Text = wPaciente.Direccion;
            dtpFechaNacimiento.Text = wPaciente.FechaNacimiento;
            txtDocumento.Text = wPaciente.NumDocumento;
            txtSexo.Text = wPaciente.Sexo;
            txtComentario.Text = wPaciente.Comentario;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarPaciente();
        }

        private void EliminarPaciente()
        {
            DialogResult w = MessageBox.Show("Esta seguro de Eliminar?", "Mensaje", MessageBoxButtons.YesNo);

            if (w.ToString() == "Yes")
            {
                PacienteDTO wPaciente = (PacienteDTO)dgvPacientes.CurrentRow.DataBoundItem;

                wPaciente.Eliminar();

                BuscarPacientes();
            }
        }
    }
}
