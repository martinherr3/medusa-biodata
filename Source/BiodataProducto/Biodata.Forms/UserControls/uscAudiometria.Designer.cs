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
            this.lblFrecuencia = new System.Windows.Forms.Label();
            this.gpbSimbolos = new System.Windows.Forms.GroupBox();
            this.chkSimboloCampoAuditivo = new System.Windows.Forms.CheckBox();
            this.btnSimboloCampoAuditivo = new System.Windows.Forms.Button();
            this.chkSimboloIncomodidad = new System.Windows.Forms.CheckBox();
            this.btnSimboloIncomodidad = new System.Windows.Forms.Button();
            this.chkSimboloComodidad = new System.Windows.Forms.CheckBox();
            this.btnSimboloComodidad = new System.Windows.Forms.Button();
            this.gpbTipoIzq = new System.Windows.Forms.GroupBox();
            this.radAerea = new System.Windows.Forms.RadioButton();
            this.radOsea = new System.Windows.Forms.RadioButton();
            this.gpbAudiogramaDerecho = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.orientedTextLabel1 = new Mds.Biodata.Forms.UserControls.OrientedTextLabel();
            this.gpbAudiogramaIzquierdo.SuspendLayout();
            this.gpbSimbolos.SuspendLayout();
            this.gpbTipoIzq.SuspendLayout();
            this.gpbAudiogramaDerecho.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // linerRight
            // 
            this.linerRight.BackColor = System.Drawing.Color.Transparent;
            this.linerRight.CreateButtonText = "Nueva Audiometria";
            this.linerRight.LegendCaption = "Leyendas";
            this.linerRight.LineColor = null;
            this.linerRight.Location = new System.Drawing.Point(22, 19);
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
            this.gpbAudiogramaIzquierdo.Controls.Add(this.orientedTextLabel1);
            this.gpbAudiogramaIzquierdo.Controls.Add(this.lblFrecuencia);
            this.gpbAudiogramaIzquierdo.Controls.Add(this.gpbSimbolos);
            this.gpbAudiogramaIzquierdo.Controls.Add(this.gpbTipoIzq);
            this.gpbAudiogramaIzquierdo.Controls.Add(this.linerLeft);
            this.gpbAudiogramaIzquierdo.Location = new System.Drawing.Point(3, 15);
            this.gpbAudiogramaIzquierdo.Name = "gpbAudiogramaIzquierdo";
            this.gpbAudiogramaIzquierdo.Size = new System.Drawing.Size(495, 508);
            this.gpbAudiogramaIzquierdo.TabIndex = 11;
            this.gpbAudiogramaIzquierdo.TabStop = false;
            this.gpbAudiogramaIzquierdo.Text = "Audiograma Izquierdo";
            // 
            // lblFrecuencia
            // 
            this.lblFrecuencia.AutoSize = true;
            this.lblFrecuencia.ForeColor = System.Drawing.Color.Blue;
            this.lblFrecuencia.Location = new System.Drawing.Point(152, 319);
            this.lblFrecuencia.Name = "lblFrecuencia";
            this.lblFrecuencia.Size = new System.Drawing.Size(60, 13);
            this.lblFrecuencia.TabIndex = 10;
            this.lblFrecuencia.Text = "Frecuencia";
            // 
            // gpbSimbolos
            // 
            this.gpbSimbolos.Controls.Add(this.chkSimboloCampoAuditivo);
            this.gpbSimbolos.Controls.Add(this.btnSimboloCampoAuditivo);
            this.gpbSimbolos.Controls.Add(this.chkSimboloIncomodidad);
            this.gpbSimbolos.Controls.Add(this.btnSimboloIncomodidad);
            this.gpbSimbolos.Controls.Add(this.chkSimboloComodidad);
            this.gpbSimbolos.Controls.Add(this.btnSimboloComodidad);
            this.gpbSimbolos.Location = new System.Drawing.Point(32, 391);
            this.gpbSimbolos.Name = "gpbSimbolos";
            this.gpbSimbolos.Size = new System.Drawing.Size(318, 111);
            this.gpbSimbolos.TabIndex = 9;
            this.gpbSimbolos.TabStop = false;
            this.gpbSimbolos.Text = "Simbolos";
            // 
            // chkSimboloCampoAuditivo
            // 
            this.chkSimboloCampoAuditivo.AutoSize = true;
            this.chkSimboloCampoAuditivo.Location = new System.Drawing.Point(160, 99);
            this.chkSimboloCampoAuditivo.Name = "chkSimboloCampoAuditivo";
            this.chkSimboloCampoAuditivo.Size = new System.Drawing.Size(155, 17);
            this.chkSimboloCampoAuditivo.TabIndex = 5;
            this.chkSimboloCampoAuditivo.Text = "Simbolo de Campo Auditivo";
            this.chkSimboloCampoAuditivo.UseVisualStyleBackColor = true;
            // 
            // btnSimboloCampoAuditivo
            // 
            this.btnSimboloCampoAuditivo.Location = new System.Drawing.Point(6, 93);
            this.btnSimboloCampoAuditivo.Name = "btnSimboloCampoAuditivo";
            this.btnSimboloCampoAuditivo.Size = new System.Drawing.Size(138, 26);
            this.btnSimboloCampoAuditivo.TabIndex = 4;
            this.btnSimboloCampoAuditivo.Text = "Insertar";
            this.btnSimboloCampoAuditivo.UseVisualStyleBackColor = true;
            // 
            // chkSimboloIncomodidad
            // 
            this.chkSimboloIncomodidad.AutoSize = true;
            this.chkSimboloIncomodidad.Location = new System.Drawing.Point(160, 62);
            this.chkSimboloIncomodidad.Name = "chkSimboloIncomodidad";
            this.chkSimboloIncomodidad.Size = new System.Drawing.Size(142, 17);
            this.chkSimboloIncomodidad.TabIndex = 3;
            this.chkSimboloIncomodidad.Text = "Simbolo de Incomodidad";
            this.chkSimboloIncomodidad.UseVisualStyleBackColor = true;
            // 
            // btnSimboloIncomodidad
            // 
            this.btnSimboloIncomodidad.Location = new System.Drawing.Point(6, 56);
            this.btnSimboloIncomodidad.Name = "btnSimboloIncomodidad";
            this.btnSimboloIncomodidad.Size = new System.Drawing.Size(138, 26);
            this.btnSimboloIncomodidad.TabIndex = 2;
            this.btnSimboloIncomodidad.Text = "Insertar";
            this.btnSimboloIncomodidad.UseVisualStyleBackColor = true;
            // 
            // chkSimboloComodidad
            // 
            this.chkSimboloComodidad.AutoSize = true;
            this.chkSimboloComodidad.Location = new System.Drawing.Point(160, 25);
            this.chkSimboloComodidad.Name = "chkSimboloComodidad";
            this.chkSimboloComodidad.Size = new System.Drawing.Size(134, 17);
            this.chkSimboloComodidad.TabIndex = 1;
            this.chkSimboloComodidad.Text = "Simbolo de Comodidad";
            this.chkSimboloComodidad.UseVisualStyleBackColor = true;
            // 
            // btnSimboloComodidad
            // 
            this.btnSimboloComodidad.Location = new System.Drawing.Point(6, 19);
            this.btnSimboloComodidad.Name = "btnSimboloComodidad";
            this.btnSimboloComodidad.Size = new System.Drawing.Size(138, 26);
            this.btnSimboloComodidad.TabIndex = 0;
            this.btnSimboloComodidad.Text = "Insertar";
            this.btnSimboloComodidad.UseVisualStyleBackColor = true;
            // 
            // gpbTipoIzq
            // 
            this.gpbTipoIzq.Controls.Add(this.radAerea);
            this.gpbTipoIzq.Controls.Add(this.radOsea);
            this.gpbTipoIzq.Location = new System.Drawing.Point(32, 342);
            this.gpbTipoIzq.Name = "gpbTipoIzq";
            this.gpbTipoIzq.Size = new System.Drawing.Size(318, 42);
            this.gpbTipoIzq.TabIndex = 8;
            this.gpbTipoIzq.TabStop = false;
            // 
            // radAerea
            // 
            this.radAerea.AutoSize = true;
            this.radAerea.Checked = true;
            this.radAerea.Location = new System.Drawing.Point(166, 19);
            this.radAerea.Name = "radAerea";
            this.radAerea.Size = new System.Drawing.Size(73, 17);
            this.radAerea.TabIndex = 1;
            this.radAerea.TabStop = true;
            this.radAerea.Text = "Vía Aérea";
            this.radAerea.UseVisualStyleBackColor = true;
            // 
            // radOsea
            // 
            this.radOsea.AutoSize = true;
            this.radOsea.Location = new System.Drawing.Point(19, 19);
            this.radOsea.Name = "radOsea";
            this.radOsea.Size = new System.Drawing.Size(70, 17);
            this.radOsea.TabIndex = 0;
            this.radOsea.Text = "Vía Osea";
            this.radOsea.UseVisualStyleBackColor = true;
            // 
            // gpbAudiogramaDerecho
            // 
            this.gpbAudiogramaDerecho.Controls.Add(this.groupBox2);
            this.gpbAudiogramaDerecho.Controls.Add(this.groupBox1);
            this.gpbAudiogramaDerecho.Controls.Add(this.linerRight);
            this.gpbAudiogramaDerecho.Location = new System.Drawing.Point(504, 15);
            this.gpbAudiogramaDerecho.Name = "gpbAudiogramaDerecho";
            this.gpbAudiogramaDerecho.Size = new System.Drawing.Size(506, 508);
            this.gpbAudiogramaDerecho.TabIndex = 12;
            this.gpbAudiogramaDerecho.TabStop = false;
            this.gpbAudiogramaDerecho.Text = "Audiograma Derecho";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(52, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 130);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Simbolos";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(160, 99);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(155, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Simbolo de Campo Auditivo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insertar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(160, 62);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(142, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Simbolo de Incomodidad";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "Insertar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(160, 25);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(134, 17);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Simbolo de Comodidad";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(138, 26);
            this.button3.TabIndex = 0;
            this.button3.Text = "Insertar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(52, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 42);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(166, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Vía Aérea";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.Text = "Vía Osea";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // orientedTextLabel1
            // 
            this.orientedTextLabel1.AutoSize = true;
            this.orientedTextLabel1.Location = new System.Drawing.Point(368, 404);
            this.orientedTextLabel1.Name = "orientedTextLabel1";
            this.orientedTextLabel1.RotationAngle = -90;
            this.orientedTextLabel1.Size = new System.Drawing.Size(98, 13);
            this.orientedTextLabel1.TabIndex = 11;
            this.orientedTextLabel1.Text = "orientedTextLabel1";
            this.orientedTextLabel1.TextDirection = Mds.Biodata.Forms.UserControls.Direction.Clockwise;
            this.orientedTextLabel1.TextOrientation = Mds.Biodata.Forms.UserControls.Orientation.Rotate;
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
            this.gpbSimbolos.ResumeLayout(false);
            this.gpbSimbolos.PerformLayout();
            this.gpbTipoIzq.ResumeLayout(false);
            this.gpbTipoIzq.PerformLayout();
            this.gpbAudiogramaDerecho.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Pavr.Drawing.Liner linerRight;
        private Pavr.Drawing.Liner linerLeft;
        private System.Windows.Forms.GroupBox gpbAudiogramaIzquierdo;
        private System.Windows.Forms.GroupBox gpbAudiogramaDerecho;
        private System.Windows.Forms.GroupBox gpbTipoIzq;
        private System.Windows.Forms.RadioButton radAerea;
        private System.Windows.Forms.RadioButton radOsea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox gpbSimbolos;
        private System.Windows.Forms.Button btnSimboloComodidad;
        private System.Windows.Forms.CheckBox chkSimboloComodidad;
        private System.Windows.Forms.CheckBox chkSimboloIncomodidad;
        private System.Windows.Forms.Button btnSimboloIncomodidad;
        private System.Windows.Forms.CheckBox chkSimboloCampoAuditivo;
        private System.Windows.Forms.Button btnSimboloCampoAuditivo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblFrecuencia;
        private OrientedTextLabel orientedTextLabel1;
    }
}
