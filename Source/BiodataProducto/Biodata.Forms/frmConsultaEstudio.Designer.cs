namespace Mds.Biodata.Forms
{
    partial class frmConsultaEstudio
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaEstudio = new System.Windows.Forms.Label();
            this.lblTipoEstudio = new System.Windows.Forms.Label();
            this.lblApellidoPaciente = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.cmbTipoEstudio = new System.Windows.Forms.ComboBox();
            this.dtpFechaEstudio = new System.Windows.Forms.DateTimePicker();
            this.gpbFiltros.SuspendLayout();
            this.sptContenedor.Panel1.SuspendLayout();
            this.sptContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(736, 37);
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.dtpFechaEstudio);
            this.gpbFiltros.Controls.Add(this.cmbTipoEstudio);
            this.gpbFiltros.Controls.Add(this.txtApellidoPaciente);
            this.gpbFiltros.Controls.Add(this.txtNombre);
            this.gpbFiltros.Controls.Add(this.lblApellidoPaciente);
            this.gpbFiltros.Controls.Add(this.lblTipoEstudio);
            this.gpbFiltros.Controls.Add(this.lblFechaEstudio);
            this.gpbFiltros.Controls.Add(this.lblNombre);
            this.gpbFiltros.Controls.SetChildIndex(this.lblNombre, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.lblFechaEstudio, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.lblTipoEstudio, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.lblApellidoPaciente, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.txtNombre, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.txtApellidoPaciente, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.cmbTipoEstudio, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.dtpFechaEstudio, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(568, 25);
            this.btnBuscar.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnBuscar_Click);
            // 
            // sptContenedor
            // 
            this.sptContenedor.SplitterDistance = 103;
            // 
            // bgwLoad
            // 
            this.bgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoad_DoWork);
            this.bgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoad_RunWorkerCompleted);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(46, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechaEstudio
            // 
            this.lblFechaEstudio.AutoSize = true;
            this.lblFechaEstudio.Location = new System.Drawing.Point(272, 25);
            this.lblFechaEstudio.Name = "lblFechaEstudio";
            this.lblFechaEstudio.Size = new System.Drawing.Size(90, 13);
            this.lblFechaEstudio.TabIndex = 2;
            this.lblFechaEstudio.Text = "Fecha de Estudio";
            // 
            // lblTipoEstudio
            // 
            this.lblTipoEstudio.AutoSize = true;
            this.lblTipoEstudio.Location = new System.Drawing.Point(9, 55);
            this.lblTipoEstudio.Name = "lblTipoEstudio";
            this.lblTipoEstudio.Size = new System.Drawing.Size(81, 13);
            this.lblTipoEstudio.TabIndex = 3;
            this.lblTipoEstudio.Text = "Tipo de Estudio";
            // 
            // lblApellidoPaciente
            // 
            this.lblApellidoPaciente.AutoSize = true;
            this.lblApellidoPaciente.Location = new System.Drawing.Point(256, 55);
            this.lblApellidoPaciente.Name = "lblApellidoPaciente";
            this.lblApellidoPaciente.Size = new System.Drawing.Size(106, 13);
            this.lblApellidoPaciente.TabIndex = 4;
            this.lblApellidoPaciente.Text = "Apellido del Paciente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.Location = new System.Drawing.Point(368, 52);
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(178, 20);
            this.txtApellidoPaciente.TabIndex = 6;
            // 
            // cmbTipoEstudio
            // 
            this.cmbTipoEstudio.FormattingEnabled = true;
            this.cmbTipoEstudio.Location = new System.Drawing.Point(96, 51);
            this.cmbTipoEstudio.Name = "cmbTipoEstudio";
            this.cmbTipoEstudio.Size = new System.Drawing.Size(154, 21);
            this.cmbTipoEstudio.TabIndex = 7;
            // 
            // dtpFechaEstudio
            // 
            this.dtpFechaEstudio.Checked = false;
            this.dtpFechaEstudio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstudio.Location = new System.Drawing.Point(369, 25);
            this.dtpFechaEstudio.Name = "dtpFechaEstudio";
            this.dtpFechaEstudio.ShowCheckBox = true;
            this.dtpFechaEstudio.Size = new System.Drawing.Size(176, 20);
            this.dtpFechaEstudio.TabIndex = 8;
            // 
            // frmConsultaEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 554);
            this.Name = "frmConsultaEstudio";
            this.Text = "frmConsultaEstudio";
            this.Load += new System.EventHandler(this.frmConsultaEstudio_Load);
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.sptContenedor.Panel1.ResumeLayout(false);
            this.sptContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblApellidoPaciente;
        private System.Windows.Forms.Label lblTipoEstudio;
        private System.Windows.Forms.Label lblFechaEstudio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellidoPaciente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbTipoEstudio;
        private System.Windows.Forms.DateTimePicker dtpFechaEstudio;
    }
}