using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Domain;
using Mds.Biodata.Business;

namespace Mds.Biodata.Forms
{
    public partial class frmUsuarioPassword : frmBase
    {
        #region "--[Properties]--"
        private Usuario _UsuarioLogueado;

        public Usuario UsuarioLogueado
        {
            get { return _UsuarioLogueado; }
            set { _UsuarioLogueado = value; }
        }

        private UsuarioBusiness _UsuarioBP;

        public UsuarioBusiness UsuarioBP
        {
            get { return _UsuarioBP; }
            set { _UsuarioBP = value; }
        }

        #endregion

        #region "--[Methods]--"
        public frmUsuarioPassword()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            txtNick.Text = UsuarioLogueado.Nick;
            txtNick.Enabled = false;
            txtPasswordActual.Focus();
        }

        private void RegistrarCambioPassword()
        {
            if (txtPasswordActual.Text != "" && txtPasswordNuevo.Text != "")
            {
                if (UsuarioBP.ValidarUsuario(txtNick.Text, txtPasswordActual.Text))
                {
                    UsuarioLogueado.Password = txtPasswordNuevo.Text;

                    UsuarioBP.Update(UsuarioLogueado);
                    UsuarioBP.Commit();
                }
                else
                {
                    ProcesarMensaje("Datos invalidos, no se puede modificar el Password");
                }
            }
            else
            {
                ProcesarMensaje("Faltan datos para realizar la modificación");
            }
        }
        #endregion

        #region "--[Events]--"
        private void frmUsuarioPassword_Load(object sender, EventArgs e)
        {
            UsuarioBP = new UsuarioBusiness(DaoFactory.GetUsuarioDao());
            CargarDatos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            RegistrarCambioPassword();
        }
        #endregion
    }
}
