namespace Mds.Biodata.Forms
{
    partial class frmEstudio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ptbProgress = new System.Windows.Forms.PictureBox();
            this.dgvPacientes = new Medusa.Biodata.FrontEnd.UserControls.GridView(this.components);
            this.cmbTipoEstudio = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtInstrumentosUtilizados = new System.Windows.Forms.TextBox();
            this.dtpFechaEstudio = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoEstudio = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.lblInstrumentosUtilizados = new System.Windows.Forms.Label();
            this.lblFechaEstudio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnRegistrarEstudio = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.btnAnterior = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.btnSiguiente = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.bgwLoad = new System.ComponentModel.BackgroundWorker();
            this.btnCerrar = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.tbcEstudio = new Dotnetrix.Controls.TabControlEX();
            this.tbpSeleccionPaciente = new Dotnetrix.Controls.TabPageEX();
            this.tbpAccionARealizar = new Dotnetrix.Controls.TabPageEX();
            this.tbpEstudio = new Dotnetrix.Controls.TabPageEX();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.tbcEstudio.SuspendLayout();
            this.tbpSeleccionPaciente.SuspendLayout();
            this.tbpAccionARealizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbProgress
            // 
            this.ptbProgress.Image = ((System.Drawing.Image)(resources.GetObject("ptbProgress.Image")));
            this.ptbProgress.Location = new System.Drawing.Point(470, 184);
            this.ptbProgress.Name = "ptbProgress";
            this.ptbProgress.Size = new System.Drawing.Size(35, 34);
            this.ptbProgress.TabIndex = 5;
            this.ptbProgress.TabStop = false;
            this.ptbProgress.Visible = false;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPacientes.EnableHeadersVisualStyles = false;
            this.dgvPacientes.GridColor = System.Drawing.Color.Silver;
            this.dgvPacientes.Location = new System.Drawing.Point(22, 40);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(914, 386);
            this.dgvPacientes.TabIndex = 0;
            // 
            // cmbTipoEstudio
            // 
            this.cmbTipoEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEstudio.FormattingEnabled = true;
            this.cmbTipoEstudio.Location = new System.Drawing.Point(138, 329);
            this.cmbTipoEstudio.Name = "cmbTipoEstudio";
            this.cmbTipoEstudio.Size = new System.Drawing.Size(238, 21);
            this.cmbTipoEstudio.TabIndex = 9;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(138, 220);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(416, 90);
            this.txtObservaciones.TabIndex = 8;
            // 
            // txtInstrumentosUtilizados
            // 
            this.txtInstrumentosUtilizados.Location = new System.Drawing.Point(138, 104);
            this.txtInstrumentosUtilizados.Multiline = true;
            this.txtInstrumentosUtilizados.Name = "txtInstrumentosUtilizados";
            this.txtInstrumentosUtilizados.Size = new System.Drawing.Size(416, 97);
            this.txtInstrumentosUtilizados.TabIndex = 7;
            // 
            // dtpFechaEstudio
            // 
            this.dtpFechaEstudio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstudio.Location = new System.Drawing.Point(138, 67);
            this.dtpFechaEstudio.Name = "dtpFechaEstudio";
            this.dtpFechaEstudio.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaEstudio.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblTipoEstudio
            // 
            this.lblTipoEstudio.AutoSize = true;
            this.lblTipoEstudio.Location = new System.Drawing.Point(66, 332);
            this.lblTipoEstudio.Name = "lblTipoEstudio";
            this.lblTipoEstudio.Size = new System.Drawing.Size(66, 13);
            this.lblTipoEstudio.TabIndex = 4;
            this.lblTipoEstudio.Text = "Tipo Estudio";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(54, 223);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 3;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // lblInstrumentosUtilizados
            // 
            this.lblInstrumentosUtilizados.AutoSize = true;
            this.lblInstrumentosUtilizados.Location = new System.Drawing.Point(17, 104);
            this.lblInstrumentosUtilizados.Name = "lblInstrumentosUtilizados";
            this.lblInstrumentosUtilizados.Size = new System.Drawing.Size(115, 13);
            this.lblInstrumentosUtilizados.TabIndex = 2;
            this.lblInstrumentosUtilizados.Text = "Instrumentos Utilizados";
            // 
            // lblFechaEstudio
            // 
            this.lblFechaEstudio.AutoSize = true;
            this.lblFechaEstudio.Location = new System.Drawing.Point(95, 71);
            this.lblFechaEstudio.Name = "lblFechaEstudio";
            this.lblFechaEstudio.Size = new System.Drawing.Size(37, 13);
            this.lblFechaEstudio.TabIndex = 1;
            this.lblFechaEstudio.Text = "Fecha";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(88, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnRegistrarEstudio
            // 
            this.btnRegistrarEstudio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarEstudio.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarEstudio.Image")));
            this.btnRegistrarEstudio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarEstudio.Location = new System.Drawing.Point(775, 489);
            this.btnRegistrarEstudio.Name = "btnRegistrarEstudio";
            this.btnRegistrarEstudio.Size = new System.Drawing.Size(133, 30);
            this.btnRegistrarEstudio.TabIndex = 4;
            this.btnRegistrarEstudio.Text = "Registrar Estudio";
            this.btnRegistrarEstudio.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnRegistrarEstudio_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnterior.Location = new System.Drawing.Point(381, 489);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(91, 30);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguiente.Location = new System.Drawing.Point(478, 489);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(93, 30);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnSiguiente_Click);
            // 
            // bgwLoad
            // 
            this.bgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoad_DoWork);
            this.bgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoad_RunWorkerCompleted);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(914, 489);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(123, 30);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnCerrar_Click);
            // 
            // tbcEstudio
            // 
            this.tbcEstudio.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbcEstudio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcEstudio.Controls.Add(this.tbpSeleccionPaciente);
            this.tbcEstudio.Controls.Add(this.tbpAccionARealizar);
            this.tbcEstudio.Controls.Add(this.tbpEstudio);
            this.tbcEstudio.Location = new System.Drawing.Point(4, 12);
            this.tbcEstudio.Multiline = true;
            this.tbcEstudio.Name = "tbcEstudio";
            this.tbcEstudio.SelectedIndex = 0;
            this.tbcEstudio.Size = new System.Drawing.Size(1033, 471);
            this.tbcEstudio.TabIndex = 5;
            // 
            // tbpSeleccionPaciente
            // 
            this.tbpSeleccionPaciente.Controls.Add(this.ptbProgress);
            this.tbpSeleccionPaciente.Controls.Add(this.dgvPacientes);
            this.tbpSeleccionPaciente.Location = new System.Drawing.Point(27, 4);
            this.tbpSeleccionPaciente.Name = "tbpSeleccionPaciente";
            this.tbpSeleccionPaciente.Size = new System.Drawing.Size(1002, 463);
            this.tbpSeleccionPaciente.TabIndex = 0;
            this.tbpSeleccionPaciente.Text = "Selección de Paciente";
            // 
            // tbpAccionARealizar
            // 
            this.tbpAccionARealizar.Controls.Add(this.cmbTipoEstudio);
            this.tbpAccionARealizar.Controls.Add(this.lblTipoEstudio);
            this.tbpAccionARealizar.Controls.Add(this.txtNombre);
            this.tbpAccionARealizar.Controls.Add(this.txtObservaciones);
            this.tbpAccionARealizar.Controls.Add(this.lblNombre);
            this.tbpAccionARealizar.Controls.Add(this.txtInstrumentosUtilizados);
            this.tbpAccionARealizar.Controls.Add(this.lblFechaEstudio);
            this.tbpAccionARealizar.Controls.Add(this.lblObservaciones);
            this.tbpAccionARealizar.Controls.Add(this.dtpFechaEstudio);
            this.tbpAccionARealizar.Controls.Add(this.lblInstrumentosUtilizados);
            this.tbpAccionARealizar.Enabled = false;
            this.tbpAccionARealizar.Location = new System.Drawing.Point(27, 4);
            this.tbpAccionARealizar.Name = "tbpAccionARealizar";
            this.tbpAccionARealizar.Size = new System.Drawing.Size(1002, 463);
            this.tbpAccionARealizar.TabIndex = 1;
            this.tbpAccionARealizar.Text = "Acción a realizar";
            // 
            // tbpEstudio
            // 
            this.tbpEstudio.Enabled = false;
            this.tbpEstudio.Location = new System.Drawing.Point(27, 4);
            this.tbpEstudio.Name = "tbpEstudio";
            this.tbpEstudio.Size = new System.Drawing.Size(1002, 463);
            this.tbpEstudio.TabIndex = 2;
            this.tbpEstudio.Text = "Estudio";
            // 
            // frmEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 577);
            this.Controls.Add(this.tbcEstudio);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnRegistrarEstudio);
            this.Controls.Add(this.btnSiguiente);
            this.Name = "frmEstudio";
            this.Text = "frmEstudio";
            this.Load += new System.EventHandler(this.frmEstudio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.tbcEstudio.ResumeLayout(false);
            this.tbpSeleccionPaciente.ResumeLayout(false);
            this.tbpAccionARealizar.ResumeLayout(false);
            this.tbpAccionARealizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnSiguiente;
        private Medusa.Biodata.FrontEnd.UserControls.GridView dgvPacientes;
        private Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnAnterior;
        internal System.Windows.Forms.PictureBox ptbProgress;
        private System.ComponentModel.BackgroundWorker bgwLoad;
        private System.Windows.Forms.Label lblInstrumentosUtilizados;
        private System.Windows.Forms.Label lblFechaEstudio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoEstudio;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaEstudio;
        private System.Windows.Forms.TextBox txtInstrumentosUtilizados;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.ComboBox cmbTipoEstudio;
        private Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnCerrar;
        private Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnRegistrarEstudio;
        private Dotnetrix.Controls.TabControlEX tbcEstudio;
        private Dotnetrix.Controls.TabPageEX tbpSeleccionPaciente;
        private Dotnetrix.Controls.TabPageEX tbpAccionARealizar;
        private Dotnetrix.Controls.TabPageEX tbpEstudio;
    }
}