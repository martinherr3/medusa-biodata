namespace Mds.Biodata.Forms
{
    partial class frmFiltrosABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltrosABM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.sptContenedor = new System.Windows.Forms.SplitContainer();
            this.gpbFiltros = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.btnCerrar = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.ptbProgress = new System.Windows.Forms.PictureBox();
            this.dgvConsultas = new Medusa.Biodata.FrontEnd.UserControls.GridView(this.components);
            this.bgwLoad = new System.ComponentModel.BackgroundWorker();
            this.sptContenedor.Panel1.SuspendLayout();
            this.sptContenedor.Panel2.SuspendLayout();
            this.sptContenedor.SuspendLayout();
            this.gpbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // sptContenedor
            // 
            this.sptContenedor.AccessibleDescription = null;
            this.sptContenedor.AccessibleName = null;
            resources.ApplyResources(this.sptContenedor, "sptContenedor");
            this.sptContenedor.BackgroundImage = null;
            this.sptContenedor.Font = null;
            this.sptContenedor.Name = "sptContenedor";
            // 
            // sptContenedor.Panel1
            // 
            this.sptContenedor.Panel1.AccessibleDescription = null;
            this.sptContenedor.Panel1.AccessibleName = null;
            resources.ApplyResources(this.sptContenedor.Panel1, "sptContenedor.Panel1");
            this.sptContenedor.Panel1.BackgroundImage = null;
            this.sptContenedor.Panel1.Controls.Add(this.gpbFiltros);
            this.sptContenedor.Panel1.Controls.Add(this.btnCerrar);
            this.sptContenedor.Panel1.Font = null;
            // 
            // sptContenedor.Panel2
            // 
            this.sptContenedor.Panel2.AccessibleDescription = null;
            this.sptContenedor.Panel2.AccessibleName = null;
            resources.ApplyResources(this.sptContenedor.Panel2, "sptContenedor.Panel2");
            this.sptContenedor.Panel2.BackgroundImage = null;
            this.sptContenedor.Panel2.Controls.Add(this.ptbProgress);
            this.sptContenedor.Panel2.Controls.Add(this.dgvConsultas);
            this.sptContenedor.Panel2.Font = null;
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.AccessibleDescription = null;
            this.gpbFiltros.AccessibleName = null;
            resources.ApplyResources(this.gpbFiltros, "gpbFiltros");
            this.gpbFiltros.BackgroundImage = null;
            this.gpbFiltros.Controls.Add(this.btnBuscar);
            this.gpbFiltros.Font = null;
            this.gpbFiltros.Name = "gpbFiltros";
            this.gpbFiltros.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleDescription = null;
            this.btnBuscar.AccessibleName = null;
            resources.ApplyResources(this.btnBuscar, "btnBuscar");
            this.btnBuscar.BackgroundImage = null;
            this.btnBuscar.Font = null;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Name = "btnBuscar";
            // 
            // btnCerrar
            // 
            this.btnCerrar.AccessibleDescription = null;
            this.btnCerrar.AccessibleName = null;
            resources.ApplyResources(this.btnCerrar, "btnCerrar");
            this.btnCerrar.BackgroundImage = null;
            this.btnCerrar.Font = null;
            this.btnCerrar.Image = null;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnCerrar_Click);
            // 
            // ptbProgress
            // 
            this.ptbProgress.AccessibleDescription = null;
            this.ptbProgress.AccessibleName = null;
            resources.ApplyResources(this.ptbProgress, "ptbProgress");
            this.ptbProgress.BackgroundImage = null;
            this.ptbProgress.Font = null;
            this.ptbProgress.ImageLocation = null;
            this.ptbProgress.Name = "ptbProgress";
            this.ptbProgress.TabStop = false;
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AccessibleDescription = null;
            this.dgvConsultas.AccessibleName = null;
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConsultas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.dgvConsultas, "dgvConsultas");
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsultas.BackgroundImage = null;
            this.dgvConsultas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvConsultas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvConsultas.EnableHeadersVisualStyles = false;
            this.dgvConsultas.Font = null;
            this.dgvConsultas.GridColor = System.Drawing.Color.Silver;
            this.dgvConsultas.MultiSelect = false;
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersVisible = false;
            this.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // frmFiltrosABM
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = null;
            this.Controls.Add(this.sptContenedor);
            this.Font = null;
            this.Icon = null;
            this.Name = "frmFiltrosABM";
            this.sptContenedor.Panel1.ResumeLayout(false);
            this.sptContenedor.Panel2.ResumeLayout(false);
            this.sptContenedor.ResumeLayout(false);
            this.gpbFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnCerrar;
        public System.Windows.Forms.GroupBox gpbFiltros;
        public Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnBuscar;
        public Medusa.Biodata.FrontEnd.UserControls.GridView dgvConsultas;
        public System.Windows.Forms.SplitContainer sptContenedor;
        internal System.Windows.Forms.PictureBox ptbProgress;
        protected System.ComponentModel.BackgroundWorker bgwLoad;


    }
}