using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Medusa.Biodata.FrontEnd.Forms
{
    public partial class PrincipalForm : BaseForm
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void gestionDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPacienteForm();
        }

        private void OpenPacienteForm()
        {
            try
            {
                FormHelper.AbrirFormulario(new PacienteForm(), (TabControl)this.spcRight.Panel2.Controls[0], "Gestion de Pacientes", DockStyle.Fill);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

    }
}
