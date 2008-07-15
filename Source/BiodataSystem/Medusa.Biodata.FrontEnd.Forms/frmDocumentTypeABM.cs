using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medusa.Biodata.Common.BusinessEntities;
using Medusa.Biodata.BackEnd.BusinessComponents;

namespace Medusa.Biodata.FrontEnd.Forms
{
    public partial class frmDocumentTypeABM : frmABMBase
    {

        #region "--[Properties]--"
        private DocumentTypeEntities _Documents;

        public DocumentTypeEntities Documents
        {
            get { return _Documents; }
            set { _Documents = value; }
        }

        #endregion

        #region "--[Events]--"

        private void frmDocumentTypeABM_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Documents = DocumentTypeBusinessComponent.Search(new DocumentTypeEntity());
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvList.DataSource = Documents;
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
                    DocumentTypeEntity wDocument = new DocumentTypeEntity();
                    wDocument.Name = txtName.Text;
                    wDocument.Description = txtDescription.Text;

                    switch (Estado)
                    {
                        case EstadoForm.Editar:
                            wDocument.ID = Convert.ToInt32(txtID.Text.Trim());
                            DocumentTypeBusinessComponent.Update(wDocument);
                            break;
                        case EstadoForm.Eliminar:
                            wDocument.ID = Convert.ToInt32(txtID.Text.Trim());
                            DocumentTypeBusinessComponent.Delete(wDocument);
                            break;
                        case EstadoForm.Nuevo:
                            DocumentTypeBusinessComponent.Insert(wDocument);
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
                        this.Llamador.Seleccion = this.Documents[dgvList.Rows[0].Index];
                    }
                    else
                    {
                        this.Llamador.Seleccion = this.Documents[dgvList.CurrentRow.Index];
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

        #region "--[Methods]--"

        public frmDocumentTypeABM()
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
            DocumentTypeEntity wDocument = (DocumentTypeEntity)dgvList.CurrentRow.DataBoundItem;

            txtID.Text = wDocument.ID.Value.ToString();
            txtName.Text = wDocument.Name;
            txtDescription.Text = wDocument.Description;
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
