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

namespace Mds.Biodata.Forms
{
    public partial class frmConsultaEstudio : frmFiltrosABM
    {
        #region "--[Properties]--"
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

        private Estudio _EstudioEntity;

        public Estudio EstudioEntity
        {
            get { return _EstudioEntity; }
            set { _EstudioEntity = value; }
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
        #endregion

        #region "--[Methods]--"
        public frmConsultaEstudio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Da formato a la grilla y crea lo necesario para el bindeo
        /// </summary>
        private void InitializeObjectView()
        {
            this.EstudioObjectView = new ObjectView(typeof(Estudio));
            this.EstudioObjectView.AllowRemove = false;
            this.EstudioObjectView.Columns.Add("ID", "ID");
            this.EstudioObjectView.Columns.Add("Nombre", "Nombre");
            this.EstudioObjectView.Columns.Add("FechaEstudio", "Fecha de Estudio");
            //this.EstudioObjectView.Columns.Add("TipoEstudio", "Tipo de Estudio");
            this.EstudioObjectView.Columns.Add("TipoEstudioValue", "Tipo de Estudio");
            this.EstudioObjectView.Columns.Add("IDHistoriaClinicaLookup.IDPacienteLookup.ApellidoNombre", "Paciente");
            this.EstudioCurrencyManager = this.dgvConsultas.BindingContext[this.EstudioObjectView];
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
                dgvConsultas.DataSource = null;
                //Habilitar(false);
                btnCerrar.Enabled = true;
                bgwLoad.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
        #endregion

        #region "--[Events]--"
        private void frmConsultaEstudio_Load(object sender, EventArgs e)
        {
            _EstudioBP = new EstudioBusiness(DaoFactory.GetEstudioDao());
            LoadList();
        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            _EstudioEntities = _EstudioBP.GetAll();
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //dgvList.DataSource = _PacienteEntities;
            this.EstudioObjectView.DataSource = (IList)this._EstudioEntities;
            this.dgvConsultas.DataSource = this.EstudioObjectView;
            ptbProgress.Visible = false;
            //Habilitar(true);
        }
        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //NHibernate.ICriteria kk = CreateCriteria(
            
        }
    }
}
