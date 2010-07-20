namespace Mds.Biodata.Forms
{
    partial class frmSeleccionAudifono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeleccionAudifono));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbcSeleccionAudifono = new Dotnetrix.Controls.TabControlEX();
            this.tbpSeleccionPaciente = new Dotnetrix.Controls.TabPageEX();
            this.ptbProgress = new System.Windows.Forms.PictureBox();
            this.dgvPacientes = new Medusa.Biodata.FrontEnd.UserControls.GridView(this.components);
            this.tbpAudiometriasRealizadas = new Dotnetrix.Controls.TabPageEX();
            this.radSeleccionarNinguno = new System.Windows.Forms.RadioButton();
            this.radSeleccionarTodos = new System.Windows.Forms.RadioButton();
            this.ptbProgressEstudios = new System.Windows.Forms.PictureBox();
            this.dgvEstudios = new Medusa.Biodata.FrontEnd.UserControls.GridView(this.components);
            this.tbpAdecuadas = new Dotnetrix.Controls.TabPageEX();
            this.ptbProgressAudifonos = new System.Windows.Forms.PictureBox();
            this.dgvAudifonosAceptados = new Medusa.Biodata.FrontEnd.UserControls.GridView(this.components);
            this.tbpSeleccionAudifono = new Dotnetrix.Controls.TabPageEX();
            this.txtNroSerie = new System.Windows.Forms.TextBox();
            this.lblNroSerie = new System.Windows.Forms.Label();
            this.dtpFechaProximaVisita = new System.Windows.Forms.DateTimePicker();
            this.lblFechaProximaVisita = new System.Windows.Forms.Label();
            this.chkUsoAudifono = new System.Windows.Forms.CheckBox();
            this.chkLecturaLabial = new System.Windows.Forms.CheckBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtInstrumentosUtilizados = new System.Windows.Forms.TextBox();
            this.dtpFechaSeleccion = new System.Windows.Forms.DateTimePicker();
            this.lblInstrumentosUtilizados = new System.Windows.Forms.Label();
            this.lblFechaSeleccion = new System.Windows.Forms.Label();
            this.bgwLoad = new System.ComponentModel.BackgroundWorker();
            this.btnAnterior = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.btnSiguiente = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.bgwLoadEstudios = new System.ComponentModel.BackgroundWorker();
            this.btnCerrar = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.bgwLoadAudifonos = new System.ComponentModel.BackgroundWorker();
            this.btnAceptar = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.tbcSeleccionAudifono.SuspendLayout();
            this.tbpSeleccionPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.tbpAudiometriasRealizadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgressEstudios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudios)).BeginInit();
            this.tbpAdecuadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgressAudifonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudifonosAceptados)).BeginInit();
            this.tbpSeleccionAudifono.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcSeleccionAudifono
            // 
            this.tbcSeleccionAudifono.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tbcSeleccionAudifono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcSeleccionAudifono.Controls.Add(this.tbpSeleccionPaciente);
            this.tbcSeleccionAudifono.Controls.Add(this.tbpAudiometriasRealizadas);
            this.tbcSeleccionAudifono.Controls.Add(this.tbpAdecuadas);
            this.tbcSeleccionAudifono.Controls.Add(this.tbpSeleccionAudifono);
            this.tbcSeleccionAudifono.Location = new System.Drawing.Point(12, 12);
            this.tbcSeleccionAudifono.Multiline = true;
            this.tbcSeleccionAudifono.Name = "tbcSeleccionAudifono";
            this.tbcSeleccionAudifono.SelectedIndex = 3;
            this.tbcSeleccionAudifono.Size = new System.Drawing.Size(760, 482);
            this.tbcSeleccionAudifono.TabIndex = 6;
            // 
            // tbpSeleccionPaciente
            // 
            this.tbpSeleccionPaciente.Controls.Add(this.ptbProgress);
            this.tbpSeleccionPaciente.Controls.Add(this.dgvPacientes);
            this.tbpSeleccionPaciente.Location = new System.Drawing.Point(50, 4);
            this.tbpSeleccionPaciente.Name = "tbpSeleccionPaciente";
            this.tbpSeleccionPaciente.Size = new System.Drawing.Size(706, 474);
            this.tbpSeleccionPaciente.TabIndex = 0;
            this.tbpSeleccionPaciente.Text = "Selección de Paciente";
            // 
            // ptbProgress
            // 
            this.ptbProgress.Image = ((System.Drawing.Image)(resources.GetObject("ptbProgress.Image")));
            this.ptbProgress.Location = new System.Drawing.Point(299, 219);
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
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvPacientes.EnableHeadersVisualStyles = false;
            this.dgvPacientes.GridColor = System.Drawing.Color.Silver;
            this.dgvPacientes.Location = new System.Drawing.Point(22, 40);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersVisible = false;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(618, 397);
            this.dgvPacientes.TabIndex = 0;
            // 
            // tbpAudiometriasRealizadas
            // 
            this.tbpAudiometriasRealizadas.Controls.Add(this.radSeleccionarNinguno);
            this.tbpAudiometriasRealizadas.Controls.Add(this.radSeleccionarTodos);
            this.tbpAudiometriasRealizadas.Controls.Add(this.ptbProgressEstudios);
            this.tbpAudiometriasRealizadas.Controls.Add(this.dgvEstudios);
            this.tbpAudiometriasRealizadas.Enabled = false;
            this.tbpAudiometriasRealizadas.Location = new System.Drawing.Point(50, 4);
            this.tbpAudiometriasRealizadas.Name = "tbpAudiometriasRealizadas";
            this.tbpAudiometriasRealizadas.Size = new System.Drawing.Size(706, 474);
            this.tbpAudiometriasRealizadas.TabIndex = 1;
            this.tbpAudiometriasRealizadas.Text = "Audiometrias realizadas";
            // 
            // radSeleccionarNinguno
            // 
            this.radSeleccionarNinguno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radSeleccionarNinguno.AutoSize = true;
            this.radSeleccionarNinguno.Location = new System.Drawing.Point(561, 442);
            this.radSeleccionarNinguno.Name = "radSeleccionarNinguno";
            this.radSeleccionarNinguno.Size = new System.Drawing.Size(124, 17);
            this.radSeleccionarNinguno.TabIndex = 9;
            this.radSeleccionarNinguno.Text = "Seleccionar Ninguno";
            this.radSeleccionarNinguno.UseVisualStyleBackColor = true;
            this.radSeleccionarNinguno.CheckedChanged += new System.EventHandler(this.radSeleccionarNinguno_CheckedChanged);
            // 
            // radSeleccionarTodos
            // 
            this.radSeleccionarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radSeleccionarTodos.AutoSize = true;
            this.radSeleccionarTodos.Checked = true;
            this.radSeleccionarTodos.Location = new System.Drawing.Point(422, 442);
            this.radSeleccionarTodos.Name = "radSeleccionarTodos";
            this.radSeleccionarTodos.Size = new System.Drawing.Size(114, 17);
            this.radSeleccionarTodos.TabIndex = 8;
            this.radSeleccionarTodos.TabStop = true;
            this.radSeleccionarTodos.Text = "Seleccionar Todos";
            this.radSeleccionarTodos.UseVisualStyleBackColor = true;
            this.radSeleccionarTodos.CheckedChanged += new System.EventHandler(this.radSeleccionarTodos_CheckedChanged);
            // 
            // ptbProgressEstudios
            // 
            this.ptbProgressEstudios.Image = ((System.Drawing.Image)(resources.GetObject("ptbProgressEstudios.Image")));
            this.ptbProgressEstudios.Location = new System.Drawing.Point(321, 218);
            this.ptbProgressEstudios.Name = "ptbProgressEstudios";
            this.ptbProgressEstudios.Size = new System.Drawing.Size(35, 34);
            this.ptbProgressEstudios.TabIndex = 7;
            this.ptbProgressEstudios.TabStop = false;
            this.ptbProgressEstudios.Visible = false;
            // 
            // dgvEstudios
            // 
            this.dgvEstudios.AllowUserToAddRows = false;
            this.dgvEstudios.AllowUserToDeleteRows = false;
            this.dgvEstudios.AllowUserToResizeRows = false;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEstudios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvEstudios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEstudios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEstudios.BackgroundColor = System.Drawing.Color.White;
            this.dgvEstudios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEstudios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEstudios.DefaultCellStyle = dataGridViewCellStyle33;
            this.dgvEstudios.EnableHeadersVisualStyles = false;
            this.dgvEstudios.GridColor = System.Drawing.Color.Silver;
            this.dgvEstudios.Location = new System.Drawing.Point(44, 39);
            this.dgvEstudios.MultiSelect = false;
            this.dgvEstudios.Name = "dgvEstudios";
            this.dgvEstudios.ReadOnly = true;
            this.dgvEstudios.RowHeadersVisible = false;
            this.dgvEstudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstudios.Size = new System.Drawing.Size(641, 397);
            this.dgvEstudios.TabIndex = 6;
            this.dgvEstudios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstudios_CellClick);
            // 
            // tbpAdecuadas
            // 
            this.tbpAdecuadas.Controls.Add(this.ptbProgressAudifonos);
            this.tbpAdecuadas.Controls.Add(this.dgvAudifonosAceptados);
            this.tbpAdecuadas.Enabled = false;
            this.tbpAdecuadas.Location = new System.Drawing.Point(50, 4);
            this.tbpAdecuadas.Name = "tbpAdecuadas";
            this.tbpAdecuadas.Size = new System.Drawing.Size(706, 474);
            this.tbpAdecuadas.TabIndex = 2;
            this.tbpAdecuadas.Text = "Adecuadas";
            // 
            // ptbProgressAudifonos
            // 
            this.ptbProgressAudifonos.Image = ((System.Drawing.Image)(resources.GetObject("ptbProgressAudifonos.Image")));
            this.ptbProgressAudifonos.Location = new System.Drawing.Point(347, 220);
            this.ptbProgressAudifonos.Name = "ptbProgressAudifonos";
            this.ptbProgressAudifonos.Size = new System.Drawing.Size(35, 34);
            this.ptbProgressAudifonos.TabIndex = 8;
            this.ptbProgressAudifonos.TabStop = false;
            this.ptbProgressAudifonos.Visible = false;
            // 
            // dgvAudifonosAceptados
            // 
            this.dgvAudifonosAceptados.AllowUserToAddRows = false;
            this.dgvAudifonosAceptados.AllowUserToDeleteRows = false;
            this.dgvAudifonosAceptados.AllowUserToResizeRows = false;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAudifonosAceptados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvAudifonosAceptados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAudifonosAceptados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAudifonosAceptados.BackgroundColor = System.Drawing.Color.White;
            this.dgvAudifonosAceptados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAudifonosAceptados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            this.dgvAudifonosAceptados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAudifonosAceptados.DefaultCellStyle = dataGridViewCellStyle36;
            this.dgvAudifonosAceptados.EnableHeadersVisualStyles = false;
            this.dgvAudifonosAceptados.GridColor = System.Drawing.Color.Silver;
            this.dgvAudifonosAceptados.Location = new System.Drawing.Point(44, 39);
            this.dgvAudifonosAceptados.MultiSelect = false;
            this.dgvAudifonosAceptados.Name = "dgvAudifonosAceptados";
            this.dgvAudifonosAceptados.ReadOnly = true;
            this.dgvAudifonosAceptados.RowHeadersVisible = false;
            this.dgvAudifonosAceptados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAudifonosAceptados.Size = new System.Drawing.Size(641, 397);
            this.dgvAudifonosAceptados.TabIndex = 7;
            // 
            // tbpSeleccionAudifono
            // 
            this.tbpSeleccionAudifono.Controls.Add(this.txtNroSerie);
            this.tbpSeleccionAudifono.Controls.Add(this.lblNroSerie);
            this.tbpSeleccionAudifono.Controls.Add(this.dtpFechaProximaVisita);
            this.tbpSeleccionAudifono.Controls.Add(this.lblFechaProximaVisita);
            this.tbpSeleccionAudifono.Controls.Add(this.chkUsoAudifono);
            this.tbpSeleccionAudifono.Controls.Add(this.chkLecturaLabial);
            this.tbpSeleccionAudifono.Controls.Add(this.txtObservaciones);
            this.tbpSeleccionAudifono.Controls.Add(this.lblObservaciones);
            this.tbpSeleccionAudifono.Controls.Add(this.txtInstrumentosUtilizados);
            this.tbpSeleccionAudifono.Controls.Add(this.dtpFechaSeleccion);
            this.tbpSeleccionAudifono.Controls.Add(this.lblInstrumentosUtilizados);
            this.tbpSeleccionAudifono.Controls.Add(this.lblFechaSeleccion);
            this.tbpSeleccionAudifono.Location = new System.Drawing.Point(50, 4);
            this.tbpSeleccionAudifono.Name = "tbpSeleccionAudifono";
            this.tbpSeleccionAudifono.Size = new System.Drawing.Size(706, 474);
            this.tbpSeleccionAudifono.TabIndex = 3;
            this.tbpSeleccionAudifono.Text = "Selección de Audifono";
            // 
            // txtNroSerie
            // 
            this.txtNroSerie.Location = new System.Drawing.Point(239, 359);
            this.txtNroSerie.Name = "txtNroSerie";
            this.txtNroSerie.Size = new System.Drawing.Size(428, 20);
            this.txtNroSerie.TabIndex = 37;
            // 
            // lblNroSerie
            // 
            this.lblNroSerie.AutoSize = true;
            this.lblNroSerie.Location = new System.Drawing.Point(167, 359);
            this.lblNroSerie.Name = "lblNroSerie";
            this.lblNroSerie.Size = new System.Drawing.Size(66, 13);
            this.lblNroSerie.TabIndex = 36;
            this.lblNroSerie.Text = "Nro de Serie";
            // 
            // dtpFechaProximaVisita
            // 
            this.dtpFechaProximaVisita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaProximaVisita.Location = new System.Drawing.Point(239, 324);
            this.dtpFechaProximaVisita.Name = "dtpFechaProximaVisita";
            this.dtpFechaProximaVisita.Size = new System.Drawing.Size(154, 20);
            this.dtpFechaProximaVisita.TabIndex = 34;
            // 
            // lblFechaProximaVisita
            // 
            this.lblFechaProximaVisita.AutoSize = true;
            this.lblFechaProximaVisita.Location = new System.Drawing.Point(113, 328);
            this.lblFechaProximaVisita.Name = "lblFechaProximaVisita";
            this.lblFechaProximaVisita.Size = new System.Drawing.Size(120, 13);
            this.lblFechaProximaVisita.TabIndex = 35;
            this.lblFechaProximaVisita.Text = "Fecha de Proxima Visita";
            // 
            // chkUsoAudifono
            // 
            this.chkUsoAudifono.AutoSize = true;
            this.chkUsoAudifono.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkUsoAudifono.Location = new System.Drawing.Point(146, 287);
            this.chkUsoAudifono.Name = "chkUsoAudifono";
            this.chkUsoAudifono.Size = new System.Drawing.Size(105, 17);
            this.chkUsoAudifono.TabIndex = 33;
            this.chkUsoAudifono.Text = "Uso de Audifono";
            this.chkUsoAudifono.UseVisualStyleBackColor = true;
            // 
            // chkLecturaLabial
            // 
            this.chkLecturaLabial.AutoSize = true;
            this.chkLecturaLabial.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkLecturaLabial.Location = new System.Drawing.Point(158, 253);
            this.chkLecturaLabial.Name = "chkLecturaLabial";
            this.chkLecturaLabial.Size = new System.Drawing.Size(93, 17);
            this.chkLecturaLabial.TabIndex = 32;
            this.chkLecturaLabial.Text = "Lectura Labial";
            this.chkLecturaLabial.UseVisualStyleBackColor = true;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(239, 158);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(428, 74);
            this.txtObservaciones.TabIndex = 28;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(155, 161);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 29;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // txtInstrumentosUtilizados
            // 
            this.txtInstrumentosUtilizados.Location = new System.Drawing.Point(239, 63);
            this.txtInstrumentosUtilizados.Multiline = true;
            this.txtInstrumentosUtilizados.Name = "txtInstrumentosUtilizados";
            this.txtInstrumentosUtilizados.Size = new System.Drawing.Size(428, 76);
            this.txtInstrumentosUtilizados.TabIndex = 24;
            // 
            // dtpFechaSeleccion
            // 
            this.dtpFechaSeleccion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaSeleccion.Location = new System.Drawing.Point(239, 21);
            this.dtpFechaSeleccion.Name = "dtpFechaSeleccion";
            this.dtpFechaSeleccion.Size = new System.Drawing.Size(154, 20);
            this.dtpFechaSeleccion.TabIndex = 25;
            // 
            // lblInstrumentosUtilizados
            // 
            this.lblInstrumentosUtilizados.AutoSize = true;
            this.lblInstrumentosUtilizados.Location = new System.Drawing.Point(118, 66);
            this.lblInstrumentosUtilizados.Name = "lblInstrumentosUtilizados";
            this.lblInstrumentosUtilizados.Size = new System.Drawing.Size(115, 13);
            this.lblInstrumentosUtilizados.TabIndex = 27;
            this.lblInstrumentosUtilizados.Text = "Instrumentos Utilizados";
            // 
            // lblFechaSeleccion
            // 
            this.lblFechaSeleccion.AutoSize = true;
            this.lblFechaSeleccion.Location = new System.Drawing.Point(131, 25);
            this.lblFechaSeleccion.Name = "lblFechaSeleccion";
            this.lblFechaSeleccion.Size = new System.Drawing.Size(102, 13);
            this.lblFechaSeleccion.TabIndex = 26;
            this.lblFechaSeleccion.Text = "Fecha de Selección";
            // 
            // bgwLoad
            // 
            this.bgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoad_DoWork);
            this.bgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoad_RunWorkerCompleted);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAnterior.Enabled = false;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnterior.Location = new System.Drawing.Point(317, 505);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(91, 30);
            this.btnAnterior.TabIndex = 8;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnAnterior_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguiente.Location = new System.Drawing.Point(414, 505);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(93, 30);
            this.btnSiguiente.TabIndex = 7;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnSiguiente_Click);
            // 
            // bgwLoadEstudios
            // 
            this.bgwLoadEstudios.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoadEstudios_DoWork);
            this.bgwLoadEstudios.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoadEstudios_RunWorkerCompleted);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrar.Location = new System.Drawing.Point(649, 505);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(123, 30);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnCerrar_Click);
            // 
            // bgwLoadAudifonos
            // 
            this.bgwLoadAudifonos.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoadAudifonos_DoWork);
            this.bgwLoadAudifonos.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoadAudifonos_RunWorkerCompleted);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Image = null;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.Location = new System.Drawing.Point(520, 505);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(123, 30);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnAceptar_Click);
            // 
            // frmSeleccionAudifono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 547);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.tbcSeleccionAudifono);
            this.Name = "frmSeleccionAudifono";
            this.Text = "frmSeleccionAudifono";
            this.Load += new System.EventHandler(this.frmSeleccionAudifono_Load);
            this.tbcSeleccionAudifono.ResumeLayout(false);
            this.tbpSeleccionPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.tbpAudiometriasRealizadas.ResumeLayout(false);
            this.tbpAudiometriasRealizadas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgressEstudios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstudios)).EndInit();
            this.tbpAdecuadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgressAudifonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudifonosAceptados)).EndInit();
            this.tbpSeleccionAudifono.ResumeLayout(false);
            this.tbpSeleccionAudifono.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Dotnetrix.Controls.TabControlEX tbcSeleccionAudifono;
        private Dotnetrix.Controls.TabPageEX tbpSeleccionPaciente;
        internal System.Windows.Forms.PictureBox ptbProgress;
        private Medusa.Biodata.FrontEnd.UserControls.GridView dgvPacientes;
        private Dotnetrix.Controls.TabPageEX tbpAudiometriasRealizadas;
        private Dotnetrix.Controls.TabPageEX tbpAdecuadas;
        private System.ComponentModel.BackgroundWorker bgwLoad;
        private Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnAnterior;
        private Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnSiguiente;
        internal System.Windows.Forms.PictureBox ptbProgressEstudios;
        private Medusa.Biodata.FrontEnd.UserControls.GridView dgvEstudios;
        private System.ComponentModel.BackgroundWorker bgwLoadEstudios;
        private Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnCerrar;
        private Medusa.Biodata.FrontEnd.UserControls.GridView dgvAudifonosAceptados;
        private System.ComponentModel.BackgroundWorker bgwLoadAudifonos;
        internal System.Windows.Forms.PictureBox ptbProgressAudifonos;
        private System.Windows.Forms.RadioButton radSeleccionarNinguno;
        private System.Windows.Forms.RadioButton radSeleccionarTodos;
        private Dotnetrix.Controls.TabPageEX tbpSeleccionAudifono;
        private System.Windows.Forms.TextBox txtInstrumentosUtilizados;
        private System.Windows.Forms.DateTimePicker dtpFechaSeleccion;
        private System.Windows.Forms.Label lblInstrumentosUtilizados;
        private System.Windows.Forms.Label lblFechaSeleccion;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.CheckBox chkLecturaLabial;
        private System.Windows.Forms.CheckBox chkUsoAudifono;
        private System.Windows.Forms.Label lblNroSerie;
        private System.Windows.Forms.DateTimePicker dtpFechaProximaVisita;
        private System.Windows.Forms.Label lblFechaProximaVisita;
        private System.Windows.Forms.TextBox txtNroSerie;
        private Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnAceptar;

    }
}