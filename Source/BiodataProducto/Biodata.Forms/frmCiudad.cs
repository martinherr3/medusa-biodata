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
    public partial class frmCiudad : frmABMBase
    {
        public frmCiudad()
        {
            InitializeComponent();
        }

        #region "--[Properties]--"
        private CiudadBusiness _CiudadBP;

        public CiudadBusiness CiudadBP
        {
            get { return _CiudadBP; }
            set { _CiudadBP = value; }
        }

        private List<Ciudad> _CiudadEntities = new List<Ciudad>();

        public List<Ciudad> CiudadEntities
        {
            get { return _CiudadEntities; }
            set { _CiudadEntities = value; }
        }

        private Ciudad _CiudadEntity;

        public Ciudad CiudadEntity
        {
            get { return _CiudadEntity; }
            set { _CiudadEntity = value; }
        }

        private ObjectView _CiudadObjectView;

        public ObjectView CiudadObjectView
        {
            get { return _CiudadObjectView; }
            set { _CiudadObjectView = value; }
        }
        private BindingManagerBase _CiudadCurrencyManager;

        public BindingManagerBase CiudadCurrencyManager
        {
            get { return _CiudadCurrencyManager; }
            set { _CiudadCurrencyManager = value; }
        }

        //private Mds.Architecture.HelpersFunctions.Validators.Winforms.Validation.ViewValidator vvtor;

        #endregion

        #region "--[Methods]--"
        private void InitializeObjectView()
        {
            this.CiudadObjectView = new ObjectView(typeof(Ciudad));
            this.CiudadObjectView.AllowRemove = false;
            this.CiudadObjectView.Columns.Add("Descripcion", "Descripcion");
            this.CiudadObjectView.Columns.Add("IDProvinciaLookup.Descripcion", "Provincia");
     
            this.CiudadCurrencyManager = this.dgvList.BindingContext[this.CiudadObjectView];
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
            CiudadEntity = CiudadBP.GetById(((Ciudad)RowSelected.InnerObject).ID);

            txtID.Text = CiudadEntity.ID.ToString();
            txtDescripcion.Text = CiudadEntity.Descripcion;
            cmbProvincia.SelectedValue = CiudadEntity.IDProvincia;

        }

        /// <summary>
        /// Valida datos basicos antes de enviar la entidad
        /// </summary>
        /// <returns></returns>
        private Boolean ValidData()
        {
            if (txtDescripcion.Text == "" || txtDescripcion.Text == null)
            {
                ProcesarAdvertencia("Debe ingresar la advertencia del paciente");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Carga el combo de Provincia
        /// </summary>
        private void LoadCombos()
        {
            //Provincia
            ProvinciaBusiness ProvinciaBP = new ProvinciaBusiness(DaoFactory.GetProvinciaDao());
            List<Provincia> wProvinciaEntities = ProvinciaBP.GetAll();
            cmbProvincia.DataSource = wProvinciaEntities;

            cmbProvincia.ValueMember = "ID";
            cmbProvincia.DisplayMember = "Descripcion";
        }
        #endregion


        #region "--[Events]--"
        private void frmCiudad_Load(object sender, EventArgs e)
        {
            _CiudadBP = new CiudadBusiness(DaoFactory.GetCiudadDao());
            LoadCombos();
            LoadList();
        }
        
        #endregion

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            _CiudadEntities = _CiudadBP.GetAll();
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.CiudadObjectView.DataSource = (IList)this._CiudadEntities;
            this.dgvList.DataSource = this.CiudadObjectView;
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
                        txtDescripcion.Text = string.Empty;
                        cmbProvincia.SelectedValue = 1;
                        txtDescripcion.Focus();
                        CiudadEntity = new Ciudad();
                        break;

                    case EstadoForm.Editar:
                        if (dgvList.Rows.Count > 0)
                        {
                            txtID.Enabled = false;
                            LoadData();
                            txtDescripcion.Focus();
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
                    CiudadEntity.Descripcion = txtDescripcion.Text;
                    CiudadEntity.IDProvincia = (Int32)cmbProvincia.SelectedValue;

                    switch (Estado)
                    {
                        case EstadoForm.Editar:
                            CiudadBP.Update(CiudadEntity);
                            CiudadBP.Commit();
                            break;
                        case EstadoForm.Eliminar:
                            CiudadBP.Delete(CiudadEntity);
                            CiudadBP.Commit();
                            break;
                        case EstadoForm.Nuevo:
                            CiudadBP.Insert(CiudadEntity);
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvList.Rows.Count > 0)
                {
                    if (dgvList.CurrentRow == null)
                    {
                        this.Llamador.Seleccion = this.CiudadEntities[dgvList.Rows[0].Index];
                    }
                    else
                    {
                        this.Llamador.Seleccion = this.CiudadEntities[dgvList.CurrentRow.Index];
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
    }
}
