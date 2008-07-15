namespace Medusa.Biodata.FrontEnd.Forms
{
    partial class frmDocumentTypeABM
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlList.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeleteItem
            // 
            this.lblDeleteItem.Location = new System.Drawing.Point(251, 207);
            // 
            // btnSelect
            // 
            this.btnSelect.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnSelect_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.txtDescription);
            this.pnlDetails.Controls.Add(this.lblDescription);
            this.pnlDetails.Controls.Add(this.txtName);
            this.pnlDetails.Controls.Add(this.lblName);
            this.pnlDetails.Controls.Add(this.txtID);
            this.pnlDetails.Controls.Add(this.lblID);
            this.pnlDetails.Size = new System.Drawing.Size(442, 273);
            this.pnlDetails.Controls.SetChildIndex(this.lblID, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtID, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnAccept, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnCancel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblDeleteItem, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblName, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtName, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblDescription, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtDescription, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(338, 243);
            this.btnCancel.TabIndex = 9;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(219, 243);
            this.btnAccept.TabIndex = 8;
            this.btnAccept.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnAccept_Click);
            // 
            // bgwLoad
            // 
            this.bgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoad_DoWork);
            this.bgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoad_RunWorkerCompleted);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(96, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 20);
            this.txtID.TabIndex = 5;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(72, 37);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 6;
            this.lblID.Text = "ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(96, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 20);
            this.txtName.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(46, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nombre";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(96, 115);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(227, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 118);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Descripcion";
            // 
            // frmDocumentTypeABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 509);
            this.Name = "frmDocumentTypeABM";
            this.Text = "frmDocumentTypeABM";
            this.BotonClick += new Medusa.Biodata.FrontEnd.Forms.frmABMBase.BotonClickEventHandler(this.Accion);
            this.Load += new System.EventHandler(this.frmDocumentTypeABM_Load);
            this.pnlList.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
    }
}