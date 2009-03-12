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

namespace Mds.Biodata.Forms
{
    public partial class frmObraSocial : frmABMBase
    {
        #region "--[Properties]--"
        private ObraSocialBusiness _ObraSocialBP;

        public ObraSocialBusiness ObraSocialBP
        {
            get { return _ObraSocialBP; }
            set { _ObraSocialBP = value; }
        }
        private List<ObraSocial> _ObrasSocialesEntities = new List<ObraSocial>();

        public List<ObraSocial> ObrasSocialesEntities
        {
            get { return _ObrasSocialesEntities; }
            set { _ObrasSocialesEntities = value; }
        }

        private ObraSocial _ObraSocialEntity;

        public ObraSocial ObraSocialEntity
        {
            get { return _ObraSocialEntity; }
            set { _ObraSocialEntity = value; }
        }

        #endregion

        #region "--[Methods]--"
        public frmObraSocial()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Da formato a la grilla
        /// </summary>
        private void BuildColumns()
        {
            try
            {
                dgvList.AutoGenerateColumns = false;
                dgvList.Columns.Clear();
                dgvList.Columns.Add("IDObraSocial", "IDObraSocial");
                dgvList.Columns[0].DataPropertyName = "IDObraSocial";
                dgvList.Columns[0].Visible = false;
                dgvList.Columns.Add("RazonSocial", "RazonSocial");
                dgvList.Columns[1].DataPropertyName = "RazonSocial";
                dgvList.Columns.Add("Direccion", "Direccion");
                dgvList.Columns[2].DataPropertyName = "Direccion";
                dgvList.Columns.Add("Telefono", "Telefono");
                dgvList.Columns[3].DataPropertyName = "Telefono";
                dgvList.Columns.Add("Contacto", "Contacto");
                dgvList.Columns[4].DataPropertyName = "Contacto";
                dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        /// <summary>
        /// Carga la grilla con los registros de la DB
        /// </summary>
        private void LoadList()
        {
            try
            {
                ptbProgress.Visible = true;
                BuildColumns();
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
            ObraSocialEntity = ObraSocialBP.GetById(((ObraSocial)dgvList.CurrentRow.DataBoundItem).ID);

            txtID.Text = ObraSocialEntity.ID.ToString();
            txtRazonSocial.Text = ObraSocialEntity.RazonSocial;
            txtDireccion.Text = ObraSocialEntity.Direccion;
            txtTelefono.Text = ObraSocialEntity.Telefono;
            txtContacto.Text = ObraSocialEntity.Contacto;
            txtCUIT.Text = ObraSocialEntity.CUIT;
            txtCorreoElectronico.Text = ObraSocialEntity.CorreoElectronico;
            txtPaginaWeb.Text = ObraSocialEntity.PaginaWeb;
        }

        /// <summary>
        /// Valida datos basicos antes de enviar la entidad
        /// </summary>
        /// <returns></returns>
        private Boolean ValidData()
        {
            if (txtRazonSocial.Text == "" || txtRazonSocial.Text == null)
            {
                ProcesarAdvertencia("Debe ingresar Razón Social");
                return false;
            }
            return true;
        }
        #endregion

        #region "--[Events]--"
        private void frmObraSocial_Load(object sender, EventArgs e)
        {
            _ObraSocialBP = new ObraSocialBusiness(DaoFactory.GetObraSocialDao());
            LoadList();
        }

        
        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            _ObrasSocialesEntities = _ObraSocialBP.GetAll();
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvList.DataSource = _ObrasSocialesEntities;
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
                        txtRazonSocial.Text = string.Empty;
                        txtDireccion.Text = string.Empty;
                        txtTelefono.Text = string.Empty;
                        txtContacto.Text = string.Empty;
                        txtCUIT.Text = string.Empty;
                        txtCorreoElectronico.Text = string.Empty;
                        txtPaginaWeb.Text = string.Empty;
                        txtRazonSocial.Focus();
                        ObraSocialEntity = new ObraSocial();
                        break;

                    case EstadoForm.Editar:
                        if (dgvList.Rows.Count > 0)
                        {
                            txtID.Enabled = false;
                            LoadData();
                            txtRazonSocial.Focus();
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

                    ObraSocialEntity.RazonSocial = txtRazonSocial.Text;
                    ObraSocialEntity.Direccion = txtDireccion.Text;
                    ObraSocialEntity.Telefono = txtTelefono.Text;
                    ObraSocialEntity.Contacto = txtContacto.Text;
                    ObraSocialEntity.CUIT = txtCUIT.Text;
                    ObraSocialEntity.CorreoElectronico = txtCorreoElectronico.Text;
                    ObraSocialEntity.PaginaWeb = txtPaginaWeb.Text;


                    switch (Estado)
                    {
                        case EstadoForm.Editar:
                            ObraSocialBP.Update(ObraSocialEntity);
                            ObraSocialBP.Commit();
                            break;
                        case EstadoForm.Eliminar:
                            ObraSocialBP.Delete(ObraSocialEntity);
                            ObraSocialBP.Commit();
                            break;
                        case EstadoForm.Nuevo:
                            ObraSocialBP.Insert(ObraSocialEntity);
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
        #endregion
    }
}
