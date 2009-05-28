namespace Mds.Biodata.Forms.UserControls
{
    partial class uscTimpanometria
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.linerCentral = new Pavr.Drawing.Liner();
            this.SuspendLayout();
            // 
            // linerCentral
            // 
            this.linerCentral.BackColor = System.Drawing.Color.Transparent;
            //this.linerCentral.ControlBackColor = System.Drawing.Color.Transparent;
            this.linerCentral.CreateButtonText = "New Timpanometria";
            this.linerCentral.LegendCaption = "Leyendas";
            this.linerCentral.Location = new System.Drawing.Point(6, 6);
            this.linerCentral.MatrixLinesColor = System.Drawing.Color.LightGray;
            this.linerCentral.Name = "linerCentral";
            //this.linerCentral.PanelBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linerCentral.PointColor = System.Drawing.Color.Black;
            this.linerCentral.PointHeight = 5;
            this.linerCentral.PointWidth = 5;
            this.linerCentral.Size = new System.Drawing.Size(481, 296);
            this.linerCentral.TabIndex = 8;
            // 
            // uscTimpanometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linerCentral);
            this.Name = "uscTimpanometria";
            this.Size = new System.Drawing.Size(503, 306);
            this.Load += new System.EventHandler(this.uscTimpanometria_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Pavr.Drawing.Liner linerCentral;
    }
}
