using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Domain;
using Mds.Biodata.Business;
using ObjectViews;
using System.Collections;

namespace Mds.Biodata.Forms
{
    public partial class frmSeleccionAudifono : frmBase
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

        private EstudioBusiness _EstudioBP;

        public EstudioBusiness EstudioBP
        {
            get { return _EstudioBP; }
            set { _EstudioBP = value; }
        }

        private List<Estudio> _EstudioEntities = new List<Estudio>();

        public List<Estudio> EstudioEntities
        {
            get { return _EstudioEntities; }
            set { _EstudioEntities = value; }
        }

        private ObjectView _EstudioObjectView;

        public ObjectView EstudioObjectView
        {
            get { return _EstudioObjectView; }
            set { _EstudioObjectView = value; }
        }
        private BindingManagerBase _EstudioCurrencyManager;

        public BindingManagerBase EstudioCurrencyManager
        {
            get { return _EstudioCurrencyManager; }
            set { _EstudioCurrencyManager = value; }
        }

        private AudifonoBusiness _AudifonoBP;

        public AudifonoBusiness AudifonoBP
        {
            get { return _AudifonoBP; }
            set { _AudifonoBP = value; }
        }

        private List<Audifono> _AudifonoEntities = new List<Audifono>();

        public List<Audifono> AudifonoEntities
        {
            get { return _AudifonoEntities; }
            set { _AudifonoEntities = value; }
        }

        private Audifono _AudifonoEntity;

        public Audifono AudifonoEntity
        {
            get { return _AudifonoEntity; }
            set { _AudifonoEntity = value; }
        }

        private ObjectView _AudifonoObjectView;

        public ObjectView AudifonoObjectView
        {
            get { return _AudifonoObjectView; }
            set { _AudifonoObjectView = value; }
        }
        private BindingManagerBase _AudifonoCurrencyManager;

        public BindingManagerBase AudifonoCurrencyManager
        {
            get { return _AudifonoCurrencyManager; }
            set { _AudifonoCurrencyManager = value; }
        }


        private SeleccionAudifonoBusiness _SeleccionBP;

        public SeleccionAudifonoBusiness SeleccionBP
        {
            get { return _SeleccionBP; }
            set { _SeleccionBP = value; }
        }
        #endregion

        #region "--[Methods]--"
        public frmSeleccionAudifono()
        {
            InitializeComponent();
            tbcSeleccionAudifono.SelectedTab = tbpSeleccionPaciente;
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
        #endregion

        private void frmSeleccionAudifono_Load(object sender, EventArgs e)
        {
            _PacienteBP = new PacienteBusiness(DaoFactory.GetPacienteDao());
            _EstudioBP = new EstudioBusiness(DaoFactory.GetEstudioDao());
            _AudifonoBP = new AudifonoBusiness(DaoFactory.GetAudifonoDao());
            _SeleccionBP = new SeleccionAudifonoBusiness(DaoFactory.GetSeleccionAudifonoDao());
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
            
            //VER COMO SELECCIONAR POR DEFECTO EL PRIMER ELEMENTO SI HAY
            //##########################################################
            //if (this.PacienteObjectView.Count > 0)
            //    this.dgvPacientes.Rows[0].Selected = true;
            //##########################################################
            this.dgvPacientes.Columns[0].Visible = false;
            ptbProgress.Visible = false;
            ////Una vez cargados el listado de pacientes empezamos a 
            ////cargar datos de estudio si es una modificacion
            //if (this.Estado == EstadoForm.Editar)
            //{
            //    CargarDatosAModificar();
            //    //Una vez cargo el estudio puede modificar los datos pero no el tipo del mismo
            //    cmbTipoEstudio.Enabled = false;
            //}
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            MovePrevious();
        }

        /// <summary>
        /// Mueve la seleccion del TAB al anterior
        /// </summary>
        private void MovePrevious()
        {
            switch (tbcSeleccionAudifono.SelectedIndex)
            {
                case 3: //tbpSeleccionAudifono
                    btnSiguiente.Enabled = true;
                    tbpSeleccionPaciente.Enabled = false;
                    tbpAudiometriasRealizadas.Enabled = false;
                    tbpAdecuadas.Enabled = true;
                    tbpSeleccionAudifono.Enabled = false;
                    break;
                case 2: //tbpAdecuadas
                    tbpSeleccionPaciente.Enabled = false;
                    tbpAudiometriasRealizadas.Enabled = true;
                    tbpAdecuadas.Enabled = false;
                    tbpSeleccionAudifono.Enabled = false;
                    break;
                case 1: //tbpAudiometriasRealizadas
                    tbpSeleccionPaciente.Enabled = true;
                    tbpAudiometriasRealizadas.Enabled = false;
                    tbpAdecuadas.Enabled = false;
                    tbpSeleccionAudifono.Enabled = false;
                    btnAnterior.Enabled = false;
                    break;
            }

            //if (tbcSeleccionAudifono.SelectedTab == tbpAdecuadas)
            //{
            //    btnSiguiente.Enabled = true;
            //    tbpSeleccionPaciente.Enabled = false;
            //    tbpAudiometriasRealizadas.Enabled = true;
            //    tbpAdecuadas.Enabled = false;
            //}
            //else
            //{
            //    btnAnterior.Enabled = false;
            //    tbpSeleccionPaciente.Enabled = true;
            //    tbpAudiometriasRealizadas.Enabled = false;
            //    tbpAdecuadas.Enabled = false;
            //}
            tbcSeleccionAudifono.SelectedIndex -= 1;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            MoveNext();
        }

        /// <summary>
        /// Mueve la seleccion del TAB al siguiente
        /// </summary>
        private void MoveNext()
        {
            switch (tbcSeleccionAudifono.SelectedIndex)
            {
                case 0: //tbpSeleccionPaciente
                    if (ValidarSeleccionPaciente())
                    {
                        //Quiere decir que pasa a la muestra de audiometrias
                        btnAnterior.Enabled = true;
                        tbpSeleccionPaciente.Enabled = false;
                        tbpAudiometriasRealizadas.Enabled = true;
                        tbpAdecuadas.Enabled = false;
                        tbpSeleccionAudifono.Enabled = false;
                        BuscarAudiometrias();
                    }
                    else
                    {
                        ProcesarAdvertencia("Debe seleccionar previamente un paciente", "Selección de paciente");
                        return;
                    }
                    break;
                case 1: //tbpAudiometriasRealizadas
                    if (ValidarSeleccionAudiometrias())
                    {
                        //Quiere decir que pasa a la decision del audifono adecuado
                        tbpSeleccionPaciente.Enabled = false;
                        tbpAudiometriasRealizadas.Enabled = false;
                        tbpAdecuadas.Enabled = true;
                        tbpSeleccionAudifono.Enabled = false;
                        BuscarAudifonosCorrectos();
                    }
                    else
                    {
                        ProcesarAdvertencia("Debe tildar previamente al menos un estudio", "Selección de Estudio");
                        return;
                    }
                    break;
                case 2: //tbpAdecuadas
                    if (ValidarSeleccionAudifono())
                    {
                        //Quiere decir que se pasa a la etapa final de "Seleccion"
                        btnSiguiente.Enabled = false;
                        tbpSeleccionPaciente.Enabled = false;
                        tbpAudiometriasRealizadas.Enabled = false;
                        tbpAdecuadas.Enabled = false;
                        tbpSeleccionAudifono.Enabled = true;

                        ObjectViews.ObjectViewRow RowSelected = (ObjectViewRow)dgvAudifonosAceptados.CurrentRow.DataBoundItem;
                        AudifonoEntity = AudifonoBP.GetById(((Audifono)RowSelected.InnerObject).ID);
                    }
                    else
                    {
                        ProcesarAdvertencia("Debe seleccionar previamente un audifono", "Selección de audifino");
                        return;
                    }
                    break;
            }

            //if (tbcSeleccionAudifono.SelectedTab == tbpSeleccionPaciente)
            //{
            //    if (ValidarSeleccionPaciente())
            //    {
            //        //Quiere decir que pasa a la muestra de audiometrias
            //        btnAnterior.Enabled = true;
            //        tbpSeleccionPaciente.Enabled = false;
            //        tbpAudiometriasRealizadas.Enabled = true;
            //        tbpAdecuadas.Enabled = false;
            //        BuscarAudiometrias();
            //    }
            //    else
            //    {
            //        ProcesarAdvertencia("Debe seleccionar previamente un paciente", "Selección de paciente");
            //        return;
            //    }
            //}
            //else
            //{

            //    if (ValidarSeleccionAudiometrias())
            //    {
            //        //Quiere decir que pasa a la decision del audifono adecuado
            //        btnSiguiente.Enabled = false;
            //        tbpSeleccionPaciente.Enabled = false;
            //        tbpAudiometriasRealizadas.Enabled = false;
            //        tbpAdecuadas.Enabled = true;
            //        BuscarAudifonosCorrectos();
            //    }
            //    else
            //    {
            //        ProcesarAdvertencia("Debe tildar previamente al menos un estudio", "Selección de Estudio");
            //        return;
            //    }
            //}
            tbcSeleccionAudifono.SelectedIndex += 1;
        }

        private Boolean ValidarSeleccionAudiometrias()
        {
            foreach (DataGridViewRow oRow in dgvEstudios.Rows)
            {
                if (Convert.ToBoolean(oRow.Cells["Seleccion"].Value) == true)
                {
                    return true;
                }
            }
            return false;
        }

        private Boolean ValidarSeleccionPaciente()
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Boolean ValidarSeleccionAudifono()
        {
            if (dgvAudifonosAceptados.SelectedRows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BuscarAudifonosCorrectos()
        {
            try
            {
                ptbProgressAudifonos.Visible = true;
                InitializeObjectViewAudifonos();
                dgvAudifonosAceptados.DataSource = null;
                bgwLoadAudifonos.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void BuscarAudiometrias()
        {
            try
            {
                ptbProgressEstudios.Visible = true;
                InitializeObjectViewEstudios();
                dgvEstudios.DataSource = null;
                bgwLoadEstudios.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void InitializeObjectViewEstudios()
        {
            this.EstudioObjectView = new ObjectView(typeof(Estudio));
            this.EstudioObjectView.AllowRemove = false;
            this.EstudioObjectView.Columns.Add("ID", "ID");
            this.EstudioObjectView.Columns.Add("Nombre", "Nombre");
            this.EstudioObjectView.Columns.Add("FechaEstudio", "Fecha de Estudio");
            this.EstudioObjectView.Columns.Add("TipoEstudioValue", "Tipo de Estudio");
            this.EstudioObjectView.Columns.Add("IDHistoriaClinicaLookup.IDPacienteLookup.ApellidoNombre", "Paciente");
            this.EstudioCurrencyManager = this.dgvEstudios.BindingContext[this.EstudioObjectView];
        }

        private void bgwLoadEstudios_DoWork(object sender, DoWorkEventArgs e)
        {
            ObjectViews.ObjectViewRow RowSelected = (ObjectViewRow)dgvPacientes.CurrentRow.DataBoundItem;
            PacienteEntity = PacienteBP.GetById(((Paciente)RowSelected.InnerObject).ID);

            _EstudioEntities = _EstudioBP.GetEstudiosTipoAndPaciente((int)TipoEstudio.Audiometria, PacienteEntity.HistoriaClinicas[0].ID);
        }

        private void bgwLoadEstudios_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.dgvEstudios.Columns.Clear();
            this.EstudioObjectView.DataSource = (IList)this._EstudioEntities;
            this.dgvEstudios.DataSource = this.EstudioObjectView;
            DataGridViewCheckBoxColumn Columna = new DataGridViewCheckBoxColumn();
            Columna.HeaderText = "Seleccion";
            Columna.Name = "Seleccion";
            this.dgvEstudios.Columns.Add(Columna);
            SetearAudiometriasEnGrilla(true);
            ptbProgressEstudios.Visible = false;
        }

        private void InitializeObjectViewAudifonos()
        {
            this.AudifonoObjectView = new ObjectView(typeof(Audifono));
            this.AudifonoObjectView.AllowRemove = false;
            this.AudifonoObjectView.Columns.Add("NombreModelo", Translate("Nombre"));
            this.AudifonoObjectView.Columns.Add("IDMarcaLookup.Nombre", Translate("Marca"));
            this.AudifonoObjectView.Columns.Add("PresionMaximaSalida", Translate("Presión Salida"));
            this.AudifonoCurrencyManager = this.dgvAudifonosAceptados.BindingContext[this.AudifonoObjectView];
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void Cerrar()
        {
            this.Parent.Parent.Controls.Remove(this.Parent);
            this.Close();
        }

        private void bgwLoadAudifonos_DoWork(object sender, DoWorkEventArgs e)
        {
            AudifonoBusiness AudifonoBP = new AudifonoBusiness(DaoFactory.GetAudifonoDao());

            List<Audifono> wAudifonos = AudifonoBP.GetAll();

            AudifonoEntities.Clear();

            foreach (Audifono wAudifono in wAudifonos)
            {
                String strFranjaAdaptacion = wAudifono.FranjaAdaptacion;

                Liner.Main.Collections.Collection FranjaAdaptacionGrafico;
                FranjaAdaptacionGrafico = (Liner.Main.Collections.Collection)Mds.Architecture.HelpersFunctions.SerializationFunctions.Deserialize(typeof(Liner.Main.Collections.Collection), strFranjaAdaptacion);
                //linerLeft.AutoGenerateLine(AudiometriaLeft, AudiometriaLeft.GetCurrentLineSeries());
                Boolean blnAceptado = true;
                //foreach (Estudio wEstudio in EstudioEntities)
                //{
                foreach (DataGridViewRow oRow in dgvEstudios.Rows)
                {
                    if (Convert.ToBoolean(oRow.Cells["Seleccion"].Value)==true)
                    {
                        Estudio wEstudio = EstudioBP.GetById((int)oRow.Cells["ID"].Value);

                        Audiometria wAudiometria = (Audiometria)wEstudio;

                        Liner.Main.Collections.Collection AudiometriaIzq;
                        AudiometriaIzq = (Liner.Main.Collections.Collection)Mds.Architecture.HelpersFunctions.SerializationFunctions.Deserialize(typeof(Liner.Main.Collections.Collection), wAudiometria.AudiogramaIzquierdo);

                        Liner.Main.Collections.Collection AudiometriaDer;
                        AudiometriaDer = (Liner.Main.Collections.Collection)Mds.Architecture.HelpersFunctions.SerializationFunctions.Deserialize(typeof(Liner.Main.Collections.Collection), wAudiometria.AudiogramaDerecho);

                        //Validacion, la linea que arranca mas abajo (aunque en la grafica el YValue es el mayor) es la linea1, o sea la linea de abajo
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        Pavr.Main.Collections.LineSeries Linea1Temp = (Pavr.Main.Collections.LineSeries)FranjaAdaptacionGrafico[0];
                        Pavr.Main.Collections.LineSeries Linea2Temp = (Pavr.Main.Collections.LineSeries)FranjaAdaptacionGrafico[1];
                        Pavr.Main.Base.PPoint Punto1Temp = (Pavr.Main.Base.PPoint)Linea1Temp.aPoints[0];
                        Pavr.Main.Base.PPoint Punto2Temp = (Pavr.Main.Base.PPoint)Linea2Temp.aPoints[0];
                        Pavr.Main.Collections.LineSeries Linea1;
                        Pavr.Main.Collections.LineSeries Linea2;
                        if (Convert.ToInt32(Punto1Temp.YValue) > Convert.ToInt32(Punto2Temp.YValue))
                        {
                            Linea1 = (Pavr.Main.Collections.LineSeries)FranjaAdaptacionGrafico[0];
                            Linea2 = (Pavr.Main.Collections.LineSeries)FranjaAdaptacionGrafico[1];
                        }
                        else
                        {
                            Linea1 = (Pavr.Main.Collections.LineSeries)FranjaAdaptacionGrafico[1];
                            Linea2 = (Pavr.Main.Collections.LineSeries)FranjaAdaptacionGrafico[0];
                        }
                        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                        Pavr.Main.Collections.LineSeries LineaOidoIzq = (Pavr.Main.Collections.LineSeries)AudiometriaIzq[0];

                        Pavr.Main.Collections.LineSeries LineaOidoDer = (Pavr.Main.Collections.LineSeries)AudiometriaDer[0];
                        Int32 iContadorIzq = 0;
                        Int32 iContadorDer = 0;
                        for (Int32 i = 0; i < 6; i++)
                        {
                            Pavr.Main.Base.PPoint PuntoIzq = null;
                            if (iContadorIzq < LineaOidoIzq.aPoints.Count)
                            {
                                PuntoIzq = (Pavr.Main.Base.PPoint)LineaOidoIzq.aPoints[iContadorIzq];
                            }

                            Pavr.Main.Base.PPoint PuntoDer = null;
                            if (iContadorDer < LineaOidoDer.aPoints.Count)
                            {
                                PuntoDer = (Pavr.Main.Base.PPoint)LineaOidoDer.aPoints[iContadorDer];
                            }

                            Pavr.Main.Base.PPoint Punto1 = (Pavr.Main.Base.PPoint)Linea1.aPoints[i];
                            Pavr.Main.Base.PPoint Punto2 = (Pavr.Main.Base.PPoint)Linea2.aPoints[i];

                            //La franja de adaptacion tiene un valor para cada frecuencia (restriccion) pero las audiometrias no
                            //necesariamente por lo cual se utiliza la propiedad XValue para saber si comparamos frecuencias similares

                            //Control para oido izquierdo
                            if (PuntoIzq != null && Convert.ToInt32(Punto1.XValue) == Convert.ToInt32(PuntoIzq.XValue))
                            {
                                if (!(Convert.ToInt32(PuntoIzq.YValue) <= Convert.ToInt32(Punto1.YValue) && Convert.ToInt32(PuntoIzq.YValue) >= Convert.ToInt32(Punto2.YValue)))
                                {
                                    blnAceptado = false;
                                }
                                iContadorIzq++;
                            }

                            //Control para oido derecho
                            if (PuntoDer != null && Convert.ToInt32(Punto1.XValue) == Convert.ToInt32(PuntoDer.XValue))
                            {
                                if (!(Convert.ToInt32(PuntoDer.YValue) <= Convert.ToInt32(Punto1.YValue) && Convert.ToInt32(PuntoDer.YValue) >= Convert.ToInt32(Punto2.YValue)))
                                {
                                    blnAceptado = false;
                                }
                                iContadorDer++;
                            }
                        }
                    }
                }
                //}

                if (blnAceptado)
                {
                    AudifonoEntities.Add(wAudifono);
                }
            }
        }

        private void bgwLoadAudifonos_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.AudifonoObjectView.DataSource = (IList)this._AudifonoEntities;
            this.dgvAudifonosAceptados.DataSource = this.AudifonoObjectView;
            ptbProgressAudifonos.Visible = false;
        }

        private void dgvEstudios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Si se realizo click en la columna del Check
            if (e.ColumnIndex == 5)
            {
                dgvEstudios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !Convert.ToBoolean(dgvEstudios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            }
        }

        private void radSeleccionarTodos_CheckedChanged(object sender, EventArgs e)
        {
            SetearAudiometriasEnGrilla(true);
        }

        private void SetearAudiometriasEnGrilla(Boolean pValue)
        {
            foreach (DataGridViewRow oRow in dgvEstudios.Rows)
            {
                oRow.Cells["Seleccion"].Value = pValue;
            }
        }

        private void radSeleccionarNinguno_CheckedChanged(object sender, EventArgs e)
        {
            SetearAudiometriasEnGrilla(false);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RegistrarSeleccion();
        }

        private void RegistrarSeleccion()
        {
            try
            {
                SeleccionAudifono wSeleccion = new SeleccionAudifono();
                wSeleccion.FechaSeleccion = dtpFechaSeleccion.Value;
                wSeleccion.InstrumentosUtilizados = txtInstrumentosUtilizados.Text;
                wSeleccion.Observaciones = txtObservaciones.Text;
                wSeleccion.LecturaLabial = chkLecturaLabial.Checked;
                wSeleccion.UsoDeAudifono = chkUsoAudifono.Checked;
                wSeleccion.ProximaVisita = dtpFechaProximaVisita.Value;
                wSeleccion.NroSerie = txtNroSerie.Text;
                wSeleccion.IDPaciente = PacienteEntity.ID;
                wSeleccion.IDPacienteLookup = PacienteEntity;
                wSeleccion.IDAudifono = AudifonoEntity.ID;
                wSeleccion.IDAudifonoLookup = AudifonoEntity;

                SeleccionBP.Insert(wSeleccion);

                ProcesarMensaje("Se registro la selección exitosamente", "Selección");

                Cerrar();
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        #region "--[Events]--"

        #endregion
    }
}
