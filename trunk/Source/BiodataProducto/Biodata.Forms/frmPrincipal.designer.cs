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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmObraSocial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestionObraSocial = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestionPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.spcRight = new System.Windows.Forms.SplitContainer();
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tsmRecordatorio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGestionRecordatorio = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tosPrincipal.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.tosPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbUsuarioLogueado,
            this.toolStripButton1});
            this.tosPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tosPrincipal.Name = "tosPrincipal";
            this.tosPrincipal.Size = new System.Drawing.Size(936, 55);
            this.tosPrincipal.TabIndex = 2;
            this.tosPrincipal.Text = "ToolStrip1";
            // 
            // tsbUsuarioLogueado
            // 
            this.tsbUsuarioLogueado.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbUsuarioLogueado.Name = "tsbUsuarioLogueado";
            this.tsbUsuarioLogueado.Size = new System.Drawing.Size(53, 52);
            this.tsbUsuarioLogueado.Text = "Usuario: ";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 52);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmObraSocial,
            this.tsmPaciente,
            this.tsmRecordatorio});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmObraSocial
            // 
            this.tsmObraSocial.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGestionObraSocial});
            this.tsmObraSocial.Name = "tsmObraSocial";
            this.tsmObraSocial.Size = new System.Drawing.Size(79, 20);
            this.tsmObraSocial.Text = "Obra Social";
            // 
            // tsmGestionObraSocial
            // 
            this.tsmGestionObraSocial.Name = "tsmGestionObraSocial";
            this.tsmGestionObraSocial.Size = new System.Drawing.Size(209, 22);
            this.tsmGestionObraSocial.Text = "Gestión de Obras Sociales";
            this.tsmGestionObraSocial.Click += new System.EventHandler(this.tsmGestionObraSocial_Click);
            // 
            // tsmPaciente
            // 
            this.tsmPaciente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGestionPaciente});
            this.tsmPaciente.Name = "tsmPaciente";
            this.tsmPaciente.Size = new System.Drawing.Size(69, 20);
            this.tsmPaciente.Text = "Pacientes";
            // 
            // tsmGestionPaciente
            // 
            this.tsmGestionPaciente.Name = "tsmGestionPaciente";
            this.tsmGestionPaciente.Size = new System.Drawing.Size(183, 22);
            this.tsmGestionPaciente.Text = "Gestión de Pacientes";
            this.tsmGestionPaciente.Click += new System.EventHandler(this.tsmGestionPaciente_Click);
            // 
            // spcRight
            // 
            this.spcRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcRight.Location = new System.Drawing.Point(0, 79);
            this.spcRight.Name = "spcRight";
            // 
            // spcRight.Panel1
            // 
            this.spcRight.Panel1.Controls.Add(this.splitLeft);
            // 
            // spcRight.Panel2
            // 
            this.spcRight.Panel2.Controls.Add(this.tbcPrincipal);
            this.spcRight.Size = new System.Drawing.Size(936, 462);
            this.spcRight.SplitterDistance = 179;
            this.spcRight.TabIndex = 4;
            // 
            // splitLeft
            // 
            this.splitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft.Location = new System.Drawing.Point(0, 0);
            this.splitLeft.Name = "splitLeft";
            this.splitLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.splitLeft.Size = new System.Drawing.Size(179, 462);
            this.splitLeft.SplitterDistance = 308;
            this.splitLeft.TabIndex = 0;
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(753, 462);
            this.tbcPrincipal.TabIndex = 0;
            // 
            // tsmRecordatorio
            // 
            this.tsmRecordatorio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGestionRecordatorio});
            this.tsmRecordatorio.Name = "tsmRecordatorio";
            this.tsmRecordatorio.Size = new System.Drawing.Size(92, 20);
            this.tsmRecordatorio.Text = "Recordatorios";
            // 
            // tsmGestionRecordatorio
            // 
            this.tsmGestionRecordatorio.Name = "tsmGestionRecordatorio";
            this.tsmGestionRecordatorio.Size = new System.Drawing.Size(206, 22);
            this.tsmGestionRecordatorio.Text = "Gestion de Recordatorios";
            this.tsmGestionRecordatorio.Click += new System.EventHandler(this.tsmGestionRecordatorio_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 541);
            this.Controls.Add(this.spcRight);
            this.Controls.Add(this.tosPrincipal);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem tsmGestionObraSocial;
        private System.Windows.Forms.ToolStripMenuItem tsmRecordatorio;
        private System.Windows.Forms.ToolStripMenuItem tsmGestionRecordatorio;
    }
}