namespace Medusa.Biodata.FrontEnd.Forms
{
    partial class frmPersonalizedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonalizedForm));
            this.ptbProgreso = new System.Windows.Forms.PictureBox();
            this.chkRequerido = new System.Windows.Forms.CheckBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.grbDocumentos = new System.Windows.Forms.GroupBox();
            this.txtEtiquetaX = new System.Windows.Forms.TextBox();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.txtOrdenX = new System.Windows.Forms.TextBox();
            this.lblOrden = new System.Windows.Forms.Label();
            this.lblTipoControl = new System.Windows.Forms.Label();
            this.cmbTipoControl = new System.Windows.Forms.ComboBox();
            this.lblTipoProducto = new System.Windows.Forms.Label();
            this.txtTextoItemX = new System.Windows.Forms.TextBox();
            this.lblListaItems = new System.Windows.Forms.Label();
            this.gpbPrevisualizar = new System.Windows.Forms.GroupBox();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.lblTextoItem = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grbBotones = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.grbAccion = new System.Windows.Forms.GroupBox();
            this.lblControles = new System.Windows.Forms.Label();
            this.btnEliminarControl = new System.Windows.Forms.Button();
            this.btnAgregarControl = new System.Windows.Forms.Button();
            this.btnModificarControl = new System.Windows.Forms.Button();
            this.grbItems = new System.Windows.Forms.GroupBox();
            this.btnEliminarItem = new System.Windows.Forms.Button();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.lstControles = new System.Windows.Forms.ListBox();
            this.bgwCargarControles = new System.ComponentModel.BackgroundWorker();
            this.bgwLoad = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgreso)).BeginInit();
            this.grbDocumentos.SuspendLayout();
            this.gpbPrevisualizar.SuspendLayout();
            this.grbBotones.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.grbAccion.SuspendLayout();
            this.grbItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbProgreso
            // 
            this.ptbProgreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbProgreso.BackColor = System.Drawing.Color.White;
            this.ptbProgreso.Image = ((System.Drawing.Image)(resources.GetObject("ptbProgreso.Image")));
            this.ptbProgreso.Location = new System.Drawing.Point(257, 239);
            this.ptbProgreso.Name = "ptbProgreso";
            this.ptbProgreso.Size = new System.Drawing.Size(32, 36);
            this.ptbProgreso.TabIndex = 16;
            this.ptbProgreso.TabStop = false;
            // 
            // chkRequerido
            // 
            this.chkRequerido.AutoSize = true;
            this.chkRequerido.Location = new System.Drawing.Point(18, 138);
            this.chkRequerido.Name = "chkRequerido";
            this.chkRequerido.Size = new System.Drawing.Size(75, 17);
            this.chkRequerido.TabIndex = 26;
            this.chkRequerido.Text = "Requerido";
            this.chkRequerido.UseVisualStyleBackColor = true;
            // 
            // cmbProductType
            // 
            this.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(17, 32);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(200, 21);
            this.cmbProductType.TabIndex = 23;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // grbDocumentos
            // 
            this.grbDocumentos.Controls.Add(this.chkRequerido);
            this.grbDocumentos.Controls.Add(this.cmbProductType);
            this.grbDocumentos.Controls.Add(this.txtEtiquetaX);
            this.grbDocumentos.Controls.Add(this.lblEtiqueta);
            this.grbDocumentos.Controls.Add(this.txtOrdenX);
            this.grbDocumentos.Controls.Add(this.lblOrden);
            this.grbDocumentos.Controls.Add(this.lblTipoControl);
            this.grbDocumentos.Controls.Add(this.cmbTipoControl);
            this.grbDocumentos.Controls.Add(this.lblTipoProducto);
            this.grbDocumentos.Location = new System.Drawing.Point(9, 3);
            this.grbDocumentos.Name = "grbDocumentos";
            this.grbDocumentos.Size = new System.Drawing.Size(231, 165);
            this.grbDocumentos.TabIndex = 3;
            this.grbDocumentos.TabStop = false;
            // 
            // txtEtiquetaX
            // 
            this.txtEtiquetaX.Location = new System.Drawing.Point(17, 112);
            this.txtEtiquetaX.MaxLength = 300;
            this.txtEtiquetaX.Name = "txtEtiquetaX";
            this.txtEtiquetaX.Size = new System.Drawing.Size(199, 20);
            this.txtEtiquetaX.TabIndex = 25;
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Location = new System.Drawing.Point(14, 96);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(46, 13);
            this.lblEtiqueta.TabIndex = 31;
            this.lblEtiqueta.Text = "Etiqueta";
            // 
            // txtOrdenX
            // 
            this.txtOrdenX.Enabled = false;
            this.txtOrdenX.Location = new System.Drawing.Point(141, 135);
            this.txtOrdenX.MaxLength = 7;
            this.txtOrdenX.Name = "txtOrdenX";
            this.txtOrdenX.Size = new System.Drawing.Size(200, 20);
            this.txtOrdenX.TabIndex = 27;
            this.txtOrdenX.Visible = false;
            // 
            // lblOrden
            // 
            this.lblOrden.AutoSize = true;
            this.lblOrden.Location = new System.Drawing.Point(99, 139);
            this.lblOrden.Name = "lblOrden";
            this.lblOrden.Size = new System.Drawing.Size(36, 13);
            this.lblOrden.TabIndex = 30;
            this.lblOrden.Text = "Orden";
            this.lblOrden.Visible = false;
            // 
            // lblTipoControl
            // 
            this.lblTipoControl.AutoSize = true;
            this.lblTipoControl.Location = new System.Drawing.Point(14, 56);
            this.lblTipoControl.Name = "lblTipoControl";
            this.lblTipoControl.Size = new System.Drawing.Size(79, 13);
            this.lblTipoControl.TabIndex = 29;
            this.lblTipoControl.Text = "Tipo de Control";
            // 
            // cmbTipoControl
            // 
            this.cmbTipoControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoControl.FormattingEnabled = true;
            this.cmbTipoControl.Location = new System.Drawing.Point(16, 72);
            this.cmbTipoControl.Name = "cmbTipoControl";
            this.cmbTipoControl.Size = new System.Drawing.Size(200, 21);
            this.cmbTipoControl.TabIndex = 24;
            this.cmbTipoControl.SelectedIndexChanged += new System.EventHandler(this.cmbTipoControl_SelectedIndexChanged);
            // 
            // lblTipoProducto
            // 
            this.lblTipoProducto.AutoSize = true;
            this.lblTipoProducto.Location = new System.Drawing.Point(14, 16);
            this.lblTipoProducto.Name = "lblTipoProducto";
            this.lblTipoProducto.Size = new System.Drawing.Size(89, 13);
            this.lblTipoProducto.TabIndex = 28;
            this.lblTipoProducto.Text = "Tipo de Producto";
            // 
            // txtTextoItemX
            // 
            this.txtTextoItemX.Location = new System.Drawing.Point(16, 144);
            this.txtTextoItemX.MaxLength = 300;
            this.txtTextoItemX.Name = "txtTextoItemX";
            this.txtTextoItemX.Size = new System.Drawing.Size(199, 20);
            this.txtTextoItemX.TabIndex = 21;
            // 
            // lblListaItems
            // 
            this.lblListaItems.AutoSize = true;
            this.lblListaItems.Location = new System.Drawing.Point(13, 14);
            this.lblListaItems.Name = "lblListaItems";
            this.lblListaItems.Size = new System.Drawing.Size(72, 13);
            this.lblListaItems.TabIndex = 25;
            this.lblListaItems.Text = "Lista de Items";
            // 
            // gpbPrevisualizar
            // 
            this.gpbPrevisualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbPrevisualizar.Controls.Add(this.ptbProgreso);
            this.gpbPrevisualizar.Controls.Add(this.pnlControles);
            this.gpbPrevisualizar.Location = new System.Drawing.Point(285, 16);
            this.gpbPrevisualizar.Name = "gpbPrevisualizar";
            this.gpbPrevisualizar.Size = new System.Drawing.Size(547, 516);
            this.gpbPrevisualizar.TabIndex = 29;
            this.gpbPrevisualizar.TabStop = false;
            this.gpbPrevisualizar.Text = "Vista Previa";
            // 
            // pnlControles
            // 
            this.pnlControles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControles.AutoScroll = true;
            this.pnlControles.BackColor = System.Drawing.SystemColors.Control;
            this.pnlControles.Location = new System.Drawing.Point(6, 16);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(535, 494);
            this.pnlControles.TabIndex = 27;
            // 
            // lblTextoItem
            // 
            this.lblTextoItem.AutoSize = true;
            this.lblTextoItem.Location = new System.Drawing.Point(13, 128);
            this.lblTextoItem.Name = "lblTextoItem";
            this.lblTextoItem.Size = new System.Drawing.Size(74, 13);
            this.lblTextoItem.TabIndex = 26;
            this.lblTextoItem.Text = "Texto del Item";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(116, 19);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 25);
            this.btnCerrar.TabIndex = 24;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // grbBotones
            // 
            this.grbBotones.Controls.Add(this.btnCerrar);
            this.grbBotones.Controls.Add(this.btnGuardar);
            this.grbBotones.Location = new System.Drawing.Point(9, 453);
            this.grbBotones.Name = "grbBotones";
            this.grbBotones.Size = new System.Drawing.Size(231, 57);
            this.grbBotones.TabIndex = 1;
            this.grbBotones.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(16, 19);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 25);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.Controls.Add(this.grbBotones);
            this.pnlMenu.Controls.Add(this.grbAccion);
            this.pnlMenu.Controls.Add(this.grbItems);
            this.pnlMenu.Controls.Add(this.grbDocumentos);
            this.pnlMenu.Location = new System.Drawing.Point(11, 13);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(268, 519);
            this.pnlMenu.TabIndex = 28;
            // 
            // grbAccion
            // 
            this.grbAccion.Controls.Add(this.lblControles);
            this.grbAccion.Controls.Add(this.btnEliminarControl);
            this.grbAccion.Controls.Add(this.btnAgregarControl);
            this.grbAccion.Controls.Add(this.btnModificarControl);
            this.grbAccion.Location = new System.Drawing.Point(9, 389);
            this.grbAccion.Name = "grbAccion";
            this.grbAccion.Size = new System.Drawing.Size(231, 58);
            this.grbAccion.TabIndex = 2;
            this.grbAccion.TabStop = false;
            // 
            // lblControles
            // 
            this.lblControles.AutoSize = true;
            this.lblControles.Location = new System.Drawing.Point(15, 11);
            this.lblControles.Name = "lblControles";
            this.lblControles.Size = new System.Drawing.Size(51, 13);
            this.lblControles.TabIndex = 29;
            this.lblControles.Text = "Controles";
            // 
            // btnEliminarControl
            // 
            this.btnEliminarControl.Location = new System.Drawing.Point(152, 27);
            this.btnEliminarControl.Name = "btnEliminarControl";
            this.btnEliminarControl.Size = new System.Drawing.Size(63, 25);
            this.btnEliminarControl.TabIndex = 27;
            this.btnEliminarControl.Text = "Eliminar";
            this.btnEliminarControl.UseVisualStyleBackColor = true;
            this.btnEliminarControl.Click += new System.EventHandler(this.btnEliminarControl_Click);
            // 
            // btnAgregarControl
            // 
            this.btnAgregarControl.Location = new System.Drawing.Point(16, 27);
            this.btnAgregarControl.Name = "btnAgregarControl";
            this.btnAgregarControl.Size = new System.Drawing.Size(60, 25);
            this.btnAgregarControl.TabIndex = 26;
            this.btnAgregarControl.Text = "Agregar";
            this.btnAgregarControl.UseVisualStyleBackColor = true;
            this.btnAgregarControl.Click += new System.EventHandler(this.btnAgregarControl_Click);
            // 
            // btnModificarControl
            // 
            this.btnModificarControl.Enabled = false;
            this.btnModificarControl.Location = new System.Drawing.Point(82, 27);
            this.btnModificarControl.Name = "btnModificarControl";
            this.btnModificarControl.Size = new System.Drawing.Size(64, 25);
            this.btnModificarControl.TabIndex = 28;
            this.btnModificarControl.Text = "Modificar";
            this.btnModificarControl.UseVisualStyleBackColor = true;
            this.btnModificarControl.Click += new System.EventHandler(this.btnModificarControl_Click);
            // 
            // grbItems
            // 
            this.grbItems.Controls.Add(this.txtTextoItemX);
            this.grbItems.Controls.Add(this.lblTextoItem);
            this.grbItems.Controls.Add(this.lblListaItems);
            this.grbItems.Controls.Add(this.btnEliminarItem);
            this.grbItems.Controls.Add(this.btnAgregarItem);
            this.grbItems.Controls.Add(this.lstControles);
            this.grbItems.Location = new System.Drawing.Point(9, 174);
            this.grbItems.Name = "grbItems";
            this.grbItems.Size = new System.Drawing.Size(231, 209);
            this.grbItems.TabIndex = 4;
            this.grbItems.TabStop = false;
            this.grbItems.Visible = false;
            // 
            // btnEliminarItem
            // 
            this.btnEliminarItem.Location = new System.Drawing.Point(116, 170);
            this.btnEliminarItem.Name = "btnEliminarItem";
            this.btnEliminarItem.Size = new System.Drawing.Size(100, 25);
            this.btnEliminarItem.TabIndex = 23;
            this.btnEliminarItem.Text = "Eliminar Item";
            this.btnEliminarItem.UseVisualStyleBackColor = true;
            this.btnEliminarItem.Click += new System.EventHandler(this.btnEliminarItem_Click);
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.Location = new System.Drawing.Point(16, 170);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(100, 25);
            this.btnAgregarItem.TabIndex = 22;
            this.btnAgregarItem.Text = "Agregar Item";
            this.btnAgregarItem.UseVisualStyleBackColor = true;
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // lstControles
            // 
            this.lstControles.FormattingEnabled = true;
            this.lstControles.Location = new System.Drawing.Point(16, 30);
            this.lstControles.Name = "lstControles";
            this.lstControles.Size = new System.Drawing.Size(199, 95);
            this.lstControles.TabIndex = 24;
            // 
            // bgwCargarControles
            // 
            this.bgwCargarControles.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCargarControles_DoWork);
            this.bgwCargarControles.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCargarControles_RunWorkerCompleted);
            // 
            // bgwLoad
            // 
            this.bgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoad_DoWork);
            this.bgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoad_RunWorkerCompleted);
            // 
            // frmPersonalizedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 533);
            this.Controls.Add(this.gpbPrevisualizar);
            this.Controls.Add(this.pnlMenu);
            this.Name = "frmPersonalizedForm";
            this.Text = "frmPersonalizedForm";
            this.Load += new System.EventHandler(this.frmPersonalizedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProgreso)).EndInit();
            this.grbDocumentos.ResumeLayout(false);
            this.grbDocumentos.PerformLayout();
            this.gpbPrevisualizar.ResumeLayout(false);
            this.grbBotones.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.grbAccion.ResumeLayout(false);
            this.grbAccion.PerformLayout();
            this.grbItems.ResumeLayout(false);
            this.grbItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.PictureBox ptbProgreso;
        internal System.Windows.Forms.CheckBox chkRequerido;
        internal System.Windows.Forms.ComboBox cmbProductType;
        internal System.Windows.Forms.GroupBox grbDocumentos;
        internal System.Windows.Forms.TextBox txtEtiquetaX;
        internal System.Windows.Forms.Label lblEtiqueta;
        internal System.Windows.Forms.TextBox txtOrdenX;
        internal System.Windows.Forms.Label lblOrden;
        internal System.Windows.Forms.Label lblTipoControl;
        internal System.Windows.Forms.ComboBox cmbTipoControl;
        internal System.Windows.Forms.Label lblTipoProducto;
        internal System.Windows.Forms.TextBox txtTextoItemX;
        internal System.Windows.Forms.Label lblListaItems;
        internal System.Windows.Forms.GroupBox gpbPrevisualizar;
        internal System.Windows.Forms.Panel pnlControles;
        internal System.Windows.Forms.Label lblTextoItem;
        internal System.Windows.Forms.Button btnCerrar;
        internal System.Windows.Forms.GroupBox grbBotones;
        internal System.Windows.Forms.Button btnGuardar;
        internal System.Windows.Forms.Panel pnlMenu;
        internal System.Windows.Forms.GroupBox grbAccion;
        internal System.Windows.Forms.Label lblControles;
        internal System.Windows.Forms.Button btnEliminarControl;
        internal System.Windows.Forms.Button btnAgregarControl;
        internal System.Windows.Forms.Button btnModificarControl;
        internal System.Windows.Forms.GroupBox grbItems;
        internal System.Windows.Forms.Button btnEliminarItem;
        internal System.Windows.Forms.Button btnAgregarItem;
        internal System.Windows.Forms.ListBox lstControles;
        internal System.ComponentModel.BackgroundWorker bgwCargarControles;
        internal System.ComponentModel.BackgroundWorker bgwLoad;
    }
}