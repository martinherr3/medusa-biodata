namespace Mds.Biodata.Forms
{
    partial class frmMoldeAudifono
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
            this.txtMedidaVentilacion = new System.Windows.Forms.TextBox();
            this.cmbTipoMolde = new System.Windows.Forms.ComboBox();
            this.lblTipoMolde = new System.Windows.Forms.Label();
            this.lblMedidaVentilacion = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.chkVentilacion = new System.Windows.Forms.CheckBox();
            this.dtpFechaRenovacion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFabricacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaRenovacion = new System.Windows.Forms.Label();
            this.lblFechaFabricacion = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlList.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeleteItem
            // 
            this.lblDeleteItem.Location = new System.Drawing.Point(218, 256);
            // 
            // btnSelect
            // 
            this.btnSelect.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnSelect_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.txtNombre);
            this.pnlDetails.Controls.Add(this.lblNombre);
            this.pnlDetails.Controls.Add(this.txtID);
            this.pnlDetails.Controls.Add(this.lblID);
            this.pnlDetails.Controls.Add(this.lblFechaFabricacion);
            this.pnlDetails.Controls.Add(this.lblFechaRenovacion);
            this.pnlDetails.Controls.Add(this.dtpFechaFabricacion);
            this.pnlDetails.Controls.Add(this.dtpFechaRenovacion);
            this.pnlDetails.Controls.Add(this.chkVentilacion);
            this.pnlDetails.Controls.Add(this.cmbMaterial);
            this.pnlDetails.Controls.Add(this.lblMaterial);
            this.pnlDetails.Controls.Add(this.txtMedidaVentilacion);
            this.pnlDetails.Controls.Add(this.cmbTipoMolde);
            this.pnlDetails.Controls.Add(this.lblTipoMolde);
            this.pnlDetails.Controls.Add(this.lblMedidaVentilacion);
            this.pnlDetails.Size = new System.Drawing.Size(411, 328);
            this.pnlDetails.Controls.SetChildIndex(this.btnAccept, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnCancel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblDeleteItem, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblMedidaVentilacion, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblTipoMolde, 0);
            this.pnlDetails.Controls.SetChildIndex(this.cmbTipoMolde, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtMedidaVentilacion, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblMaterial, 0);
            this.pnlDetails.Controls.SetChildIndex(this.cmbMaterial, 0);
            this.pnlDetails.Controls.SetChildIndex(this.chkVentilacion, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtpFechaRenovacion, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtpFechaFabricacion, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblFechaRenovacion, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblFechaFabricacion, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblID, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtID, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblNombre, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtNombre, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(305, 292);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(186, 292);
            this.btnAccept.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnAccept_Click);
            // 
            // bgwLoad
            // 
            this.bgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoad_DoWork);
            this.bgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoad_RunWorkerCompleted);
            // 
            // txtMedidaVentilacion
            // 
            this.txtMedidaVentilacion.Location = new System.Drawing.Point(124, 161);
            this.txtMedidaVentilacion.Name = "txtMedidaVentilacion";
            this.txtMedidaVentilacion.Size = new System.Drawing.Size(132, 20);
            this.txtMedidaVentilacion.TabIndex = 38;
            // 
            // cmbTipoMolde
            // 
            this.cmbTipoMolde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoMolde.FormattingEnabled = true;
            this.cmbTipoMolde.Location = new System.Drawing.Point(124, 84);
            this.cmbTipoMolde.Name = "cmbTipoMolde";
            this.cmbTipoMolde.Size = new System.Drawing.Size(201, 21);
            this.cmbTipoMolde.TabIndex = 40;
            // 
            // lblTipoMolde
            // 
            this.lblTipoMolde.AutoSize = true;
            this.lblTipoMolde.Location = new System.Drawing.Point(43, 87);
            this.lblTipoMolde.Name = "lblTipoMolde";
            this.lblTipoMolde.Size = new System.Drawing.Size(75, 13);
            this.lblTipoMolde.TabIndex = 42;
            this.lblTipoMolde.Text = "Tipo de Molde";
            // 
            // lblMedidaVentilacion
            // 
            this.lblMedidaVentilacion.AutoSize = true;
            this.lblMedidaVentilacion.Location = new System.Drawing.Point(6, 164);
            this.lblMedidaVentilacion.Name = "lblMedidaVentilacion";
            this.lblMedidaVentilacion.Size = new System.Drawing.Size(112, 13);
            this.lblMedidaVentilacion.TabIndex = 41;
            this.lblMedidaVentilacion.Text = "Medida de Ventilación";
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(124, 111);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(201, 21);
            this.cmbMaterial.TabIndex = 44;
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(74, 114);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(44, 13);
            this.lblMaterial.TabIndex = 45;
            this.lblMaterial.Text = "Material";
            // 
            // chkVentilacion
            // 
            this.chkVentilacion.AutoSize = true;
            this.chkVentilacion.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.chkVentilacion.Location = new System.Drawing.Point(60, 138);
            this.chkVentilacion.Name = "chkVentilacion";
            this.chkVentilacion.Size = new System.Drawing.Size(78, 17);
            this.chkVentilacion.TabIndex = 46;
            this.chkVentilacion.Text = "Ventilación";
            this.chkVentilacion.UseVisualStyleBackColor = true;
            // 
            // dtpFechaRenovacion
            // 
            this.dtpFechaRenovacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRenovacion.Location = new System.Drawing.Point(124, 190);
            this.dtpFechaRenovacion.Name = "dtpFechaRenovacion";
            this.dtpFechaRenovacion.Size = new System.Drawing.Size(132, 20);
            this.dtpFechaRenovacion.TabIndex = 47;
            // 
            // dtpFechaFabricacion
            // 
            this.dtpFechaFabricacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFabricacion.Location = new System.Drawing.Point(124, 220);
            this.dtpFechaFabricacion.Name = "dtpFechaFabricacion";
            this.dtpFechaFabricacion.Size = new System.Drawing.Size(132, 20);
            this.dtpFechaFabricacion.TabIndex = 48;
            // 
            // lblFechaRenovacion
            // 
            this.lblFechaRenovacion.AutoSize = true;
            this.lblFechaRenovacion.Location = new System.Drawing.Point(5, 194);
            this.lblFechaRenovacion.Name = "lblFechaRenovacion";
            this.lblFechaRenovacion.Size = new System.Drawing.Size(113, 13);
            this.lblFechaRenovacion.TabIndex = 49;
            this.lblFechaRenovacion.Text = "Fecha de Renovación";
            // 
            // lblFechaFabricacion
            // 
            this.lblFechaFabricacion.AutoSize = true;
            this.lblFechaFabricacion.Location = new System.Drawing.Point(8, 224);
            this.lblFechaFabricacion.Name = "lblFechaFabricacion";
            this.lblFechaFabricacion.Size = new System.Drawing.Size(110, 13);
            this.lblFechaFabricacion.TabIndex = 50;
            this.lblFechaFabricacion.Text = "Fecha de Fabricación";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(65, 20);
            this.txtID.TabIndex = 51;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(104, 26);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 52;
            this.lblID.Text = "ID";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 20);
            this.txtNombre.TabIndex = 53;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(74, 52);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 54;
            this.lblNombre.Text = "Nombre";
            // 
            // frmMoldeAudifono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 564);
            this.Name = "frmMoldeAudifono";
            this.Text = "frmMoldeAudifono";
            this.Load += new System.EventHandler(this.frmMoldeAudifono_Load);
            this.pnlList.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtMedidaVentilacion;
        private System.Windows.Forms.ComboBox cmbTipoMolde;
        private System.Windows.Forms.Label lblTipoMolde;
        private System.Windows.Forms.Label lblMedidaVentilacion;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.CheckBox chkVentilacion;
        private System.Windows.Forms.DateTimePicker dtpFechaRenovacion;
        private System.Windows.Forms.Label lblFechaFabricacion;
        private System.Windows.Forms.Label lblFechaRenovacion;
        private System.Windows.Forms.DateTimePicker dtpFechaFabricacion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}