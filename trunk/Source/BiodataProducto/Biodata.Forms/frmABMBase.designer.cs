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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.pnlList.AccessibleDescription = null;
            this.pnlList.AccessibleName = null;
            resources.ApplyResources(this.pnlList, "pnlList");
            this.pnlList.BackgroundImage = null;
            this.pnlList.Controls.Add(this.ptbProgress);
            this.pnlList.Controls.Add(this.dgvList);
            this.pnlList.Controls.Add(this.btnClose);
            this.pnlList.Controls.Add(this.btnDelete);
            this.pnlList.Controls.Add(this.btnEdit);
            this.pnlList.Controls.Add(this.btnNew);
            this.pnlList.Controls.Add(this.btnSelect);
            this.pnlList.Font = null;
            this.pnlList.Name = "pnlList";
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
            // dgvList
            // 
            this.dgvList.AccessibleDescription = null;
            this.dgvList.AccessibleName = null;
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgvList, "dgvList");
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BackgroundImage = null;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Font = null;
            this.dgvList.GridColor = System.Drawing.Color.Silver;
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleDescription = null;
            this.btnClose.AccessibleName = null;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.BackgroundImage = null;
            this.btnClose.Font = null;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.Name = "btnClose";
            this.btnClose.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleDescription = null;
            this.btnDelete.AccessibleName = null;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.BackgroundImage = null;
            this.btnDelete.Font = null;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleDescription = null;
            this.btnEdit.AccessibleName = null;
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.BackgroundImage = null;
            this.btnEdit.Font = null;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleDescription = null;
            this.btnNew.AccessibleName = null;
            resources.ApplyResources(this.btnNew, "btnNew");
            this.btnNew.BackgroundImage = null;
            this.btnNew.Font = null;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Name = "btnNew";
            this.btnNew.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnNew_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.AccessibleDescription = null;
            this.btnSelect.AccessibleName = null;
            resources.ApplyResources(this.btnSelect, "btnSelect");
            this.btnSelect.BackgroundImage = null;
            this.btnSelect.Font = null;
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnSelect_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.AccessibleDescription = null;
            this.pnlDetails.AccessibleName = null;
            resources.ApplyResources(this.pnlDetails, "pnlDetails");
            this.pnlDetails.BackgroundImage = null;
            this.pnlDetails.Controls.Add(this.lblDeleteItem);
            this.pnlDetails.Controls.Add(this.btnCancel);
            this.pnlDetails.Controls.Add(this.btnAccept);
            this.pnlDetails.Font = null;
            this.pnlDetails.Name = "pnlDetails";
            // 
            // lblDeleteItem
            // 
            this.lblDeleteItem.AccessibleDescription = null;
            this.lblDeleteItem.AccessibleName = null;
            resources.ApplyResources(this.lblDeleteItem, "lblDeleteItem");
            this.lblDeleteItem.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteItem.Name = "lblDeleteItem";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = null;
            this.btnCancel.AccessibleName = null;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BackgroundImage = null;
            this.btnCancel.Font = null;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.AccessibleDescription = null;
            this.btnAccept.AccessibleName = null;
            resources.ApplyResources(this.btnAccept, "btnAccept");
            this.btnAccept.BackgroundImage = null;
            this.btnAccept.Font = null;
            this.btnAccept.Image = ((System.Drawing.Image)(resources.GetObject("btnAccept.Image")));
            this.btnAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnAccept_Click);
            // 
            // frmABMBase
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = null;
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlList);
            this.Font = null;
            this.Icon = null;
            this.Name = "frmABMBase";
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