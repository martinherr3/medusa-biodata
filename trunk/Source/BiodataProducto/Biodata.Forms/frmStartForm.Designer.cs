namespace Mds.Biodata.Forms
{
    partial class frmStartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStartForm));
            this.flaPresentacion = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.flaPresentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // flaPresentacion
            // 
            this.flaPresentacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flaPresentacion.Enabled = true;
            this.flaPresentacion.Location = new System.Drawing.Point(0, 0);
            this.flaPresentacion.Name = "flaPresentacion";
            this.flaPresentacion.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("flaPresentacion.OcxState")));
            this.flaPresentacion.Size = new System.Drawing.Size(815, 555);
            this.flaPresentacion.TabIndex = 0;
            // 
            // frmStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 555);
            this.Controls.Add(this.flaPresentacion);
            this.Name = "frmStartForm";
            this.Text = "frmStartForm";
            this.Load += new System.EventHandler(this.frmStartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flaPresentacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash flaPresentacion;


    }
}