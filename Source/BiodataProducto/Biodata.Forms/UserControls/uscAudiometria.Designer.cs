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
            this.gpbAudiogramaIzquierdo = new System.Windows.Forms.GroupBox();
            this.lblNivelAuditivoIzq = new System.Windows.Forms.Label();
            this.lblFrecuenciaIzq = new System.Windows.Forms.Label();
            this.gpbTipoIzq = new System.Windows.Forms.GroupBox();
            this.radAereaIzq = new System.Windows.Forms.RadioButton();
            this.radOseaIzq = new System.Windows.Forms.RadioButton();
            this.gpbAudiogramaDerecho = new System.Windows.Forms.GroupBox();
            this.lblNivelAuditivoDer = new System.Windows.Forms.Label();
            this.lblFrecuenciaDer = new System.Windows.Forms.Label();
            this.gpbTipoDer = new System.Windows.Forms.GroupBox();
            this.radAereaDer = new System.Windows.Forms.RadioButton();
            this.radOseaDer = new System.Windows.Forms.RadioButton();
            this.gpbAudiogramaIzquierdo.SuspendLayout();
            this.gpbTipoIzq.SuspendLayout();
            this.gpbAudiogramaDerecho.SuspendLayout();
            this.gpbTipoDer.SuspendLayout();
            this.SuspendLayout();
            // 
            // linerRight
            // 
            this.linerRight.BackColor = System.Drawing.Color.Transparent;
            this.linerRight.CreateButtonText = "Nueva Audiometria";
            this.linerRight.LegendCaption = "Leyendas";
            this.linerRight.LineColor = null;
            this.linerRight.Location = new System.Drawing.Point(25, 29);
            this.linerRight.MatrixLinesColor = System.Drawing.Color.LightGray;
            this.linerRight.Name = "linerRight";
            this.linerRight.PointColor = System.Drawing.Color.Black;
            this.linerRight.Size = new System.Drawing.Size(475, 294);
            this.linerRight.TabIndex = 8;
            this.linerRight.BeforeSeriesCreation += new Pavr.Drawing.Liner.BeforeSeriesCreationHandler(this.linerRight_BeforeSeriesCreation);
            // 
            // linerLeft
            // 
            this.linerLeft.BackColor = System.Drawing.Color.Transparent;
            this.linerLeft.CreateButtonText = "Nueva Audiometria";
            this.linerLeft.LegendCaption = "Leyendas";
            this.linerLeft.LineColor = null;
            this.linerLeft.Location = new System.Drawing.Point(18, 29);
            this.linerLeft.MatrixLinesColor = System.Drawing.Color.LightGray;
            this.linerLeft.Name = "linerLeft";
            this.linerLeft.PointColor = System.Drawing.Color.Black;
            this.linerLeft.Size = new System.Drawing.Size(472, 296);
            this.linerLeft.TabIndex = 7;
            this.linerLeft.BeforeSeriesCreation += new Pavr.Drawing.Liner.BeforeSeriesCreationHandler(this.linerLeft_BeforeSeriesCreation);
            // 
            // gpbAudiogramaIzquierdo
            // 
            this.gpbAudiogramaIzquierdo.Controls.Add(this.lblNivelAuditivoIzq);
            this.gpbAudiogramaIzquierdo.Controls.Add(this.lblFrecuenciaIzq);
            this.gpbAudiogramaIzquierdo.Controls.Add(this.gpbTipoIzq);
            this.gpbAudiogramaIzquierdo.Controls.Add(this.linerLeft);
            this.gpbAudiogramaIzquierdo.Location = new System.Drawing.Point(518, 11);
            this.gpbAudiogramaIzquierdo.Name = "gpbAudiogramaIzquierdo";
            this.gpbAudiogramaIzquierdo.Size = new System.Drawing.Size(489, 491);
            this.gpbAudiogramaIzquierdo.TabIndex = 11;
            this.gpbAudiogramaIzquierdo.TabStop = false;
            this.gpbAudiogramaIzquierdo.Text = "Audiograma Izquierdo";
            // 
            // lblNivelAuditivoIzq
            // 
            this.lblNivelAuditivoIzq.AutoSize = true;
            this.lblNivelAuditivoIzq.ForeColor = System.Drawing.Color.Blue;
            this.lblNivelAuditivoIzq.Location = new System.Drawing.Point(377, 133);
            this.lblNivelAuditivoIzq.Name = "lblNivelAuditivoIzq";
            this.lblNivelAuditivoIzq.Size = new System.Drawing.Size(94, 13);
            this.lblNivelAuditivoIzq.TabIndex = 11;
            this.lblNivelAuditivoIzq.Text = "Nivel Auditivo (dB)";
            // 
            // lblFrecuenciaIzq
            // 
            this.lblFrecuenciaIzq.AutoSize = true;
            this.lblFrecuenciaIzq.ForeColor = System.Drawing.Color.Blue;
            this.lblFrecuenciaIzq.Location = new System.Drawing.Point(152, 319);
            this.lblFrecuenciaIzq.Name = "lblFrecuenciaIzq";
            this.lblFrecuenciaIzq.Size = new System.Drawing.Size(60, 13);
            this.lblFrecuenciaIzq.TabIndex = 10;
            this.lblFrecuenciaIzq.Text = "Frecuencia";
            // 
            // gpbTipoIzq
            // 
            this.gpbTipoIzq.Controls.Add(this.radAereaIzq);
            this.gpbTipoIzq.Controls.Add(this.radOseaIzq);
            this.gpbTipoIzq.ForeColor = System.Drawing.Color.Blue;
            this.gpbTipoIzq.Location = new System.Drawing.Point(46, 342);
            this.gpbTipoIzq.Name = "gpbTipoIzq";
            this.gpbTipoIzq.Size = new System.Drawing.Size(309, 42);
            this.gpbTipoIzq.TabIndex = 8;
            this.gpbTipoIzq.TabStop = false;
            // 
            // radAereaIzq
            // 
            this.radAereaIzq.AutoSize = true;
            this.radAereaIzq.Checked = true;
            this.radAereaIzq.Location = new System.Drawing.Point(166, 19);
            this.radAereaIzq.Name = "radAereaIzq";
            this.radAereaIzq.Size = new System.Drawing.Size(73, 17);
            this.radAereaIzq.TabIndex = 1;
            this.radAereaIzq.TabStop = true;
            this.radAereaIzq.Text = "Vía Aérea";
            this.radAereaIzq.UseVisualStyleBackColor = true;
            // 
            // radOseaIzq
            // 
            this.radOseaIzq.AutoSize = true;
            this.radOseaIzq.Location = new System.Drawing.Point(19, 19);
            this.radOseaIzq.Name = "radOseaIzq";
            this.radOseaIzq.Size = new System.Drawing.Size(70, 17);
            this.radOseaIzq.TabIndex = 0;
            this.radOseaIzq.Text = "Vía Osea";
            this.radOseaIzq.UseVisualStyleBackColor = true;
            // 
            // gpbAudiogramaDerecho
            // 
            this.gpbAudiogramaDerecho.Controls.Add(this.lblNivelAuditivoDer);
            this.gpbAudiogramaDerecho.Controls.Add(this.lblFrecuenciaDer);
            this.gpbAudiogramaDerecho.Controls.Add(this.gpbTipoDer);
            this.gpbAudiogramaDerecho.Controls.Add(this.linerRight);
            this.gpbAudiogramaDerecho.ForeColor = System.Drawing.Color.Red;
            this.gpbAudiogramaDerecho.Location = new System.Drawing.Point(3, 11);
            this.gpbAudiogramaDerecho.Name = "gpbAudiogramaDerecho";
            this.gpbAudiogramaDerecho.Size = new System.Drawing.Size(509, 491);
            this.gpbAudiogramaDerecho.TabIndex = 12;
            this.gpbAudiogramaDerecho.TabStop = false;
            this.gpbAudiogramaDerecho.Text = "Audiograma Derecho";
            // 
            // lblNivelAuditivoDer
            // 
            this.lblNivelAuditivoDer.AutoSize = true;
            this.lblNivelAuditivoDer.ForeColor = System.Drawing.Color.Red;
            this.lblNivelAuditivoDer.Location = new System.Drawing.Point(394, 133);
            this.lblNivelAuditivoDer.Name = "lblNivelAuditivoDer";
            this.lblNivelAuditivoDer.Size = new System.Drawing.Size(94, 13);
            this.lblNivelAuditivoDer.TabIndex = 13;
            this.lblNivelAuditivoDer.Text = "Nivel Auditivo (dB)";
            // 
            // lblFrecuenciaDer
            // 
            this.lblFrecuenciaDer.AutoSize = true;
            this.lblFrecuenciaDer.ForeColor = System.Drawing.Color.Red;
            this.lblFrecuenciaDer.Location = new System.Drawing.Point(157, 319);
            this.lblFrecuenciaDer.Name = "lblFrecuenciaDer";
            this.lblFrecuenciaDer.Size = new System.Drawing.Size(60, 13);
            this.lblFrecuenciaDer.TabIndex = 12;
            this.lblFrecuenciaDer.Text = "Frecuencia";
            // 
            // gpbTipoDer
            // 
            this.gpbTipoDer.Controls.Add(this.radAereaDer);
            this.gpbTipoDer.Controls.Add(this.radOseaDer);
            this.gpbTipoDer.Location = new System.Drawing.Point(53, 342);
            this.gpbTipoDer.Name = "gpbTipoDer";
            this.gpbTipoDer.Size = new System.Drawing.Size(310, 42);
            this.gpbTipoDer.TabIndex = 9;
            this.gpbTipoDer.TabStop = false;
            // 
            // radAereaDer
            // 
            this.radAereaDer.AutoSize = true;
            this.radAereaDer.Checked = true;
            this.radAereaDer.Location = new System.Drawing.Point(166, 19);
            this.radAereaDer.Name = "radAereaDer";
            this.radAereaDer.Size = new System.Drawing.Size(73, 17);
            this.radAereaDer.TabIndex = 1;
            this.radAereaDer.TabStop = true;
            this.radAereaDer.Text = "Vía Aérea";
            this.radAereaDer.UseVisualStyleBackColor = true;
            // 
            // radOseaDer
            // 
            this.radOseaDer.AutoSize = true;
            this.radOseaDer.Location = new System.Drawing.Point(19, 19);
            this.radOseaDer.Name = "radOseaDer";
            this.radOseaDer.Size = new System.Drawing.Size(70, 17);
            this.radOseaDer.TabIndex = 0;
            this.radOseaDer.Text = "Vía Osea";
            this.radOseaDer.UseVisualStyleBackColor = true;
            // 
            // uscAudiometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gpbAudiogramaDerecho);
            this.Controls.Add(this.gpbAudiogramaIzquierdo);
            this.Name = "uscAudiometria";
            this.Size = new System.Drawing.Size(1010, 526);
            this.Load += new System.EventHandler(this.uscAudiometria_Load);
            this.gpbAudiogramaIzquierdo.ResumeLayout(false);
            this.gpbAudiogramaIzquierdo.PerformLayout();
            this.gpbTipoIzq.ResumeLayout(false);
            this.gpbTipoIzq.PerformLayout();
            this.gpbAudiogramaDerecho.ResumeLayout(false);
            this.gpbAudiogramaDerecho.PerformLayout();
            this.gpbTipoDer.ResumeLayout(false);
            this.gpbTipoDer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Pavr.Drawing.Liner linerRight;
        private Pavr.Drawing.Liner linerLeft;
        private System.Windows.Forms.GroupBox gpbAudiogramaIzquierdo;
        private System.Windows.Forms.GroupBox gpbAudiogramaDerecho;
        private System.Windows.Forms.GroupBox gpbTipoIzq;
        private System.Windows.Forms.RadioButton radAereaIzq;
        private System.Windows.Forms.RadioButton radOseaIzq;
        private System.Windows.Forms.GroupBox gpbTipoDer;
        private System.Windows.Forms.RadioButton radAereaDer;
        private System.Windows.Forms.RadioButton radOseaDer;
        private System.Windows.Forms.Label lblFrecuenciaIzq;
        private System.Windows.Forms.Label lblNivelAuditivoIzq;
        private System.Windows.Forms.Label lblNivelAuditivoDer;
        private System.Windows.Forms.Label lblFrecuenciaDer;
    }
}
