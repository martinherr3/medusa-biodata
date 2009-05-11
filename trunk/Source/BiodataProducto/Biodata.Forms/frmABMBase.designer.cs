namespace Mds.Biodata.Forms
{
    partial class frmABMBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMBase));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlList = new System.Windows.Forms.Panel();
            this.ptbProgress = new System.Windows.Forms.PictureBox();
            this.dgvList = new Medusa.Biodata.FrontEnd.UserControls.GridView(this.components);
            this.btnClose = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.btnDelete = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.btnEdit = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.btnNew = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.btnSelect = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.lblDeleteItem = new System.Windows.Forms.Label();
            this.btnCancel = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.btnAccept = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.bgwLoad = new System.ComponentModel.BackgroundWorker();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.Controls.Add(this.ptbProgress);
            this.pnlList.Controls.Add(this.dgvList);
            this.pnlList.Controls.Add(this.btnClose);
            this.pnlList.Controls.Add(this.btnDelete);
            this.pnlList.Controls.Add(this.btnEdit);
            this.pnlList.Controls.Add(this.btnNew);
            this.pnlList.Controls.Add(this.btnSelect);
            this.pnlList.Location = new System.Drawing.Point(12, 12);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(572, 205);
            this.pnlList.TabIndex = 0;
            // 
            // ptbProgress
            // 
            this.ptbProgress.Image = ((System.Drawing.Image)(resources.GetObject("ptbProgress.Image")));
            this.ptbProgress.Location = new System.Drawing.Point(200, 83);
            this.ptbProgress.Name = "ptbProgress";
            this.ptbProgress.Size = new System.Drawing.Size(35, 34);
            this.ptbProgress.TabIndex = 4;
            this.ptbProgress.TabStop = false;
            this.ptbProgress.Visible = false;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.GridColor = System.Drawing.Color.Silver;
            this.dgvList.Location = new System.Drawing.Point(3, 3);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(439, 194);
            this.dgvList.TabIndex = 6;
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Location = new System.Drawing.Point(448, 163);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(121, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Texto = "Cerrar";
            this.btnClose.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(448, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Texto = "Eliminar";
            this.btnDelete.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Location = new System.Drawing.Point(448, 83);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(121, 34);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Texto = "Editar";
            this.btnEdit.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(448, 43);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(121, 34);
            this.btnNew.TabIndex = 1;
            this.btnNew.Texto = "Nuevo";
            this.btnNew.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnNew_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.Location = new System.Drawing.Point(448, 3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(121, 34);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Texto = "Seleccionar";
            this.btnSelect.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnSelect_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDetails.Controls.Add(this.lblDeleteItem);
            this.pnlDetails.Controls.Add(this.btnCancel);
            this.pnlDetails.Controls.Add(this.btnAccept);
            this.pnlDetails.Location = new System.Drawing.Point(12, 223);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(411, 273);
            this.pnlDetails.TabIndex = 1;
            this.pnlDetails.Visible = false;
            // 
            // lblDeleteItem
            // 
            this.lblDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeleteItem.AutoSize = true;
            this.lblDeleteItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteItem.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteItem.Location = new System.Drawing.Point(220, 207);
            this.lblDeleteItem.Name = "lblDeleteItem";
            this.lblDeleteItem.Size = new System.Drawing.Size(188, 13);
            this.lblDeleteItem.TabIndex = 4;
            this.lblDeleteItem.Text = "¿Desea Eliminar este elemento?";
            this.lblDeleteItem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Location = new System.Drawing.Point(307, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Texto = "Cancelar";
            this.btnCancel.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.Location = new System.Drawing.Point(188, 243);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(104, 27);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Texto = "Aceptar";
            this.btnAccept.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnAccept_Click);
            // 
            // frmABMBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 509);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlList);
            this.Name = "frmABMBase";
            this.Text = "frmABMBase";
            this.Load += new System.EventHandler(this.frmABMBase_Load);
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lblDeleteItem;
        public System.Windows.Forms.Panel pnlList;
        protected Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnClose;
        protected Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnDelete;
        protected Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnEdit;
        protected Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnNew;
        protected Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnSelect;
        protected Medusa.Biodata.FrontEnd.UserControls.GridView dgvList;
        public System.Windows.Forms.Panel pnlDetails;
        internal System.Windows.Forms.PictureBox ptbProgress;
        protected Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnCancel;
        protected Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnAccept;
        protected System.ComponentModel.BackgroundWorker bgwLoad;
    }
}