namespace Mds.Biodata.Forms
{
    partial class frmObraSocial
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtPaginaWeb = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblPaginaWeb = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.pnlList.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeleteItem
            // 
            this.lblDeleteItem.Location = new System.Drawing.Point(277, 260);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.lblPaginaWeb);
            this.pnlDetails.Controls.Add(this.lblCorreoElectronico);
            this.pnlDetails.Controls.Add(this.lblCUIT);
            this.pnlDetails.Controls.Add(this.lblContacto);
            this.pnlDetails.Controls.Add(this.lblTelefono);
            this.pnlDetails.Controls.Add(this.lblDireccion);
            this.pnlDetails.Controls.Add(this.lblRazonSocial);
            this.pnlDetails.Controls.Add(this.lblID);
            this.pnlDetails.Controls.Add(this.txtCorreoElectronico);
            this.pnlDetails.Controls.Add(this.txtPaginaWeb);
            this.pnlDetails.Controls.Add(this.txtContacto);
            this.pnlDetails.Controls.Add(this.txtCUIT);
            this.pnlDetails.Controls.Add(this.txtTelefono);
            this.pnlDetails.Controls.Add(this.txtRazonSocial);
            this.pnlDetails.Controls.Add(this.txtDireccion);
            this.pnlDetails.Controls.Add(this.txtID);
            this.pnlDetails.Location = new System.Drawing.Point(12, 228);
            this.pnlDetails.Size = new System.Drawing.Size(480, 333);
            this.pnlDetails.Controls.SetChildIndex(this.txtID, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnAccept, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnCancel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblDeleteItem, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtDireccion, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtRazonSocial, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtTelefono, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtCUIT, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtContacto, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtPaginaWeb, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtCorreoElectronico, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblID, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblRazonSocial, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblDireccion, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblTelefono, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblContacto, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblCUIT, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblCorreoElectronico, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblPaginaWeb, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(364, 296);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(245, 296);
            this.btnAccept.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnAccept_Click);
            // 
            // bgwLoad
            // 
            this.bgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoad_DoWork);
            this.bgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoad_RunWorkerCompleted);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(113, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(42, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(113, 85);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(257, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(113, 59);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(257, 20);
            this.txtRazonSocial.TabIndex = 7;
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(113, 137);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(175, 20);
            this.txtContacto.TabIndex = 10;
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(113, 163);
            this.txtCUIT.MaxLength = 13;
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(175, 20);
            this.txtCUIT.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(113, 111);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(175, 20);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(113, 189);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(175, 20);
            this.txtCorreoElectronico.TabIndex = 12;
            // 
            // txtPaginaWeb
            // 
            this.txtPaginaWeb.Location = new System.Drawing.Point(113, 215);
            this.txtPaginaWeb.Name = "txtPaginaWeb";
            this.txtPaginaWeb.Size = new System.Drawing.Size(175, 20);
            this.txtPaginaWeb.TabIndex = 13;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(88, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 13;
            this.lblID.Text = "ID";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(37, 62);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 14;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(55, 88);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 15;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Location = new System.Drawing.Point(75, 166);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(32, 13);
            this.lblCUIT.TabIndex = 18;
            this.lblCUIT.Text = "CUIT";
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(57, 140);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(50, 13);
            this.lblContacto.TabIndex = 17;
            this.lblContacto.Text = "Contacto";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(57, 114);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblPaginaWeb
            // 
            this.lblPaginaWeb.AutoSize = true;
            this.lblPaginaWeb.Location = new System.Drawing.Point(44, 214);
            this.lblPaginaWeb.Name = "lblPaginaWeb";
            this.lblPaginaWeb.Size = new System.Drawing.Size(63, 13);
            this.lblPaginaWeb.TabIndex = 20;
            this.lblPaginaWeb.Text = "PaginaWeb";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(16, 188);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(94, 13);
            this.lblCorreoElectronico.TabIndex = 19;
            this.lblCorreoElectronico.Text = "Correo Electronico";
            // 
            // frmObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 573);
            this.Name = "frmObraSocial";
            this.Text = "Obra Social";
            this.Load += new System.EventHandler(this.frmObraSocial_Load);
            this.pnlList.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtPaginaWeb;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblPaginaWeb;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblRazonSocial;

    }
}