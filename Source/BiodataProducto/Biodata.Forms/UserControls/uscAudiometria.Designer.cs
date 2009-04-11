namespace Mds.Biodata.Forms.UserControls
{
    partial class uscAudiometria
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
            this.linerRight = new Pavr.Drawing.Liner();
            this.linerLeft = new Pavr.Drawing.Liner();
            this.lblOidoIzquierdo = new System.Windows.Forms.Label();
            this.lblOidoDerecho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linerRight
            // 
            this.linerRight.BackColor = System.Drawing.Color.Transparent;
            this.linerRight.ControlBackColor = System.Drawing.Color.Transparent;
            this.linerRight.CreateButtonText = "Nueva Audiometria";
            this.linerRight.LegendCaption = "Leyendas";
            this.linerRight.Location = new System.Drawing.Point(501, 15);
            this.linerRight.MatrixLinesColor = System.Drawing.Color.LightGray;
            this.linerRight.Name = "linerRight";
            this.linerRight.PanelBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linerRight.PointColor = System.Drawing.Color.Black;
            this.linerRight.PointHeight = 5;
            this.linerRight.PointWidth = 5;
            this.linerRight.Size = new System.Drawing.Size(475, 294);
            this.linerRight.TabIndex = 8;
            // 
            // linerLeft
            // 
            this.linerLeft.BackColor = System.Drawing.Color.Transparent;
            this.linerLeft.ControlBackColor = System.Drawing.Color.Transparent;
            this.linerLeft.CreateButtonText = "Nueva Audiometria";
            this.linerLeft.LegendCaption = "Leyendas";
            this.linerLeft.Location = new System.Drawing.Point(12, 13);
            this.linerLeft.MatrixLinesColor = System.Drawing.Color.LightGray;
            this.linerLeft.Name = "linerLeft";
            this.linerLeft.PanelBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linerLeft.PointColor = System.Drawing.Color.Black;
            this.linerLeft.PointHeight = 5;
            this.linerLeft.PointWidth = 5;
            this.linerLeft.Size = new System.Drawing.Size(467, 296);
            this.linerLeft.TabIndex = 7;
            // 
            // lblOidoIzquierdo
            // 
            this.lblOidoIzquierdo.AutoSize = true;
            this.lblOidoIzquierdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOidoIzquierdo.ForeColor = System.Drawing.Color.Blue;
            this.lblOidoIzquierdo.Location = new System.Drawing.Point(531, 312);
            this.lblOidoIzquierdo.Name = "lblOidoIzquierdo";
            this.lblOidoIzquierdo.Size = new System.Drawing.Size(89, 13);
            this.lblOidoIzquierdo.TabIndex = 9;
            this.lblOidoIzquierdo.Text = "Oido Izquierdo";
            // 
            // lblOidoDerecho
            // 
            this.lblOidoDerecho.AutoSize = true;
            this.lblOidoDerecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOidoDerecho.ForeColor = System.Drawing.Color.Red;
            this.lblOidoDerecho.Location = new System.Drawing.Point(45, 312);
            this.lblOidoDerecho.Name = "lblOidoDerecho";
            this.lblOidoDerecho.Size = new System.Drawing.Size(85, 13);
            this.lblOidoDerecho.TabIndex = 10;
            this.lblOidoDerecho.Text = "Oido Derecho";
            // 
            // uscAudiometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblOidoDerecho);
            this.Controls.Add(this.lblOidoIzquierdo);
            this.Controls.Add(this.linerRight);
            this.Controls.Add(this.linerLeft);
            this.Name = "uscAudiometria";
            this.Size = new System.Drawing.Size(1001, 330);
            this.Load += new System.EventHandler(this.uscAudiometria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pavr.Drawing.Liner linerRight;
        private Pavr.Drawing.Liner linerLeft;
        private System.Windows.Forms.Label lblOidoIzquierdo;
        private System.Windows.Forms.Label lblOidoDerecho;
    }
}
