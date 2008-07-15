using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medusa.Biodata.BackEnd.BusinessComponents;
using Medusa.Biodata.Common.BusinessEntities;

namespace Medusa.Biodata.FrontEnd.Forms
{
    public partial class frmProductTypeABM : frmABMBase
    {
        #region "--[Properties]--"
        private ProductTypeEntities _ProductTypes;

        public ProductTypeEntities ProductTypes
        {
            get { return _ProductTypes; }
            set { _ProductTypes = value; }
        }

        #endregion

        #region "--[Events]--"
        private void frmProductTypeABM_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            this.ProductTypes = ProductTypeBusinessComponent.Search(new ProductTypeEntity());
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvList.DataSource = ProductTypes;
            ptbProgress.Visible = false;
            Habilitar(true);
        }

        private void Accion()
        {
            try
            {
                pnlDetails.Visible = true;

                switch (Estado)
                {
                    case EstadoForm.Nuevo:
                        txtID.Text = string.Empty;
                        txtID.Enabled = false;
                        txtName.Text = string.Empty;
                        txtDescription.Text = string.Empty;
                        txtName.Focus();
                        break;

                    case EstadoForm.Editar:
                        if (dgvList.Rows.Count > 0)
                        {
                            txtID.Enabled = false;
                            LoadData();
                            txtName.Focus();
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
                    ProductTypeEntity wProductType = new ProductTypeEntity();
                    wProductType.Name = txtName.Text;
                    wProductType.Description = txtDescription.Text;

                    switch (Estado)
                    {
                        case EstadoForm.Editar:
                            wProductType.ID = Convert.ToInt32(txtID.Text.Trim());
                            ProductTypeBusinessComponent.Update(wProductType);
                            break;
                        case EstadoForm.Eliminar:
                            wProductType.ID = Convert.ToInt32(txtID.Text.Trim());
                            ProductTypeBusinessComponent.Delete(wProductType);
                            break;
                        case EstadoForm.Nuevo:
                            ProductTypeBusinessComponent.Insert(wProductType);
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

        #region "--[Methods]--"

        public frmProductTypeABM()
        {
            InitializeComponent();
        }

        private void LoadList()
        {
            try
            {
                ptbProgress.Visible = true;
                //CrearColumnas();
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

        private void LoadData()
        {
            ProductTypeEntity wProductType = (ProductTypeEntity)dgvList.CurrentRow.DataBoundItem;

            txtID.Text = wProductType.ID.Value.ToString();
            txtName.Text = wProductType.Name;
            txtDescription.Text = wProductType.Description;
        }

        private Boolean ValidData()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Falta ingresar el nombre", "Nombre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Falta ingresar la Descripcion", "Descripcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        #endregion
    }
}
