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
    public partial class frmAudifonos : frmABMBase
    {
        #region "--[Properties]--"
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

        #endregion

        #region "--[Methods]--"
        public frmAudifonos()
        {
            InitializeComponent();
        }

        private void frmAudifonos_Load(object sender, EventArgs e)
        {
            _AudifonoBP = new AudifonoBusiness(DaoFactory.GetAudifonoDao());
            LoadCombos();
            //LoadList();
        }

        private void InitializeObjectView()
        {
            this.AudifonoObjectView = new ObjectView(typeof(Audifono));
            this.AudifonoObjectView.AllowRemove = false;
            this.AudifonoObjectView.Columns.Add("NombreModelo", Translate("Nombre"));
            this.AudifonoObjectView.Columns.Add("Marca", Translate("Marca"));
            this.AudifonoObjectView.Columns.Add("Tipo", Translate("Tipo"));

            this.AudifonoCurrencyManager = this.dgvList.BindingContext[this.AudifonoObjectView];
        }

        /// <summary>
        /// Carga el combo de Provincia
        /// </summary>
        private void LoadCombos()
        {
            //Marca Audifonos
            MarcaAudifonoBusiness MarcaBP = new MarcaAudifonoBusiness(DaoFactory.GetMarcaAudifonoDao());
            List<MarcaAudifono> wMarcaEntities = MarcaBP.GetAll();
            cmbMarca.DataSource = wMarcaEntities;

            cmbMarca.ValueMember = "ID";
            cmbMarca.DisplayMember = "Nombre";

            //Tipo de Documento
            cmbTipoAudifono.DataSource = Enum.GetValues(typeof(Enumeraciones.TipoAudifono));
        }

        /// <summary>
        /// Carga la entidad (registro) seleccionada en los controles
        /// </summary>
        private void LoadData()
        {
            ObjectViews.ObjectViewRow RowSelected = (ObjectViewRow)dgvList.CurrentRow.DataBoundItem;
            AudifonoEntity = AudifonoBP.GetById(((Audifono)RowSelected.InnerObject).ID);

            txtID.Text = AudifonoEntity.ID.ToString();
            txtNombreModelo.Text = AudifonoEntity.NombreModelo;
            cmbMarca.SelectedValue = AudifonoEntity.Marca;
            txtObservacion.Text = AudifonoEntity.Observacion;
            cmbTipoAudifono.SelectedItem = (Enumeraciones.TipoAudifono)AudifonoEntity.Tipo;
            if (AudifonoEntity.Senal == 0)
            {
                radDigital.Checked = true;
            }
            else
            {
                radAnalogico.Checked = true;
            }
            chkProgramable.Checked = AudifonoEntity.Programable.Value;
            txtPresionSalida.Text = AudifonoEntity.PresionMaximaSalida.ToString();

            Liner.Main.Collections.Collection FranjaGrafico;
            FranjaGrafico = (Liner.Main.Collections.Collection)Mds.Architecture.HelpersFunctions.SerializationFunctions.Deserialize(typeof(Liner.Main.Collections.Collection), AudifonoEntity.FranjaAdaptacion);

            linerFranjaAdaptacion.AutoGenerateLine(FranjaGrafico, FranjaGrafico.GetCurrentLineSeries());
        }
        #endregion

        #region "--[Events]--"
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
                        txtNombreModelo.Text = string.Empty;
                        txtObservacion.Text = string.Empty;
                        cmbTipoAudifono.SelectedItem = Enumeraciones.TipoAudifono.Retroauricular;
                        radDigital.Checked = true;
                        chkProgramable.Checked = false;
                        txtPresionSalida.Text = string.Empty;
                        linerFranjaAdaptacion.ClearSeries(true);    
                        txtNombreModelo.Focus();
                        break;

                    case EstadoForm.Editar:
                        if (dgvList.Rows.Count > 0)
                        {
                            txtID.Enabled = false;
                            LoadData();
                            txtNombreModelo.Focus();
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
