namespace Mds.Biodata.Forms
{
    partial class frmUsuarioPassword
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
            this.lblNick = new System.Windows.Forms.Label();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.txtPasswordActual = new System.Windows.Forms.TextBox();
            this.lblPasswordActual = new System.Windows.Forms.Label();
            this.txtPasswordNuevo = new System.Windows.Forms.TextBox();
            this.lblPasswordNuevo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(67, 15);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(29, 13);
            this.lblNick.TabIndex = 0;
            this.lblNick.Text = "Nick";
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(102, 12);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(252, 20);
            this.txtNick.TabIndex = 1;
            // 
            // txtPasswordActual
            // 
            this.txtPasswordActual.Location = new System.Drawing.Point(102, 45);
            this.txtPasswordActual.Name = "txtPasswordActual";
            this.txtPasswordActual.Size = new System.Drawing.Size(252, 20);
            this.txtPasswordActual.TabIndex = 3;
            // 
            // lblPasswordActual
            // 
            this.lblPasswordActual.AutoSize = true;
            this.lblPasswordActual.Location = new System.Drawing.Point(12, 48);
            this.lblPasswordActual.Name = "lblPasswordActual";
            this.lblPasswordActual.Size = new System.Drawing.Size(86, 13);
            this.lblPasswordActual.TabIndex = 2;
            this.lblPasswordActual.Text = "Password Actual";
            // 
            // txtPasswordNuevo
            // 
            this.txtPasswordNuevo.Location = new System.Drawing.Point(102, 80);
            this.txtPasswordNuevo.Name = "txtPasswordNuevo";
            this.txtPasswordNuevo.Size = new System.Drawing.Size(252, 20);
            this.txtPasswordNuevo.TabIndex = 5;
            // 
            // lblPasswordNuevo
            // 
            this.lblPasswordNuevo.AutoSize = true;
            this.lblPasswordNuevo.Location = new System.Drawing.Point(8, 83);
            this.lblPasswordNuevo.Name = "lblPasswordNuevo";
            this.lblPasswordNuevo.Size = new System.Drawing.Size(88, 13);
            this.lblPasswordNuevo.TabIndex = 4;
            this.lblPasswordNuevo.Text = "Password Nuevo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(102, 117);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 21);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(238, 117);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 21);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmUsuarioPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 142);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPasswordNuevo);
            this.Controls.Add(this.lblPasswordNuevo);
            this.Controls.Add(this.txtPasswordActual);
            this.Controls.Add(this.lblPasswordActual);
            this.Controls.Add(this.txtNick);
            this.Controls.Add(this.lblNick);
            this.Name = "frmUsuarioPassword";
            this.Text = "Cambio de Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.TextBox txtPasswordActual;
        private System.Windows.Forms.Label lblPasswordActual;
        private System.Windows.Forms.TextBox txtPasswordNuevo;
        private System.Windows.Forms.Label lblPasswordNuevo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}