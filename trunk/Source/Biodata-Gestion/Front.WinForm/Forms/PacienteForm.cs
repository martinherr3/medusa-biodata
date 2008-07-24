using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medusa.Biodata.Data.Interfaces;
using Medusa.Biodata.Entity;

namespace Medusa.Biodata.Util.Forms
{
    public partial class PacienteForm : Form
    {
        public PacienteForm()
        {
            InitializeComponent();
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            
            
        }

        /// <summary>
        /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
        /// </summary>
        public IDaoFactory DaoFactory
        {
            get
            {
                return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            IPacienteDao dao = DaoFactory.GetPacienteDao();
            Paciente paciente = new Paciente();
            paciente.Nombre = TxtNombre.Text;
            paciente.Apellido = TxtApellido.Text;
            paciente.Edad = Convert.ToInt32(TxtEdad.Text);

            dao.Save(paciente);
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
