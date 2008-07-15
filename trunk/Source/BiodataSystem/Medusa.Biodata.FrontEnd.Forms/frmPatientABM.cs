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
    public partial class frmPatientABM : frmABMBase
    {
        #region "--[Properties]--"
        private PatientEntities _Patients;

        public PatientEntities Patients
        {
            get { return _Patients; }
            set { _Patients = value; }
        }
        #endregion

        #region "--[Events]--"
        private void frmPatientABM_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Patients = PatientBusinessComponent.Search(new PatientEntity());
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvList.DataSource = Patients;
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
                        txtFirstName.Text = string.Empty;
                        txtLastName.Text = string.Empty;
                        txtDocumentType.Text = string.Empty;
                        txtDocumentType.Tag = string.Empty;
                        txtDocumentNumber.Text = string.Empty;
                        txtAddress.Text = string.Empty;
                        txtPhone.Text = string.Empty;
                        txtMobile.Text = string.Empty;
                        txtEmail.Text = string.Empty;
                        dtpDateBirth.Value = DateTime.Today;
                        txtProfession.Text = string.Empty;
                        txtHealthInsurance.Text = string.Empty;
                        txtFirstName.Focus();
                        break;

                    case EstadoForm.Editar:
                        if (dgvList.Rows.Count > 0)
                        {
                            txtID.Enabled = false;
                            LoadData();
                            txtFirstName.Focus();
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
                    PatientEntity wPatient = new PatientEntity();
                    wPatient.FirstName = txtFirstName.Text;
                    wPatient.LastName = txtLastName.Text;
                    wPatient.DocumentType.ID = Convert.ToInt32(txtDocumentType.Tag);
                    wPatient.DocumentNumber = txtDocumentNumber.Text;
                    wPatient.Address = txtAddress.Text;
                    wPatient.Phone = txtPhone.Text;
                    wPatient.Mobile = txtMobile.Text;
                    wPatient.Email = txtEmail.Text;
                    wPatient.DateBirth = dtpDateBirth.Value.Date;
                    wPatient.Profession = txtProfession.Text;
                    wPatient.HealthInsurance = txtHealthInsurance.Text;

                    switch (Estado)
                    {
                        case EstadoForm.Editar:
                            wPatient.ID = Convert.ToInt32(txtID.Text.Trim());
                            PatientBusinessComponent.Update(wPatient);
                            break;
                        case EstadoForm.Eliminar:
                            wPatient.ID = Convert.ToInt32(txtID.Text.Trim());
                            PatientBusinessComponent.Delete(wPatient);
                            break;
                        case EstadoForm.Nuevo:
                            PatientBusinessComponent.Insert(wPatient);
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

        private void btnOpenDocumentType_Click(object sender, EventArgs e)
        {
            try
            {
                txtDocumentType.Tag = string.Empty;
                txtDocumentType.Text = string.Empty;

                frmDocumentTypeABM frm = new frmDocumentTypeABM();
                frm.Llamador = this;
                this.Parent.Enabled = false;
                GereralFunctions.AbrirFormulario(frm, (TabControl)this.Parent.Parent, "Tipos de Documentos", DockStyle.Fill, false, true);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }

        }

        private void frmDocumentTypeABM_SeleccionCompleja(bool pCerrar)
        {
            if (pCerrar)
            {
                if ((this.Seleccion != null))
                {
                    if ((((DocumentTypeEntity)this.Seleccion).ID.HasValue))
                    {
                        txtDocumentType.Tag = ((DocumentTypeEntity)this.Seleccion).ID.Value;
                        txtDocumentType.Text = ((DocumentTypeEntity)this.Seleccion).Name.Trim().ToString();
                    }
                    else
                    {
                        txtDocumentType.Tag = string.Empty;
                        txtDocumentType.Text = string.Empty;
                    }
                }
                this.Seleccion = null;
            }
        } 


        #endregion

        #region "--[Methods]--"
        public frmPatientABM()
        {
            InitializeComponent();
        }

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

        private void LoadData()
        {
            PatientEntity wPatient = (PatientEntity)dgvList.CurrentRow.DataBoundItem;

            txtID.Text = wPatient.ID.Value.ToString();
            txtFirstName.Text = wPatient.FirstName;
            txtLastName.Text = wPatient.LastName;
            txtDocumentType.Text = wPatient.DocumentType.Name;
            txtDocumentType.Tag = wPatient.DocumentType.ID;
            txtDocumentNumber.Text = wPatient.DocumentNumber;
            txtAddress.Text = wPatient.Address;
            txtPhone.Text = wPatient.Phone;
            txtMobile.Text = wPatient.Mobile;
            txtEmail.Text = wPatient.Email;
            dtpDateBirth.Value = wPatient.DateBirth.Value;
            txtProfession.Text = wPatient.Profession;
            txtHealthInsurance.Text = wPatient.HealthInsurance;
        }

        private Boolean ValidData()
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Falta ingresar el nombre", "Nombre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtLastName.Text == "")
            {
                MessageBox.Show("Falta ingresar el apellido", "Apellido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtDocumentType.Tag.ToString() == "")
            {
                MessageBox.Show("Falta seleccionar el Tipo de Documento", "Tipo de Documento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtDocumentNumber.Text == "")
            {
                MessageBox.Show("Falta ingresar el Nro de Documento", "Nro de Documento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void BuildColumns()
        {
            try
            {
                dgvList.AutoGenerateColumns = false;
                dgvList.Columns.Clear();
                dgvList.Columns.Add("ID", "ID");
                dgvList.Columns[0].DataPropertyName = "ID";
                dgvList.Columns[0].Visible = false;
                dgvList.Columns.Add("Nombre", "Nombre");
                dgvList.Columns[1].DataPropertyName = "FirstName";
                dgvList.Columns.Add("Apellido", "Apellido");
                dgvList.Columns[2].DataPropertyName = "LastName";
                dgvList.Columns.Add("Telefono", "Telefono");
                dgvList.Columns[3].DataPropertyName = "Phone";
                dgvList.Columns.Add("Direccion", "Direccion");
                dgvList.Columns[4].DataPropertyName = "Address";
                dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        } 


        #endregion

    }
}
