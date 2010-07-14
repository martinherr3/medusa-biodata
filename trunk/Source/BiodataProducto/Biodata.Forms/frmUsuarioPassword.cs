using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Domain;
using Mds.Biodata.Business;
using Mds.Biodata.Helpers;

namespace Mds.Biodata.Forms
{
    public partial class frmUsuarioPassword : frmBase
    {
        #region "--[Properties]--"
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
            txtNick.Text = UsuarioSistema.Nick;
            
            txtPasswordActual.Focus();
        }

        private void RegistrarCambioPassword()
        {
            try
            {
                if (txtPasswordActual.Text != "" && txtPasswordNuevo.Text != "")
                {
                    if (CryptoHelper.ComparePasswordMD5(txtPasswordActual.Text, UsuarioSistema.Password))
                    {
                        UsuarioSistema.Password = CryptoHelper.HashMD5(txtPasswordNuevo.Text);

                        UsuarioBP.Update(UsuarioSistema);
                        UsuarioBP.Commit();
                        ProcesarMensaje("Se modifico el password exitosamente");
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
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
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
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion  
    }
}
