using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Business;
using Mds.Biodata.Domain;

namespace Mds.Biodata.Forms
{
    public partial class frmLogin : frmBase
    {
        #region "--[Properties]--"
        private UsuarioBusiness _UsuarioBP;

        public UsuarioBusiness UsuarioBP
        {
            get { return _UsuarioBP; }
            set { _UsuarioBP = value; }
        }
        #endregion

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNick.Text == "")
            {
                ProcesarMensaje("Debe ingresar el nick", "Login");
                return;
            }
            if (txtPassword.Text == "")
            {
                ProcesarMensaje("Debe ingresar el password", "Login");
                return;
            }

            Login(txtNick.Text, txtPassword.Text);
        }

        private void Login(String pNick, String pPassword)
        {
            Usuario wUsuarioLogin = _UsuarioBP.ValidarUsuario(pNick, pPassword);

            if (wUsuarioLogin == null)
            {
                ProcesarAdvertencia("Usuario no valido");
            }
            else
            {
                //Se llama al formulario principal
                frmPrincipal frmPrinc = new frmPrincipal();
                frmPrinc.UsuarioSistema = wUsuarioLogin;
                frmPrinc.Show();
                this.Close();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _UsuarioBP = new UsuarioBusiness(DaoFactory.GetUsuarioDao());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Program.Close();
        }
    }
}
