namespace Mds.Biodata.Forms
{
    partial class frmPaciente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaciente));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.btnSeleccionarCiudad = new System.Windows.Forms.Button();
            this.dgvObrasSociales = new Medusa.Biodata.FrontEnd.UserControls.GridView(this.components);
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gpbObrasSociales = new System.Windows.Forms.GroupBox();
            this.tbcDatos = new System.Windows.Forms.TabControl();
            this.tbpDatosPaciente = new System.Windows.Forms.TabPage();
            this.tbpDatosHistorialClinico = new System.Windows.Forms.TabPage();
            this.lblInicioAtencion = new System.Windows.Forms.Label();
            this.dtpInicioAtencion = new System.Windows.Forms.DateTimePicker();
            this.txtEstadoSalud = new System.Windows.Forms.TextBox();
            this.lblEstadoSalud = new System.Windows.Forms.Label();
            this.txtAntecedentesPersonales = new System.Windows.Forms.TextBox();
            this.lblAntecedentesPersonales = new System.Windows.Forms.Label();
            this.txtAntecedentesHereditarios = new System.Windows.Forms.TextBox();
            this.lblAntecedentesHereditarios = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.tbpDatosAudifonos = new System.Windows.Forms.TabPage();
            this.btnCancelarAudifono = new System.Windows.Forms.Button();
            this.btnAceptarAudifono = new System.Windows.Forms.Button();
            this.btnEliminarAudifono = new System.Windows.Forms.Button();
            this.btnModificarAudifono = new System.Windows.Forms.Button();
            this.btnNuevoAudifono = new System.Windows.Forms.Button();
            this.dgvAudifonosMoldes = new Medusa.Biodata.FrontEnd.UserControls.GridView(this.components);
            this.cmbLadoOido = new System.Windows.Forms.ComboBox();
            this.lblLadoOido = new System.Windows.Forms.Label();
            this.txtEstadoAudifono = new System.Windows.Forms.TextBox();
            this.lblEstadoAudifono = new System.Windows.Forms.Label();
            this.txtObservacionAudifono = new System.Windows.Forms.TextBox();
            this.lblObservacionAudifono = new System.Windows.Forms.Label();
            this.dtpFechaFabricacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFabricacion = new System.Windows.Forms.Label();
            this.dtpProximoService = new System.Windows.Forms.DateTimePicker();
            this.lblProximoService = new System.Windows.Forms.Label();
            this.txtNroSerie = new System.Windows.Forms.TextBox();
            this.lblNroSerie = new System.Windows.Forms.Label();
            this.btnSeleccionarAudifono = new System.Windows.Forms.Button();
            this.txtAudifono = new System.Windows.Forms.TextBox();
            this.lblAudifono = new System.Windows.Forms.Label();
            this.btnSeleccionarMoldeAudifono = new System.Windows.Forms.Button();
            this.txtMoldeAudifono = new System.Windows.Forms.TextBox();
            this.lblMoldeAudifono = new System.Windows.Forms.Label();
            this.buttonUC1 = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.btnBuscar = new Medusa.Biodata.FrontEnd.UserControls.ButtonUC();
            this.gpbFiltros = new System.Windows.Forms.GroupBox();
            this.lblCiudadBuscar = new System.Windows.Forms.Label();
            this.cmbCiudadBuscar = new System.Windows.Forms.ComboBox();
            this.txtDocumentoBuscar = new System.Windows.Forms.TextBox();
            this.lblDocumentoBuscar = new System.Windows.Forms.Label();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.lblNombreBuscar = new System.Windows.Forms.Label();
            this.cmbSexoBuscar = new System.Windows.Forms.ComboBox();
            this.txtApellidoBuscar = new System.Windows.Forms.TextBox();
            this.lblSexoBuscar = new System.Windows.Forms.Label();
            this.lblApellidoBuscar = new System.Windows.Forms.Label();
            this.gpbDatosAudifono = new System.Windows.Forms.GroupBox();
            this.pnlList.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObrasSociales)).BeginInit();
            this.gpbObrasSociales.SuspendLayout();
            this.tbcDatos.SuspendLayout();
            this.tbpDatosPaciente.SuspendLayout();
            this.tbpDatosHistorialClinico.SuspendLayout();
            this.tbpDatosAudifonos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudifonosMoldes)).BeginInit();
            this.gpbFiltros.SuspendLayout();
            this.gpbDatosAudifono.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDeleteItem
            // 
            this.lblDeleteItem.Location = new System.Drawing.Point(605, 463);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.buttonUC1);
            this.pnlList.Location = new System.Drawing.Point(12, 94);
            this.pnlList.Size = new System.Drawing.Size(800, 235);
            this.pnlList.Controls.SetChildIndex(this.buttonUC1, 0);
            this.pnlList.Controls.SetChildIndex(this.btnSelect, 0);
            this.pnlList.Controls.SetChildIndex(this.btnNew, 0);
            this.pnlList.Controls.SetChildIndex(this.btnEdit, 0);
            this.pnlList.Controls.SetChildIndex(this.btnDelete, 0);
            this.pnlList.Controls.SetChildIndex(this.btnClose, 0);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(676, 163);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(676, 123);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(676, 83);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(676, 43);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(676, 3);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.tbcDatos);
            this.pnlDetails.Location = new System.Drawing.Point(12, 354);
            this.pnlDetails.Size = new System.Drawing.Size(797, 520);
            this.pnlDetails.Controls.SetChildIndex(this.btnCancel, 0);
            this.pnlDetails.Controls.SetChildIndex(this.btnAccept, 0);
            this.pnlDetails.Controls.SetChildIndex(this.lblDeleteItem, 0);
            this.pnlDetails.Controls.SetChildIndex(this.tbcDatos, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(692, 486);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(573, 487);
            this.btnAccept.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnAccept_Click);
            // 
            // bgwLoad
            // 
            this.bgwLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwLoad_DoWork);
            this.bgwLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwLoad_RunWorkerCompleted);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(137, 22);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(65, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(251, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(137, 74);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(251, 20);
            this.txtApellido.TabIndex = 7;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(137, 179);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(251, 20);
            this.txtCorreoElectronico.TabIndex = 10;
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(137, 153);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(251, 20);
            this.txtNumeroDocumento.TabIndex = 9;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(137, 100);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(251, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(137, 355);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(251, 20);
            this.txtCelular.TabIndex = 13;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(137, 329);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(251, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(137, 255);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(251, 68);
            this.txtComentario.TabIndex = 11;
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(137, 126);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(154, 21);
            this.cmbTipoDocumento.TabIndex = 14;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(137, 205);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(154, 20);
            this.dtpFechaNacimiento.TabIndex = 15;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(137, 231);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(65, 21);
            this.cmbSexo.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(117, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(91, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(91, 77);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 21;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(83, 103);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 20;
            this.lblDireccion.Text = "Direccion";
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(34, 129);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(101, 13);
            this.lblTipoDocumento.TabIndex = 25;
            this.lblTipoDocumento.Text = "Tipo de Documento";
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(18, 153);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(117, 13);
            this.lblNumeroDocumento.TabIndex = 24;
            this.lblNumeroDocumento.Text = "Numero de Documento";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(41, 179);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(94, 13);
            this.lblCorreoElectronico.TabIndex = 23;
            this.lblCorreoElectronico.Text = "Correo Electronico";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(27, 205);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 22;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(104, 234);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 30;
            this.lblSexo.Text = "Sexo";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(75, 255);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(60, 13);
            this.lblComentario.TabIndex = 29;
            this.lblComentario.Text = "Comentario";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(86, 332);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 28;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(96, 358);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(39, 13);
            this.lblCelular.TabIndex = 27;
            this.lblCelular.Text = "Celular";
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.Location = new System.Drawing.Point(95, 384);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(40, 13);
            this.lblCiudad.TabIndex = 26;
            this.lblCiudad.Text = "Ciudad";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCiudad
            // 
            this.txtCiudad.Enabled = false;
            this.txtCiudad.Location = new System.Drawing.Point(137, 384);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(204, 20);
            this.txtCiudad.TabIndex = 31;
            // 
            // btnSeleccionarCiudad
            // 
            this.btnSeleccionarCiudad.Location = new System.Drawing.Point(347, 383);
            this.btnSeleccionarCiudad.Name = "btnSeleccionarCiudad";
            this.btnSeleccionarCiudad.Size = new System.Drawing.Size(41, 23);
            this.btnSeleccionarCiudad.TabIndex = 32;
            this.btnSeleccionarCiudad.Text = "...";
            this.btnSeleccionarCiudad.UseVisualStyleBackColor = true;
            this.btnSeleccionarCiudad.Click += new System.EventHandler(this.btnSeleccionarCiudad_Click);
            // 
            // dgvObrasSociales
            // 
            this.dgvObrasSociales.AllowUserToAddRows = false;
            this.dgvObrasSociales.AllowUserToDeleteRows = false;
            this.dgvObrasSociales.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvObrasSociales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvObrasSociales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObrasSociales.BackgroundColor = System.Drawing.Color.White;
            this.dgvObrasSociales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObrasSociales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvObrasSociales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObrasSociales.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvObrasSociales.EnableHeadersVisualStyles = false;
            this.dgvObrasSociales.GridColor = System.Drawing.Color.Silver;
            this.dgvObrasSociales.Location = new System.Drawing.Point(20, 28);
            this.dgvObrasSociales.MultiSelect = false;
            this.dgvObrasSociales.Name = "dgvObrasSociales";
            this.dgvObrasSociales.ReadOnly = true;
            this.dgvObrasSociales.RowHeadersVisible = false;
            this.dgvObrasSociales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObrasSociales.Size = new System.Drawing.Size(316, 132);
            this.dgvObrasSociales.TabIndex = 33;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(19, 173);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(86, 31);
            this.btnAgregar.TabIndex = 34;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(245, 173);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 31);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gpbObrasSociales
            // 
            this.gpbObrasSociales.Controls.Add(this.dgvObrasSociales);
            this.gpbObrasSociales.Controls.Add(this.btnEliminar);
            this.gpbObrasSociales.Controls.Add(this.btnAgregar);
            this.gpbObrasSociales.Location = new System.Drawing.Point(405, 182);
            this.gpbObrasSociales.Name = "gpbObrasSociales";
            this.gpbObrasSociales.Size = new System.Drawing.Size(354, 221);
            this.gpbObrasSociales.TabIndex = 37;
            this.gpbObrasSociales.TabStop = false;
            this.gpbObrasSociales.Text = "Obras Sociales";
            // 
            // tbcDatos
            // 
            this.tbcDatos.Controls.Add(this.tbpDatosPaciente);
            this.tbcDatos.Controls.Add(this.tbpDatosHistorialClinico);
            this.tbcDatos.Controls.Add(this.tbpDatosAudifonos);
            this.tbcDatos.Location = new System.Drawing.Point(3, 3);
            this.tbcDatos.Name = "tbcDatos";
            this.tbcDatos.SelectedIndex = 0;
            this.tbcDatos.Size = new System.Drawing.Size(797, 445);
            this.tbcDatos.TabIndex = 38;
            // 
            // tbpDatosPaciente
            // 
            this.tbpDatosPaciente.Controls.Add(this.txtDireccion);
            this.tbpDatosPaciente.Controls.Add(this.gpbObrasSociales);
            this.tbpDatosPaciente.Controls.Add(this.txtID);
            this.tbpDatosPaciente.Controls.Add(this.btnSeleccionarCiudad);
            this.tbpDatosPaciente.Controls.Add(this.txtNombre);
            this.tbpDatosPaciente.Controls.Add(this.txtCiudad);
            this.tbpDatosPaciente.Controls.Add(this.txtApellido);
            this.tbpDatosPaciente.Controls.Add(this.lblComentario);
            this.tbpDatosPaciente.Controls.Add(this.lblSexo);
            this.tbpDatosPaciente.Controls.Add(this.lblTelefono);
            this.tbpDatosPaciente.Controls.Add(this.txtNumeroDocumento);
            this.tbpDatosPaciente.Controls.Add(this.lblCelular);
            this.tbpDatosPaciente.Controls.Add(this.txtCorreoElectronico);
            this.tbpDatosPaciente.Controls.Add(this.lblCiudad);
            this.tbpDatosPaciente.Controls.Add(this.cmbTipoDocumento);
            this.tbpDatosPaciente.Controls.Add(this.txtCelular);
            this.tbpDatosPaciente.Controls.Add(this.dtpFechaNacimiento);
            this.tbpDatosPaciente.Controls.Add(this.txtTelefono);
            this.tbpDatosPaciente.Controls.Add(this.txtComentario);
            this.tbpDatosPaciente.Controls.Add(this.cmbSexo);
            this.tbpDatosPaciente.Controls.Add(this.lblTipoDocumento);
            this.tbpDatosPaciente.Controls.Add(this.lblID);
            this.tbpDatosPaciente.Controls.Add(this.lblNumeroDocumento);
            this.tbpDatosPaciente.Controls.Add(this.lblNombre);
            this.tbpDatosPaciente.Controls.Add(this.lblCorreoElectronico);
            this.tbpDatosPaciente.Controls.Add(this.lblDireccion);
            this.tbpDatosPaciente.Controls.Add(this.lblFechaNacimiento);
            this.tbpDatosPaciente.Controls.Add(this.lblApellido);
            this.tbpDatosPaciente.Location = new System.Drawing.Point(4, 22);
            this.tbpDatosPaciente.Name = "tbpDatosPaciente";
            this.tbpDatosPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatosPaciente.Size = new System.Drawing.Size(789, 419);
            this.tbpDatosPaciente.TabIndex = 0;
            this.tbpDatosPaciente.Text = "Paciente";
            this.tbpDatosPaciente.UseVisualStyleBackColor = true;
            // 
            // tbpDatosHistorialClinico
            // 
            this.tbpDatosHistorialClinico.Controls.Add(this.lblInicioAtencion);
            this.tbpDatosHistorialClinico.Controls.Add(this.dtpInicioAtencion);
            this.tbpDatosHistorialClinico.Controls.Add(this.txtEstadoSalud);
            this.tbpDatosHistorialClinico.Controls.Add(this.lblEstadoSalud);
            this.tbpDatosHistorialClinico.Controls.Add(this.txtAntecedentesPersonales);
            this.tbpDatosHistorialClinico.Controls.Add(this.lblAntecedentesPersonales);
            this.tbpDatosHistorialClinico.Controls.Add(this.txtAntecedentesHereditarios);
            this.tbpDatosHistorialClinico.Controls.Add(this.lblAntecedentesHereditarios);
            this.tbpDatosHistorialClinico.Controls.Add(this.txtObservaciones);
            this.tbpDatosHistorialClinico.Controls.Add(this.lblObservaciones);
            this.tbpDatosHistorialClinico.Location = new System.Drawing.Point(4, 22);
            this.tbpDatosHistorialClinico.Name = "tbpDatosHistorialClinico";
            this.tbpDatosHistorialClinico.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDatosHistorialClinico.Size = new System.Drawing.Size(789, 419);
            this.tbpDatosHistorialClinico.TabIndex = 1;
            this.tbpDatosHistorialClinico.Text = "Historial Clinico";
            this.tbpDatosHistorialClinico.UseVisualStyleBackColor = true;
            // 
            // lblInicioAtencion
            // 
            this.lblInicioAtencion.AutoSize = true;
            this.lblInicioAtencion.Location = new System.Drawing.Point(46, 47);
            this.lblInicioAtencion.Name = "lblInicioAtencion";
            this.lblInicioAtencion.Size = new System.Drawing.Size(92, 13);
            this.lblInicioAtencion.TabIndex = 29;
            this.lblInicioAtencion.Text = "Inicio de Atencion";
            // 
            // dtpInicioAtencion
            // 
            this.dtpInicioAtencion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioAtencion.Location = new System.Drawing.Point(144, 47);
            this.dtpInicioAtencion.Name = "dtpInicioAtencion";
            this.dtpInicioAtencion.Size = new System.Drawing.Size(144, 20);
            this.dtpInicioAtencion.TabIndex = 28;
            // 
            // txtEstadoSalud
            // 
            this.txtEstadoSalud.Location = new System.Drawing.Point(144, 261);
            this.txtEstadoSalud.MaxLength = 250;
            this.txtEstadoSalud.Multiline = true;
            this.txtEstadoSalud.Name = "txtEstadoSalud";
            this.txtEstadoSalud.Size = new System.Drawing.Size(484, 47);
            this.txtEstadoSalud.TabIndex = 26;
            // 
            // lblEstadoSalud
            // 
            this.lblEstadoSalud.AutoSize = true;
            this.lblEstadoSalud.Location = new System.Drawing.Point(53, 261);
            this.lblEstadoSalud.Name = "lblEstadoSalud";
            this.lblEstadoSalud.Size = new System.Drawing.Size(85, 13);
            this.lblEstadoSalud.TabIndex = 27;
            this.lblEstadoSalud.Text = "Estado de Salud";
            // 
            // txtAntecedentesPersonales
            // 
            this.txtAntecedentesPersonales.Location = new System.Drawing.Point(144, 200);
            this.txtAntecedentesPersonales.Multiline = true;
            this.txtAntecedentesPersonales.Name = "txtAntecedentesPersonales";
            this.txtAntecedentesPersonales.Size = new System.Drawing.Size(484, 55);
            this.txtAntecedentesPersonales.TabIndex = 24;
            // 
            // lblAntecedentesPersonales
            // 
            this.lblAntecedentesPersonales.AutoSize = true;
            this.lblAntecedentesPersonales.Location = new System.Drawing.Point(10, 200);
            this.lblAntecedentesPersonales.Name = "lblAntecedentesPersonales";
            this.lblAntecedentesPersonales.Size = new System.Drawing.Size(128, 13);
            this.lblAntecedentesPersonales.TabIndex = 25;
            this.lblAntecedentesPersonales.Text = "Antecedentes Personales";
            // 
            // txtAntecedentesHereditarios
            // 
            this.txtAntecedentesHereditarios.Location = new System.Drawing.Point(144, 135);
            this.txtAntecedentesHereditarios.Multiline = true;
            this.txtAntecedentesHereditarios.Name = "txtAntecedentesHereditarios";
            this.txtAntecedentesHereditarios.Size = new System.Drawing.Size(484, 59);
            this.txtAntecedentesHereditarios.TabIndex = 22;
            // 
            // lblAntecedentesHereditarios
            // 
            this.lblAntecedentesHereditarios.AutoSize = true;
            this.lblAntecedentesHereditarios.Location = new System.Drawing.Point(6, 135);
            this.lblAntecedentesHereditarios.Name = "lblAntecedentesHereditarios";
            this.lblAntecedentesHereditarios.Size = new System.Drawing.Size(132, 13);
            this.lblAntecedentesHereditarios.TabIndex = 23;
            this.lblAntecedentesHereditarios.Text = "Antecedentes Hereditarios";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(144, 82);
            this.txtObservaciones.MaxLength = 250;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(484, 47);
            this.txtObservaciones.TabIndex = 20;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(60, 85);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 21;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // tbpDatosAudifonos
            // 
            this.tbpDatosAudifonos.Controls.Add(this.gpbDatosAudifono);
            this.tbpDatosAudifonos.Controls.Add(this.btnCancelarAudifono);
            this.tbpDatosAudifonos.Controls.Add(this.btnAceptarAudifono);
            this.tbpDatosAudifonos.Controls.Add(this.btnEliminarAudifono);
            this.tbpDatosAudifonos.Controls.Add(this.btnModificarAudifono);
            this.tbpDatosAudifonos.Controls.Add(this.btnNuevoAudifono);
            this.tbpDatosAudifonos.Controls.Add(this.dgvAudifonosMoldes);
            this.tbpDatosAudifonos.Location = new System.Drawing.Point(4, 22);
            this.tbpDatosAudifonos.Name = "tbpDatosAudifonos";
            this.tbpDatosAudifonos.Size = new System.Drawing.Size(789, 419);
            this.tbpDatosAudifonos.TabIndex = 2;
            this.tbpDatosAudifonos.Text = "Audifonos";
            this.tbpDatosAudifonos.UseVisualStyleBackColor = true;
            // 
            // btnCancelarAudifono
            // 
            this.btnCancelarAudifono.Enabled = false;
            this.btnCancelarAudifono.Location = new System.Drawing.Point(618, 179);
            this.btnCancelarAudifono.Name = "btnCancelarAudifono";
            this.btnCancelarAudifono.Size = new System.Drawing.Size(82, 25);
            this.btnCancelarAudifono.TabIndex = 57;
            this.btnCancelarAudifono.Text = "Cancelar";
            this.btnCancelarAudifono.UseVisualStyleBackColor = true;
            this.btnCancelarAudifono.Click += new System.EventHandler(this.btnCancelarAudifono_Click);
            // 
            // btnAceptarAudifono
            // 
            this.btnAceptarAudifono.Enabled = false;
            this.btnAceptarAudifono.Location = new System.Drawing.Point(523, 179);
            this.btnAceptarAudifono.Name = "btnAceptarAudifono";
            this.btnAceptarAudifono.Size = new System.Drawing.Size(89, 25);
            this.btnAceptarAudifono.TabIndex = 56;
            this.btnAceptarAudifono.Text = "Aceptar";
            this.btnAceptarAudifono.UseVisualStyleBackColor = true;
            this.btnAceptarAudifono.Click += new System.EventHandler(this.btnAceptarAudifono_Click);
            // 
            // btnEliminarAudifono
            // 
            this.btnEliminarAudifono.Location = new System.Drawing.Point(365, 179);
            this.btnEliminarAudifono.Name = "btnEliminarAudifono";
            this.btnEliminarAudifono.Size = new System.Drawing.Size(99, 25);
            this.btnEliminarAudifono.TabIndex = 55;
            this.btnEliminarAudifono.Text = "Eliminar";
            this.btnEliminarAudifono.UseVisualStyleBackColor = true;
            this.btnEliminarAudifono.Click += new System.EventHandler(this.btnEliminarAudifono_Click);
            // 
            // btnModificarAudifono
            // 
            this.btnModificarAudifono.Location = new System.Drawing.Point(248, 179);
            this.btnModificarAudifono.Name = "btnModificarAudifono";
            this.btnModificarAudifono.Size = new System.Drawing.Size(111, 25);
            this.btnModificarAudifono.TabIndex = 54;
            this.btnModificarAudifono.Text = "Modificar";
            this.btnModificarAudifono.UseVisualStyleBackColor = true;
            this.btnModificarAudifono.Click += new System.EventHandler(this.btnModificarAudifono_Click);
            // 
            // btnNuevoAudifono
            // 
            this.btnNuevoAudifono.Location = new System.Drawing.Point(128, 179);
            this.btnNuevoAudifono.Name = "btnNuevoAudifono";
            this.btnNuevoAudifono.Size = new System.Drawing.Size(114, 25);
            this.btnNuevoAudifono.TabIndex = 53;
            this.btnNuevoAudifono.Text = "Nuevo";
            this.btnNuevoAudifono.UseVisualStyleBackColor = true;
            this.btnNuevoAudifono.Click += new System.EventHandler(this.btnNuevoAudifono_Click);
            // 
            // dgvAudifonosMoldes
            // 
            this.dgvAudifonosMoldes.AllowUserToAddRows = false;
            this.dgvAudifonosMoldes.AllowUserToDeleteRows = false;
            this.dgvAudifonosMoldes.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvAudifonosMoldes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAudifonosMoldes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAudifonosMoldes.BackgroundColor = System.Drawing.Color.White;
            this.dgvAudifonosMoldes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSalmon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAudifonosMoldes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAudifonosMoldes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAudifonosMoldes.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAudifonosMoldes.EnableHeadersVisualStyles = false;
            this.dgvAudifonosMoldes.GridColor = System.Drawing.Color.Silver;
            this.dgvAudifonosMoldes.Location = new System.Drawing.Point(128, 28);
            this.dgvAudifonosMoldes.MultiSelect = false;
            this.dgvAudifonosMoldes.Name = "dgvAudifonosMoldes";
            this.dgvAudifonosMoldes.ReadOnly = true;
            this.dgvAudifonosMoldes.RowHeadersVisible = false;
            this.dgvAudifonosMoldes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAudifonosMoldes.Size = new System.Drawing.Size(569, 143);
            this.dgvAudifonosMoldes.TabIndex = 52;
            // 
            // cmbLadoOido
            // 
            this.cmbLadoOido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLadoOido.FormattingEnabled = true;
            this.cmbLadoOido.Location = new System.Drawing.Point(481, 39);
            this.cmbLadoOido.Name = "cmbLadoOido";
            this.cmbLadoOido.Size = new System.Drawing.Size(204, 21);
            this.cmbLadoOido.TabIndex = 50;
            // 
            // lblLadoOido
            // 
            this.lblLadoOido.AutoSize = true;
            this.lblLadoOido.Location = new System.Drawing.Point(419, 43);
            this.lblLadoOido.Name = "lblLadoOido";
            this.lblLadoOido.Size = new System.Drawing.Size(58, 13);
            this.lblLadoOido.TabIndex = 51;
            this.lblLadoOido.Text = "Lado Oído";
            // 
            // txtEstadoAudifono
            // 
            this.txtEstadoAudifono.Location = new System.Drawing.Point(116, 148);
            this.txtEstadoAudifono.Multiline = true;
            this.txtEstadoAudifono.Name = "txtEstadoAudifono";
            this.txtEstadoAudifono.Size = new System.Drawing.Size(569, 47);
            this.txtEstadoAudifono.TabIndex = 48;
            // 
            // lblEstadoAudifono
            // 
            this.lblEstadoAudifono.AutoSize = true;
            this.lblEstadoAudifono.Location = new System.Drawing.Point(74, 151);
            this.lblEstadoAudifono.Name = "lblEstadoAudifono";
            this.lblEstadoAudifono.Size = new System.Drawing.Size(40, 13);
            this.lblEstadoAudifono.TabIndex = 49;
            this.lblEstadoAudifono.Text = "Estado";
            // 
            // txtObservacionAudifono
            // 
            this.txtObservacionAudifono.Location = new System.Drawing.Point(116, 92);
            this.txtObservacionAudifono.Multiline = true;
            this.txtObservacionAudifono.Name = "txtObservacionAudifono";
            this.txtObservacionAudifono.Size = new System.Drawing.Size(569, 50);
            this.txtObservacionAudifono.TabIndex = 46;
            // 
            // lblObservacionAudifono
            // 
            this.lblObservacionAudifono.AutoSize = true;
            this.lblObservacionAudifono.Location = new System.Drawing.Point(48, 95);
            this.lblObservacionAudifono.Name = "lblObservacionAudifono";
            this.lblObservacionAudifono.Size = new System.Drawing.Size(67, 13);
            this.lblObservacionAudifono.TabIndex = 47;
            this.lblObservacionAudifono.Text = "Observación";
            // 
            // dtpFechaFabricacion
            // 
            this.dtpFechaFabricacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFabricacion.Location = new System.Drawing.Point(116, 66);
            this.dtpFechaFabricacion.Name = "dtpFechaFabricacion";
            this.dtpFechaFabricacion.Size = new System.Drawing.Size(204, 20);
            this.dtpFechaFabricacion.TabIndex = 44;
            // 
            // lblFechaFabricacion
            // 
            this.lblFechaFabricacion.AutoSize = true;
            this.lblFechaFabricacion.Location = new System.Drawing.Point(4, 69);
            this.lblFechaFabricacion.Name = "lblFechaFabricacion";
            this.lblFechaFabricacion.Size = new System.Drawing.Size(110, 13);
            this.lblFechaFabricacion.TabIndex = 45;
            this.lblFechaFabricacion.Text = "Fecha de Fabricación";
            // 
            // dtpProximoService
            // 
            this.dtpProximoService.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpProximoService.Location = new System.Drawing.Point(481, 66);
            this.dtpProximoService.Name = "dtpProximoService";
            this.dtpProximoService.Size = new System.Drawing.Size(204, 20);
            this.dtpProximoService.TabIndex = 42;
            // 
            // lblProximoService
            // 
            this.lblProximoService.AutoSize = true;
            this.lblProximoService.Location = new System.Drawing.Point(396, 69);
            this.lblProximoService.Name = "lblProximoService";
            this.lblProximoService.Size = new System.Drawing.Size(83, 13);
            this.lblProximoService.TabIndex = 43;
            this.lblProximoService.Text = "Proximo Service";
            // 
            // txtNroSerie
            // 
            this.txtNroSerie.Location = new System.Drawing.Point(116, 39);
            this.txtNroSerie.Name = "txtNroSerie";
            this.txtNroSerie.Size = new System.Drawing.Size(204, 20);
            this.txtNroSerie.TabIndex = 39;
            // 
            // lblNroSerie
            // 
            this.lblNroSerie.AutoSize = true;
            this.lblNroSerie.Location = new System.Drawing.Point(48, 42);
            this.lblNroSerie.Name = "lblNroSerie";
            this.lblNroSerie.Size = new System.Drawing.Size(66, 13);
            this.lblNroSerie.TabIndex = 41;
            this.lblNroSerie.Text = "Nro de Serie";
            // 
            // btnSeleccionarAudifono
            // 
            this.btnSeleccionarAudifono.Location = new System.Drawing.Point(326, 11);
            this.btnSeleccionarAudifono.Name = "btnSeleccionarAudifono";
            this.btnSeleccionarAudifono.Size = new System.Drawing.Size(41, 23);
            this.btnSeleccionarAudifono.TabIndex = 38;
            this.btnSeleccionarAudifono.Text = "...";
            this.btnSeleccionarAudifono.UseVisualStyleBackColor = true;
            this.btnSeleccionarAudifono.Click += new System.EventHandler(this.btnSeleccionarAudifono_Click);
            // 
            // txtAudifono
            // 
            this.txtAudifono.Enabled = false;
            this.txtAudifono.Location = new System.Drawing.Point(116, 12);
            this.txtAudifono.Name = "txtAudifono";
            this.txtAudifono.Size = new System.Drawing.Size(204, 20);
            this.txtAudifono.TabIndex = 37;
            // 
            // lblAudifono
            // 
            this.lblAudifono.AutoSize = true;
            this.lblAudifono.Location = new System.Drawing.Point(65, 12);
            this.lblAudifono.Name = "lblAudifono";
            this.lblAudifono.Size = new System.Drawing.Size(49, 13);
            this.lblAudifono.TabIndex = 36;
            this.lblAudifono.Text = "Audifono";
            // 
            // btnSeleccionarMoldeAudifono
            // 
            this.btnSeleccionarMoldeAudifono.Location = new System.Drawing.Point(691, 12);
            this.btnSeleccionarMoldeAudifono.Name = "btnSeleccionarMoldeAudifono";
            this.btnSeleccionarMoldeAudifono.Size = new System.Drawing.Size(41, 23);
            this.btnSeleccionarMoldeAudifono.TabIndex = 35;
            this.btnSeleccionarMoldeAudifono.Text = "...";
            this.btnSeleccionarMoldeAudifono.UseVisualStyleBackColor = true;
            this.btnSeleccionarMoldeAudifono.Click += new System.EventHandler(this.btnSeleccionarMoldeAudifono_Click);
            // 
            // txtMoldeAudifono
            // 
            this.txtMoldeAudifono.Enabled = false;
            this.txtMoldeAudifono.Location = new System.Drawing.Point(481, 13);
            this.txtMoldeAudifono.Name = "txtMoldeAudifono";
            this.txtMoldeAudifono.Size = new System.Drawing.Size(204, 20);
            this.txtMoldeAudifono.TabIndex = 34;
            // 
            // lblMoldeAudifono
            // 
            this.lblMoldeAudifono.AutoSize = true;
            this.lblMoldeAudifono.Location = new System.Drawing.Point(384, 16);
            this.lblMoldeAudifono.Name = "lblMoldeAudifono";
            this.lblMoldeAudifono.Size = new System.Drawing.Size(95, 13);
            this.lblMoldeAudifono.TabIndex = 33;
            this.lblMoldeAudifono.Text = "Molde de audifono";
            // 
            // buttonUC1
            // 
            this.buttonUC1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUC1.Image = null;
            this.buttonUC1.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonUC1.Location = new System.Drawing.Point(676, 199);
            this.buttonUC1.Name = "buttonUC1";
            this.buttonUC1.Size = new System.Drawing.Size(121, 34);
            this.buttonUC1.TabIndex = 33;
            this.buttonUC1.Text = "Informe en detalle";
            this.buttonUC1.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.buttonUC1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(674, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(114, 26);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new Medusa.Biodata.FrontEnd.UserControls.ButtonUC.ClickEventHandler(this.btnBuscar_Click);
            // 
            // gpbFiltros
            // 
            this.gpbFiltros.Controls.Add(this.lblCiudadBuscar);
            this.gpbFiltros.Controls.Add(this.cmbCiudadBuscar);
            this.gpbFiltros.Controls.Add(this.txtDocumentoBuscar);
            this.gpbFiltros.Controls.Add(this.lblDocumentoBuscar);
            this.gpbFiltros.Controls.Add(this.txtNombreBuscar);
            this.gpbFiltros.Controls.Add(this.btnBuscar);
            this.gpbFiltros.Controls.Add(this.lblNombreBuscar);
            this.gpbFiltros.Controls.Add(this.cmbSexoBuscar);
            this.gpbFiltros.Controls.Add(this.txtApellidoBuscar);
            this.gpbFiltros.Controls.Add(this.lblSexoBuscar);
            this.gpbFiltros.Controls.Add(this.lblApellidoBuscar);
            this.gpbFiltros.Location = new System.Drawing.Point(14, 3);
            this.gpbFiltros.Name = "gpbFiltros";
            this.gpbFiltros.Size = new System.Drawing.Size(796, 85);
            this.gpbFiltros.TabIndex = 9;
            this.gpbFiltros.TabStop = false;
            this.gpbFiltros.Text = "Filtros";
            // 
            // lblCiudadBuscar
            // 
            this.lblCiudadBuscar.AutoSize = true;
            this.lblCiudadBuscar.Location = new System.Drawing.Point(453, 22);
            this.lblCiudadBuscar.Name = "lblCiudadBuscar";
            this.lblCiudadBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblCiudadBuscar.TabIndex = 32;
            this.lblCiudadBuscar.Text = "Ciudad";
            // 
            // cmbCiudadBuscar
            // 
            this.cmbCiudadBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCiudadBuscar.FormattingEnabled = true;
            this.cmbCiudadBuscar.Location = new System.Drawing.Point(499, 18);
            this.cmbCiudadBuscar.Name = "cmbCiudadBuscar";
            this.cmbCiudadBuscar.Size = new System.Drawing.Size(148, 21);
            this.cmbCiudadBuscar.TabIndex = 31;
            // 
            // txtDocumentoBuscar
            // 
            this.txtDocumentoBuscar.Location = new System.Drawing.Point(377, 45);
            this.txtDocumentoBuscar.Name = "txtDocumentoBuscar";
            this.txtDocumentoBuscar.Size = new System.Drawing.Size(270, 20);
            this.txtDocumentoBuscar.TabIndex = 19;
            // 
            // lblDocumentoBuscar
            // 
            this.lblDocumentoBuscar.AutoSize = true;
            this.lblDocumentoBuscar.Location = new System.Drawing.Point(309, 48);
            this.lblDocumentoBuscar.Name = "lblDocumentoBuscar";
            this.lblDocumentoBuscar.Size = new System.Drawing.Size(62, 13);
            this.lblDocumentoBuscar.TabIndex = 18;
            this.lblDocumentoBuscar.Text = "Documento";
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Location = new System.Drawing.Point(92, 45);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(179, 20);
            this.txtNombreBuscar.TabIndex = 17;
            // 
            // lblNombreBuscar
            // 
            this.lblNombreBuscar.AutoSize = true;
            this.lblNombreBuscar.Location = new System.Drawing.Point(42, 45);
            this.lblNombreBuscar.Name = "lblNombreBuscar";
            this.lblNombreBuscar.Size = new System.Drawing.Size(44, 13);
            this.lblNombreBuscar.TabIndex = 16;
            this.lblNombreBuscar.Text = "Nombre";
            // 
            // cmbSexoBuscar
            // 
            this.cmbSexoBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexoBuscar.FormattingEnabled = true;
            this.cmbSexoBuscar.Location = new System.Drawing.Point(377, 18);
            this.cmbSexoBuscar.Name = "cmbSexoBuscar";
            this.cmbSexoBuscar.Size = new System.Drawing.Size(61, 21);
            this.cmbSexoBuscar.TabIndex = 15;
            // 
            // txtApellidoBuscar
            // 
            this.txtApellidoBuscar.Location = new System.Drawing.Point(92, 19);
            this.txtApellidoBuscar.Name = "txtApellidoBuscar";
            this.txtApellidoBuscar.Size = new System.Drawing.Size(179, 20);
            this.txtApellidoBuscar.TabIndex = 14;
            // 
            // lblSexoBuscar
            // 
            this.lblSexoBuscar.AutoSize = true;
            this.lblSexoBuscar.Location = new System.Drawing.Point(340, 21);
            this.lblSexoBuscar.Name = "lblSexoBuscar";
            this.lblSexoBuscar.Size = new System.Drawing.Size(31, 13);
            this.lblSexoBuscar.TabIndex = 13;
            this.lblSexoBuscar.Text = "Sexo";
            // 
            // lblApellidoBuscar
            // 
            this.lblApellidoBuscar.AutoSize = true;
            this.lblApellidoBuscar.Location = new System.Drawing.Point(42, 19);
            this.lblApellidoBuscar.Name = "lblApellidoBuscar";
            this.lblApellidoBuscar.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoBuscar.TabIndex = 11;
            this.lblApellidoBuscar.Text = "Apellido";
            // 
            // gpbDatosAudifono
            // 
            this.gpbDatosAudifono.Controls.Add(this.cmbLadoOido);
            this.gpbDatosAudifono.Controls.Add(this.lblLadoOido);
            this.gpbDatosAudifono.Controls.Add(this.txtEstadoAudifono);
            this.gpbDatosAudifono.Controls.Add(this.lblEstadoAudifono);
            this.gpbDatosAudifono.Controls.Add(this.txtObservacionAudifono);
            this.gpbDatosAudifono.Controls.Add(this.lblObservacionAudifono);
            this.gpbDatosAudifono.Controls.Add(this.dtpFechaFabricacion);
            this.gpbDatosAudifono.Controls.Add(this.lblFechaFabricacion);
            this.gpbDatosAudifono.Controls.Add(this.dtpProximoService);
            this.gpbDatosAudifono.Controls.Add(this.lblProximoService);
            this.gpbDatosAudifono.Controls.Add(this.txtNroSerie);
            this.gpbDatosAudifono.Controls.Add(this.lblNroSerie);
            this.gpbDatosAudifono.Controls.Add(this.btnSeleccionarAudifono);
            this.gpbDatosAudifono.Controls.Add(this.txtAudifono);
            this.gpbDatosAudifono.Controls.Add(this.lblAudifono);
            this.gpbDatosAudifono.Controls.Add(this.btnSeleccionarMoldeAudifono);
            this.gpbDatosAudifono.Controls.Add(this.txtMoldeAudifono);
            this.gpbDatosAudifono.Controls.Add(this.lblMoldeAudifono);
            this.gpbDatosAudifono.Enabled = false;
            this.gpbDatosAudifono.Location = new System.Drawing.Point(14, 212);
            this.gpbDatosAudifono.Name = "gpbDatosAudifono";
            this.gpbDatosAudifono.Size = new System.Drawing.Size(742, 201);
            this.gpbDatosAudifono.TabIndex = 58;
            this.gpbDatosAudifono.TabStop = false;
            // 
            // frmPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 878);
            this.Controls.Add(this.gpbFiltros);
            this.Name = "frmPaciente";
            this.Text = "frmPaciente";
            this.Load += new System.EventHandler(this.frmPaciente_Load);
            this.SeleccionCompleja += new Mds.Biodata.Forms.frmABMBase.SeleccionComplejaEventHandler(this.frmPacienteSelecciones_SeleccionCompleja);
            this.Controls.SetChildIndex(this.pnlList, 0);
            this.Controls.SetChildIndex(this.pnlDetails, 0);
            this.Controls.SetChildIndex(this.gpbFiltros, 0);
            this.pnlList.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObrasSociales)).EndInit();
            this.gpbObrasSociales.ResumeLayout(false);
            this.tbcDatos.ResumeLayout(false);
            this.tbpDatosPaciente.ResumeLayout(false);
            this.tbpDatosPaciente.PerformLayout();
            this.tbpDatosHistorialClinico.ResumeLayout(false);
            this.tbpDatosHistorialClinico.PerformLayout();
            this.tbpDatosAudifonos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAudifonosMoldes)).EndInit();
            this.gpbFiltros.ResumeLayout(false);
            this.gpbFiltros.PerformLayout();
            this.gpbDatosAudifono.ResumeLayout(false);
            this.gpbDatosAudifono.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Button btnSeleccionarCiudad;
        private Medusa.Biodata.FrontEnd.UserControls.GridView dgvObrasSociales;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox gpbObrasSociales;
        private System.Windows.Forms.TabControl tbcDatos;
        private System.Windows.Forms.TabPage tbpDatosPaciente;
        private System.Windows.Forms.TabPage tbpDatosHistorialClinico;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtAntecedentesHereditarios;
        private System.Windows.Forms.Label lblAntecedentesHereditarios;
        private System.Windows.Forms.TextBox txtEstadoSalud;
        private System.Windows.Forms.Label lblEstadoSalud;
        private System.Windows.Forms.TextBox txtAntecedentesPersonales;
        private System.Windows.Forms.Label lblAntecedentesPersonales;
        private System.Windows.Forms.Label lblInicioAtencion;
        private System.Windows.Forms.DateTimePicker dtpInicioAtencion;
        private Medusa.Biodata.FrontEnd.UserControls.ButtonUC buttonUC1;
        public Medusa.Biodata.FrontEnd.UserControls.ButtonUC btnBuscar;
        public System.Windows.Forms.GroupBox gpbFiltros;
        private System.Windows.Forms.Label lblCiudadBuscar;
        private System.Windows.Forms.ComboBox cmbCiudadBuscar;
        private System.Windows.Forms.TextBox txtDocumentoBuscar;
        private System.Windows.Forms.Label lblDocumentoBuscar;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Label lblNombreBuscar;
        private System.Windows.Forms.ComboBox cmbSexoBuscar;
        private System.Windows.Forms.TextBox txtApellidoBuscar;
        private System.Windows.Forms.Label lblSexoBuscar;
        private System.Windows.Forms.Label lblApellidoBuscar;
        private System.Windows.Forms.TabPage tbpDatosAudifonos;
        private System.Windows.Forms.Button btnSeleccionarAudifono;
        private System.Windows.Forms.TextBox txtAudifono;
        private System.Windows.Forms.Label lblAudifono;
        private System.Windows.Forms.Button btnSeleccionarMoldeAudifono;
        private System.Windows.Forms.TextBox txtMoldeAudifono;
        private System.Windows.Forms.Label lblMoldeAudifono;
        private System.Windows.Forms.TextBox txtNroSerie;
        private System.Windows.Forms.Label lblNroSerie;
        private System.Windows.Forms.DateTimePicker dtpFechaFabricacion;
        private System.Windows.Forms.Label lblFechaFabricacion;
        private System.Windows.Forms.DateTimePicker dtpProximoService;
        private System.Windows.Forms.Label lblProximoService;
        private System.Windows.Forms.TextBox txtObservacionAudifono;
        private System.Windows.Forms.Label lblObservacionAudifono;
        private System.Windows.Forms.TextBox txtEstadoAudifono;
        private System.Windows.Forms.Label lblEstadoAudifono;
        private System.Windows.Forms.ComboBox cmbLadoOido;
        private System.Windows.Forms.Label lblLadoOido;
        public Medusa.Biodata.FrontEnd.UserControls.GridView dgvAudifonosMoldes;
        private System.Windows.Forms.Button btnNuevoAudifono;
        private System.Windows.Forms.Button btnEliminarAudifono;
        private System.Windows.Forms.Button btnModificarAudifono;
        private System.Windows.Forms.Button btnCancelarAudifono;
        private System.Windows.Forms.Button btnAceptarAudifono;
        private System.Windows.Forms.GroupBox gpbDatosAudifono;
    }
}