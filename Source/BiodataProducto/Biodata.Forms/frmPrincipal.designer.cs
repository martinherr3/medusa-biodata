namespace Mds.Biodata.Forms
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tosPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsbUsuarioLogueado = new System.Windows.Forms.ToolStripLabel();
            this.tsbPaciente = new System.Windows.Forms.ToolStripButton();
            this.tsbEstudio = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRecordatorio = new System.Windows.Forms.ToolStripButton();
            this.tsbAudifono = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbReportePaciente = new System.Windows.Forms.ToolStripButton();
            this.tsbReporteAudifono = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAyuda = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestionPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestionCiudad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestionObraSocial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSeleccionAudifono = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEstudio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevoEstudio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsultarEstudio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAudifono = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestionAudifono = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgenda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRecordatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInformeFichaPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportePaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReporteAudifono = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReporteObraSocial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReporteEstudiosPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReporteRecordatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReportePacientesPorAudifono = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReporteAudifonosPorPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHerramientasSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestionParametrosSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCambioPasswordUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBackUpBaseDatos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmManualAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmObraSocial = new System.Windows.Forms.ToolStripMenuItem();
            this.spcRight = new System.Windows.Forms.SplitContainer();
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tosPrincipal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.spcRight.Panel1.SuspendLayout();
            this.spcRight.Panel2.SuspendLayout();
            this.spcRight.SuspendLayout();
            this.splitLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // tosPrincipal
            // 
            this.tosPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tosPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUsuarioLogueado,
            this.tsbPaciente,
            this.tsbEstudio,
            this.toolStripSeparator1,
            this.tsbRecordatorio,
            this.tsbAudifono,
            this.toolStripSeparator2,
            this.tsbReportePaciente,
            this.tsbReporteAudifono,
            this.toolStripSeparator3,
            this.tsbAyuda});
            this.tosPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tosPrincipal.Name = "tosPrincipal";
            this.tosPrincipal.Size = new System.Drawing.Size(936, 39);
            this.tosPrincipal.TabIndex = 2;
            this.tosPrincipal.Text = "ToolStrip1";
            // 
            // tsbUsuarioLogueado
            // 
            this.tsbUsuarioLogueado.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbUsuarioLogueado.Name = "tsbUsuarioLogueado";
            this.tsbUsuarioLogueado.Size = new System.Drawing.Size(50, 36);
            this.tsbUsuarioLogueado.Text = "Usuario: ";
            // 
            // tsbPaciente
            // 
            this.tsbPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPaciente.Image = ((System.Drawing.Image)(resources.GetObject("tsbPaciente.Image")));
            this.tsbPaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPaciente.Name = "tsbPaciente";
            this.tsbPaciente.Size = new System.Drawing.Size(36, 36);
            this.tsbPaciente.Text = "Pacientes";
            // 
            // tsbEstudio
            // 
            this.tsbEstudio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEstudio.Image = ((System.Drawing.Image)(resources.GetObject("tsbEstudio.Image")));
            this.tsbEstudio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEstudio.Name = "tsbEstudio";
            this.tsbEstudio.Size = new System.Drawing.Size(36, 36);
            this.tsbEstudio.Text = "Estudio";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbRecordatorio
            // 
            this.tsbRecordatorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRecordatorio.Image = ((System.Drawing.Image)(resources.GetObject("tsbRecordatorio.Image")));
            this.tsbRecordatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRecordatorio.Name = "tsbRecordatorio";
            this.tsbRecordatorio.Size = new System.Drawing.Size(36, 36);
            this.tsbRecordatorio.Text = "Recordatorios";
            // 
            // tsbAudifono
            // 
            this.tsbAudifono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAudifono.Image = ((System.Drawing.Image)(resources.GetObject("tsbAudifono.Image")));
            this.tsbAudifono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAudifono.Name = "tsbAudifono";
            this.tsbAudifono.Size = new System.Drawing.Size(36, 36);
            this.tsbAudifono.Text = "Audifonos";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbReportePaciente
            // 
            this.tsbReportePaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReportePaciente.Image = ((System.Drawing.Image)(resources.GetObject("tsbReportePaciente.Image")));
            this.tsbReportePaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReportePaciente.Name = "tsbReportePaciente";
            this.tsbReportePaciente.Size = new System.Drawing.Size(36, 36);
            this.tsbReportePaciente.Text = "Reporte de Pacientes";
            // 
            // tsbReporteAudifono
            // 
            this.tsbReporteAudifono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReporteAudifono.Image = ((System.Drawing.Image)(resources.GetObject("tsbReporteAudifono.Image")));
            this.tsbReporteAudifono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReporteAudifono.Name = "tsbReporteAudifono";
            this.tsbReporteAudifono.Size = new System.Drawing.Size(36, 36);
            this.tsbReporteAudifono.Text = "Reporte de Audifonos";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbAyuda
            // 
            this.tsbAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAyuda.Image = ((System.Drawing.Image)(resources.GetObject("tsbAyuda.Image")));
            this.tsbAyuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAyuda.Name = "tsbAyuda";
            this.tsbAyuda.Size = new System.Drawing.Size(36, 36);
            this.tsbAyuda.Text = "Ayuda";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPaciente,
            this.tsmEstudio,
            this.tsmAudifono,
            this.tsmAgenda,
            this.tsmReporte,
            this.tsmHerramientasSeguridad,
            this.tsmAyuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmPaciente
            // 
            this.tsmPaciente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGestionPaciente,
            this.tsmGestionCiudad,
            this.tsmGestionObraSocial,
            this.tsmSeleccionAudifono});
            this.tsmPaciente.Name = "tsmPaciente";
            this.tsmPaciente.Size = new System.Drawing.Size(65, 20);
            this.tsmPaciente.Text = "Pacientes";
            // 
            // tsmGestionPaciente
            // 
            this.tsmGestionPaciente.Name = "tsmGestionPaciente";
            this.tsmGestionPaciente.Size = new System.Drawing.Size(209, 22);
            this.tsmGestionPaciente.Text = "Gestión de Pacientes";
            this.tsmGestionPaciente.Click += new System.EventHandler(this.tsmGestionPaciente_Click);
            // 
            // tsmGestionCiudad
            // 
            this.tsmGestionCiudad.Name = "tsmGestionCiudad";
            this.tsmGestionCiudad.Size = new System.Drawing.Size(209, 22);
            this.tsmGestionCiudad.Text = "Gestión de Ciudades";
            this.tsmGestionCiudad.Click += new System.EventHandler(this.tsmGestionCiudad_Click);
            // 
            // tsmGestionObraSocial
            // 
            this.tsmGestionObraSocial.Name = "tsmGestionObraSocial";
            this.tsmGestionObraSocial.Size = new System.Drawing.Size(209, 22);
            this.tsmGestionObraSocial.Text = "Gestión de Obras Sociales";
            this.tsmGestionObraSocial.Click += new System.EventHandler(this.tsmGestionObraSocial_Click);
            // 
            // tsmSeleccionAudifono
            // 
            this.tsmSeleccionAudifono.Name = "tsmSeleccionAudifono";
            this.tsmSeleccionAudifono.Size = new System.Drawing.Size(209, 22);
            this.tsmSeleccionAudifono.Text = "Selección de Audífono";
            this.tsmSeleccionAudifono.Click += new System.EventHandler(this.tsmSeleccionAudifono_Click);
            // 
            // tsmEstudio
            // 
            this.tsmEstudio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNuevoEstudio,
            this.tsmConsultarEstudio});
            this.tsmEstudio.Name = "tsmEstudio";
            this.tsmEstudio.Size = new System.Drawing.Size(54, 20);
            this.tsmEstudio.Text = "Estudio";
            // 
            // tsmNuevoEstudio
            // 
            this.tsmNuevoEstudio.Name = "tsmNuevoEstudio";
            this.tsmNuevoEstudio.Size = new System.Drawing.Size(218, 22);
            this.tsmNuevoEstudio.Text = "Generar Nuevo Estudio";
            this.tsmNuevoEstudio.Click += new System.EventHandler(this.tsmNuevoEstudio_Click);
            // 
            // tsmConsultarEstudio
            // 
            this.tsmConsultarEstudio.Name = "tsmConsultarEstudio";
            this.tsmConsultarEstudio.Size = new System.Drawing.Size(218, 22);
            this.tsmConsultarEstudio.Text = "Consultar Estudio Realizado";
            this.tsmConsultarEstudio.Click += new System.EventHandler(this.tsmConsultarEstudio_Click);
            // 
            // tsmAudifono
            // 
            this.tsmAudifono.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGestionAudifono});
            this.tsmAudifono.Name = "tsmAudifono";
            this.tsmAudifono.Size = new System.Drawing.Size(67, 20);
            this.tsmAudifono.Text = "Audífonos";
            // 
            // tsmGestionAudifono
            // 
            this.tsmGestionAudifono.Name = "tsmGestionAudifono";
            this.tsmGestionAudifono.Size = new System.Drawing.Size(187, 22);
            this.tsmGestionAudifono.Text = "Gestión de Audífonos";
            this.tsmGestionAudifono.Click += new System.EventHandler(this.tsmGestionAudifono_Click);
            // 
            // tsmAgenda
            // 
            this.tsmAgenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRecordatorio});
            this.tsmAgenda.Name = "tsmAgenda";
            this.tsmAgenda.Size = new System.Drawing.Size(56, 20);
            this.tsmAgenda.Text = "Agenda";
            // 
            // tsmRecordatorio
            // 
            this.tsmRecordatorio.Name = "tsmRecordatorio";
            this.tsmRecordatorio.Size = new System.Drawing.Size(152, 22);
            this.tsmRecordatorio.Text = "Recordatorios";
            this.tsmRecordatorio.Click += new System.EventHandler(this.tsmRecordatorio_Click);
            // 
            // tsmReporte
            // 
            this.tsmReporte.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmInformeFichaPaciente,
            this.tsmReportePaciente,
            this.tsmReporteAudifono,
            this.tsmReporteObraSocial,
            this.tsmReporteEstudiosPaciente,
            this.tsmReporteRecordatorio,
            this.tsmReportePacientesPorAudifono,
            this.tsmReporteAudifonosPorPaciente});
            this.tsmReporte.Name = "tsmReporte";
            this.tsmReporte.Size = new System.Drawing.Size(63, 20);
            this.tsmReporte.Text = "Reportes";
            // 
            // tsmInformeFichaPaciente
            // 
            this.tsmInformeFichaPaciente.Name = "tsmInformeFichaPaciente";
            this.tsmInformeFichaPaciente.Size = new System.Drawing.Size(253, 22);
            this.tsmInformeFichaPaciente.Text = "Informe de Ficha de Paciente";
            this.tsmInformeFichaPaciente.Click += new System.EventHandler(this.tsmInformeFichaPaciente_Click);
            // 
            // tsmReportePaciente
            // 
            this.tsmReportePaciente.Name = "tsmReportePaciente";
            this.tsmReportePaciente.Size = new System.Drawing.Size(253, 22);
            this.tsmReportePaciente.Text = "Reporte de Pacientes";
            this.tsmReportePaciente.Click += new System.EventHandler(this.tsmReportePaciente_Click);
            // 
            // tsmReporteAudifono
            // 
            this.tsmReporteAudifono.Name = "tsmReporteAudifono";
            this.tsmReporteAudifono.Size = new System.Drawing.Size(253, 22);
            this.tsmReporteAudifono.Text = "Reporte de Audífonos";
            this.tsmReporteAudifono.Click += new System.EventHandler(this.tsmReporteAudifono_Click);
            // 
            // tsmReporteObraSocial
            // 
            this.tsmReporteObraSocial.Name = "tsmReporteObraSocial";
            this.tsmReporteObraSocial.Size = new System.Drawing.Size(253, 22);
            this.tsmReporteObraSocial.Text = "Reporte de Obras Sociales";
            this.tsmReporteObraSocial.Click += new System.EventHandler(this.tsmReporteObraSocial_Click);
            // 
            // tsmReporteEstudiosPaciente
            // 
            this.tsmReporteEstudiosPaciente.Name = "tsmReporteEstudiosPaciente";
            this.tsmReporteEstudiosPaciente.Size = new System.Drawing.Size(253, 22);
            this.tsmReporteEstudiosPaciente.Text = "Reporte de Estudios por Paciente";
            this.tsmReporteEstudiosPaciente.Click += new System.EventHandler(this.tsmReporteEstudiosPaciente_Click);
            // 
            // tsmReporteRecordatorio
            // 
            this.tsmReporteRecordatorio.Name = "tsmReporteRecordatorio";
            this.tsmReporteRecordatorio.Size = new System.Drawing.Size(253, 22);
            this.tsmReporteRecordatorio.Text = "Reporte de Recordatorio";
            this.tsmReporteRecordatorio.Click += new System.EventHandler(this.tsmReporteRecordatorio_Click);
            // 
            // tsmReportePacientesPorAudifono
            // 
            this.tsmReportePacientesPorAudifono.Name = "tsmReportePacientesPorAudifono";
            this.tsmReportePacientesPorAudifono.Size = new System.Drawing.Size(253, 22);
            this.tsmReportePacientesPorAudifono.Text = "Reporte de Pacientes por Audífono";
            this.tsmReportePacientesPorAudifono.Click += new System.EventHandler(this.tsmReportePacientesPorAudifono_Click);
            // 
            // tsmReporteAudifonosPorPaciente
            // 
            this.tsmReporteAudifonosPorPaciente.Name = "tsmReporteAudifonosPorPaciente";
            this.tsmReporteAudifonosPorPaciente.Size = new System.Drawing.Size(253, 22);
            this.tsmReporteAudifonosPorPaciente.Text = "Reporte de Audífonos por paciente";
            this.tsmReporteAudifonosPorPaciente.Click += new System.EventHandler(this.tsmReporteAudifonosPorPaciente_Click);
            // 
            // tsmHerramientasSeguridad
            // 
            this.tsmHerramientasSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGestionParametrosSistema,
            this.tsmCambioPasswordUsuario,
            this.tsmBackUpBaseDatos});
            this.tsmHerramientasSeguridad.Name = "tsmHerramientasSeguridad";
            this.tsmHerramientasSeguridad.Size = new System.Drawing.Size(143, 20);
            this.tsmHerramientasSeguridad.Text = "Herramientas y Seguridad";
            // 
            // tsmGestionParametrosSistema
            // 
            this.tsmGestionParametrosSistema.Name = "tsmGestionParametrosSistema";
            this.tsmGestionParametrosSistema.Size = new System.Drawing.Size(251, 22);
            this.tsmGestionParametrosSistema.Text = "Gestión de Parametros del Sistema";
            this.tsmGestionParametrosSistema.Click += new System.EventHandler(this.tsmGestionParametrosSistema_Click);
            // 
            // tsmCambioPasswordUsuario
            // 
            this.tsmCambioPasswordUsuario.Name = "tsmCambioPasswordUsuario";
            this.tsmCambioPasswordUsuario.Size = new System.Drawing.Size(251, 22);
            this.tsmCambioPasswordUsuario.Text = "Cambio de Password del Usuario";
            this.tsmCambioPasswordUsuario.Click += new System.EventHandler(this.tsmCambioPasswordUsuario_Click);
            // 
            // tsmBackUpBaseDatos
            // 
            this.tsmBackUpBaseDatos.Name = "tsmBackUpBaseDatos";
            this.tsmBackUpBaseDatos.Size = new System.Drawing.Size(251, 22);
            this.tsmBackUpBaseDatos.Text = "BackUp de Base de Datos";
            this.tsmBackUpBaseDatos.Click += new System.EventHandler(this.tsmBackUpBaseDatos_Click);
            // 
            // tsmAyuda
            // 
            this.tsmAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManualAyuda,
            this.tsmAcercaDe,
            this.tsmSalir});
            this.tsmAyuda.Name = "tsmAyuda";
            this.tsmAyuda.Size = new System.Drawing.Size(50, 20);
            this.tsmAyuda.Text = "Ayuda";
            // 
            // tsmManualAyuda
            // 
            this.tsmManualAyuda.Name = "tsmManualAyuda";
            this.tsmManualAyuda.Size = new System.Drawing.Size(168, 22);
            this.tsmManualAyuda.Text = "Manual de Ayuda";
            this.tsmManualAyuda.Click += new System.EventHandler(this.tsmManualAyuda_Click);
            // 
            // tsmAcercaDe
            // 
            this.tsmAcercaDe.Name = "tsmAcercaDe";
            this.tsmAcercaDe.Size = new System.Drawing.Size(168, 22);
            this.tsmAcercaDe.Text = "Acerca de ...";
            this.tsmAcercaDe.Click += new System.EventHandler(this.tsmAcercaDe_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(168, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // tsmObraSocial
            // 
            this.tsmObraSocial.Name = "tsmObraSocial";
            this.tsmObraSocial.Size = new System.Drawing.Size(32, 19);
            // 
            // spcRight
            // 
            this.spcRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcRight.Location = new System.Drawing.Point(0, 63);
            this.spcRight.Name = "spcRight";
            // 
            // spcRight.Panel1
            // 
            this.spcRight.Panel1.Controls.Add(this.splitLeft);
            this.spcRight.Panel1Collapsed = true;
            // 
            // spcRight.Panel2
            // 
            this.spcRight.Panel2.Controls.Add(this.tbcPrincipal);
            this.spcRight.Size = new System.Drawing.Size(936, 478);
            this.spcRight.SplitterDistance = 94;
            this.spcRight.TabIndex = 4;
            // 
            // splitLeft
            // 
            this.splitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft.Location = new System.Drawing.Point(0, 0);
            this.splitLeft.Name = "splitLeft";
            this.splitLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitLeft.Size = new System.Drawing.Size(94, 478);
            this.splitLeft.SplitterDistance = 318;
            this.splitLeft.TabIndex = 0;
            this.splitLeft.Visible = false;
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(936, 478);
            this.tbcPrincipal.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 541);
            this.Controls.Add(this.spcRight);
            this.Controls.Add(this.tosPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Audiologia - Gestión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.tosPrincipal.ResumeLayout(false);
            this.tosPrincipal.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.spcRight.Panel1.ResumeLayout(false);
            this.spcRight.Panel2.ResumeLayout(false);
            this.spcRight.ResumeLayout(false);
            this.splitLeft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip tosPrincipal;
        internal System.Windows.Forms.ToolStripLabel tsbUsuarioLogueado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmPaciente;
        private System.Windows.Forms.ToolStripMenuItem tsmGestionPaciente;
        private System.Windows.Forms.ToolStripMenuItem tsmObraSocial;
        private System.Windows.Forms.SplitContainer spcRight;
        private System.Windows.Forms.SplitContainer splitLeft;
        internal System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.ToolStripButton tsbPaciente;
        private System.Windows.Forms.ToolStripMenuItem tsmGestionCiudad;
        private System.Windows.Forms.ToolStripMenuItem tsmGestionObraSocial;
        private System.Windows.Forms.ToolStripMenuItem tsmEstudio;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevoEstudio;
        private System.Windows.Forms.ToolStripMenuItem tsmConsultarEstudio;
        private System.Windows.Forms.ToolStripMenuItem tsmAudifono;
        private System.Windows.Forms.ToolStripMenuItem tsmGestionAudifono;
        private System.Windows.Forms.ToolStripMenuItem tsmAgenda;
        private System.Windows.Forms.ToolStripMenuItem tsmRecordatorio;
        private System.Windows.Forms.ToolStripMenuItem tsmReporte;
        private System.Windows.Forms.ToolStripMenuItem tsmInformeFichaPaciente;
        private System.Windows.Forms.ToolStripMenuItem tsmReportePaciente;
        private System.Windows.Forms.ToolStripMenuItem tsmReporteAudifono;
        private System.Windows.Forms.ToolStripMenuItem tsmReporteObraSocial;
        private System.Windows.Forms.ToolStripMenuItem tsmReporteEstudiosPaciente;
        private System.Windows.Forms.ToolStripMenuItem tsmReporteRecordatorio;
        private System.Windows.Forms.ToolStripMenuItem tsmHerramientasSeguridad;
        private System.Windows.Forms.ToolStripMenuItem tsmGestionParametrosSistema;
        private System.Windows.Forms.ToolStripMenuItem tsmCambioPasswordUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmBackUpBaseDatos;
        private System.Windows.Forms.ToolStripMenuItem tsmAyuda;
        private System.Windows.Forms.ToolStripMenuItem tsmManualAyuda;
        private System.Windows.Forms.ToolStripMenuItem tsmAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem tsmSeleccionAudifono;
        private System.Windows.Forms.ToolStripMenuItem tsmReportePacientesPorAudifono;
        private System.Windows.Forms.ToolStripMenuItem tsmReporteAudifonosPorPaciente;
        private System.Windows.Forms.ToolStripButton tsbEstudio;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRecordatorio;
        private System.Windows.Forms.ToolStripButton tsbAudifono;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbReportePaciente;
        private System.Windows.Forms.ToolStripButton tsbReporteAudifono;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbAyuda;
    }
}
