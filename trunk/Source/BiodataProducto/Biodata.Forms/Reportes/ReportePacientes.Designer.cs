namespace Mds.Biodata.Forms.Reportes
{
    partial class ReportePacientes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportePacientes));
            this.gpbFiltros = new System.Windows.Forms.GroupBox();
            this.lblCiudadBuscar = new System.Windows.Forms.Label();
            this.cmbCiudadBuscar = new System.Windows.Forms.ComboBox();
            this.txtDocumentoBuscar = new System.Windows.Forms.TextBox();
            this.lblDocumentoBuscar = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.lblNombreBuscar = new System.Windows.Forms.Label();
            this.cmbSexoBuscar = new System.Windows.Forms.ComboBox();
            this.txtApellidoBuscar = new System.Windows.Forms.TextBox();
            this.lblSexoBuscar = new System.Windows.Forms.Label();
            this.lblApellidoBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bscOrigenReporte)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.gpbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Mds_Biodata_Domain_Paciente";
            reportDataSource1.Value = this.bscOrigenReporte;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Mds.Biodata.Forms.Reportes.rptPacientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 78);
            this.reportViewer1.Size = new System.Drawing.Size(939, 441);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.gpbFiltros);
            this.pnlDatos.Size = new System.Drawing.Size(939, 80);
            this.pnlDatos.Controls.SetChildIndex(this.gpbFiltros, 0);
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.lblCiudadBuscar);
            this.gpbFiltros.Controls.Add(this.cmbCiudadBuscar);
            this.gpbFiltros.Controls.Add(this.txtDocumentoBuscar);
            this.gpbFiltros.Controls.Add(this.lblDocumentoBuscar);
            this.gpbFiltros.Controls.Add(this.txtNombreBuscar);
            this.gpbFiltros.Controls.Add(this.btnBuscar);
            this.gpbFiltros.Controls.Add(this.lblNombreBuscar);
            this.gpbFiltros.Controls.Add(this.cmbSexoBuscar);
            this.gpbFiltros.Controls.Add(this.txtApellidoBuscar);
            this.gpbFiltros.Controls.Add(this.lblSexoBuscar);
            this.gpbFiltros.Controls.Add(this.lblApellidoBuscar);
            this.gpbFiltros.Location = new System.Drawing.Point(3, 1);
            this.gpbFiltros.Name = "gpbFiltros";
            this.gpbFiltros.Size = new System.Drawing.Size(796, 71);
            this.gpbFiltros.TabIndex = 10;
            this.gpbFiltros.TabStop = false;
            this.gpbFiltros.Text = "Filtros";
            // 
            // lblCiudadBuscar
            // 
            this.lblCiudadBuscar.AutoSize = true;
            this.lblCiudadBuscar.Location = new System.Drawing.Point(453, 22);
            this.lblCiudadBuscar.Name = "lblCiudadBuscar";
            this.lblCiudadBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblCiudadBuscar.TabIndex = 32;
            this.lblCiudadBuscar.Text = "Ciudad";
            // 
            // cmbCiudadBuscar
            // 
            this.cmbCiudadBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudadBuscar.FormattingEnabled = true;
            this.cmbCiudadBuscar.Location = new System.Drawing.Point(499, 18);
            this.cmbCiudadBuscar.Name = "cmbCiudadBuscar";
            this.cmbCiudadBuscar.Size = new System.Drawing.Size(148, 21);
            this.cmbCiudadBuscar.TabIndex = 31;
            // 
            // txtDocumentoBuscar
            // 
            this.txtDocumentoBuscar.Location = new System.Drawing.Point(377, 45);
            this.txtDocumentoBuscar.Name = "txtDocumentoBuscar";
            this.txtDocumentoBuscar.Size = new System.Drawing.Size(270, 20);
            this.txtDocumentoBuscar.TabIndex = 19;
            // 
            // lblDocumentoBuscar
            // 
            this.lblDocumentoBuscar.AutoSize = true;
            this.lblDocumentoBuscar.Location = new System.Drawing.Point(309, 48);
            this.lblDocumentoBuscar.Name = "lblDocumentoBuscar";
            this.lblDocumentoBuscar.Size = new System.Drawing.Size(62, 13);
            this.lblDocumentoBuscar.TabIndex = 18;
            this.lblDocumentoBuscar.Text = "Documento";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Location = new System.Drawing.Point(92, 45);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(179, 20);
            this.txtNombreBuscar.TabIndex = 17;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(674, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 26);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnBuscar_Click);
            // 
            // lblNombreBuscar
            // 
            this.lblNombreBuscar.AutoSize = true;
            this.lblNombreBuscar.Location = new System.Drawing.Point(42, 45);
            this.lblNombreBuscar.Name = "lblNombreBuscar";
            this.lblNombreBuscar.Size = new System.Drawing.Size(44, 13);
            this.lblNombreBuscar.TabIndex = 16;
            this.lblNombreBuscar.Text = "Nombre";
            // 
            // cmbSexoBuscar
            // 
            this.cmbSexoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexoBuscar.FormattingEnabled = true;
            this.cmbSexoBuscar.Location = new System.Drawing.Point(377, 18);
            this.cmbSexoBuscar.Name = "cmbSexoBuscar";
            this.cmbSexoBuscar.Size = new System.Drawing.Size(61, 21);
            this.cmbSexoBuscar.TabIndex = 15;
            // 
            // txtApellidoBuscar
            // 
            this.txtApellidoBuscar.Location = new System.Drawing.Point(92, 19);
            this.txtApellidoBuscar.Name = "txtApellidoBuscar";
            this.txtApellidoBuscar.Size = new System.Drawing.Size(179, 20);
            this.txtApellidoBuscar.TabIndex = 14;
            // 
            // lblSexoBuscar
            // 
            this.lblSexoBuscar.AutoSize = true;
            this.lblSexoBuscar.Location = new System.Drawing.Point(340, 21);
            this.lblSexoBuscar.Name = "lblSexoBuscar";
            this.lblSexoBuscar.Size = new System.Drawing.Size(31, 13);
            this.lblSexoBuscar.TabIndex = 13;
            this.lblSexoBuscar.Text = "Sexo";
            // 
            // lblApellidoBuscar
            // 
            this.lblApellidoBuscar.AutoSize = true;
            this.lblApellidoBuscar.Location = new System.Drawing.Point(42, 19);
            this.lblApellidoBuscar.Name = "lblApellidoBuscar";
            this.lblApellidoBuscar.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoBuscar.TabIndex = 11;
            this.lblApellidoBuscar.Text = "Apellido";
            // 
            // ReportePacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 519);
            this.Name = "ReportePacientes";
            this.Text = "ReportePacientes";
            this.Load += new System.EventHandler(this.ReportePacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bscOrigenReporte)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gpbFiltros;
        private System.Windows.Forms.Label lblCiudadBuscar;
        private System.Windows.Forms.ComboBox cmbCiudadBuscar;
        private System.Windows.Forms.TextBox txtDocumentoBuscar;
        private System.Windows.Forms.Label lblDocumentoBuscar;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        public Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnBuscar;
        private System.Windows.Forms.Label lblNombreBuscar;
        private System.Windows.Forms.ComboBox cmbSexoBuscar;
        private System.Windows.Forms.TextBox txtApellidoBuscar;
        private System.Windows.Forms.Label lblSexoBuscar;
        private System.Windows.Forms.Label lblApellidoBuscar;

    }
}