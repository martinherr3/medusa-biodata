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
using Mds.Biodata.Forms.UserControls;

namespace Mds.Biodata.Forms
{
    public partial class frmEstudio : frmBase
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

        private TabPage TabPageActual;
        private Int32 TipoEstudioActual = -1;

        private EstadoForm _estado = EstadoForm.Nuevo;
        public EstadoForm Estado
        {
            get { return _estado; }
            set
            {
                _estado = value;
            }
        }

        private Estudio _EstudioActual;

        public Estudio EstudioActual
        {
            get { return _EstudioActual; }
            set { _EstudioActual = value; }
        }

        private Int32 _EstudioActualID;

        public Int32 EstudioActualID
        {
            get { return _EstudioActualID; }
            set { _EstudioActualID = value; }
        }
        #endregion

        #region "--[Methods]--"
        public frmEstudio()
        {
            InitializeComponent();
            TabPageActual = tbpSeleccionPaciente;
            tbcEstudio.SelectedTab = tbpSeleccionPaciente;
            LoadTipoEstudios();
        }

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
            this.PacienteCurrencyManager = this.dgvPacientes.BindingContext[this.PacienteObjectView];
        }

        /// <summary>
        /// Carga la grilla con los registros de la DB
        /// </summary>
        private void LoadList()
        {
            try
            {
                ptbProgress.Visible = true;
                InitializeObjectView();
                dgvPacientes.DataSource = null;
                bgwLoad.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        /// <summary>
        /// Mueve la seleccion del TAB al siguiente
        /// </summary>
        private void MoveNext()
        {
            if (tbcEstudio.SelectedTab == tbpAccionARealizar)
            {
                if (TipoEstudioActual == -1)
                {
                    tbcEstudio.SelectedIndex += 1;
                    btnSiguiente.Enabled = false;

                    tbpSeleccionPaciente.Enabled = false;
                    tbpAccionARealizar.Enabled = false;
                    tbpEstudio.Enabled = true;

                    CargarEstudio();
                }
                else
                {
                    if (TipoEstudioActual != Convert.ToInt32((Enumeraciones.TipoEstudio)cmbTipoEstudio.SelectedItem))
                    {
                        if (ProcesarMensaje("El tipo de estudio ha cambiado, se reemplazara el anterior. ¿Desea continuar?", "Cambio de estudio", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            tbcEstudio.SelectedIndex += 1;
                            btnSiguiente.Enabled = false;

                            tbpSeleccionPaciente.Enabled = false;
                            tbpAccionARealizar.Enabled = false;
                            tbpEstudio.Enabled = true;

                            CargarEstudio();
                        }
                    }
                    else
                    {
                        tbcEstudio.SelectedIndex += 1;
                        btnSiguiente.Enabled = false;

                        tbpSeleccionPaciente.Enabled = false;
                        tbpAccionARealizar.Enabled = false;
                        tbpEstudio.Enabled = true;
                    }
                }
  
            }
            else
            {
                tbcEstudio.SelectedIndex += 1;
                btnAnterior.Enabled = true;

                tbpSeleccionPaciente.Enabled = false;
                tbpAccionARealizar.Enabled = true;
                tbpEstudio.Enabled = false;
            }

            //if (tbcEstudio.SelectedTab == tbpAccionARealizar)
            //{
            //    LoadTipoEstudios();
            //}
        }

        /// <summary>
        /// Carga el user control correspondiente al tipo de estudio seleccionado en el combo
        /// </summary>
        private void CargarEstudio()
        {
            tbpEstudio.Controls.Clear();
            switch ((Enumeraciones.TipoEstudio)cmbTipoEstudio.SelectedItem)
            {
                case Enumeraciones.TipoEstudio.Anamnesis:
                    uscAnamnesis wUserAnamnesis = new uscAnamnesis();
                    wUserAnamnesis.Dock = DockStyle.Fill;
                    if (this.Estado == EstadoForm.Editar)
                    {
                        wUserAnamnesis.CargarDatosEstudio(this.EstudioActual);
                    }
                    else
                    {
                        wUserAnamnesis.CargarPreguntas();
                    }
                        
                    tbpEstudio.Controls.Add(wUserAnamnesis);
                    break;
                case Enumeraciones.TipoEstudio.Audiometria:
                    uscAudiometria wUserAudiometria = new uscAudiometria();
                    wUserAudiometria.Dock = DockStyle.Fill;
                    if (this.Estado == EstadoForm.Editar)
                        wUserAudiometria.CargarDatosEstudio(this.EstudioActual);
                    tbpEstudio.Controls.Add(wUserAudiometria);
                    break;
                //case Enumeraciones.TipoEstudio.ImpedanciometriaDinamica:
                //    uscImpedanciometriaDinamica wUserImpedanciometriaDinamica = new uscImpedanciometriaDinamica();
                //    wUserImpedanciometriaDinamica.Dock = DockStyle.Fill;
                //    tbpEstudio.Controls.Add(wUserImpedanciometriaDinamica);
                //    break;
                //case Enumeraciones.TipoEstudio.ImpedanciometriaEstatica:
                //    uscImpedanciometriaEstatica wUserImpedanciometriaEstatica = new uscImpedanciometriaEstatica();
                //    wUserImpedanciometriaEstatica.Dock = DockStyle.Fill;
                //    tbpEstudio.Controls.Add(wUserImpedanciometriaEstatica);
                //    break;
                case Enumeraciones.TipoEstudio.LogoAudiometria:
                    uscLogoAudiometria wUserLogoAudiometria = new uscLogoAudiometria();
                    wUserLogoAudiometria.Dock = DockStyle.Fill;
                    if (this.Estado == EstadoForm.Editar)
                        wUserLogoAudiometria.CargarDatosEstudio(this.EstudioActual);
                    tbpEstudio.Controls.Add(wUserLogoAudiometria);
                    break;
                case Enumeraciones.TipoEstudio.Timpanometria:
                    uscTimpanometria wUserTimpanometria = new uscTimpanometria();
                    wUserTimpanometria.Dock = DockStyle.Fill;
                    if (this.Estado == EstadoForm.Editar)
                    {
                        wUserTimpanometria.CargarDatosEstudio(this.EstudioActual);
                    }
                    else
                    {
                        wUserTimpanometria.DarFormatoGrillas();
                    }
                        
                    tbpEstudio.Controls.Add(wUserTimpanometria);
                    break;
                case Enumeraciones.TipoEstudio.TestDeLing:
                    uscTestLing wUserTestLing = new uscTestLing();
                    wUserTestLing.Dock = DockStyle.Fill;
                    if (this.Estado == EstadoForm.Editar)
                    {
                        wUserTestLing.CargarDatosEstudio(this.EstudioActual);
                    }
                    else
                    {
                        wUserTestLing.DarFormatoGrillas();
                        wUserTestLing.CargarValoresInicialesGrilla();
                    }
                        
                    tbpEstudio.Controls.Add(wUserTestLing);
                    break;
            }

            TipoEstudioActual = Convert.ToInt32((Enumeraciones.TipoEstudio)cmbTipoEstudio.SelectedItem);
        }

        /// <summary>
        /// Carga los tipos de estudios para la seleccion
        /// </summary>
        private void LoadTipoEstudios()
        {
            cmbTipoEstudio.DataSource = Enum.GetValues(typeof(Enumeraciones.TipoEstudio));
        }

        /// <summary>
        /// Mueve la seleccion del TAB al anterior
        /// </summary>
        private void MovePreviuos()
        {
            if (tbcEstudio.SelectedTab == tbpAccionARealizar)
            {
                tbcEstudio.SelectedIndex -= 1;
                btnAnterior.Enabled = false;

                tbpSeleccionPaciente.Enabled = true;
                tbpAccionARealizar.Enabled = false;
                tbpEstudio.Enabled = false;
            }
            else
            {
                tbcEstudio.SelectedIndex -= 1;
                btnSiguiente.Enabled = true;

                tbpSeleccionPaciente.Enabled = false;
                tbpAccionARealizar.Enabled = true;
                tbpEstudio.Enabled = false;
            }
        }

        /// <summary>
        /// Cierra la solapa con la ventana
        /// </summary>
        public void Cerrar()
        {
            this.Parent.Parent.Controls.Remove(this.Parent);
            this.Close();
        }

        /// <summary>
        /// Registra el estudio en cuestión dependiendo del tipo de estudio
        /// </summary>
        private void RegistrarEstudio()
        {
            try
            {
                if (ValidData())
                {
                    uscBase UseEstudio = (uscBase)tbpEstudio.Controls[0];

                    Estudio wEstudio = UseEstudio.ObtenerDatosEstudio();

                    wEstudio.Nombre = txtNombre.Text;
                    wEstudio.FechaEstudio = dtpFechaEstudio.Value;
                    wEstudio.InstrumentosUtilizados = txtInstrumentosUtilizados.Text;
                    wEstudio.Observaciones = txtObservaciones.Text;
                    wEstudio.TipoEstudio = (Int32)cmbTipoEstudio.SelectedItem;

                    ObjectViewRow wFila = (ObjectViewRow)dgvPacientes.CurrentRow.DataBoundItem;
                    wEstudio.IDHistoriaClinicaLookup = ((Paciente)wFila.InnerObject).HistoriaClinicas[0];
                    wEstudio.IDHistoriaClinica = wEstudio.IDHistoriaClinicaLookup.ID;

                    EstudioBusiness EstudioBP = new EstudioBusiness(DaoFactory.GetEstudioDao());

                    if (this.Estado == EstadoForm.Nuevo)
                    {
                        EstudioBP.Insert(wEstudio);

                        //INSERTA POR SEPARADO CABECERA Y DETALLES EN TODOS LOS CASOS DEJA EN EN LA PROPIEDAD "Cascade" DEL
                        //.hbm COMO "Delete" NADA MAS, DESPUES LE BUSCAMOS UNA SOLUCION

                        //ESTO NO DEBERIA ESTAR, ES UNA NEGRADA PERO PARA SALIR DEL PASO NO QUEDA OTRA POR AHORA
                        //switch (wEstudio.GetType().Name)
                        //{
                        //    case "Anamnesi":
                        //        AnamnesisPreguntaBusiness wPreguntaRespuestaBP = new AnamnesisPreguntaBusiness(DaoFactory.GetAnamnesisPreguntaDao());
                        //        foreach (AnamnesisPregunta wPreguntaRespuesta in ((Anamnesi)wEstudio).AnamnesisPreguntases)
                        //        {
                        //            wPreguntaRespuesta.IDEstudio = wEstudio.ID;
                        //            wPreguntaRespuestaBP.Insert(wPreguntaRespuesta);
                        //        }

                        //        break;
                        //}
                    }
                    else
                    {
                        EstudioBP.Update(wEstudio);
                        EstudioBP.Commit();
                    }

                    ProcesarMensaje("Se registro el Estudio en forma exitosa");
                }
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
                ProcesarAdvertencia("Debe ingresar el Nombre Descriptivo del Estudio");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Cargo los datos del estudio en caso de una modificacion
        /// </summary>
        private void CargarDatosAModificar()
        {
            try
            {
                EstudioBusiness EstudioBP = new EstudioBusiness(DaoFactory.GetEstudioDao());

                this.EstudioActual = EstudioBP.GetById(this.EstudioActualID);

                Int32 i = -1;

                for (i = 0; i < dgvPacientes.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dgvPacientes.Rows[i].Cells[0].Value) == this.EstudioActual.IDHistoriaClinicaLookup.IDPacienteLookup.ID)
                    {
                        dgvPacientes.Rows[i].Selected = true;
                        dgvPacientes.CurrentCell = dgvPacientes.Rows[i].Cells[1];
                        break;
                    }
                }

                if (i == dgvPacientes.Rows.Count)
                {
                    ProcesarMensaje("No se encontro al paciente, posible error en la carga de datos", "Paciente en Estudio");
                }


                dgvPacientes.Enabled = false;

                txtNombre.Text = EstudioActual.Nombre;
                dtpFechaEstudio.Value = EstudioActual.FechaEstudio;
                txtInstrumentosUtilizados.Text = EstudioActual.InstrumentosUtilizados;
                txtObservaciones.Text = EstudioActual.Observaciones;
                cmbTipoEstudio.SelectedItem = (Enumeraciones.TipoEstudio)EstudioActual.TipoEstudio;
                CargarEstudio();

                //Audiometria wAudiometriaModificar = (Audiometria)this.EstudioActual;
            }
            catch (Exception ex)
            {

                ProcesarExcepcion(ex);
            }
        }
        #endregion

        #region "--[Events]--"
        private void frmEstudio_Load(object sender, EventArgs e)
        {
            _PacienteBP = new PacienteBusiness(DaoFactory.GetPacienteDao());
            LoadList();
        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            _PacienteEntities = _PacienteBP.GetAll();
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.PacienteObjectView.DataSource = (IList)this._PacienteEntities;
            this.dgvPacientes.DataSource = this.PacienteObjectView;
            this.dgvPacientes.Columns[0].Visible = false;
            ptbProgress.Visible = false;
            //Una vez cargados el listado de pacientes empezamos a 
            //cargar datos de estudio si es una modificacion
            if (this.Estado == EstadoForm.Editar)
            {
                CargarDatosAModificar();
                //Una vez cargo el estudio puede modificar los datos pero no el tipo del mismo
                cmbTipoEstudio.Enabled = false;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MoveNext();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            MovePreviuos();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btnRegistrarEstudio_Click(object sender, EventArgs e)
        {
            RegistrarEstudio();
        }
        #endregion
    }
}
