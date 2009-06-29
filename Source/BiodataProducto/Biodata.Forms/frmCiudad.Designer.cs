namespace Mds.Biodata.Forms
{
    partial class frmCiudad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCiudad));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.pnlList.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeleteItem
            // 
            this.lblDeleteItem.AccessibleDescription = null;
            this.lblDeleteItem.AccessibleName = null;
            resources.ApplyResources(this.lblDeleteItem, "lblDeleteItem");
            // 
            // pnlList
            // 
            this.pnlList.AccessibleDescription = null;
            this.pnlList.AccessibleName = null;
            resources.ApplyResources(this.pnlList, "pnlList");
            this.pnlList.BackgroundImage = null;
            this.pnlList.Font = null;
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = null;
            this.btnClose.AccessibleName = null;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BackgroundImage = null;
            this.btnClose.Font = null;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = null;
            this.btnDelete.AccessibleName = null;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BackgroundImage = null;
            this.btnDelete.Font = null;
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleDescription = null;
            this.btnEdit.AccessibleName = null;
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.BackgroundImage = null;
            this.btnEdit.Font = null;
            // 
            // btnNew
            // 
            this.btnNew.AccessibleDescription = null;
            this.btnNew.AccessibleName = null;
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.BackgroundImage = null;
            this.btnNew.Font = null;
            // 
            // btnSelect
            // 
            this.btnSelect.AccessibleDescription = null;
            this.btnSelect.AccessibleName = null;
            resources.ApplyResources(this.btnSelect, "btnSelect");
            this.btnSelect.BackgroundImage = null;
            this.btnSelect.Font = null;
            this.btnSelect.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnSelect_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.AccessibleDescription = null;
            this.pnlDetails.AccessibleName = null;
            resources.ApplyResources(this.pnlDetails, "pnlDetails");
            this.pnlDetails.BackgroundImage = null;
            this.pnlDetails.Controls.Add(this.lblProvincia);
            this.pnlDetails.Controls.Add(this.lblDescripcion);
            this.pnlDetails.Controls.Add(this.lblID);
            this.pnlDetails.Controls.Add(this.cmbProvincia);
            this.pnlDetails.Controls.Add(this.txtDescripcion);
            this.pnlDetails.Controls.Add(this.txtID);
            this.pnlDetails.Font = null;
            this.pnlDetails.Controls.SetChildIndex(this.txtID, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnAccept, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnCancel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblDeleteItem, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.pnlDetails.Controls.SetChildIndex(this.cmbProvincia, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblID, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblProvincia, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = null;
            this.btnCancel.AccessibleName = null;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackgroundImage = null;
            this.btnCancel.Font = null;
            // 
            // btnAccept
            // 
            this.btnAccept.AccessibleDescription = null;
            this.btnAccept.AccessibleName = null;
            resources.ApplyResources(this.btnAccept, "btnAccept");
            this.btnAccept.BackgroundImage = null;
            this.btnAccept.Font = null;
            this.btnAccept.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnAccept_Click);
            // 
            // bgwLoad
            // 
            this.bgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoad_DoWork);
            this.bgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoad_RunWorkerCompleted);
            // 
            // txtID
            // 
            this.txtID.AccessibleDescription = null;
            this.txtID.AccessibleName = null;
            resources.ApplyResources(this.txtID, "txtID");
            this.txtID.BackgroundImage = null;
            this.txtID.Font = null;
            this.txtID.Name = "txtID";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AccessibleDescription = null;
            this.txtDescripcion.AccessibleName = null;
            resources.ApplyResources(this.txtDescripcion, "txtDescripcion");
            this.txtDescripcion.BackgroundImage = null;
            this.txtDescripcion.Font = null;
            this.txtDescripcion.Name = "txtDescripcion";
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.AccessibleDescription = null;
            this.cmbProvincia.AccessibleName = null;
            resources.ApplyResources(this.cmbProvincia, "cmbProvincia");
            this.cmbProvincia.BackgroundImage = null;
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.Font = null;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Name = "cmbProvincia";
            // 
            // lblID
            // 
            this.lblID.AccessibleDescription = null;
            this.lblID.AccessibleName = null;
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Font = null;
            this.lblID.Name = "lblID";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AccessibleDescription = null;
            this.lblDescripcion.AccessibleName = null;
            resources.ApplyResources(this.lblDescripcion, "lblDescripcion");
            this.lblDescripcion.Font = null;
            this.lblDescripcion.Name = "lblDescripcion";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AccessibleDescription = null;
            this.lblProvincia.AccessibleName = null;
            resources.ApplyResources(this.lblProvincia, "lblProvincia");
            this.lblProvincia.Font = null;
            this.lblProvincia.Name = "lblProvincia";
            // 
            // frmCiudad
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Font = null;
            this.Icon = null;
            this.Name = "frmCiudad";
            this.Load += new System.EventHandler(this.frmCiudad_Load);
            this.pnlList.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblDescripcion;
    }
}