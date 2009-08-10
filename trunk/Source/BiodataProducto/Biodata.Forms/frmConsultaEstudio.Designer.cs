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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaEstudio));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaEstudioDesde = new System.Windows.Forms.Label();
            this.lblTipoEstudio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbTipoEstudio = new System.Windows.Forms.ComboBox();
            this.dtpFechaEstudioDesde = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.btnEdit = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.btnNew = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.dtpFechaEstudioHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaEstudioHasta = new System.Windows.Forms.Label();
            this.gpbFiltros.SuspendLayout();
            this.sptContenedor.Panel1.SuspendLayout();
            this.sptContenedor.Panel2.SuspendLayout();
            this.sptContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(1128, 37);
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.dtpFechaEstudioHasta);
            this.gpbFiltros.Controls.Add(this.lblFechaEstudioHasta);
            this.gpbFiltros.Controls.Add(this.dtpFechaEstudioDesde);
            this.gpbFiltros.Controls.Add(this.cmbTipoEstudio);
            this.gpbFiltros.Controls.Add(this.txtNombre);
            this.gpbFiltros.Controls.Add(this.lblTipoEstudio);
            this.gpbFiltros.Controls.Add(this.lblFechaEstudioDesde);
            this.gpbFiltros.Controls.Add(this.lblNombre);
            this.gpbFiltros.Size = new System.Drawing.Size(837, 83);
            this.gpbFiltros.Controls.SetChildIndex(this.lblNombre, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.btnBuscar, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.lblFechaEstudioDesde, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.lblTipoEstudio, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.txtNombre, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.cmbTipoEstudio, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.dtpFechaEstudioDesde, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.lblFechaEstudioHasta, 0);
            this.gpbFiltros.Controls.SetChildIndex(this.dtpFechaEstudioHasta, 0);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(717, 24);
            this.btnBuscar.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnBuscar_Click);
            // 
            // sptContenedor
            // 
            // 
            // sptContenedor.Panel2
            // 
            this.sptContenedor.Panel2.Controls.Add(this.panel1);
            this.sptContenedor.Size = new System.Drawing.Size(877, 554);
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
            // lblFechaEstudioDesde
            // 
            this.lblFechaEstudioDesde.AutoSize = true;
            this.lblFechaEstudioDesde.Location = new System.Drawing.Point(19, 60);
            this.lblFechaEstudioDesde.Name = "lblFechaEstudioDesde";
            this.lblFechaEstudioDesde.Size = new System.Drawing.Size(71, 13);
            this.lblFechaEstudioDesde.TabIndex = 2;
            this.lblFechaEstudioDesde.Text = "Fecha Desde";
            // 
            // lblTipoEstudio
            // 
            this.lblTipoEstudio.AutoSize = true;
            this.lblTipoEstudio.Location = new System.Drawing.Point(294, 28);
            this.lblTipoEstudio.Name = "lblTipoEstudio";
            this.lblTipoEstudio.Size = new System.Drawing.Size(81, 13);
            this.lblTipoEstudio.TabIndex = 3;
            this.lblTipoEstudio.Text = "Tipo de Estudio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(96, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // cmbTipoEstudio
            // 
            this.cmbTipoEstudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEstudio.FormattingEnabled = true;
            this.cmbTipoEstudio.Location = new System.Drawing.Point(381, 24);
            this.cmbTipoEstudio.Name = "cmbTipoEstudio";
            this.cmbTipoEstudio.Size = new System.Drawing.Size(154, 21);
            this.cmbTipoEstudio.TabIndex = 7;
            // 
            // dtpFechaEstudioDesde
            // 
            this.dtpFechaEstudioDesde.Checked = false;
            this.dtpFechaEstudioDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstudioDesde.Location = new System.Drawing.Point(96, 56);
            this.dtpFechaEstudioDesde.Name = "dtpFechaEstudioDesde";
            this.dtpFechaEstudioDesde.Size = new System.Drawing.Size(154, 20);
            this.dtpFechaEstudioDesde.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Location = new System.Drawing.Point(735, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 126);
            this.panel1.TabIndex = 6;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(6, 89);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 34);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(6, 49);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 34);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Editar";
            this.btnEdit.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(6, 9);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(121, 34);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Nuevo";
            this.btnNew.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnNew_Click);
            // 
            // dtpFechaEstudioHasta
            // 
            this.dtpFechaEstudioHasta.Checked = false;
            this.dtpFechaEstudioHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEstudioHasta.Location = new System.Drawing.Point(381, 56);
            this.dtpFechaEstudioHasta.Name = "dtpFechaEstudioHasta";
            this.dtpFechaEstudioHasta.Size = new System.Drawing.Size(154, 20);
            this.dtpFechaEstudioHasta.TabIndex = 10;
            // 
            // lblFechaEstudioHasta
            // 
            this.lblFechaEstudioHasta.AutoSize = true;
            this.lblFechaEstudioHasta.Location = new System.Drawing.Point(307, 60);
            this.lblFechaEstudioHasta.Name = "lblFechaEstudioHasta";
            this.lblFechaEstudioHasta.Size = new System.Drawing.Size(68, 13);
            this.lblFechaEstudioHasta.TabIndex = 9;
            this.lblFechaEstudioHasta.Text = "Fecha Hasta";
            // 
            // frmConsultaEstudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 554);
            this.Name = "frmConsultaEstudio";
            this.Text = "frmConsultaEstudio";
            this.Load += new System.EventHandler(this.frmConsultaEstudio_Load);
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.sptContenedor.Panel1.ResumeLayout(false);
            this.sptContenedor.Panel2.ResumeLayout(false);
            this.sptContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTipoEstudio;
        private System.Windows.Forms.Label lblFechaEstudioDesde;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbTipoEstudio;
        private System.Windows.Forms.DateTimePicker dtpFechaEstudioDesde;
        private System.Windows.Forms.Panel panel1;
        protected Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnDelete;
        protected Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnEdit;
        protected Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnNew;
        private System.Windows.Forms.DateTimePicker dtpFechaEstudioHasta;
        private System.Windows.Forms.Label lblFechaEstudioHasta;
    }
}