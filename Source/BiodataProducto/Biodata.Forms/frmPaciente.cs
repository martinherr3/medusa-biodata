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
//using Mds.Architecture.HelpersFunctions.Validators;

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

        private Enumeraciones.SeleccionDestino _SeleccionLlamada;

        public Enumeraciones.SeleccionDestino SeleccionLlamada
        {
            get { return _SeleccionLlamada; }
            set { _SeleccionLlamada = value; }
        }

        private Boolean _EnfocarReporte;

        public Boolean EnfocarReporte
        {
            get { return _EnfocarReporte; }
            set { _EnfocarReporte = value; }
        }

        //Propiedades para la gestion de AudifonoPaciente (Relacion del paciente con N audifonos-moldes)
        private EstadoForm _EstadoAccionAudifono = EstadoForm.Nuevo;
        public EstadoForm EstadoAccionAudifono
        {
            get { return _EstadoAccionAudifono; }
            set { _EstadoAccionAudifono = value; }
        }

        private AudifonoPaciente _AudifonoPacienteEntity;

        public AudifonoPaciente AudifonoPacienteEntity
        {
            get { return _AudifonoPacienteEntity; }
            set { _AudifonoPacienteEntity = value; }
        }
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

        public frmPaciente(Boolean pEnfocarReporte)
        {
            InitializeComponent();

            EnfocarReporte = pEnfocarReporte;
        }

        /// <summary>
        /// Da formato a la grilla y crea lo necesario para el bindeo
        /// </summary>
        private void InitializeObjectView()
        {
            this.PacienteObjectView = new ObjectView(typeof(Paciente));
            this.PacienteObjectView.AllowRemove = false;
            this.PacienteObjectView.Columns.Add("ID", "ID");
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
        private void LoadList(Boolean ContarParametrosBusqueda)
        {
            try
            {
                ptbProgress.Visible = true;
                //BuildColumns();
                InitializeObjectView();
                dgvList.DataSource = null;
                Habilitar(false);
                btnClose.Enabled = true;
                bgwLoad.RunWorkerAsync(ContarParametrosBusqueda);
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
            txtCiudad.Tag = PacienteEntity.IDCiudad;
            txtCiudad.Text = PacienteEntity.IDCiudadLookup.Descripcion;
            //Cargar los datos de la historia clinica, El paciente tiene una historia clinica y cada historia clinica pertenece solo a un paciente
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            dtpInicioAtencion.Value = PacienteEntity.HistoriaClinicas[0].FechaInicioAtencion;
            txtObservaciones.Text = PacienteEntity.HistoriaClinicas[0].Observaciones;
            txtAntecedentesHereditarios.Text = PacienteEntity.HistoriaClinicas[0].AntecedentesHereditarios;
            txtAntecedentesPersonales.Text = PacienteEntity.HistoriaClinicas[0].AntecedentesPersonales;
            txtEstadoSalud.Text = PacienteEntity.HistoriaClinicas[0].EstadoSalud;
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Carga las obras sociales del Paciente
            LoadObrasSociales();
            //Carga los audifonos con sus moldes respectivos del Paciente
            LoadAudifonoMolde();

        }

        /// <summary>
        /// Carga las obras sociales del paciente en cuestión
        /// </summary>
        private void LoadObrasSociales()
        {
            try
            {
                //Construimos la vista para la grilla
                ObjectView ObrasSocialesObjectView = new ObjectView(typeof(ObraSocialXPaciente));
                ObrasSocialesObjectView.AllowRemove = false;
                ObrasSocialesObjectView.Columns.Add("IDObraSocialLookup.RazonSocial", "Obra Social");
                ObrasSocialesObjectView.Columns.Add("NumeroAfiliado", "Numero de Afiliado");
                BindingManagerBase ObrasSocialesManager = dgvObrasSociales.BindingContext[ObrasSocialesObjectView];
                ObrasSocialesObjectView.DataSource = (IList)this.PacienteEntity.ObraSocialXPacientes;
                dgvObrasSociales.DataSource = ObrasSocialesObjectView;
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }


        /// <summary>
        /// Carga Los audifonos y molde del paciente en cuestión
        /// </summary>
        private void LoadAudifonoMolde()
        {
            try
            {
                //Construimos la vista para la grilla
                ObjectView AudifonoMoldeObjectView = new ObjectView(typeof(AudifonoPaciente));
                AudifonoMoldeObjectView.AllowRemove = false;
                AudifonoMoldeObjectView.Columns.Add("IDAudifonoLookup.NombreModelo", "Audifono");
                AudifonoMoldeObjectView.Columns.Add("IDMoldeLookup.Nombre", "Molde");
                AudifonoMoldeObjectView.Columns.Add("NroSerie", "NroSerie");
                BindingManagerBase AudifonoMoldeManager = dgvAudifonosMoldes.BindingContext[AudifonoMoldeObjectView];
                AudifonoMoldeObjectView.DataSource = (IList)this.PacienteEntity.AudifonoPacientes;
                dgvAudifonosMoldes.DataSource = AudifonoMoldeObjectView;
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
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
            if (txtTelefono.Text == "" || txtTelefono.Text == null)
            {
                ProcesarAdvertencia("Debe ingresar el telefono del paciente");
                return false;
            }
            
            //if (txtNumeroDocumento.Text == "" || txtNumeroDocumento.Text == null)
            //{
            //    ProcesarAdvertencia("Debe ingresar el Numero de Documento del paciente");
            //    return false;
            //}
            //if (txtCiudad.Text == "" || txtCiudad.Text == null)
            //{
            //    ProcesarAdvertencia("Debe seleccionar una ciudad para el paciente");
            //    return false;
            //}
            return true;
        }

        /// <summary>
        /// Carga los combos de Tipo de Documento, Sexo y Lado Oido
        /// </summary>
        private void LoadCombos()
        {
            try
            {
                //Tipo de Documento
                cmbTipoDocumento.DataSource = Enum.GetValues(typeof(Enumeraciones.TipoDocumento));
                //Sexo
                cmbSexo.DataSource = Enum.GetValues(typeof(Enumeraciones.Sexo));
                //Lado Oido
                cmbLadoOido.DataSource = Enum.GetValues(typeof(Enumeraciones.LadoOido));
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        /// <summary>
        /// Elimina el registro del paciente para con esa obra social, solo elimina la vinculación, no la obra social en si
        /// </summary>
        private void EliminarObraSocial()
        {
            try
            {
                if (ProcesarMensaje("¿Esta seguro que desea eliminar la Obra Social para este Paciente?", "Eliminación Obra Social", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ObjectViewRow wObraSocialXPacienteRow = (ObjectViewRow)dgvObrasSociales.CurrentRow.DataBoundItem;
                    ObraSocialXPaciente wObraSocialXPaciente = (ObraSocialXPaciente)wObraSocialXPacienteRow.InnerObject;

                    PacienteEntity.ObraSocialXPacientes.Remove(wObraSocialXPaciente);
                    LoadObrasSociales();
                }
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        /// <summary>
        /// Agrega una nueva vinculacion a una obra social pidiendo su numero de afiliado
        /// </summary>
        private void AgregarObraSocial()
        {
            try
            {
                this.SeleccionLlamada = Enumeraciones.SeleccionDestino.ObraSocialSeleccion;
                frmObraSocial frm = new frmObraSocial();
                frm.Llamador = this;
                this.Parent.Enabled = false;
                GereralFunctions.AbrirFormulario(frm, (TabControl)this.Parent.Parent, "Seleccionar Obra Social", DockStyle.Fill, false, true);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        /// <summary>
        /// Carga los combos de Tipo de Documento y Sexo para busqueda
        /// </summary>
        private void LoadCombosBusqueda()
        {
            try
            {
                Array miSexo = Enum.GetValues(typeof(Enumeraciones.Sexo));

                cmbSexoBuscar.Items.Add("--Sel--");

                for (Int32 i = 0; i < miSexo.Length; i++)
                {
                    cmbSexoBuscar.Items.Add(miSexo.GetValue(i));
                }

                cmbSexoBuscar.SelectedIndex = 0;

                CiudadBusiness CiudadBP = new CiudadBusiness(DaoFactory.GetCiudadDao());
                List<Ciudad> wCiudadEntitiesBuscar = CiudadBP.GetAll();
                //cmbCiudadBuscar.DataSource = wCiudadEntitiesBuscar;
                cmbCiudadBuscar.ValueMember = "ID";
                cmbCiudadBuscar.DisplayMember = "Descripcion";

                for (Int32 i = wCiudadEntitiesBuscar.Count - 1; i > -1; i--)
                {
                    cmbCiudadBuscar.Items.Insert(0, wCiudadEntitiesBuscar[i]);
                }

                cmbCiudadBuscar.Items.Insert(0, "--Sel--");

                cmbCiudadBuscar.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
        #endregion

        #region "--[Events]--"
        private void frmPaciente_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            _PacienteBP = new PacienteBusiness(DaoFactory.GetPacienteDao());
            LoadCombos();
            LoadCombosBusqueda();
            LoadList(false);
            
            if (EnfocarReporte)
            {
                buttonUC1.Focus();
            }
        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!Convert.ToBoolean(e.Argument))
            {
                _PacienteEntities = _PacienteBP.GetAll();
            }
            else
            {
                Decimal? ValorNumeroDocumento = null;

                if (txtDocumentoBuscar.Text != "")
                {
                    if (GereralFunctions.ValidarNumero(txtDocumentoBuscar.Text))
                    {
                        ValorNumeroDocumento = Convert.ToDecimal(txtDocumentoBuscar.Text);
                    }
                    else
                    {
                        ProcesarAdvertencia(Translate("El documento debe ser númerico"), "Dato no valido");
                        return;
                    }
                }

                Int32? ValorCiudad = null;

                if (cmbCiudadBuscar.SelectedIndex != 0)
                {
                    Ciudad oCiudad = (Ciudad)cmbCiudadBuscar.SelectedItem;
                    ValorCiudad = oCiudad.ID;
                }


                String strSexo = "";
                if (cmbSexoBuscar.SelectedIndex != 0)
                {
                    strSexo = cmbSexoBuscar.SelectedItem.ToString();
                }
                _PacienteEntities = _PacienteBP.GetPacientesByParameters(txtNombreBuscar.Text, txtApellidoBuscar.Text, ValorNumeroDocumento, strSexo, ValorCiudad);
            }
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


                //Limpieza de los controles y grilla de AudifonoPaciente sin importar la accion
                /////////////////////////////////////////////////////////////////
                LimpiarControlesAudifono();
                dgvAudifonosMoldes.DataSource = null;
                /////////////////////////////////////////////////////////////////
                //Posicionar sobre la primer solapa sin importar la accion
                tbcDatos.SelectedTab = tbpDatosPaciente;
                /////////////////////////////////////////////////////////////////

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
                        txtCiudad.Tag = string.Empty;
                        txtCiudad.Text = string.Empty;
                        //Limpieza de los controles de Historia Clinica
                        /////////////////////////////////////////////////////////////////
                        dtpInicioAtencion.Value = DateTime.Now;
                        txtObservaciones.Text = string.Empty;
                        txtAntecedentesHereditarios.Text = string.Empty;
                        txtAntecedentesPersonales.Text = string.Empty;
                        txtEstadoSalud.Text = string.Empty;
                        /////////////////////////////////////////////////////////////////
                        //Limpieza de la grilla de obras sociales
                        /////////////////////////////////////////////////////////////////
                        dgvObrasSociales.DataSource = null;
                        /////////////////////////////////////////////////////////////////
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

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData())
                {
                    PacienteEntity.Nombre = txtNombre.Text;
                    PacienteEntity.Apellido = txtApellido.Text;
                    PacienteEntity.Direccion = txtDireccion.Text;
                    PacienteEntity.TipoDocumento = Convert.ToInt32(cmbTipoDocumento.SelectedItem);
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
                    //PacienteEntity.IDCiudad = (Int32)cmbCiudad.SelectedValue;
                    PacienteEntity.IDCiudad = (Int32)txtCiudad.Tag;

                    switch (Estado)
                    {
                        case EstadoForm.Editar:
                            PacienteEntity.HistoriaClinicas[0].FechaInicioAtencion = dtpInicioAtencion.Value;
                            PacienteEntity.HistoriaClinicas[0].Observaciones = txtObservaciones.Text;
                            PacienteEntity.HistoriaClinicas[0].AntecedentesHereditarios = txtAntecedentesHereditarios.Text;
                            PacienteEntity.HistoriaClinicas[0].AntecedentesPersonales = txtAntecedentesPersonales.Text;
                            PacienteEntity.HistoriaClinicas[0].EstadoSalud = txtEstadoSalud.Text;
                            PacienteBP.Update(PacienteEntity);
                            PacienteBP.Commit();

                            //ObraSocialXPacienteBusiness wObraSocialXPacienteBP = new ObraSocialXPacienteBusiness(DaoFactory.GetObraSocialXPacienteDao());
                            ////Borramos las anteriores
                            //ObraSocialXPaciente wObraSocialesABorrar = new ObraSocialXPaciente();
                            //wObraSocialesABorrar.IDPacienteLookup = PacienteEntity;
                            //wObraSocialesABorrar.IDPaciente = PacienteEntity.ID;
                            //wObraSocialXPacienteBP.Delete(wObraSocialesABorrar);
                            //wObraSocialXPacienteBP.Commit();
                            ////Agregamos las nuevas
                            //foreach (ObraSocialXPaciente wObraSocialXPaciente in PacienteEntity.ObraSocialXPacientes)
                            //{
                            //    wObraSocialXPaciente.IDPaciente = PacienteEntity.ID;
                            //    wObraSocialXPacienteBP.Insert(wObraSocialXPaciente);
                            //}
                            break;
                        case EstadoForm.Eliminar:
                            PacienteBP.Delete(PacienteEntity);
                            PacienteBP.Commit();
                            ////Borra la Historia clinica
                            //HistoriaClinicaBusiness HistoriaClinicaBP = new HistoriaClinicaBusiness(DaoFactory.GetHistoriaClinicaDao());
                            //HistoriaClinica wHistoria = new HistoriaClinica();
                            //wHistoria.ID = PacienteEntity.HistoriaClinicas[0].ID;
                            //HistoriaClinicaBP.Delete(wHistoria);
                            //HistoriaClinicaBP.Commit();
                            ////Borramos las Obras Sociales
                            //ObraSocialXPaciente wObraSocialesABorrar2 = new ObraSocialXPaciente();
                            //wObraSocialesABorrar2.IDPacienteLookup = PacienteEntity;
                            //wObraSocialesABorrar2.IDPaciente = PacienteEntity.ID;
                            //ObraSocialXPacienteBusiness wObraSocialXPacienteBP2 = new ObraSocialXPacienteBusiness(DaoFactory.GetObraSocialXPacienteDao());
                            //wObraSocialXPacienteBP2.Delete(wObraSocialesABorrar2);
                            //wObraSocialXPacienteBP2.Commit();
                            break;
                        case EstadoForm.Nuevo:

                            HistoriaClinica wHistoriaNuevo = new HistoriaClinica();
                            wHistoriaNuevo.FechaInicioAtencion = dtpInicioAtencion.Value;
                            wHistoriaNuevo.Observaciones = txtObservaciones.Text;
                            wHistoriaNuevo.AntecedentesHereditarios = txtAntecedentesHereditarios.Text;
                            wHistoriaNuevo.AntecedentesPersonales = txtAntecedentesPersonales.Text;
                            wHistoriaNuevo.EstadoSalud = txtEstadoSalud.Text;
                            wHistoriaNuevo.IDPacienteLookup = PacienteEntity;
                            PacienteEntity.HistoriaClinicas.Add(wHistoriaNuevo);
                            PacienteBP.Insert(PacienteEntity);
                            break;
                    }
                    pnlDetails.Visible = false;
                    CambiarTamaño(true);
                    Estado = EstadoForm.Grilla;
                    LoadList(false);
                }
            }

            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void btnSeleccionarCiudad_Click(object sender, EventArgs e)
        {
            SeleccionarCiudad();
        }

        private void SeleccionarCiudad()
        {
            try
            {
                txtCiudad.Tag = string.Empty;
                txtCiudad.Text = string.Empty;

                this.SeleccionLlamada = Enumeraciones.SeleccionDestino.CiudadSeleccion;
                frmCiudad frm = new frmCiudad();
                frm.Llamador = this;
                this.Parent.Enabled = false;
                GereralFunctions.AbrirFormulario(frm, (TabControl)this.Parent.Parent, "Ciudades", DockStyle.Fill, false, true);

            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }


        private void frmPacienteSelecciones_SeleccionCompleja(bool pCerrar)
        {
            if (pCerrar)
            {
                if ((this.Seleccion != null))
                {
                    switch (this.SeleccionLlamada)
                    {
                        case Enumeraciones.SeleccionDestino.CiudadSeleccion:
                            if (((Ciudad)this.Seleccion).ID != null || ((Ciudad)this.Seleccion).ID > 0)
                            {
                                txtCiudad.Tag = ((Ciudad)this.Seleccion).ID;
                                txtCiudad.Text = ((Ciudad)this.Seleccion).Descripcion;
                                PacienteEntity.IDCiudadLookup = (Ciudad)this.Seleccion;
                            }
                            else
                            {
                                txtCiudad.Tag = string.Empty;
                                txtCiudad.Text = string.Empty;
                            }
                            break;
                        case Enumeraciones.SeleccionDestino.ObraSocialSeleccion:
                            if (((ObraSocial)this.Seleccion).ID != null || ((ObraSocial)this.Seleccion).ID > 0)
                            {
                                ObraSocialXPaciente wObraSocialXPaciente = new ObraSocialXPaciente();

                                wObraSocialXPaciente.IDObraSocialLookup = (ObraSocial)this.Seleccion;
                                wObraSocialXPaciente.IDPacienteLookup = PacienteEntity;
                                wObraSocialXPaciente.IDObraSocial = ((ObraSocial)this.Seleccion).ID;
                                wObraSocialXPaciente.IDPaciente = PacienteEntity.ID;
                                String Valor = Inputbox.Show("Ingrese el Número de Afiliado", "Afiliado", FormStartPosition.CenterScreen);
                                wObraSocialXPaciente.NumeroAfiliado = Valor;
                                PacienteEntity.ObraSocialXPacientes.Add(wObraSocialXPaciente);
                                LoadObrasSociales();
                            }
                            break;
                        case Enumeraciones.SeleccionDestino.AudifonosSeleccion:
                            if (((Audifono)this.Seleccion).ID != null || ((Audifono)this.Seleccion).ID > 0)
                            {
                                txtAudifono.Tag = ((Audifono)this.Seleccion).ID;
                                txtAudifono.Text = ((Audifono)this.Seleccion).NombreModelo;
                                //PacienteEntity.IDCiudadLookup = (Ciudad)this.Seleccion;
                            }
                            else
                            {
                                txtAudifono.Tag = string.Empty;
                                txtAudifono.Text = string.Empty;
                            }
                            break;
                        case Enumeraciones.SeleccionDestino.MoldeAudifonoSeleccion:
                            if (((MoldeAudifono)this.Seleccion).ID != null || ((MoldeAudifono)this.Seleccion).ID > 0)
                            {
                                txtMoldeAudifono.Tag = ((MoldeAudifono)this.Seleccion).ID;
                                txtMoldeAudifono.Text = ((MoldeAudifono)this.Seleccion).Nombre;
                                //PacienteEntity.IDCiudadLookup = (Ciudad)this.Seleccion;
                            }
                            else
                            {
                                txtMoldeAudifono.Tag = string.Empty;
                                txtMoldeAudifono.Text = string.Empty;
                            }
                            break;
                    }
                }
                this.Seleccion = null;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarObraSocial();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarObraSocial();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LoadList(true);
        }

        private void buttonUC1_Click(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count > 0)
            {
                Reportes.ReportePacienteDetalle frm = new Reportes.ReportePacienteDetalle();
                //frm.Llamador = this;
                //this.Parent.Enabled = false;
                ObjectViews.ObjectViewRow RowSelected = (ObjectViewRow)dgvList.CurrentRow.DataBoundItem;
                PacienteEntity = PacienteBP.GetById(((Paciente)RowSelected.InnerObject).ID);

                frm.PacienteParticular = PacienteEntity;
                GereralFunctions.AbrirFormulario(frm, (TabControl)this.Parent.Parent, "Reporte Detalle Paciente", DockStyle.Fill, false, true);
            }
        }
        #endregion

        private void btnSeleccionarAudifono_Click(object sender, EventArgs e)
        {
            SeleccionarAudifono();
        }

        private void SeleccionarAudifono()
        {
            try
            {
                txtAudifono.Tag = string.Empty;
                txtAudifono.Text = string.Empty;

                this.SeleccionLlamada = Enumeraciones.SeleccionDestino.AudifonosSeleccion;
                frmAudifonos frm = new frmAudifonos();
                frm.Llamador = this;
                this.Parent.Enabled = false;
                GereralFunctions.AbrirFormulario(frm, (TabControl)this.Parent.Parent, "Audifonos", DockStyle.Fill, false, true);

            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void btnSeleccionarMoldeAudifono_Click(object sender, EventArgs e)
        {
            SeleccionarMoldeAudifono();
        }

        private void SeleccionarMoldeAudifono()
        {
            try
            {
                txtMoldeAudifono.Tag = string.Empty;
                txtMoldeAudifono.Text = string.Empty;

                this.SeleccionLlamada = Enumeraciones.SeleccionDestino.MoldeAudifonoSeleccion;
                frmMoldeAudifono frm = new frmMoldeAudifono();
                frm.Llamador = this;
                this.Parent.Enabled = false;
                GereralFunctions.AbrirFormulario(frm, (TabControl)this.Parent.Parent, "Moldes de Audifono", DockStyle.Fill, false, true);

            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void btnNuevoAudifono_Click(object sender, EventArgs e)
        {
            EstadoAccionAudifono = EstadoForm.Nuevo;
            HabilitarControlesAudifono(true);
            btnSeleccionarAudifono.Focus();
            AudifonoPacienteEntity = new AudifonoPaciente();
            LimpiarControlesAudifono();
        }

        /// <summary>
        /// Habilita los botones para la gestion de audifonos
        /// </summary>
        /// <param name="pValor"></param>
        private void HabilitarControlesAudifono(Boolean pValor)
        {
            btnAceptarAudifono.Enabled = pValor;
            btnCancelarAudifono.Enabled = pValor;
            btnNuevoAudifono.Enabled = !pValor;
            btnModificarAudifono.Enabled = !pValor;
            btnEliminarAudifono.Enabled = !pValor;
            dgvAudifonosMoldes.Enabled = !pValor;
            //Botones Aceptar y Cancelar del ABM general
            btnAccept.Enabled = !pValor;
            btnCancel.Enabled = !pValor;
            //Habilitacion del contenedor de datos
            gpbDatosAudifono.Enabled = pValor;
        }

        /// <summary>
        /// Limpia los controles que se utilizan para la carga de audifono molde
        /// </summary>
        private void LimpiarControlesAudifono()
        {
            txtAudifono.Tag = string.Empty;
            txtAudifono.Text = string.Empty;
            txtMoldeAudifono.Tag = string.Empty;
            txtMoldeAudifono.Text = string.Empty;
            txtNroSerie.Text = string.Empty;
            cmbLadoOido.SelectedItem = Enumeraciones.LadoOido.Izquierdo;
            dtpFechaFabricacion.Value = DateTime.Now;
            dtpProximoService.Value = DateTime.Now;
            txtObservacionAudifono.Text = string.Empty;
            txtEstadoAudifono.Text = string.Empty;
        }

        private void btnAceptarAudifono_Click(object sender, EventArgs e)
        {
            CapturaDatosAudifono();
            switch (this.EstadoAccionAudifono)
            {
                case EstadoForm.Nuevo:
                    PacienteEntity.AudifonoPacientes.Add(AudifonoPacienteEntity);
                    break;
                case EstadoForm.Editar:

                    break;
                case EstadoForm.Eliminar:
                    PacienteEntity.AudifonoPacientes.Remove(AudifonoPacienteEntity);
                    break;
            }
            HabilitarControlesAudifono(false);
            LoadAudifonoMolde();
        }

        /// <summary>
        /// Captura los datos de ingresados en Audifono en una entidad del tipo AudifonoPaciente
        /// </summary>
        private void CapturaDatosAudifono()
        {
            AudifonoPacienteEntity.NroSerie = txtNroSerie.Text;
            AudifonoPacienteEntity.FechaFabricacion = dtpFechaFabricacion.Value;
            AudifonoPacienteEntity.ProximoService = dtpProximoService.Value;
            AudifonoPacienteEntity.Observacion = txtObservacionAudifono.Text;
            AudifonoPacienteEntity.Estado = txtEstadoAudifono.Text;
            AudifonoPacienteEntity.LadoOido = Convert.ToInt32(cmbLadoOido.SelectedItem);
            //AudifonoPacienteEntity.IDPaciente = PacienteEntity.ID;
            AudifonoPacienteEntity.IDPacienteLookup = PacienteEntity;
            Audifono wAudifono = new Audifono((Int32)txtAudifono.Tag);
            wAudifono.NombreModelo = txtAudifono.Text;
            MoldeAudifono wMolde = new MoldeAudifono((Int32)txtMoldeAudifono.Tag);
            wMolde.Nombre = txtMoldeAudifono.Text;
            AudifonoPacienteEntity.IDAudifono = wAudifono.ID;
            AudifonoPacienteEntity.IDAudifonoLookup = wAudifono;
            AudifonoPacienteEntity.IDMolde = wMolde.ID;
            AudifonoPacienteEntity.IDMoldeLookup = wMolde;
        }

        private void btnModificarAudifono_Click(object sender, EventArgs e)
        {
            EstadoAccionAudifono = EstadoForm.Editar;
            HabilitarControlesAudifono(true);
            btnSeleccionarAudifono.Focus();
            LoadDataAudifono();
        }

        /// <summary>
        /// Carga los datos del audifono y molde seleccionado para el paciente
        /// </summary>
        private void LoadDataAudifono()
        {
            ObjectViews.ObjectViewRow RowSelected = (ObjectViewRow)dgvAudifonosMoldes.CurrentRow.DataBoundItem;
            AudifonoPacienteEntity = (AudifonoPaciente)RowSelected.InnerObject;

            //txtID.Text = PacienteEntity.ID.ToString();
            txtAudifono.Tag = AudifonoPacienteEntity.IDAudifono;
            txtAudifono.Text = AudifonoPacienteEntity.IDAudifonoLookup.NombreModelo;
            txtMoldeAudifono.Tag = AudifonoPacienteEntity.IDMolde;
            txtMoldeAudifono.Text = AudifonoPacienteEntity.IDMoldeLookup.Nombre;
            txtNroSerie.Text = AudifonoPacienteEntity.NroSerie;
            cmbLadoOido.SelectedItem = (Enumeraciones.LadoOido)AudifonoPacienteEntity.LadoOido;
            dtpFechaFabricacion.Value = AudifonoPacienteEntity.FechaFabricacion.Value;
            dtpProximoService.Value = AudifonoPacienteEntity.ProximoService.Value;
            txtObservacionAudifono.Text = AudifonoPacienteEntity.Observacion;
            txtEstadoAudifono.Text = AudifonoPacienteEntity.Estado;
        }

        private void btnEliminarAudifono_Click(object sender, EventArgs e)
        {
            EstadoAccionAudifono = EstadoForm.Eliminar;
            HabilitarControlesAudifono(true);
            LoadDataAudifono();
        }

        private void btnCancelarAudifono_Click(object sender, EventArgs e)
        {
            HabilitarControlesAudifono(false);
        }

        
    }
}
