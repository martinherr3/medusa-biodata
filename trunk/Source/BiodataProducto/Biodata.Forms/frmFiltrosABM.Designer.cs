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
            this.dgvConsultas = new Medusa.Biodata.FrontEnd.UserControls.GridView(this.components);
            this.ptbProgress = new System.Windows.Forms.PictureBox();
            this.bgwLoad = new System.ComponentModel.BackgroundWorker();
            this.sptContenedor.Panel1.SuspendLayout();
            this.sptContenedor.Panel2.SuspendLayout();
            this.sptContenedor.SuspendLayout();
            this.gpbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // sptContenedor
            // 
            this.sptContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptContenedor.Location = new System.Drawing.Point(0, 0);
            this.sptContenedor.Name = "sptContenedor";
            this.sptContenedor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptContenedor.Panel1
            // 
            this.sptContenedor.Panel1.Controls.Add(this.gpbFiltros);
            this.sptContenedor.Panel1.Controls.Add(this.btnCerrar);
            this.sptContenedor.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // sptContenedor.Panel2
            // 
            this.sptContenedor.Panel2.Controls.Add(this.ptbProgress);
            this.sptContenedor.Panel2.Controls.Add(this.dgvConsultas);
            this.sptContenedor.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sptContenedor.Size = new System.Drawing.Size(828, 554);
            this.sptContenedor.SplitterDistance = 111;
            this.sptContenedor.TabIndex = 0;
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.btnBuscar);
            this.gpbFiltros.Location = new System.Drawing.Point(28, 12);
            this.gpbFiltros.Name = "gpbFiltros";
            this.gpbFiltros.Size = new System.Drawing.Size(688, 83);
            this.gpbFiltros.TabIndex = 6;
            this.gpbFiltros.TabStop = false;
            this.gpbFiltros.Text = "Filtros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(568, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 30);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Texto = "Buscar";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCerrar.Image = null;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrar.Location = new System.Drawing.Point(736, 31);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(80, 30);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Texto = "Cerrar";
            this.btnCerrar.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnCerrar_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvConsultas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConsultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultas.BackgroundColor = System.Drawing.Color.White;
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
            this.dgvConsultas.GridColor = System.Drawing.Color.Silver;
            this.dgvConsultas.Location = new System.Drawing.Point(28, 26);
            this.dgvConsultas.MultiSelect = false;
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersVisible = false;
            this.dgvConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultas.Size = new System.Drawing.Size(688, 346);
            this.dgvConsultas.TabIndex = 0;
            // 
            // ptbProgress
            // 
            this.ptbProgress.Image = ((System.Drawing.Image)(resources.GetObject("ptbProgress.Image")));
            this.ptbProgress.Location = new System.Drawing.Point(355, 138);
            this.ptbProgress.Name = "ptbProgress";
            this.ptbProgress.Size = new System.Drawing.Size(35, 34);
            this.ptbProgress.TabIndex = 5;
            this.ptbProgress.TabStop = false;
            this.ptbProgress.Visible = false;
            // 
            // frmFiltrosABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(828, 554);
            this.Controls.Add(this.sptContenedor);
            this.Name = "frmFiltrosABM";
            this.Text = "frmFiltrosABM";
            this.sptContenedor.Panel1.ResumeLayout(false);
            this.sptContenedor.Panel2.ResumeLayout(false);
            this.sptContenedor.ResumeLayout(false);
            this.gpbFiltros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgress)).EndInit();
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