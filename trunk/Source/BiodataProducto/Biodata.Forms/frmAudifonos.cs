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

        private void InitializeObjectView()
        {
            this.AudifonoObjectView = new ObjectView(typeof(Audifono));
            this.AudifonoObjectView.AllowRemove = false;
            this.AudifonoObjectView.Columns.Add("NombreModelo", Translate("Nombre"));
            this.AudifonoObjectView.Columns.Add("IDMarcaLookup.Nombre", Translate("Marca"));
            this.AudifonoObjectView.Columns.Add("PresionMaximaSalida", Translate("Presión Salida"));

            this.AudifonoCurrencyManager = this.dgvList.BindingContext[this.AudifonoObjectView];
        }

        /// <summary>
        /// Carga el combo de marca de audifono y tipo de audifono
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
            cmbMarca.SelectedValue = AudifonoEntity.IDMarca;
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
            if (FranjaGrafico.Count > 0)
                linerFranjaAdaptacion.AutoGenerateLine(FranjaGrafico, FranjaGrafico.GetCurrentLineSeries());
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
        /// Valida datos basicos antes de enviar la entidad
        /// </summary>
        /// <returns></returns>
        private Boolean ValidData()
        {
            if (txtNombreModelo.Text == "" || txtNombreModelo.Text == null)
            {
                ProcesarAdvertencia("Debe ingresar el Nombre del modelo");
                return false;
            }
            if (!ValidarNumero(txtPresionSalida.Text))
            {
                ProcesarAdvertencia("La presión debe ser un valor numerico", "Presión");
                return false;
            }

            return true;
        }
        #endregion

        #region "--[Events]--"
        private void frmAudifonos_Load(object sender, EventArgs e)
        {
            _AudifonoBP = new AudifonoBusiness(DaoFactory.GetAudifonoDao());
            LoadCombos();
            LoadList(false);
        }

        public override void Accion()
        {
            try
            {
                linerFranjaAdaptacion.ClearSeries(false);
                pnlDetails.Visible = true;
                tbcAudifono.SelectedIndex = 0;
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
                        txtNombreModelo.Focus();
                        AudifonoEntity = new Audifono();
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

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!Convert.ToBoolean(e.Argument))
            {
                _AudifonoEntities = _AudifonoBP.GetAll();
            }
            else
            {
                //VER FILTROS
            }
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.AudifonoObjectView.DataSource = (IList)this._AudifonoEntities;
            this.dgvList.DataSource = this.AudifonoObjectView;
            ptbProgress.Visible = false;
            Habilitar(true);
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData())
                {
                    AudifonoEntity.NombreModelo = txtNombreModelo.Text;
                    AudifonoEntity.IDMarca = (Int32)cmbMarca.SelectedValue;
                    AudifonoEntity.Observacion = txtObservacion.Text;
                    AudifonoEntity.Tipo = Convert.ToInt32(cmbTipoAudifono.SelectedItem);
                    if (radDigital.Checked)
                    {
                        AudifonoEntity.Senal = 0; //Digital
                    }
                    else
                    {
                        AudifonoEntity.Senal = 1; //Analogico
                    }
                    AudifonoEntity.Programable = chkProgramable.Checked;
                    AudifonoEntity.PresionMaximaSalida = Convert.ToDecimal(txtPresionSalida.Text);

                    object myLineas;
                    object myLineasSeries;
                    linerFranjaAdaptacion.GenerateLinePointsArgs(out myLineas, out myLineasSeries);
                    String strLineasFranja = Mds.Architecture.HelpersFunctions.SerializationFunctions.Serialize(myLineas);
                    AudifonoEntity.FranjaAdaptacion = strLineasFranja;

                    switch (Estado)
                    {
                        case EstadoForm.Editar:
                            AudifonoBP.Update(AudifonoEntity);
                            AudifonoBP.Commit();
                            break;
                        case EstadoForm.Eliminar:
                            AudifonoBP.Delete(AudifonoEntity);
                            AudifonoBP.Commit();
                            break;
                        case EstadoForm.Nuevo:
                            AudifonoBP.Insert(AudifonoEntity);
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
        #endregion

    }
}
