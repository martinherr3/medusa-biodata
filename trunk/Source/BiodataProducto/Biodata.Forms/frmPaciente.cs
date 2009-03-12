using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Architecture.Utils;
using Mds.Biodata.Business;
using Mds.Biodata.Domain;

namespace Mds.Biodata.Forms
{
    public partial class frmPaciente : frmABMBase
    {
        #region "--[Properties]--"
        private PacienteBusiness _PacienteBP;

        public PacienteBusiness PacienteBP
        {
            get { return _PacienteBP; }
            set { _PacienteBP = value; }
        }

        private List<Paciente> _PacienteEntities = new List<Paciente>();

        public List<Paciente> PacienteEntities
        {
            get { return _PacienteEntities; }
            set { _PacienteEntities = value; }
        }

        private Paciente _PacienteEntity;

        public Paciente PacienteEntity
        {
            get { return _PacienteEntity; }
            set { _PacienteEntity = value; }
        }
        #endregion

        #region "--[Methods]--"
        public frmPaciente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Da formato a la grilla
        /// </summary>
        private void BuildColumns()
        {
            try
            {
                dgvList.AutoGenerateColumns = false;
                dgvList.Columns.Clear();
                dgvList.Columns.Add("Nombre", "Nombre");
                dgvList.Columns[0].DataPropertyName = "Nombre";
                dgvList.Columns[0].Visible = false;
                dgvList.Columns.Add("Apellido", "Apellido");
                dgvList.Columns[1].DataPropertyName = "Apellido";
                dgvList.Columns.Add("Direccion", "Direccion");
                dgvList.Columns[2].DataPropertyName = "Direccion";
                dgvList.Columns.Add("Telefono", "Telefono");
                dgvList.Columns[3].DataPropertyName = "Telefono";
                dgvList.Columns.Add("Celular", "Celular");
                dgvList.Columns[4].DataPropertyName = "Celular";
                dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        /// <summary>
        /// Carga la grilla con los registros de la DB
        /// </summary>
        private void LoadList()
        {
            try
            {
                ptbProgress.Visible = true;
                BuildColumns();
                dgvList.DataSource = null;
                Habilitar(false);
                btnClose.Enabled = true;
                bgwLoad.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        /// <summary>
        /// Carga la entidad (registro) seleccionada en los controles
        /// </summary>
        private void LoadData()
        {
            PacienteEntity = PacienteBP.GetById(((Paciente)dgvList.CurrentRow.DataBoundItem).ID);

            

            txtID.Text = PacienteEntity.ID.ToString();
            txtNombre.Text = PacienteEntity.Nombre;
            txtApellido.Text = PacienteEntity.Apellido;
            txtDireccion.Text = PacienteEntity.Direccion;
            cmbTipoDocumento.SelectedValue = PacienteEntity.TipoDocumento; 
            txtNumeroDocumento.Text = PacienteEntity.NumeroDocumento.ToString();
            txtCorreoElectronico.Text = PacienteEntity.CorreoElectronico;
            dtpFechaNacimiento.Value = PacienteEntity.FechaNacimiento.Value;
            if (PacienteEntity.Sexo==Constantes.Sexo.Masculino)
            {
                cmbSexo.SelectedValue=Enumeraciones.Sexo.M;
            }
            else
            {
                cmbSexo.SelectedValue=Enumeraciones.Sexo.F;
            }
            txtComentario.Text = PacienteEntity.Comentario;
            txtTelefono.Text = PacienteEntity.Telefono;
            txtCelular.Text = PacienteEntity.Celular.ToString();
            cmbCiudad.SelectedValue = PacienteEntity.IDCiudad;
            
        }

        /// <summary>
        /// Valida datos basicos antes de enviar la entidad
        /// </summary>
        /// <returns></returns>
        private Boolean ValidData()
        {
            if (txtNombre.Text == "" || txtNombre.Text == null)
            {
                ProcesarAdvertencia("Debe ingresar el Nombre del paciente");
                return false;
            }
            if (txtApellido.Text == "" || txtApellido.Text == null)
            {
                ProcesarAdvertencia("Debe ingresar el Apellido del paciente");
                return false;
            }
            if (txtNumeroDocumento.Text == "" || txtNumeroDocumento.Text == null)
            {
                ProcesarAdvertencia("Debe ingresar el Numero de Documento del paciente");
                return false;
            }
            return true;
        }
        #endregion

        #region "--[Events]--"
        private void frmPaciente_Load(object sender, EventArgs e)
        {
            _PacienteBP = new PacienteBusiness(DaoFactory.GetPacienteDao());
            LoadList();
            //cmbTipoDocumento.DataSource = Enum.GetValues(typeof(Enumeraciones.TipoDocumento));
        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            _PacienteEntities = _PacienteBP.GetAll();
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvList.DataSource = _PacienteEntities;
            ptbProgress.Visible = false;
            Habilitar(true);
        }

        public override void Accion()
        {
            try
            {
                pnlDetails.Visible = true;

                switch (Estado)
                {
                    case EstadoForm.Nuevo:
                        txtID.Text = string.Empty;
                        txtID.Enabled = false;
                        txtNombre.Text = string.Empty;
                        txtApellido.Text = string.Empty;
                        txtDireccion.Text = string.Empty;
                        cmbTipoDocumento.SelectedValue = Enumeraciones.TipoDocumento.DNI;
                        txtNumeroDocumento.Text = string.Empty;
                        txtCorreoElectronico.Text = string.Empty;
                        dtpFechaNacimiento.Value = DateTime.Now;
                        cmbSexo.SelectedValue = Enumeraciones.Sexo.M;
                        txtComentario.Text = string.Empty;
                        txtTelefono.Text = string.Empty;
                        txtCelular.Text = string.Empty;
                        cmbCiudad.SelectedValue = 1;
                        txtNombre.Focus();
                        PacienteEntity = new Paciente();
                        break;

                    case EstadoForm.Editar:
                        if (dgvList.Rows.Count > 0)
                        {
                            txtID.Enabled = false;
                            LoadData();
                            txtNombre.Focus();
                        }

                        break;

                    case EstadoForm.Eliminar:
                        if (dgvList.Rows.Count > 0)
                        {
                            txtID.Enabled = false;
                            LoadData();
                        }

                        break;
                }
            }

            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
        #endregion





    }
}
