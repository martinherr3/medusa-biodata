using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mds.Biodata.Forms
{
    public partial class frmPrincipal : frmBase
    {
        #region "--[Properties]--"
        #endregion

        #region "--[Methods]--"
        public frmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region "--[Events]--"
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            GereralFunctions.Principal = this;
        }
        #endregion
        

        #region "--[Llamadas a Ventanas de la aplicación--"
        private void tsmGestionObraSocial_Click(object sender, EventArgs e)
        {
            OpenObraSocial();
        }

        private void OpenObraSocial()
        {
            try
            {
                GereralFunctions.AbrirFormulario(new frmObraSocial(), (TabControl)this.spcRight.Panel2.Controls[0], "Gestión de Obras Sociales", DockStyle.Fill);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void tsmGestionPaciente_Click(object sender, EventArgs e)
        {
            OpenPaciente();
        }

        private void OpenPaciente()
        {
            try
            {
                GereralFunctions.AbrirFormulario(new frmPaciente(), (TabControl)this.spcRight.Panel2.Controls[0], "Gestión de Pacientes", DockStyle.Fill);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
        #endregion

        private void tsmGestionRecordatorio_Click(object sender, EventArgs e)
        {
            OpenGestionRecordatorio();

        }

        private void OpenGestionRecordatorio()
        {
            try
            {
                GereralFunctions.AbrirFormulario(new frmRecordatorio(), (TabControl)this.spcRight.Panel2.Controls[0], "Gestión de Recordatorios", DockStyle.Fill);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }



        
        
    }
}
