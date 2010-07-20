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
    public partial class frmMoldeAudifono : frmABMBase
    {
        #region "--[Properties]--"
        private MoldeAudifonoBusiness _MoldeAudifonoBP;

        public MoldeAudifonoBusiness MoldeAudifonoBP
        {
            get { return _MoldeAudifonoBP; }
            set { _MoldeAudifonoBP = value; }
        }

        private List<MoldeAudifono> _MoldeAudifonoEntities = new List<MoldeAudifono>();

        public List<MoldeAudifono> MoldeAudifonoEntities
        {
            get { return _MoldeAudifonoEntities; }
            set { _MoldeAudifonoEntities = value; }
        }

        private MoldeAudifono _MoldeAudifonoEntity;

        public MoldeAudifono MoldeAudifonoEntity
        {
            get { return _MoldeAudifonoEntity; }
            set { _MoldeAudifonoEntity = value; }
        }

        private ObjectView _MoldeAudifonoObjectView;

        public ObjectView MoldeAudifonoObjectView
        {
            get { return _MoldeAudifonoObjectView; }
            set { _MoldeAudifonoObjectView = value; }
        }

        private BindingManagerBase _MoldeAudifonoCurrencyManager;

        public BindingManagerBase MoldeAudifonoCurrencyManager
        {
            get { return _MoldeAudifonoCurrencyManager; }
            set { _MoldeAudifonoCurrencyManager = value; }
        }
        #endregion

        #region "--[Methods]--"
        public frmMoldeAudifono()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Da formato a la grilla y crea lo necesario para el bindeo
        /// </summary>
        private void InitializeObjectView()
        {
            this.MoldeAudifonoObjectView = new ObjectView(typeof(MoldeAudifono));
            this.MoldeAudifonoObjectView.AllowRemove = false;
            this.MoldeAudifonoObjectView.Columns.Add("ID", "ID");
            this.MoldeAudifonoObjectView.Columns.Add("Nombre", "Nombre");
            this.MoldeAudifonoObjectView.Columns.Add("TipoValue", "Tipo");
            this.MoldeAudifonoObjectView.Columns.Add("MedidaVentilacion", "Medida de Ventilación");
            this.MoldeAudifonoCurrencyManager = this.dgvList.BindingContext[this.MoldeAudifonoObjectView];
        }

        /// <summary>
        /// Carga la grilla con los registros de la DB
        /// </summary>
        private void LoadList(Boolean ContarParametrosBusqueda)
        {
            try
            {
                ptbProgress.Visible = true;
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
            MoldeAudifonoEntity = MoldeAudifonoBP.GetById(((MoldeAudifono)RowSelected.InnerObject).ID);

            txtID.Text = MoldeAudifonoEntity.ID.ToString();
            txtNombre.Text = MoldeAudifonoEntity.Nombre;
            cmbTipoMolde.SelectedItem = (Enumeraciones.TipoMolde)MoldeAudifonoEntity.Tipo;
            cmbMaterial.SelectedItem = (Enumeraciones.MaterialMolde)MoldeAudifonoEntity.Material;
            chkVentilacion.Checked = MoldeAudifonoEntity.Ventilacion;
            txtMedidaVentilacion.Text = MoldeAudifonoEntity.MedidaVentilacion.ToString();
            dtpFechaRenovacion.Value = MoldeAudifonoEntity.FechaRenovacion.Value;
            dtpFechaFabricacion.Value = MoldeAudifonoEntity.FechaFabricacion.Value;
        }

        /// <summary>
        /// Valida datos basicos antes de enviar la entidad
        /// </summary>
        /// <returns></returns>
        private Boolean ValidData()
        {
            //Las propiedades ingresadas por el usuario a validar son "Tipo", "Material" y "Ventilacion"
            //las cuales, por el tipo de control de UI, no hacen falta validar

            if (txtNombre.Text == "" || txtNombre.Text == null)
            {
                ProcesarAdvertencia("Debe ingresar el Nombre del Modelo");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Carga los combos de Tipo de Molde y Material de Molde
        /// </summary>
        private void LoadCombos()
        {
            try
            {
                //Tipo de Molde
                cmbTipoMolde.DataSource = Enum.GetValues(typeof(Enumeraciones.TipoMolde));
                //Material de Molde
                cmbMaterial.DataSource = Enum.GetValues(typeof(Enumeraciones.MaterialMolde));
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
        #endregion

        #region "--[Events]--"
        private void frmMoldeAudifono_Load(object sender, EventArgs e)
        {
            _MoldeAudifonoBP = new MoldeAudifonoBusiness(DaoFactory.GetMoldeAudifonoDao());
            LoadCombos();
            LoadList(false);
        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!Convert.ToBoolean(e.Argument))
            {
                _MoldeAudifonoEntities = _MoldeAudifonoBP.GetAll();
            }
            else
            {
                //Si existieran filtros
            }
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.MoldeAudifonoObjectView.DataSource = (IList)this._MoldeAudifonoEntities;
            this.dgvList.DataSource = this.MoldeAudifonoObjectView;
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
                        cmbTipoMolde.SelectedItem = Enumeraciones.TipoMolde.FullShell;
                        cmbMaterial.SelectedItem = Enumeraciones.MaterialMolde.Siliconado;
                        chkVentilacion.Checked = false;
                        txtMedidaVentilacion.Text = string.Empty;
                        dtpFechaRenovacion.Value = DateTime.Now;
                        dtpFechaFabricacion.Value = DateTime.Now;

                        txtNombre.Focus();
                        MoldeAudifonoEntity = new MoldeAudifono();
                        break;

                    case EstadoForm.Editar:
                        if (dgvList.Rows.Count > 0)
                        {
                            txtID.Enabled = false;
                            LoadData();
                            cmbTipoMolde.Focus();
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
                    MoldeAudifonoEntity.Tipo = Convert.ToInt32(cmbTipoMolde.SelectedItem);
                    MoldeAudifonoEntity.Nombre = txtNombre.Text;
                    MoldeAudifonoEntity.Material = Convert.ToInt32(cmbMaterial.SelectedItem);
                    MoldeAudifonoEntity.Ventilacion = chkVentilacion.Checked;
                    MoldeAudifonoEntity.MedidaVentilacion = Convert.ToDecimal(txtMedidaVentilacion.Text);
                    MoldeAudifonoEntity.FechaRenovacion = dtpFechaRenovacion.Value;
                    MoldeAudifonoEntity.FechaFabricacion = dtpFechaFabricacion.Value;


                    switch (Estado)
                    {
                        case EstadoForm.Editar:
                            MoldeAudifonoBP.Update(MoldeAudifonoEntity);
                            MoldeAudifonoBP.Commit();
                            break;
                        case EstadoForm.Eliminar:
                            MoldeAudifonoBP.Delete(MoldeAudifonoEntity);
                            MoldeAudifonoBP.Commit();
                            break;
                        case EstadoForm.Nuevo:
                            MoldeAudifonoBP.Insert(MoldeAudifonoEntity);
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.Rows.Count > 0)
                {
                    if (dgvList.CurrentRow == null)
                    {
                        this.Llamador.Seleccion = this.MoldeAudifonoEntities[dgvList.Rows[0].Index];
                    }
                    else
                    {
                        this.Llamador.Seleccion = this.MoldeAudifonoEntities[dgvList.CurrentRow.Index];
                    }
                }
                else
                {
                    this.Llamador.Seleccion = null;
                }
                Cerrar();
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
        #endregion

    }
}
