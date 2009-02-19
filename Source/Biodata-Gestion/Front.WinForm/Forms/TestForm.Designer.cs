namespace Medusa.Biodata.FrontEnd.Forms
{
    partial class TestForm
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbObraSocial = new System.Windows.Forms.ComboBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gridMain = new Medusa.Biodata.FrontEnd.UserControls.MedusaGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObraSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchControl1 = new Medusa.Biodata.FrontEnd.UserControls.SearchControl();
            this.pnlDetails.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // abmControl
            // 
            this.abmControl.ClickEdit += new EditEventHandler(this.abmControl_ClickEdit);
            this.abmControl.ClickSelect += new SelectEventHandler(this.abmControl_ClickSelect);
            this.abmControl.ClickDelete += new DeleteEventHandler(this.abmControl_ClickDelete);
            this.abmControl.ClickNew += new NewEventHandler(this.abmControl_ClickNew);
            // 
            // pnlDetails
            // 
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.label5);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Controls.Add(this.label3);
            this.pnlDetails.Controls.Add(this.label2);
            this.pnlDetails.Controls.Add(this.label1);
            this.pnlDetails.Controls.Add(this.txtComentario);
            this.pnlDetails.Controls.Add(this.cmbObraSocial);
            this.pnlDetails.Controls.Add(this.cmbSexo);
            this.pnlDetails.Controls.Add(this.txtDocumento);
            this.pnlDetails.Controls.Add(this.txtDireccion);
            this.pnlDetails.Controls.Add(this.txtApellido);
            this.pnlDetails.Controls.Add(this.txtNombre);
            this.pnlDetails.Location = new System.Drawing.Point(0, 369);
            this.pnlDetails.Size = new System.Drawing.Size(715, 237);
            this.pnlDetails.Controls.SetChildIndex(this.txtNombre, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtId, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblId, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnCancelar, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnAceptar, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtApellido, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtDireccion, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtDocumento, 0);
            this.pnlDetails.Controls.SetChildIndex(this.cmbSexo, 0);
            this.pnlDetails.Controls.SetChildIndex(this.cmbObraSocial, 0);
            this.pnlDetails.Controls.SetChildIndex(this.txtComentario, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label1, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label2, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label3, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label4, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label5, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label6, 0);
            this.pnlDetails.Controls.SetChildIndex(this.label7, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(602, 182);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(510, 182);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.gridMain);
            this.pnlList.Location = new System.Drawing.Point(0, 76);
            this.pnlList.Size = new System.Drawing.Size(715, 296);
            this.pnlList.Controls.SetChildIndex(this.gridMain, 0);
            this.pnlList.Controls.SetChildIndex(this.abmControl, 0);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(83, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(185, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(83, 94);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(185, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(83, 120);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(185, 20);
            this.txtDocumento.TabIndex = 7;
            // 
            // cmbSexo
            // 
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cmbSexo.Location = new System.Drawing.Point(83, 146);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(185, 21);
            this.cmbSexo.TabIndex = 8;
            // 
            // cmbObraSocial
            // 
            this.cmbObraSocial.FormattingEnabled = true;
            this.cmbObraSocial.Location = new System.Drawing.Point(441, 42);
            this.cmbObraSocial.Name = "cmbObraSocial";
            this.cmbObraSocial.Size = new System.Drawing.Size(247, 21);
            this.cmbObraSocial.TabIndex = 9;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(441, 68);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(247, 99);
            this.txtComentario.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Documento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Obra Social";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Comentario";
            // 
            // gridMain
            // 
            this.gridMain.AllowUserToOrderColumns = true;
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.ObraSocial});
            this.gridMain.Location = new System.Drawing.Point(3, 26);
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(576, 260);
            this.gridMain.TabIndex = 4;
            this.gridMain.Click += new System.EventHandler(this.gridMain_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // ObraSocial
            // 
            this.ObraSocial.DataPropertyName = "ObraSocial";
            this.ObraSocial.HeaderText = "Obra Social";
            this.ObraSocial.Name = "ObraSocial";
            this.ObraSocial.ReadOnly = true;
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(4, 8);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(547, 62);
            this.searchControl1.TabIndex = 18;
            this.searchControl1.ClickSearch += new SearchEventHandler(this.searchControl1_ClickSearch);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 628);
            this.Controls.Add(this.searchControl1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.Controls.SetChildIndex(this.searchControl1, 0);
            this.Controls.SetChildIndex(this.pnlList, 0);
            this.Controls.SetChildIndex(this.pnlDetails, 0);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.ComboBox cmbObraSocial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Medusa.Biodata.FrontEnd.UserControls.MedusaGrid gridMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObraSocial;
        private Medusa.Biodata.FrontEnd.UserControls.SearchControl searchControl1;

    }
}