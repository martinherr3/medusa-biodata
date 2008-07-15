namespace Medusa.Biodata.FrontEnd.Forms
{
    partial class frmProductABM
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
            this.tbcDatos = new System.Windows.Forms.TabControl();
            this.tbpDatos = new System.Windows.Forms.TabPage();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtMinimumStock = new System.Windows.Forms.TextBox();
            this.lblMinimumStock = new System.Windows.Forms.Label();
            this.txtCurrentStock = new System.Windows.Forms.TextBox();
            this.lblCurrentStock = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.tbpDatosPersonalizados = new System.Windows.Forms.TabPage();
            this.cboProductType = new System.Windows.Forms.ComboBox();
            this.lblProductType = new System.Windows.Forms.Label();
            this.gpbDatosPersonalizados = new System.Windows.Forms.GroupBox();
            this.pnlDatosPersonalizados = new System.Windows.Forms.Panel();
            this.pnlList.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.tbcDatos.SuspendLayout();
            this.tbpDatos.SuspendLayout();
            this.tbpDatosPersonalizados.SuspendLayout();
            this.gpbDatosPersonalizados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeleteItem
            // 
            this.lblDeleteItem.Location = new System.Drawing.Point(381, 305);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(448, 168);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(448, 127);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(448, 85);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.tbcDatos);
            this.pnlDetails.Location = new System.Drawing.Point(12, 234);
            this.pnlDetails.Size = new System.Drawing.Size(572, 362);
            this.pnlDetails.Controls.SetChildIndex(this.lblDeleteItem, 0);
            this.pnlDetails.Controls.SetChildIndex(this.tbcDatos, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnCancel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnAccept, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(468, 332);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(349, 332);
            this.btnAccept.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnAccept_Click);
            // 
            // bgwLoad
            // 
            this.bgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoad_DoWork);
            this.bgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoad_RunWorkerCompleted);
            // 
            // tbcDatos
            // 
            this.tbcDatos.Controls.Add(this.tbpDatos);
            this.tbcDatos.Controls.Add(this.tbpDatosPersonalizados);
            this.tbcDatos.Location = new System.Drawing.Point(3, 13);
            this.tbcDatos.Name = "tbcDatos";
            this.tbcDatos.SelectedIndex = 0;
            this.tbcDatos.Size = new System.Drawing.Size(566, 293);
            this.tbcDatos.TabIndex = 5;
            this.tbcDatos.SelectedIndexChanged += new System.EventHandler(this.tbcDatos_SelectedIndexChanged);
            // 
            // tbpDatos
            // 
            this.tbpDatos.Controls.Add(this.txtCost);
            this.tbpDatos.Controls.Add(this.lblCost);
            this.tbpDatos.Controls.Add(this.txtPrice);
            this.tbpDatos.Controls.Add(this.lblPrice);
            this.tbpDatos.Controls.Add(this.txtMinimumStock);
            this.tbpDatos.Controls.Add(this.lblMinimumStock);
            this.tbpDatos.Controls.Add(this.txtCurrentStock);
            this.tbpDatos.Controls.Add(this.lblCurrentStock);
            this.tbpDatos.Controls.Add(this.txtDescription);
            this.tbpDatos.Controls.Add(this.lblDescription);
            this.tbpDatos.Controls.Add(this.txtName);
            this.tbpDatos.Controls.Add(this.lblName);
            this.tbpDatos.Controls.Add(this.txtID);
            this.tbpDatos.Controls.Add(this.lblID);
            this.tbpDatos.Location = new System.Drawing.Point(4, 22);
            this.tbpDatos.Name = "tbpDatos";
            this.tbpDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatos.Size = new System.Drawing.Size(558, 267);
            this.tbpDatos.TabIndex = 0;
            this.tbpDatos.Text = "Datos";
            this.tbpDatos.UseVisualStyleBackColor = true;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(94, 168);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(103, 20);
            this.txtCost.TabIndex = 23;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(54, 171);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(34, 13);
            this.lblCost.TabIndex = 24;
            this.lblCost.Text = "Costo";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(94, 142);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(103, 20);
            this.txtPrice.TabIndex = 20;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(51, 149);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 13);
            this.lblPrice.TabIndex = 22;
            this.lblPrice.Text = "Precio";
            // 
            // txtMinimumStock
            // 
            this.txtMinimumStock.Location = new System.Drawing.Point(94, 116);
            this.txtMinimumStock.Name = "txtMinimumStock";
            this.txtMinimumStock.Size = new System.Drawing.Size(75, 20);
            this.txtMinimumStock.TabIndex = 19;
            // 
            // lblMinimumStock
            // 
            this.lblMinimumStock.AutoSize = true;
            this.lblMinimumStock.Location = new System.Drawing.Point(17, 119);
            this.lblMinimumStock.Name = "lblMinimumStock";
            this.lblMinimumStock.Size = new System.Drawing.Size(71, 13);
            this.lblMinimumStock.TabIndex = 21;
            this.lblMinimumStock.Text = "Stock Minimo";
            // 
            // txtCurrentStock
            // 
            this.txtCurrentStock.Location = new System.Drawing.Point(94, 90);
            this.txtCurrentStock.Name = "txtCurrentStock";
            this.txtCurrentStock.Size = new System.Drawing.Size(75, 20);
            this.txtCurrentStock.TabIndex = 17;
            // 
            // lblCurrentStock
            // 
            this.lblCurrentStock.AutoSize = true;
            this.lblCurrentStock.Location = new System.Drawing.Point(23, 93);
            this.lblCurrentStock.Name = "lblCurrentStock";
            this.lblCurrentStock.Size = new System.Drawing.Size(68, 13);
            this.lblCurrentStock.TabIndex = 18;
            this.lblCurrentStock.Text = "Stock Actual";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(94, 64);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(227, 20);
            this.txtDescription.TabIndex = 14;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(28, 67);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Descripcion";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(227, 20);
            this.txtName.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Nombre";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(94, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(75, 20);
            this.txtID.TabIndex = 11;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(70, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID";
            // 
            // tbpDatosPersonalizados
            // 
            this.tbpDatosPersonalizados.Controls.Add(this.cboProductType);
            this.tbpDatosPersonalizados.Controls.Add(this.lblProductType);
            this.tbpDatosPersonalizados.Controls.Add(this.gpbDatosPersonalizados);
            this.tbpDatosPersonalizados.Location = new System.Drawing.Point(4, 22);
            this.tbpDatosPersonalizados.Name = "tbpDatosPersonalizados";
            this.tbpDatosPersonalizados.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatosPersonalizados.Size = new System.Drawing.Size(558, 267);
            this.tbpDatosPersonalizados.TabIndex = 1;
            this.tbpDatosPersonalizados.Text = "Personalizados";
            this.tbpDatosPersonalizados.UseVisualStyleBackColor = true;
            // 
            // cboProductType
            // 
            this.cboProductType.FormattingEnabled = true;
            this.cboProductType.Location = new System.Drawing.Point(105, 6);
            this.cboProductType.Name = "cboProductType";
            this.cboProductType.Size = new System.Drawing.Size(227, 21);
            this.cboProductType.TabIndex = 28;
            this.cboProductType.SelectedIndexChanged += new System.EventHandler(this.cboProductType_SelectedIndexChanged);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(10, 9);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(89, 13);
            this.lblProductType.TabIndex = 27;
            this.lblProductType.Text = "Tipo de Producto";
            // 
            // gpbDatosPersonalizados
            // 
            this.gpbDatosPersonalizados.Controls.Add(this.pnlDatosPersonalizados);
            this.gpbDatosPersonalizados.Location = new System.Drawing.Point(6, 32);
            this.gpbDatosPersonalizados.Name = "gpbDatosPersonalizados";
            this.gpbDatosPersonalizados.Size = new System.Drawing.Size(546, 239);
            this.gpbDatosPersonalizados.TabIndex = 0;
            this.gpbDatosPersonalizados.TabStop = false;
            // 
            // pnlDatosPersonalizados
            // 
            this.pnlDatosPersonalizados.AutoScroll = true;
            this.pnlDatosPersonalizados.Location = new System.Drawing.Point(6, 19);
            this.pnlDatosPersonalizados.Name = "pnlDatosPersonalizados";
            this.pnlDatosPersonalizados.Size = new System.Drawing.Size(534, 214);
            this.pnlDatosPersonalizados.TabIndex = 0;
            // 
            // frmProductABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 609);
            this.Name = "frmProductABM";
            this.Text = "frmProductABM";
            this.BotonClick += new Medusa.Biodata.FrontEnd.Forms.frmABMBase.BotonClickEventHandler(this.Accion);
            this.Load += new System.EventHandler(this.frmProductABM_Load);
            this.pnlList.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.tbcDatos.ResumeLayout(false);
            this.tbpDatos.ResumeLayout(false);
            this.tbpDatos.PerformLayout();
            this.tbpDatosPersonalizados.ResumeLayout(false);
            this.tbpDatosPersonalizados.PerformLayout();
            this.gpbDatosPersonalizados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcDatos;
        private System.Windows.Forms.TabPage tbpDatos;
        private System.Windows.Forms.TabPage tbpDatosPersonalizados;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtMinimumStock;
        private System.Windows.Forms.Label lblMinimumStock;
        private System.Windows.Forms.TextBox txtCurrentStock;
        private System.Windows.Forms.Label lblCurrentStock;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.ComboBox cboProductType;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.GroupBox gpbDatosPersonalizados;
        private System.Windows.Forms.Panel pnlDatosPersonalizados;
    }
}