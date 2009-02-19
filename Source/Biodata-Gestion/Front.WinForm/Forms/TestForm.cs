using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medusa.Biodata.Service;
using System.Collections;
using Medusa.Biodata.Domain;
using Medusa.Biodata.Utils;
using Medusa.Biodata.FrontEnd.DTO;
using Medusa.Biodata.FrontEnd.Assembler;
using System.Reflection;
using System.Threading;
using Medusa.Biodata.FrontEnd.UserControls;

namespace Medusa.Biodata.FrontEnd.Forms
{
    public partial class TestForm : TestBaseForm
    {
        private PacienteService _pacienteService;
        private ObraSocialService _obraSocialService;
        private PacienteAssembler _pacienteAssembler = new PacienteAssembler();
        private IList<Paciente> _pacientes;
        private IList _pacienteDTOList;
        private Paciente _paciente;
        private PacienteDTO _pacienteDTO;

        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            gridMain.AutoGenerateColumns = false;
            //Seteo estado del form al inicio
            Estado = EstadoForm.GRILLA;
            //Crear servicios de negocio
            _pacienteService = new PacienteService(base.DaoFactory.GetPacienteDao());
            _obraSocialService = new ObraSocialService(base.DaoFactory.GetObraSocialDao());
            //Cargar combo Obra Social
            cmbObraSocial.DataSource = _obraSocialService.GetAll();
            cmbObraSocial.ValueMember = "ID";
            cmbObraSocial.DisplayMember = "RazonSocial";
            //Cargar grilla asincronicamente
            backgroundWorker.RunWorkerAsync(Operacion.CARGAR_GRILLA);
            //medusaStatusBar.Loading = false;
            this.ModoEstatico();


            //TEST SEARCH CONTROL
            SearchItem item1 = new SearchItem();
            item1.DisplayMember = "Nombre";
            item1.ValueMember = "Nombre";
            SearchItem item2 = new SearchItem();
            item2.DisplayMember = "Apellido";
            item2.ValueMember = "Apellido";
            IList<SearchItem> listItems = new List<SearchItem>();
            listItems.Add(item1);
            listItems.Add(item2);

            searchControl1.Campos = listItems;
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Operacion operacion =  (Operacion)Enum.Parse(typeof(Operacion), e.Argument.ToString());

            try
            {
                //Borrar
                Thread.Sleep(3000);

                switch (operacion)
                {
                    case Operacion.CARGAR_GRILLA:
                        _pacienteDTOList = _pacienteAssembler.CreateDTOArrayList(_pacienteService.GetAll());
                        break;
                    case Operacion.INSERTAR:
                        _paciente = _pacienteAssembler.CreateDomainObject(_pacienteDTO);
                        _pacienteService.Insert(_paciente);
                        break;
                    case Operacion.ELIMINAR:
                        //nada
                        break;
                    case Operacion.ACTUALIZAR:                        
                        _paciente = _pacienteAssembler.CreateDomainObject(_pacienteDTO);
                        _pacienteService.Update(_paciente);
                        break;
                    default:
                        //nada;
                        break;
                }
                //Setear operacion para el RunWorkerCompleted
                e.Result = operacion;
            }
            catch (Exception ex)
            {
                
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Operacion operacion = (Operacion)Enum.Parse(typeof(Operacion), e.Result.ToString());
            medusaStatusBar.Loading = false;

            switch (operacion)
            {
                case Operacion.CARGAR_GRILLA:
                    this.MainTable = BindingHelper.GetDataTable(_pacienteDTOList, typeof(PacienteDTO));
                    this.MainBindingSource.DataSource = this.MainTable;
                    bindingNavigator.BindingSource = this.MainBindingSource;
                    gridMain.DataSource = this.MainBindingSource;
                    medusaStatusBar.Information = "La grilla se ha actualizado correctamente";
                    break;
                case Operacion.INSERTAR:
                    this.ModoEstatico();
                    //this.RefrescarGrilla();
                    medusaStatusBar.Information = "El paciente se ha insertado correctamente";
                    break;
                case Operacion.ELIMINAR:
                    this.ModoEstatico();
                    //this.RefrescarGrilla();
                    medusaStatusBar.Information = "El paciente se ha eliminado correctamente";
                    break;
                case Operacion.ACTUALIZAR:
                    this.ModoEstatico();
                    //this.RefrescarGrilla();
                    medusaStatusBar.Information = "El paciente se ha actualizado correctamente";
                    break;
            }
        }

        private void abmControl_ClickSelect(object sender, EventArgs e)
        {
            DataRow selectedRow = ((DataRowView)this.MainBindingSource.Current).Row;
            int selectedId = (int)selectedRow["ID"];

            _pacienteDTO = _pacienteAssembler.CreateDTO(_pacienteService.GetById(selectedId));

            this.MostrarEntidad();
        }

        protected override void MostrarEntidad()
        {
            base.MostrarEntidad();

            txtId.Text = _pacienteDTO.ID.ToString();
            txtNombre.Text = _pacienteDTO.Nombre;
            txtApellido.Text = _pacienteDTO.Apellido;
            txtDocumento.Text = _pacienteDTO.NumDocumento;
            txtDireccion.Text = _pacienteDTO.Direccion;
            txtComentario.Text = _pacienteDTO.Comentario;
            cmbObraSocial.SelectedValue = _pacienteDTO.ObraSocialId;
            cmbSexo.SelectedItem = _pacienteDTO.Sexo; 
        }

        protected override void ModoEstatico()
        {
            base.ModoEstatico();

            txtNombre.ReadOnly = true;
            txtApellido.ReadOnly = true;
            txtDocumento.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtComentario.ReadOnly = true;
            cmbObraSocial.Enabled = false;
            cmbSexo.Enabled = false;
        }

        protected override void ModoEditable()
        {
            base.ModoEditable();

            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtDocumento.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtComentario.ReadOnly = false;
            cmbObraSocial.Enabled = true;
            cmbSexo.Enabled = true;
        }

        protected override void LimpiarFormulario()
        {
            base.LimpiarFormulario();
            txtNombre.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtDocumento.Text = String.Empty;
            txtDireccion.Text = String.Empty;
            txtComentario.Text = String.Empty;
        }

        protected override void GrabarEntidad()
        {
            base.GrabarEntidad();
            _pacienteDTO = new PacienteDTO();
            if(txtId.Text != String.Empty)
                _pacienteDTO.ID = Convert.ToInt32(txtId.Text);
            _pacienteDTO.Nombre = txtNombre.Text;
            _pacienteDTO.Apellido = txtApellido.Text;
            _pacienteDTO.NumDocumento = txtDocumento.Text;
            _pacienteDTO.Direccion = txtDireccion.Text;
            _pacienteDTO.Comentario = txtComentario.Text;
            if(cmbObraSocial.SelectedValue!=null)
                _pacienteDTO.ObraSocialId = (int)cmbObraSocial.SelectedValue;
            if(cmbSexo.SelectedItem!=null)
                _pacienteDTO.Sexo = cmbSexo.SelectedItem.ToString();
        }

        private void abmControl_ClickEdit(object sender, EventArgs e)
        {
            this.ModoEditable();
            this.Estado = EstadoForm.EDITAR;
        }

        private void abmControl_ClickNew(object sender, EventArgs e)
        {
            this.ModoEditable();
            this.LimpiarFormulario();
            this.Estado = EstadoForm.NUEVO;
        }

        private void abmControl_ClickDelete(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que quiere eliminar el Paciente", "Biodata", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.GrabarEntidad();
                this.Estado = EstadoForm.ELIMINAR;
                _paciente = _pacienteService.GetById(_pacienteDTO.ID);
                _pacienteService.Delete(_paciente);
                this.RefrescarGrilla();
            }        
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (this.Estado)
            {
                case EstadoForm.NUEVO:
                    if (!backgroundWorker.IsBusy)
                    {
                        medusaStatusBar.Loading = true;
                        this.GrabarEntidad();
                        backgroundWorker.RunWorkerAsync(Operacion.INSERTAR);
                    }
                    break;
                case EstadoForm.EDITAR:
                    if (!backgroundWorker.IsBusy)
                    {
                        medusaStatusBar.Loading = true;
                        this.GrabarEntidad();
                        backgroundWorker.RunWorkerAsync(Operacion.ACTUALIZAR);
                    }
                    break;   
                default:
                    //nada
                    break;
            }
        }

        protected override void btnRefrescar_Click(object sender, EventArgs e)
        {
            base.btnRefrescar_Click(sender, e);
            this.RefrescarGrilla();     
        }

        protected override void RefrescarGrilla()
        {
            base.RefrescarGrilla();
            //Cargar grilla asincronicamente si no esta ocupado
            if (!backgroundWorker.IsBusy)
            {
                medusaStatusBar.Loading = true;
                backgroundWorker.RunWorkerAsync(Operacion.CARGAR_GRILLA);
            }
        }

        private void gridMain_Click(object sender, EventArgs e)
        {
            DataRow selectedRow = ((DataRowView)this.MainBindingSource.Current).Row;
            int selectedId = (int)selectedRow["ID"];

            _pacienteDTO = _pacienteAssembler.CreateDTO(_pacienteService.GetById(selectedId));

            this.MostrarEntidad();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.ModoEstatico();
        }

        private void searchControl1_ClickSearch(object sender, SearchArgs e)
        {
            //MessageBox.Show("Hola!!!");

            //Para probar Filtro -- HACER BIEN!!!
            _pacienteDTOList = _pacienteAssembler.CreateDTOArrayList(_pacienteService.FiltrarPorApellido(e.ItemSeleccionado.Valor));
            this.MainTable = BindingHelper.GetDataTable(_pacienteDTOList, typeof(PacienteDTO));
            this.MainBindingSource.DataSource = this.MainTable;
            bindingNavigator.BindingSource = this.MainBindingSource;
            gridMain.DataSource = this.MainBindingSource;
        }
       
    }
}
