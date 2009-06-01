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

        #endregion

        #region "--[Methods]--"
        public frmEstudio()
        {
            InitializeComponent();
            TabPageActual = tbpSeleccionPaciente;
        }

        private void InitializeObjectView()
        {
            this.PacienteObjectView = new ObjectView(typeof(Paciente));
            this.PacienteObjectView.AllowRemove = false;
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
                tbcEstudio.SelectedIndex += 1;
                btnSiguiente.Enabled = false;
                CargarEstudio();
            }
            else
            {
                tbcEstudio.SelectedIndex += 1;
                btnAnterior.Enabled = true;
            }

            if (tbcEstudio.SelectedTab == tbpAccionARealizar)
            {
                LoadTipoEstudios();
            }
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
                    tbpEstudio.Controls.Add(wUserAnamnesis);
                    break;
                case Enumeraciones.TipoEstudio.Audiometria:
                    uscAudiometria wUserAudiometria = new uscAudiometria();
                    wUserAudiometria.Dock = DockStyle.Fill;
                    tbpEstudio.Controls.Add(wUserAudiometria);
                    break;
                case Enumeraciones.TipoEstudio.ImpedanciometriaDinamica:
                    uscImpedanciometriaDinamica wUserImpedanciometriaDinamica = new uscImpedanciometriaDinamica();
                    wUserImpedanciometriaDinamica.Dock = DockStyle.Fill;
                    tbpEstudio.Controls.Add(wUserImpedanciometriaDinamica);
                    break;
                case Enumeraciones.TipoEstudio.ImpedanciometriaEstatica:
                    uscImpedanciometriaEstatica wUserImpedanciometriaEstatica = new uscImpedanciometriaEstatica();
                    wUserImpedanciometriaEstatica.Dock = DockStyle.Fill;
                    tbpEstudio.Controls.Add(wUserImpedanciometriaEstatica);
                    break;
                case Enumeraciones.TipoEstudio.LogoAudiometria:
                    uscLogoAudiometria wUserLogoAudiometria = new uscLogoAudiometria();
                    wUserLogoAudiometria.Dock = DockStyle.Fill;
                    tbpEstudio.Controls.Add(wUserLogoAudiometria);
                    break;
                case Enumeraciones.TipoEstudio.Timpanometria:
                    uscTimpanometria wUserTimpanometria = new uscTimpanometria();
                    wUserTimpanometria.Dock = DockStyle.Fill;
                    tbpEstudio.Controls.Add(wUserTimpanometria);
                    break;
            }
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
            }
            else
            {
                tbcEstudio.SelectedIndex -= 1;
                btnSiguiente.Enabled = true;
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

                EstudioBP.Insert(wEstudio);

                //INSERTA POR SEPARADO CABECERA Y DETALLES EN TODOS LOS CASOS DEJA EN EN LA PROPIEDAD "Cascade" DEL
                //.hbm COMO "Delete" NADA MAS, DESPUES LE BUSCAMOS UNA SOLUCION

                //ESTO NO DEBERIA ESTAR, ES UNA NEGRADA PERO PARA SALIR DEL PASO NO QUEDA OTRA POR AHORA
                switch (wEstudio.GetType().Name)
                {
                    case "Anamnesi":
                        AnamnesisPreguntaBusiness wPreguntaRespuestaBP = new AnamnesisPreguntaBusiness(DaoFactory.GetAnamnesisPreguntaDao());
                        foreach (AnamnesisPregunta wPreguntaRespuesta in ((Anamnesi)wEstudio).AnamnesisPreguntases)
                        {
                            wPreguntaRespuesta.IDEstudio = wEstudio.ID;
                            wPreguntaRespuestaBP.Insert(wPreguntaRespuesta);
                        }

                        break;
                }
                
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
            ptbProgress.Visible = false;
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
