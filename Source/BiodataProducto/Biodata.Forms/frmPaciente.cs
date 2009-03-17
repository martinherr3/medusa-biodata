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
using ObjectViews;
using System.Collections;
using Mds.Architecture.HelpersFunctions.Validators;

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

        private ObjectView _PacienteObjectView;

        public ObjectView PacienteObjectView
        {
            get { return _PacienteObjectView; }
            set { _PacienteObjectView = value; }
        }
        private BindingManagerBase _PacienteCurrencyManager;

        public BindingManagerBase PacienteCurrencyManager
        {
            get { return _PacienteCurrencyManager; }
            set { _PacienteCurrencyManager = value; }
        }


        //private Mds.Architecture.HelpersFunctions.Validators.Winforms.Validation.ViewValidator vvtor;
        
        #endregion

        #region "--[Methods]--"
        public frmPaciente()
        {
            InitializeComponent();

            ////Setup Validation Validation
            //vvtor = new Mds.Architecture.HelpersFunctions.Validators.Winforms.Validation.ViewValidator(errorProvider1);
            ////First Name
            //vvtor.Bind(txtNombre, typeof(Paciente), "Nombre");
            //txtNombre.Validating += new Mds.Architecture.HelpersFunctions.Validators.Winforms.Validation.EventValidation(vvtor).ValidatingHandler;
            ////Last Name
            //vvtor.Bind(txtApellido, typeof(Paciente), "Apellido");
            //txtApellido.Validating += new Mds.Architecture.HelpersFunctions.Validators.Winforms.Validation.EventValidation(vvtor).ValidatingHandler;
            ////Email 
            //vvtor.Bind(tEmail, typeof(Paciente), "Email");
            //tEmail.Validating += new EventValidation(vvtor).ValidatingHandler;
            ////Street
            //vvtor.Bind(tStreet, typeof(Paciente), "Street");
            //tStreet.Validating += new EventValidation(vvtor).ValidatingHandler;
            ////Street Number
            //vvtor.Bind(tNumber, typeof(Paciente), "Number");
            //tNumber.Validating += new EventValidation(vvtor).ValidatingHandler;

        }

        /// <summary>
        /// Da formato a la grilla
        /// </summary>
        //private void BuildColumns()
        //{
        //    try
        //    {
        //        dgvList.AutoGenerateColumns = false;
        //        dgvList.Columns.Clear();
        //        dgvList.Columns.Add("Nombre", "Nombre");
        //        dgvList.Columns[0].DataPropertyName = "Nombre";
        //        dgvList.Columns.Add("Apellido", "Apellido");
        //        dgvList.Columns[1].DataPropertyName = "Apellido";
        //        dgvList.Columns.Add("Direccion", "Direccion");
        //        dgvList.Columns[2].DataPropertyName = "Direccion";
        //        dgvList.Columns.Add("Telefono", "Telefono");
        //        dgvList.Columns[3].DataPropertyName = "Telefono";
        //        dgvList.Columns.Add("Celular", "Celular");
        //        dgvList.Columns[4].DataPropertyName = "Celular";
        //        dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    }

        //    catch (Exception ex)
        //    {
        //        ProcesarExcepcion(ex);
        //    }
        //}
        private void InitializeObjectView()
        {
            this.PacienteObjectView = new ObjectView(typeof(Paciente));
            this.PacienteObjectView.AllowRemove = false;
            this.PacienteObjectView.Columns.Add("Nombre", "Nombre");
            this.PacienteObjectView.Columns.Add("Apellido", "Apellido");
            this.PacienteObjectView.Columns.Add("Direccion", "Direccion");
            this.PacienteObjectView.Columns.Add("Telefono", "Telefono");
            this.PacienteObjectView.Columns.Add("Celular", "Celular");
            this.PacienteCurrencyManager = this.dgvList.BindingContext[this.PacienteObjectView];
        }

        /// <summary>
        /// Carga la grilla con los registros de la DB
        /// </summary>
        private void LoadList()
        {
            try
            {
                ptbProgress.Visible = true;
                //BuildColumns();
                InitializeObjectView();
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
            ObjectViews.ObjectViewRow RowSelected = (ObjectViewRow)dgvList.CurrentRow.DataBoundItem;
            PacienteEntity = PacienteBP.GetById(((Paciente)RowSelected.InnerObject).ID);

            txtID.Text = PacienteEntity.ID.ToString();
            txtNombre.Text = PacienteEntity.Nombre;
            txtApellido.Text = PacienteEntity.Apellido;
            txtDireccion.Text = PacienteEntity.Direccion;
            cmbTipoDocumento.SelectedItem = (Enumeraciones.TipoDocumento)PacienteEntity.TipoDocumento;
            txtNumeroDocumento.Text = PacienteEntity.NumeroDocumento.ToString();
            txtCorreoElectronico.Text = PacienteEntity.CorreoElectronico;
            dtpFechaNacimiento.Value = PacienteEntity.FechaNacimiento.Value;
            if (PacienteEntity.Sexo == Constantes.Sexo.Masculino)
            {
                cmbSexo.SelectedItem = Enumeraciones.Sexo.M;
            }
            else
            {
                cmbSexo.SelectedItem = Enumeraciones.Sexo.F;
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

        /// <summary>
        /// Carga los combos de Tipo de Documento, Sexo y Ciudad
        /// </summary>
        private void LoadCombos()
        {
            //Tipo de Documento
            cmbTipoDocumento.DataSource = Enum.GetValues(typeof(Enumeraciones.TipoDocumento));
            //Sexo
            cmbSexo.DataSource = Enum.GetValues(typeof(Enumeraciones.Sexo));
            //Ciudad
            CiudadBusiness CiudadBP = new CiudadBusiness(DaoFactory.GetCiudadDao());
            List<Ciudad> wCiudadEntities = CiudadBP.GetAll();
            cmbCiudad.DataSource = wCiudadEntities;

            cmbCiudad.ValueMember = "ID";
            cmbCiudad.DisplayMember = "Descripcion";

        }
        #endregion

        #region "--[Events]--"
        private void frmPaciente_Load(object sender, EventArgs e)
        {
            _PacienteBP = new PacienteBusiness(DaoFactory.GetPacienteDao());
            LoadCombos();
            LoadList();
        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            _PacienteEntities = _PacienteBP.GetAll();
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //dgvList.DataSource = _PacienteEntities;
            this.PacienteObjectView.DataSource = (IList)this._PacienteEntities;
            this.dgvList.DataSource = this.PacienteObjectView;
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
                        cmbTipoDocumento.SelectedItem = Enumeraciones.TipoDocumento.DNI;
                        txtNumeroDocumento.Text = string.Empty;
                        txtCorreoElectronico.Text = string.Empty;
                        dtpFechaNacimiento.Value = DateTime.Now;
                        cmbSexo.SelectedItem = Enumeraciones.Sexo.M;
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData())
                {
                    PacienteEntity.Nombre = txtNombre.Text;
                    PacienteEntity.Apellido = txtApellido.Text;
                    PacienteEntity.Direccion = txtDireccion.Text;
                    PacienteEntity.TipoDocumento = (Int32)cmbTipoDocumento.SelectedItem;
                    PacienteEntity.NumeroDocumento = Convert.ToDecimal(txtNumeroDocumento.Text);
                    PacienteEntity.CorreoElectronico = txtCorreoElectronico.Text;
                    PacienteEntity.FechaNacimiento = dtpFechaNacimiento.Value;
                    if ((Enumeraciones.Sexo)cmbSexo.SelectedItem == Enumeraciones.Sexo.M)
                    {
                        PacienteEntity.Sexo = Constantes.Sexo.Masculino;
                    }
                    else
                    {
                        PacienteEntity.Sexo = Constantes.Sexo.Femenino;
                    }
                    PacienteEntity.Comentario = txtComentario.Text;
                    PacienteEntity.Telefono = txtTelefono.Text;
                    PacienteEntity.Celular = txtCelular.Text;
                    PacienteEntity.IDCiudad = (Int32)cmbCiudad.SelectedValue;

                    switch (Estado)
                    {
                        case EstadoForm.Editar:
                            PacienteBP.Update(PacienteEntity);
                            PacienteBP.Commit();
                            break;
                        case EstadoForm.Eliminar:
                            PacienteBP.Delete(PacienteEntity);
                            PacienteBP.Commit();
                            break;
                        case EstadoForm.Nuevo:
                            PacienteBP.Insert(PacienteEntity);
                            break;
                    }
                    pnlDetails.Visible = false;
                    CambiarTamaño(true);
                    Estado = EstadoForm.Grilla;
                    LoadList();
                }
            }

            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

    }
}
