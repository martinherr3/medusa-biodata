namespace Mds.Biodata.Forms.UserControls
{
    partial class uscAnamnesis
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
            this.gpbAnamnesis = new System.Windows.Forms.GroupBox();
            this.pnlPreguntasRespuestas = new System.Windows.Forms.Panel();
            this.gpbAnamnesis.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbAnamnesis
            // 
            this.gpbAnamnesis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbAnamnesis.Controls.Add(this.pnlPreguntasRespuestas);
            this.gpbAnamnesis.Location = new System.Drawing.Point(3, 3);
            this.gpbAnamnesis.Name = "gpbAnamnesis";
            this.gpbAnamnesis.Size = new System.Drawing.Size(961, 508);
            this.gpbAnamnesis.TabIndex = 0;
            this.gpbAnamnesis.TabStop = false;
            this.gpbAnamnesis.Text = "Preguntas";
            // 
            // pnlPreguntasRespuestas
            // 
            this.pnlPreguntasRespuestas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPreguntasRespuestas.AutoScroll = true;
            this.pnlPreguntasRespuestas.Location = new System.Drawing.Point(6, 19);
            this.pnlPreguntasRespuestas.Name = "pnlPreguntasRespuestas";
            this.pnlPreguntasRespuestas.Size = new System.Drawing.Size(949, 483);
            this.pnlPreguntasRespuestas.TabIndex = 0;
            // 
            // uscAnamnesis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbAnamnesis);
            this.Name = "uscAnamnesis";
            this.Size = new System.Drawing.Size(967, 514);
            this.Load += new System.EventHandler(this.uscAnamnesis_Load);
            this.gpbAnamnesis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAnamnesis;
        private System.Windows.Forms.Panel pnlPreguntasRespuestas;

    }
}
