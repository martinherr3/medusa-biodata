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
            ((System.ComponentModel.ISupportInitialize)(this.bscOrigenReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "Mds_Biodata_Domain_Audifono";
            reportDataSource1.Value = this.bscOrigenReporte;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Mds.Biodata.Forms.Reportes.rptAudifonos.rdlc";
            // 
            // ReporteAudifonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 519);
            this.Name = "ReporteAudifonos";
            this.Text = "ReporteAudifonos";
            this.Load += new System.EventHandler(this.ReporteAudifonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bscOrigenReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

    }
}