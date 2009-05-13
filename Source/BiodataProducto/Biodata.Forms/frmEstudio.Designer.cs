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
            this.tbcEstudio = new System.Windows.Forms.TabControl();
            this.tbpSeleccionPaciente = new System.Windows.Forms.TabPage();
            this.ptbProgress = new System.Windows.Forms.PictureBox();
            this.dgvPacientes = new Medusa.Biodata.FrontEnd.UserControls.GridView(this.components);
            this.tbpAccionARealizar = new System.Windows.Forms.TabPage();
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
            this.tbpEstudio = new System.Windows.Forms.TabPage();
            this.btnRegistrarEstudio = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.btnAnterior = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.btnSiguiente = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.bgwLoad = new System.ComponentModel.BackgroundWorker();
            this.btnCerrar = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.tbcEstudio.SuspendLayout();
            this.tbpSeleccionPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.tbpAccionARealizar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcEstudio
            // 
            this.tbcEstudio.Controls.Add(this.tbpSeleccionPaciente);
            this.tbcEstudio.Controls.Add(this.tbpAccionARealizar);
            this.tbcEstudio.Controls.Add(this.tbpEstudio);
            this.tbcEstudio.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbcEstudio.Location = new System.Drawing.Point(0, 0);
            this.tbcEstudio.Name = "tbcEstudio";
            this.tbcEstudio.SelectedIndex = 0;
            this.tbcEstudio.Size = new System.Drawing.Size(997, 470);
            this.tbcEstudio.TabIndex = 0;
            // 
            // tbpSeleccionPaciente
            // 
            this.tbpSeleccionPaciente.Controls.Add(this.ptbProgress);
            this.tbpSeleccionPaciente.Controls.Add(this.dgvPacientes);
            this.tbpSeleccionPaciente.Location = new System.Drawing.Point(4, 22);
            this.tbpSeleccionPaciente.Name = "tbpSeleccionPaciente";
            this.tbpSeleccionPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSeleccionPaciente.Size = new System.Drawing.Size(989, 444);
            this.tbpSeleccionPaciente.TabIndex = 0;
            this.tbpSeleccionPaciente.Text = "Selección de Paciente";
            this.tbpSeleccionPaciente.UseVisualStyleBackColor = true;
            // 
            // ptbProgress
            // 
            this.ptbProgress.Image = ((System.Drawing.Image)(resources.GetObject("ptbProgress.Image")));
            this.ptbProgress.Location = new System.Drawing.Point(557, 217);
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
            this.dgvPacientes.Location = new System.Drawing.Point(43, 34);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(914, 404);
            this.dgvPacientes.TabIndex = 0;
            // 
            // tbpAccionARealizar
            // 
            this.tbpAccionARealizar.Controls.Add(this.cmbTipoEstudio);
            this.tbpAccionARealizar.Controls.Add(this.txtObservaciones);
            this.tbpAccionARealizar.Controls.Add(this.txtInstrumentosUtilizados);
            this.tbpAccionARealizar.Controls.Add(this.dtpFechaEstudio);
            this.tbpAccionARealizar.Controls.Add(this.txtNombre);
            this.tbpAccionARealizar.Controls.Add(this.lblTipoEstudio);
            this.tbpAccionARealizar.Controls.Add(this.lblObservaciones);
            this.tbpAccionARealizar.Controls.Add(this.lblInstrumentosUtilizados);
            this.tbpAccionARealizar.Controls.Add(this.lblFechaEstudio);
            this.tbpAccionARealizar.Controls.Add(this.lblNombre);
            this.tbpAccionARealizar.Location = new System.Drawing.Point(4, 22);
            this.tbpAccionARealizar.Name = "tbpAccionARealizar";
            this.tbpAccionARealizar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAccionARealizar.Size = new System.Drawing.Size(989, 376);
            this.tbpAccionARealizar.TabIndex = 1;
            this.tbpAccionARealizar.Text = "Acción a realizar";
            this.tbpAccionARealizar.UseVisualStyleBackColor = true;
            // 
            // cmbTipoEstudio
            // 
            this.cmbTipoEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEstudio.FormattingEnabled = true;
            this.cmbTipoEstudio.Location = new System.Drawing.Point(144, 361);
            this.cmbTipoEstudio.Name = "cmbTipoEstudio";
            this.cmbTipoEstudio.Size = new System.Drawing.Size(238, 21);
            this.cmbTipoEstudio.TabIndex = 9;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(144, 249);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(416, 94);
            this.txtObservaciones.TabIndex = 8;
            // 
            // txtInstrumentosUtilizados
            // 
            this.txtInstrumentosUtilizados.Location = new System.Drawing.Point(144, 144);
            this.txtInstrumentosUtilizados.Multiline = true;
            this.txtInstrumentosUtilizados.Name = "txtInstrumentosUtilizados";
            this.txtInstrumentosUtilizados.Size = new System.Drawing.Size(416, 86);
            this.txtInstrumentosUtilizados.TabIndex = 7;
            // 
            // dtpFechaEstudio
            // 
            this.dtpFechaEstudio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstudio.Location = new System.Drawing.Point(144, 105);
            this.dtpFechaEstudio.Name = "dtpFechaEstudio";
            this.dtpFechaEstudio.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaEstudio.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(144, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(238, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblTipoEstudio
            // 
            this.lblTipoEstudio.AutoSize = true;
            this.lblTipoEstudio.Location = new System.Drawing.Point(72, 364);
            this.lblTipoEstudio.Name = "lblTipoEstudio";
            this.lblTipoEstudio.Size = new System.Drawing.Size(66, 13);
            this.lblTipoEstudio.TabIndex = 4;
            this.lblTipoEstudio.Text = "Tipo Estudio";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(60, 249);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 3;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // lblInstrumentosUtilizados
            // 
            this.lblInstrumentosUtilizados.AutoSize = true;
            this.lblInstrumentosUtilizados.Location = new System.Drawing.Point(23, 144);
            this.lblInstrumentosUtilizados.Name = "lblInstrumentosUtilizados";
            this.lblInstrumentosUtilizados.Size = new System.Drawing.Size(115, 13);
            this.lblInstrumentosUtilizados.TabIndex = 2;
            this.lblInstrumentosUtilizados.Text = "Instrumentos Utilizados";
            // 
            // lblFechaEstudio
            // 
            this.lblFechaEstudio.AutoSize = true;
            this.lblFechaEstudio.Location = new System.Drawing.Point(101, 109);
            this.lblFechaEstudio.Name = "lblFechaEstudio";
            this.lblFechaEstudio.Size = new System.Drawing.Size(37, 13);
            this.lblFechaEstudio.TabIndex = 1;
            this.lblFechaEstudio.Text = "Fecha";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(94, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // tbpEstudio
            // 
            this.tbpEstudio.Location = new System.Drawing.Point(4, 22);
            this.tbpEstudio.Name = "tbpEstudio";
            this.tbpEstudio.Size = new System.Drawing.Size(989, 376);
            this.tbpEstudio.TabIndex = 2;
            this.tbpEstudio.Text = "Estudio";
            this.tbpEstudio.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarEstudio
            // 
            this.btnRegistrarEstudio.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarEstudio.Image")));
            this.btnRegistrarEstudio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarEstudio.Location = new System.Drawing.Point(699, 489);
            this.btnRegistrarEstudio.Name = "btnRegistrarEstudio";
            this.btnRegistrarEstudio.Size = new System.Drawing.Size(133, 30);
            this.btnRegistrarEstudio.TabIndex = 4;
            this.btnRegistrarEstudio.Texto = "Registrar Estudio";
            this.btnRegistrarEstudio.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnRegistrarEstudio_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnterior.Location = new System.Drawing.Point(381, 489);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(91, 30);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Texto = "Anterior";
            this.btnAnterior.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguiente.Location = new System.Drawing.Point(478, 489);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(93, 30);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Texto = "Siguiente";
            this.btnSiguiente.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnSiguiente_Click);
            // 
            // bgwLoad
            // 
            this.bgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoad_DoWork);
            this.bgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoad_RunWorkerCompleted);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(838, 489);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(123, 30);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Texto = "Cerrar";
            this.btnCerrar.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnCerrar_Click);
            // 
            // frmEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 531);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnRegistrarEstudio);
            this.Controls.Add(this.tbcEstudio);
            this.Controls.Add(this.btnSiguiente);
            this.Name = "frmEstudio";
            this.Text = "frmEstudio";
            this.Load += new System.EventHandler(this.frmEstudio_Load);
            this.tbcEstudio.ResumeLayout(false);
            this.tbpSeleccionPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.tbpAccionARealizar.ResumeLayout(false);
            this.tbpAccionARealizar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcEstudio;
        private System.Windows.Forms.TabPage tbpSeleccionPaciente;
        private System.Windows.Forms.TabPage tbpAccionARealizar;
        private System.Windows.Forms.TabPage tbpEstudio;
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
    }
}