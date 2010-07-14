using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Domain;
using Mds.Biodata.Business;
using ObjectViews;
using System.Collections;
using Mds.Biodata.Helpers;

namespace Mds.Biodata.Forms
{
    public partial class frmUsuario : frmABMBase
    {
        #region "--[Properties]--"
        private UsuarioBusiness _UsuarioBP;

        public UsuarioBusiness UsuarioBP
        {
            get { return _UsuarioBP; }
            set { _UsuarioBP = value; }
        }

        private List<Usuario> _UsuarioEntities = new List<Usuario>();

        public List<Usuario> UsuarioEntities
        {
            get { return _UsuarioEntities; }
            set { _UsuarioEntities = value; }
        }

        private Usuario _UsuarioEntity;

        public Usuario UsuarioEntity
        {
            get { return _UsuarioEntity; }
            set { _UsuarioEntity = value; }
        }

        private ObjectView _UsuarioObjectView;

        public ObjectView UsuarioObjectView
        {
            get { return _UsuarioObjectView; }
            set { _UsuarioObjectView = value; }
        }

        private BindingManagerBase _UsuarioCurrencyManager;

        public BindingManagerBase UsuarioCurrencyManager
        {
            get { return _UsuarioCurrencyManager; }
            set { _UsuarioCurrencyManager = value; }
        }
        #endregion

        #region "--[Methods]--"
        public frmUsuario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Da formato a la grilla y crea lo necesario para el bindeo
        /// </summary>
        private void InitializeObjectView()
        {
            this.UsuarioObjectView = new ObjectView(typeof(Usuario));
            this.UsuarioObjectView.AllowRemove = false;
            this.UsuarioObjectView.Columns.Add("ID", "ID");
            this.UsuarioObjectView.Columns.Add("Nombre", "Nombre");
            this.UsuarioObjectView.Columns.Add("Apellido", "Apellido");
            this.UsuarioObjectView.Columns.Add("Nick", "Nick");
            this.UsuarioCurrencyManager = this.dgvList.BindingContext[this.UsuarioObjectView];
        }

        /// <summary>
        /// Carga la grilla con los registros de la DB
        /// </summary>
        private void LoadList(Boolean ContarParametrosBusqueda)
        {
            try
            {
                ptbProgress.Visible = true;
                InitializeObjectView();
                dgvList.DataSource = null;
                Habilitar(false);
                btnClose.Enabled = true;
                bgwLoad.RunWorkerAsync(ContarParametrosBusqueda);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        /// <summary>
        /// Carga la entidad (registro) seleccionada en los controles
        /// </summary>
        private void LoadData()
        {
            ObjectViews.ObjectViewRow RowSelected = (ObjectViewRow)dgvList.CurrentRow.DataBoundItem;
            UsuarioEntity = UsuarioBP.GetById(((Usuario)RowSelected.InnerObject).ID);

            txtID.Text = UsuarioEntity.ID.ToString();
            txtNombre.Text = UsuarioEntity.Nombre;
            txtApellido.Text = UsuarioEntity.Apellido;
            txtNick.Text = UsuarioEntity.Nick;
            txtPassword.Text = UsuarioEntity.Password;
            cmbTipoUsuario.SelectedItem = (Enumeraciones.TipoUsuario)UsuarioEntity.TipoUsuario;
            
        }

        /// <summary>
        /// Valida datos basicos antes de enviar la entidad
        /// </summary>
        /// <returns></returns>
        private Boolean ValidData()
        {
            if (txtNombre.Text == "" || txtNombre.Text == null)
            {
                ProcesarAdvertencia("Debe ingresar el Nombre del usuario");
                return false;
            }
            if (txtApellido.Text == "" || txtApellido.Text == null)
            {
                ProcesarAdvertencia("Debe ingresar el Apellido del usuario");
                return false;
            }
            if (txtNick.Text == "" || txtNick.Text == null)
            {
                ProcesarAdvertencia("Debe ingresar el Nick del usuario");
                return false;
            }
            if (txtPassword.Text == "" || txtPassword.Text == null)
            {
                ProcesarAdvertencia("Debe ingresar el password del usuario");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Carga los combos de Tipo de Documento y Sexo
        /// </summary>
        private void LoadCombos()
        {
            try
            {
                //Tipo de Usuario
                cmbTipoUsuario.DataSource = Enum.GetValues(typeof(Enumeraciones.TipoUsuario));
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
        #endregion

        #region "--[Events]--"
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            _UsuarioBP = new UsuarioBusiness(DaoFactory.GetUsuarioDao());
            LoadCombos();
            LoadList(false);
        }
        #endregion

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!Convert.ToBoolean(e.Argument))
            {
                _UsuarioEntities = _UsuarioBP.GetAll();
            }
            else
            {
                //Si existieran filtros
            }
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.UsuarioObjectView.DataSource = (IList)this._UsuarioEntities;
            this.dgvList.DataSource = this.UsuarioObjectView;
            ptbProgress.Visible = false;
            Habilitar(true);
        }

        public override void Accion()
        {
            try
            {
                pnlDetails.Visible = true;

                switch (Estado)
                {
                    case EstadoForm.Nuevo:
                        txtID.Text = string.Empty;
                        txtID.Enabled = false;
                        txtNombre.Text = string.Empty;
                        txtApellido.Text = string.Empty;
                        txtNick.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                        cmbTipoUsuario.SelectedItem = Enumeraciones.TipoUsuario.UsuarioComun;
                        
                        txtNombre.Focus();
                        UsuarioEntity = new Usuario();

                        break;

                    case EstadoForm.Editar:
                        if (dgvList.Rows.Count > 0)
                        {
                            txtID.Enabled = false;
                            LoadData();
                            txtNombre.Focus();
                        }

                        break;

                    case EstadoForm.Eliminar:
                        if (dgvList.Rows.Count > 0)
                        {
                            txtID.Enabled = false;
                            LoadData();
                        }

                        break;
                }
            }

            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData())
                {
                    UsuarioEntity.Nombre = txtNombre.Text;
                    UsuarioEntity.Apellido = txtApellido.Text;
                    UsuarioEntity.Nick = txtNick.Text;
                    //UsuarioEntity.Password = txtPassword.Text;
                    if (Estado == EstadoForm.Editar)
                    {
                        if (UsuarioEntity.Password != txtPassword.Text)
                        {
                            UsuarioEntity.Password = CryptoHelper.HashMD5(txtPassword.Text);
                        }
                    }
                    else
                    {
                        UsuarioEntity.Password = CryptoHelper.HashMD5(txtPassword.Text);
                    }
                    UsuarioEntity.TipoUsuario = Convert.ToInt32(cmbTipoUsuario.SelectedItem);
                    
                    switch (Estado)
                    {
                        case EstadoForm.Editar:
                            UsuarioBP.Update(UsuarioEntity);
                            UsuarioBP.Commit();
                            break;
                        case EstadoForm.Eliminar:
                            UsuarioBP.Delete(UsuarioEntity);
                            UsuarioBP.Commit();
                            break;
                        case EstadoForm.Nuevo:
                            UsuarioBP.Insert(UsuarioEntity);
                            break;
                    }
                    pnlDetails.Visible = false;
                    CambiarTamaño(true);
                    Estado = EstadoForm.Grilla;
                    LoadList(false);
                }
            }

            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
    }
}
