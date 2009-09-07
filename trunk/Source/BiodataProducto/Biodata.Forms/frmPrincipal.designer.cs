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
            this.spcRight = new System.Windows.Forms.SplitContainer();
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.tbcPrincipal = new Dotnetrix.Controls.TabControlEX();
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
            this.spcRight.Panel1.SuspendLayout();
            this.spcRight.Panel2.SuspendLayout();
            this.spcRight.SuspendLayout();
            this.splitLeft.SuspendLayout();
            this.tosPrincipal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcRight
            // 
            resources.ApplyResources(this.spcRight, "spcRight");
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
            // 
            // splitLeft
            // 
            resources.ApplyResources(this.splitLeft, "splitLeft");
            this.splitLeft.Name = "splitLeft";
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.AllowDrop = true;
            this.tbcPrincipal.AllowTabDrag = true;
            resources.ApplyResources(this.tbcPrincipal, "tbcPrincipal");
            this.tbcPrincipal.Name = "tbcPrincipal";
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
            resources.ApplyResources(this.tosPrincipal, "tosPrincipal");
            this.tosPrincipal.Name = "tosPrincipal";
            // 
            // tsbUsuarioLogueado
            // 
            this.tsbUsuarioLogueado.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbUsuarioLogueado.Name = "tsbUsuarioLogueado";
            resources.ApplyResources(this.tsbUsuarioLogueado, "tsbUsuarioLogueado");
            // 
            // tsbPaciente
            // 
            this.tsbPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbPaciente, "tsbPaciente");
            this.tsbPaciente.Name = "tsbPaciente";
            // 
            // tsbEstudio
            // 
            this.tsbEstudio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbEstudio, "tsbEstudio");
            this.tsbEstudio.Name = "tsbEstudio";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // tsbRecordatorio
            // 
            this.tsbRecordatorio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbRecordatorio, "tsbRecordatorio");
            this.tsbRecordatorio.Name = "tsbRecordatorio";
            // 
            // tsbAudifono
            // 
            this.tsbAudifono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbAudifono, "tsbAudifono");
            this.tsbAudifono.Name = "tsbAudifono";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // tsbReportePaciente
            // 
            this.tsbReportePaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbReportePaciente, "tsbReportePaciente");
            this.tsbReportePaciente.Name = "tsbReportePaciente";
            // 
            // tsbReporteAudifono
            // 
            this.tsbReporteAudifono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbReporteAudifono, "tsbReporteAudifono");
            this.tsbReporteAudifono.Name = "tsbReporteAudifono";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // tsbAyuda
            // 
            this.tsbAyuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            resources.ApplyResources(this.tsbAyuda, "tsbAyuda");
            this.tsbAyuda.Name = "tsbAyuda";
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
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // tsmPaciente
            // 
            this.tsmPaciente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGestionPaciente,
            this.tsmGestionCiudad,
            this.tsmGestionObraSocial,
            this.tsmSeleccionAudifono});
            this.tsmPaciente.Name = "tsmPaciente";
            resources.ApplyResources(this.tsmPaciente, "tsmPaciente");
            // 
            // tsmGestionPaciente
            // 
            this.tsmGestionPaciente.Name = "tsmGestionPaciente";
            resources.ApplyResources(this.tsmGestionPaciente, "tsmGestionPaciente");
            this.tsmGestionPaciente.Click += new System.EventHandler(this.tsmGestionPaciente_Click);
            // 
            // tsmGestionCiudad
            // 
            this.tsmGestionCiudad.Name = "tsmGestionCiudad";
            resources.ApplyResources(this.tsmGestionCiudad, "tsmGestionCiudad");
            this.tsmGestionCiudad.Click += new System.EventHandler(this.tsmGestionCiudad_Click);
            // 
            // tsmGestionObraSocial
            // 
            this.tsmGestionObraSocial.Name = "tsmGestionObraSocial";
            resources.ApplyResources(this.tsmGestionObraSocial, "tsmGestionObraSocial");
            this.tsmGestionObraSocial.Click += new System.EventHandler(this.tsmGestionObraSocial_Click);
            // 
            // tsmSeleccionAudifono
            // 
            this.tsmSeleccionAudifono.Name = "tsmSeleccionAudifono";
            resources.ApplyResources(this.tsmSeleccionAudifono, "tsmSeleccionAudifono");
            this.tsmSeleccionAudifono.Click += new System.EventHandler(this.tsmSeleccionAudifono_Click);
            // 
            // tsmEstudio
            // 
            this.tsmEstudio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNuevoEstudio,
            this.tsmConsultarEstudio});
            this.tsmEstudio.Name = "tsmEstudio";
            resources.ApplyResources(this.tsmEstudio, "tsmEstudio");
            // 
            // tsmNuevoEstudio
            // 
            this.tsmNuevoEstudio.Name = "tsmNuevoEstudio";
            resources.ApplyResources(this.tsmNuevoEstudio, "tsmNuevoEstudio");
            this.tsmNuevoEstudio.Click += new System.EventHandler(this.tsmNuevoEstudio_Click);
            // 
            // tsmConsultarEstudio
            // 
            this.tsmConsultarEstudio.Name = "tsmConsultarEstudio";
            resources.ApplyResources(this.tsmConsultarEstudio, "tsmConsultarEstudio");
            this.tsmConsultarEstudio.Click += new System.EventHandler(this.tsmConsultarEstudio_Click);
            // 
            // tsmAudifono
            // 
            this.tsmAudifono.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGestionAudifono});
            this.tsmAudifono.Name = "tsmAudifono";
            resources.ApplyResources(this.tsmAudifono, "tsmAudifono");
            // 
            // tsmGestionAudifono
            // 
            this.tsmGestionAudifono.Name = "tsmGestionAudifono";
            resources.ApplyResources(this.tsmGestionAudifono, "tsmGestionAudifono");
            this.tsmGestionAudifono.Click += new System.EventHandler(this.tsmGestionAudifono_Click);
            // 
            // tsmAgenda
            // 
            this.tsmAgenda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRecordatorio});
            this.tsmAgenda.Name = "tsmAgenda";
            resources.ApplyResources(this.tsmAgenda, "tsmAgenda");
            // 
            // tsmRecordatorio
            // 
            this.tsmRecordatorio.Name = "tsmRecordatorio";
            resources.ApplyResources(this.tsmRecordatorio, "tsmRecordatorio");
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
            resources.ApplyResources(this.tsmReporte, "tsmReporte");
            // 
            // tsmInformeFichaPaciente
            // 
            this.tsmInformeFichaPaciente.Name = "tsmInformeFichaPaciente";
            resources.ApplyResources(this.tsmInformeFichaPaciente, "tsmInformeFichaPaciente");
            this.tsmInformeFichaPaciente.Click += new System.EventHandler(this.tsmInformeFichaPaciente_Click);
            // 
            // tsmReportePaciente
            // 
            this.tsmReportePaciente.Name = "tsmReportePaciente";
            resources.ApplyResources(this.tsmReportePaciente, "tsmReportePaciente");
            this.tsmReportePaciente.Click += new System.EventHandler(this.tsmReportePaciente_Click);
            // 
            // tsmReporteAudifono
            // 
            this.tsmReporteAudifono.Name = "tsmReporteAudifono";
            resources.ApplyResources(this.tsmReporteAudifono, "tsmReporteAudifono");
            this.tsmReporteAudifono.Click += new System.EventHandler(this.tsmReporteAudifono_Click);
            // 
            // tsmReporteObraSocial
            // 
            this.tsmReporteObraSocial.Name = "tsmReporteObraSocial";
            resources.ApplyResources(this.tsmReporteObraSocial, "tsmReporteObraSocial");
            this.tsmReporteObraSocial.Click += new System.EventHandler(this.tsmReporteObraSocial_Click);
            // 
            // tsmReporteEstudiosPaciente
            // 
            this.tsmReporteEstudiosPaciente.Name = "tsmReporteEstudiosPaciente";
            resources.ApplyResources(this.tsmReporteEstudiosPaciente, "tsmReporteEstudiosPaciente");
            this.tsmReporteEstudiosPaciente.Click += new System.EventHandler(this.tsmReporteEstudiosPaciente_Click);
            // 
            // tsmReporteRecordatorio
            // 
            this.tsmReporteRecordatorio.Name = "tsmReporteRecordatorio";
            resources.ApplyResources(this.tsmReporteRecordatorio, "tsmReporteRecordatorio");
            this.tsmReporteRecordatorio.Click += new System.EventHandler(this.tsmReporteRecordatorio_Click);
            // 
            // tsmReportePacientesPorAudifono
            // 
            this.tsmReportePacientesPorAudifono.Name = "tsmReportePacientesPorAudifono";
            resources.ApplyResources(this.tsmReportePacientesPorAudifono, "tsmReportePacientesPorAudifono");
            this.tsmReportePacientesPorAudifono.Click += new System.EventHandler(this.tsmReportePacientesPorAudifono_Click);
            // 
            // tsmReporteAudifonosPorPaciente
            // 
            this.tsmReporteAudifonosPorPaciente.Name = "tsmReporteAudifonosPorPaciente";
            resources.ApplyResources(this.tsmReporteAudifonosPorPaciente, "tsmReporteAudifonosPorPaciente");
            this.tsmReporteAudifonosPorPaciente.Click += new System.EventHandler(this.tsmReporteAudifonosPorPaciente_Click);
            // 
            // tsmHerramientasSeguridad
            // 
            this.tsmHerramientasSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGestionParametrosSistema,
            this.tsmCambioPasswordUsuario,
            this.tsmBackUpBaseDatos});
            this.tsmHerramientasSeguridad.Name = "tsmHerramientasSeguridad";
            resources.ApplyResources(this.tsmHerramientasSeguridad, "tsmHerramientasSeguridad");
            // 
            // tsmGestionParametrosSistema
            // 
            this.tsmGestionParametrosSistema.Name = "tsmGestionParametrosSistema";
            resources.ApplyResources(this.tsmGestionParametrosSistema, "tsmGestionParametrosSistema");
            this.tsmGestionParametrosSistema.Click += new System.EventHandler(this.tsmGestionParametrosSistema_Click);
            // 
            // tsmCambioPasswordUsuario
            // 
            this.tsmCambioPasswordUsuario.Name = "tsmCambioPasswordUsuario";
            resources.ApplyResources(this.tsmCambioPasswordUsuario, "tsmCambioPasswordUsuario");
            this.tsmCambioPasswordUsuario.Click += new System.EventHandler(this.tsmCambioPasswordUsuario_Click);
            // 
            // tsmBackUpBaseDatos
            // 
            this.tsmBackUpBaseDatos.Name = "tsmBackUpBaseDatos";
            resources.ApplyResources(this.tsmBackUpBaseDatos, "tsmBackUpBaseDatos");
            this.tsmBackUpBaseDatos.Click += new System.EventHandler(this.tsmBackUpBaseDatos_Click);
            // 
            // tsmAyuda
            // 
            this.tsmAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmManualAyuda,
            this.tsmAcercaDe,
            this.tsmSalir});
            this.tsmAyuda.Name = "tsmAyuda";
            resources.ApplyResources(this.tsmAyuda, "tsmAyuda");
            // 
            // tsmManualAyuda
            // 
            this.tsmManualAyuda.Name = "tsmManualAyuda";
            resources.ApplyResources(this.tsmManualAyuda, "tsmManualAyuda");
            this.tsmManualAyuda.Click += new System.EventHandler(this.tsmManualAyuda_Click);
            // 
            // tsmAcercaDe
            // 
            this.tsmAcercaDe.Name = "tsmAcercaDe";
            resources.ApplyResources(this.tsmAcercaDe, "tsmAcercaDe");
            this.tsmAcercaDe.Click += new System.EventHandler(this.tsmAcercaDe_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            resources.ApplyResources(this.tsmSalir, "tsmSalir");
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // tsmObraSocial
            // 
            this.tsmObraSocial.Name = "tsmObraSocial";
            resources.ApplyResources(this.tsmObraSocial, "tsmObraSocial");
            // 
            // frmPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spcRight);
            this.Controls.Add(this.tosPrincipal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.spcRight.Panel1.ResumeLayout(false);
            this.spcRight.Panel2.ResumeLayout(false);
            this.spcRight.ResumeLayout(false);
            this.splitLeft.ResumeLayout(false);
            this.tosPrincipal.ResumeLayout(false);
            this.tosPrincipal.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        public Dotnetrix.Controls.TabControlEX tbcPrincipal;
    }
}
