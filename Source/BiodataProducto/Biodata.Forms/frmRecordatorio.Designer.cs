namespace Mds.Biodata.Forms
{
    partial class frmRecordatorio
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblTipoVinculado = new System.Windows.Forms.Label();
            this.txtIDRecordatorio = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIDVinculado = new System.Windows.Forms.TextBox();
            this.dtpFechaRecordatorio = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoVinculado = new System.Windows.Forms.ComboBox();
            this.pnlList.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.cmbTipoVinculado);
            this.pnlDetails.Controls.Add(this.lblTipoVinculado);
            this.pnlDetails.Controls.Add(this.lbl);
            this.pnlDetails.Controls.Add(this.dtpFechaRecordatorio);
            this.pnlDetails.Controls.Add(this.txtDescripcion);
            this.pnlDetails.Controls.Add(this.txtIDRecordatorio);
            this.pnlDetails.Controls.Add(this.lblID);
            this.pnlDetails.Controls.Add(this.txtIDVinculado);
            this.pnlDetails.Controls.Add(this.lblFecha);
            this.pnlDetails.Controls.Add(this.lblDescripcion);
            this.pnlDetails.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblFecha, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtIDVinculado, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblID, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtIDRecordatorio, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtDescripcion, 0);
            this.pnlDetails.Controls.SetChildIndex(this.dtpFechaRecordatorio, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lbl, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblTipoVinculado, 0);
            this.pnlDetails.Controls.SetChildIndex(this.cmbTipoVinculado, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnAccept, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnCancel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblDeleteItem, 0);
            // 
            // btnAccept
            // 
            this.btnAccept.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnAccept_Click);
            // 
            // bgwLoad
            // 
            this.bgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoad_DoWork);
            this.bgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoad_RunWorkerCompleted);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(49, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(82, 13);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID Recordatorio";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(49, 125);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(49, 62);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(49, 152);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(67, 13);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "ID vinculado";
            // 
            // lblTipoVinculado
            // 
            this.lblTipoVinculado.AutoSize = true;
            this.lblTipoVinculado.Location = new System.Drawing.Point(49, 183);
            this.lblTipoVinculado.Name = "lblTipoVinculado";
            this.lblTipoVinculado.Size = new System.Drawing.Size(78, 13);
            this.lblTipoVinculado.TabIndex = 9;
            this.lblTipoVinculado.Text = "Tipo Vinculado";
            // 
            // txtIDRecordatorio
            // 
            this.txtIDRecordatorio.Location = new System.Drawing.Point(147, 24);
            this.txtIDRecordatorio.Name = "txtIDRecordatorio";
            this.txtIDRecordatorio.Size = new System.Drawing.Size(57, 20);
            this.txtIDRecordatorio.TabIndex = 10;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(147, 55);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(211, 50);
            this.txtDescripcion.TabIndex = 11;
            // 
            // txtIDVinculado
            // 
            this.txtIDVinculado.Location = new System.Drawing.Point(147, 145);
            this.txtIDVinculado.Name = "txtIDVinculado";
            this.txtIDVinculado.Size = new System.Drawing.Size(57, 20);
            this.txtIDVinculado.TabIndex = 12;
            // 
            // dtpFechaRecordatorio
            // 
            this.dtpFechaRecordatorio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaRecordatorio.Location = new System.Drawing.Point(147, 117);
            this.dtpFechaRecordatorio.Name = "dtpFechaRecordatorio";
            this.dtpFechaRecordatorio.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRecordatorio.TabIndex = 15;
            // 
            // cmbTipoVinculado
            // 
            this.cmbTipoVinculado.FormattingEnabled = true;
            this.cmbTipoVinculado.Location = new System.Drawing.Point(147, 177);
            this.cmbTipoVinculado.Name = "cmbTipoVinculado";
            this.cmbTipoVinculado.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoVinculado.TabIndex = 16;
            // 
            // frmRecordatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 509);
            this.Name = "frmRecordatorio";
            this.Text = "frmRecordatorio";
            this.Load += new System.EventHandler(this.frmRecordatorio_Load);
            this.pnlList.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTipoVinculado;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtIDVinculado;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIDRecordatorio;
        private System.Windows.Forms.DateTimePicker dtpFechaRecordatorio;
        private System.Windows.Forms.ComboBox cmbTipoVinculado;
    }
}