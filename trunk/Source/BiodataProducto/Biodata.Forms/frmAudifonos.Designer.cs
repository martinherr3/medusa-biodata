namespace Mds.Biodata.Forms
{
    partial class frmAudifonos
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombreModelo = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbTipoAudifono = new System.Windows.Forms.ComboBox();
            this.radDigital = new System.Windows.Forms.RadioButton();
            this.radAnalogico = new System.Windows.Forms.RadioButton();
            this.chkProgramable = new System.Windows.Forms.CheckBox();
            this.txtPresionSalida = new System.Windows.Forms.TextBox();
            this.tbcAudifono = new Dotnetrix.Controls.TabControlEX();
            this.tbpDatos = new Dotnetrix.Controls.TabPageEX();
            this.lblPresionSalida = new System.Windows.Forms.Label();
            this.lblProgramable = new System.Windows.Forms.Label();
            this.lblSenal = new System.Windows.Forms.Label();
            this.lblTipoAudifono = new System.Windows.Forms.Label();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblNombreModelo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.tbpFranjaAdaptacion = new Dotnetrix.Controls.TabPageEX();
            this.linerFranjaAdaptacion = new Pavr.Drawing.Liner();
            this.pnlList.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.tbcAudifono.SuspendLayout();
            this.tbpDatos.SuspendLayout();
            this.tbpFranjaAdaptacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeleteItem
            // 
            this.lblDeleteItem.Location = new System.Drawing.Point(525, 418);
            // 
            // pnlList
            // 
            this.pnlList.Size = new System.Drawing.Size(721, 216);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(597, 163);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(597, 123);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(597, 83);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(597, 43);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(597, 3);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.tbcAudifono);
            this.pnlDetails.Location = new System.Drawing.Point(12, 234);
            this.pnlDetails.Size = new System.Drawing.Size(721, 476);
            this.pnlDetails.Controls.SetChildIndex(this.lblDeleteItem, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnAccept, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnCancel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.tbcAudifono, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(612, 446);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(493, 446);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(152, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(65, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtNombreModelo
            // 
            this.txtNombreModelo.Location = new System.Drawing.Point(152, 55);
            this.txtNombreModelo.Name = "txtNombreModelo";
            this.txtNombreModelo.Size = new System.Drawing.Size(343, 20);
            this.txtNombreModelo.TabIndex = 6;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(152, 132);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(343, 94);
            this.txtObservacion.TabIndex = 7;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(152, 96);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(232, 21);
            this.cmbMarca.TabIndex = 12;
            // 
            // cmbTipoAudifono
            // 
            this.cmbTipoAudifono.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoAudifono.FormattingEnabled = true;
            this.cmbTipoAudifono.Location = new System.Drawing.Point(152, 245);
            this.cmbTipoAudifono.Name = "cmbTipoAudifono";
            this.cmbTipoAudifono.Size = new System.Drawing.Size(232, 21);
            this.cmbTipoAudifono.TabIndex = 13;
            // 
            // radDigital
            // 
            this.radDigital.AutoSize = true;
            this.radDigital.Checked = true;
            this.radDigital.Location = new System.Drawing.Point(152, 281);
            this.radDigital.Name = "radDigital";
            this.radDigital.Size = new System.Drawing.Size(54, 17);
            this.radDigital.TabIndex = 14;
            this.radDigital.TabStop = true;
            this.radDigital.Text = "Digital";
            this.radDigital.UseVisualStyleBackColor = true;
            // 
            // radAnalogico
            // 
            this.radAnalogico.AutoSize = true;
            this.radAnalogico.Location = new System.Drawing.Point(212, 281);
            this.radAnalogico.Name = "radAnalogico";
            this.radAnalogico.Size = new System.Drawing.Size(72, 17);
            this.radAnalogico.TabIndex = 15;
            this.radAnalogico.TabStop = true;
            this.radAnalogico.Text = "Analogico";
            this.radAnalogico.UseVisualStyleBackColor = true;
            // 
            // chkProgramable
            // 
            this.chkProgramable.AutoSize = true;
            this.chkProgramable.Location = new System.Drawing.Point(152, 313);
            this.chkProgramable.Name = "chkProgramable";
            this.chkProgramable.Size = new System.Drawing.Size(15, 14);
            this.chkProgramable.TabIndex = 16;
            this.chkProgramable.UseVisualStyleBackColor = true;
            // 
            // txtPresionSalida
            // 
            this.txtPresionSalida.Location = new System.Drawing.Point(152, 343);
            this.txtPresionSalida.Name = "txtPresionSalida";
            this.txtPresionSalida.Size = new System.Drawing.Size(65, 20);
            this.txtPresionSalida.TabIndex = 17;
            // 
            // tbcAudifono
            // 
            this.tbcAudifono.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbcAudifono.Controls.Add(this.tbpDatos);
            this.tbcAudifono.Controls.Add(this.tbpFranjaAdaptacion);
            this.tbcAudifono.Location = new System.Drawing.Point(3, 3);
            this.tbcAudifono.Multiline = true;
            this.tbcAudifono.Name = "tbcAudifono";
            this.tbcAudifono.SelectedIndex = 1;
            this.tbcAudifono.Size = new System.Drawing.Size(715, 401);
            this.tbcAudifono.TabIndex = 18;
            // 
            // tbpDatos
            // 
            this.tbpDatos.Controls.Add(this.lblPresionSalida);
            this.tbpDatos.Controls.Add(this.lblProgramable);
            this.tbpDatos.Controls.Add(this.lblSenal);
            this.tbpDatos.Controls.Add(this.lblTipoAudifono);
            this.tbpDatos.Controls.Add(this.lblObservacion);
            this.tbpDatos.Controls.Add(this.lblMarca);
            this.tbpDatos.Controls.Add(this.lblNombreModelo);
            this.tbpDatos.Controls.Add(this.lblID);
            this.tbpDatos.Controls.Add(this.txtID);
            this.tbpDatos.Controls.Add(this.txtPresionSalida);
            this.tbpDatos.Controls.Add(this.txtNombreModelo);
            this.tbpDatos.Controls.Add(this.chkProgramable);
            this.tbpDatos.Controls.Add(this.txtObservacion);
            this.tbpDatos.Controls.Add(this.radAnalogico);
            this.tbpDatos.Controls.Add(this.cmbMarca);
            this.tbpDatos.Controls.Add(this.radDigital);
            this.tbpDatos.Controls.Add(this.cmbTipoAudifono);
            this.tbpDatos.Location = new System.Drawing.Point(27, 4);
            this.tbpDatos.Name = "tbpDatos";
            this.tbpDatos.Size = new System.Drawing.Size(684, 393);
            this.tbpDatos.TabIndex = 0;
            this.tbpDatos.Text = "Datos";
            // 
            // lblPresionSalida
            // 
            this.lblPresionSalida.AutoSize = true;
            this.lblPresionSalida.Location = new System.Drawing.Point(26, 346);
            this.lblPresionSalida.Name = "lblPresionSalida";
            this.lblPresionSalida.Size = new System.Drawing.Size(113, 13);
            this.lblPresionSalida.TabIndex = 25;
            this.lblPresionSalida.Text = "Presion Maxima Salida";
            // 
            // lblProgramable
            // 
            this.lblProgramable.AutoSize = true;
            this.lblProgramable.Location = new System.Drawing.Point(73, 314);
            this.lblProgramable.Name = "lblProgramable";
            this.lblProgramable.Size = new System.Drawing.Size(66, 13);
            this.lblProgramable.TabIndex = 24;
            this.lblProgramable.Text = "Programable";
            // 
            // lblSenal
            // 
            this.lblSenal.AutoSize = true;
            this.lblSenal.Location = new System.Drawing.Point(102, 283);
            this.lblSenal.Name = "lblSenal";
            this.lblSenal.Size = new System.Drawing.Size(34, 13);
            this.lblSenal.TabIndex = 23;
            this.lblSenal.Text = "Señal";
            // 
            // lblTipoAudifono
            // 
            this.lblTipoAudifono.AutoSize = true;
            this.lblTipoAudifono.Location = new System.Drawing.Point(102, 248);
            this.lblTipoAudifono.Name = "lblTipoAudifono";
            this.lblTipoAudifono.Size = new System.Drawing.Size(28, 13);
            this.lblTipoAudifono.TabIndex = 22;
            this.lblTipoAudifono.Text = "Tipo";
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(70, 135);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(67, 13);
            this.lblObservacion.TabIndex = 21;
            this.lblObservacion.Text = "Observación";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(102, 99);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 20;
            this.lblMarca.Text = "Marca";
            // 
            // lblNombreModelo
            // 
            this.lblNombreModelo.AutoSize = true;
            this.lblNombreModelo.Location = new System.Drawing.Point(40, 58);
            this.lblNombreModelo.Name = "lblNombreModelo";
            this.lblNombreModelo.Size = new System.Drawing.Size(97, 13);
            this.lblNombreModelo.TabIndex = 19;
            this.lblNombreModelo.Text = "Nombre de Modelo";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(119, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "ID";
            // 
            // tbpFranjaAdaptacion
            // 
            this.tbpFranjaAdaptacion.Controls.Add(this.linerFranjaAdaptacion);
            this.tbpFranjaAdaptacion.Location = new System.Drawing.Point(27, 4);
            this.tbpFranjaAdaptacion.Name = "tbpFranjaAdaptacion";
            this.tbpFranjaAdaptacion.Size = new System.Drawing.Size(684, 393);
            this.tbpFranjaAdaptacion.TabIndex = 1;
            this.tbpFranjaAdaptacion.Text = "Franja Adaptación";
            // 
            // linerFranjaAdaptacion
            // 
            this.linerFranjaAdaptacion.BackColor = System.Drawing.Color.Transparent;
            this.linerFranjaAdaptacion.CreateButtonText = "Generar Franja";
            this.linerFranjaAdaptacion.LegendCaption = "Leyendas";
            this.linerFranjaAdaptacion.LineColor = null;
            this.linerFranjaAdaptacion.Location = new System.Drawing.Point(16, 28);
            this.linerFranjaAdaptacion.MatrixLinesColor = System.Drawing.Color.LightGray;
            this.linerFranjaAdaptacion.Name = "linerFranjaAdaptacion";
            this.linerFranjaAdaptacion.PointColor = System.Drawing.Color.Black;
            this.linerFranjaAdaptacion.Size = new System.Drawing.Size(472, 296);
            this.linerFranjaAdaptacion.TabIndex = 8;
            // 
            // frmAudifonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 723);
            this.Name = "frmAudifonos";
            this.Text = "frmAudifonos";
            this.Load += new System.EventHandler(this.frmAudifonos_Load);
            this.pnlList.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.tbcAudifono.ResumeLayout(false);
            this.tbpDatos.ResumeLayout(false);
            this.tbpDatos.PerformLayout();
            this.tbpFranjaAdaptacion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtNombreModelo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbTipoAudifono;
        private System.Windows.Forms.RadioButton radAnalogico;
        private System.Windows.Forms.RadioButton radDigital;
        private System.Windows.Forms.CheckBox chkProgramable;
        private System.Windows.Forms.TextBox txtPresionSalida;
        private Dotnetrix.Controls.TabControlEX tbcAudifono;
        private Dotnetrix.Controls.TabPageEX tbpDatos;
        private Dotnetrix.Controls.TabPageEX tbpFranjaAdaptacion;
        private Pavr.Drawing.Liner linerFranjaAdaptacion;
        private System.Windows.Forms.Label lblProgramable;
        private System.Windows.Forms.Label lblSenal;
        private System.Windows.Forms.Label lblTipoAudifono;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNombreModelo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblPresionSalida;
    }
}