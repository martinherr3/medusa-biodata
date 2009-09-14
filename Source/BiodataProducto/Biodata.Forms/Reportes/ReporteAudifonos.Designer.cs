namespace Mds.Biodata.Forms.Reportes
{
    partial class ReporteAudifonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteAudifonos));
            this.gpbFiltros = new System.Windows.Forms.GroupBox();
            this.lblPresionSalidaBuscar = new System.Windows.Forms.Label();
            this.txtPresionSalidaBuscar = new System.Windows.Forms.TextBox();
            this.lblMarcaBuscar = new System.Windows.Forms.Label();
            this.cmbMarcaBuscar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.cmbTipoBuscar = new System.Windows.Forms.ComboBox();
            this.txtNombreModeloBuscar = new System.Windows.Forms.TextBox();
            this.lblTipoBuscar = new System.Windows.Forms.Label();
            this.lblNombreModeloBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bscOrigenReporte)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.gpbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Mds_Biodata_Domain_Audifono";
            reportDataSource1.Value = this.bscOrigenReporte;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Mds.Biodata.Forms.Reportes.rptAudifonos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 89);
            this.reportViewer1.Size = new System.Drawing.Size(932, 430);
            // 
            // pnlDatos
            // 
            this.pnlDatos.Controls.Add(this.gpbFiltros);
            this.pnlDatos.Size = new System.Drawing.Size(932, 90);
            this.pnlDatos.Controls.SetChildIndex(this.gpbFiltros, 0);
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.lblPresionSalidaBuscar);
            this.gpbFiltros.Controls.Add(this.txtPresionSalidaBuscar);
            this.gpbFiltros.Controls.Add(this.lblMarcaBuscar);
            this.gpbFiltros.Controls.Add(this.cmbMarcaBuscar);
            this.gpbFiltros.Controls.Add(this.btnBuscar);
            this.gpbFiltros.Controls.Add(this.cmbTipoBuscar);
            this.gpbFiltros.Controls.Add(this.txtNombreModeloBuscar);
            this.gpbFiltros.Controls.Add(this.lblTipoBuscar);
            this.gpbFiltros.Controls.Add(this.lblNombreModeloBuscar);
            this.gpbFiltros.Location = new System.Drawing.Point(12, 5);
            this.gpbFiltros.Name = "gpbFiltros";
            this.gpbFiltros.Size = new System.Drawing.Size(723, 71);
            this.gpbFiltros.TabIndex = 11;
            this.gpbFiltros.TabStop = false;
            this.gpbFiltros.Text = "Filtros";
            // 
            // lblPresionSalidaBuscar
            // 
            this.lblPresionSalidaBuscar.AutoSize = true;
            this.lblPresionSalidaBuscar.Location = new System.Drawing.Point(345, 50);
            this.lblPresionSalidaBuscar.Name = "lblPresionSalidaBuscar";
            this.lblPresionSalidaBuscar.Size = new System.Drawing.Size(113, 13);
            this.lblPresionSalidaBuscar.TabIndex = 34;
            this.lblPresionSalidaBuscar.Text = "Presion Maxima Salida";
            // 
            // txtPresionSalidaBuscar
            // 
            this.txtPresionSalidaBuscar.Location = new System.Drawing.Point(464, 47);
            this.txtPresionSalidaBuscar.Name = "txtPresionSalidaBuscar";
            this.txtPresionSalidaBuscar.Size = new System.Drawing.Size(107, 20);
            this.txtPresionSalidaBuscar.TabIndex = 33;
            // 
            // lblMarcaBuscar
            // 
            this.lblMarcaBuscar.AutoSize = true;
            this.lblMarcaBuscar.Location = new System.Drawing.Point(345, 18);
            this.lblMarcaBuscar.Name = "lblMarcaBuscar";
            this.lblMarcaBuscar.Size = new System.Drawing.Size(37, 13);
            this.lblMarcaBuscar.TabIndex = 32;
            this.lblMarcaBuscar.Text = "Marca";
            // 
            // cmbMarcaBuscar
            // 
            this.cmbMarcaBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarcaBuscar.FormattingEnabled = true;
            this.cmbMarcaBuscar.Location = new System.Drawing.Point(388, 18);
            this.cmbMarcaBuscar.Name = "cmbMarcaBuscar";
            this.cmbMarcaBuscar.Size = new System.Drawing.Size(183, 21);
            this.cmbMarcaBuscar.TabIndex = 31;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(601, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 26);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnBuscar_Click);
            // 
            // cmbTipoBuscar
            // 
            this.cmbTipoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBuscar.FormattingEnabled = true;
            this.cmbTipoBuscar.Location = new System.Drawing.Point(110, 42);
            this.cmbTipoBuscar.Name = "cmbTipoBuscar";
            this.cmbTipoBuscar.Size = new System.Drawing.Size(201, 21);
            this.cmbTipoBuscar.TabIndex = 15;
            // 
            // txtNombreModeloBuscar
            // 
            this.txtNombreModeloBuscar.Location = new System.Drawing.Point(110, 19);
            this.txtNombreModeloBuscar.Name = "txtNombreModeloBuscar";
            this.txtNombreModeloBuscar.Size = new System.Drawing.Size(201, 20);
            this.txtNombreModeloBuscar.TabIndex = 14;
            // 
            // lblTipoBuscar
            // 
            this.lblTipoBuscar.AutoSize = true;
            this.lblTipoBuscar.Location = new System.Drawing.Point(76, 50);
            this.lblTipoBuscar.Name = "lblTipoBuscar";
            this.lblTipoBuscar.Size = new System.Drawing.Size(28, 13);
            this.lblTipoBuscar.TabIndex = 13;
            this.lblTipoBuscar.Text = "Tipo";
            // 
            // lblNombreModeloBuscar
            // 
            this.lblNombreModeloBuscar.AutoSize = true;
            this.lblNombreModeloBuscar.Location = new System.Drawing.Point(7, 19);
            this.lblNombreModeloBuscar.Name = "lblNombreModeloBuscar";
            this.lblNombreModeloBuscar.Size = new System.Drawing.Size(97, 13);
            this.lblNombreModeloBuscar.TabIndex = 11;
            this.lblNombreModeloBuscar.Text = "Nombre de Modelo";
            // 
            // ReporteAudifonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 519);
            this.Name = "ReporteAudifonos";
            this.Text = "ReporteAudifonos";
            this.Load += new System.EventHandler(this.ReporteAudifonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bscOrigenReporte)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox gpbFiltros;
        private System.Windows.Forms.Label lblPresionSalidaBuscar;
        private System.Windows.Forms.TextBox txtPresionSalidaBuscar;
        private System.Windows.Forms.Label lblMarcaBuscar;
        private System.Windows.Forms.ComboBox cmbMarcaBuscar;
        public Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnBuscar;
        private System.Windows.Forms.ComboBox cmbTipoBuscar;
        private System.Windows.Forms.TextBox txtNombreModeloBuscar;
        private System.Windows.Forms.Label lblTipoBuscar;
        private System.Windows.Forms.Label lblNombreModeloBuscar;

    }
}