namespace Mds.Biodata.Forms.Reportes
{
    partial class ReportePacienteDetalle
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
            ((System.ComponentModel.ISupportInitialize)(this.bscOrigenReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Mds.Biodata.Forms.Reportes.rptPacienteDetalle.rdlc";
            // 
            // ReportePacienteDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 519);
            this.Name = "ReportePacienteDetalle";
            this.Text = "ReportePacienteDetalle";
            this.Load += new System.EventHandler(this.ReportePacienteDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bscOrigenReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}