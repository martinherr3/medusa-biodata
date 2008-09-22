using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;
using Medusa.Biodata.Service;

namespace Medusa.Biodata.Util.Forms
{
    public partial class PacienteForm : Form
    {

        PacienteService _pacienteService;
        ObraSocialService _obraSocialService;
 
        public PacienteForm()
        {
            InitializeComponent();
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            _obraSocialService = new ObraSocialService(DaoFactory);
            _pacienteService = new PacienteService(DaoFactory);

            IList<ObraSocial> obraSociales = _obraSocialService.GetObrasSociales();
            foreach (ObraSocial os in obraSociales)
            {
                cmbObraSocial.Items.Add(os.RazonSocial);
            }
            
            
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

           
            Paciente paciente = new Paciente();
            paciente.Nombre = TxtNombre.Text;
            paciente.Apellido = TxtApellido.Text;
            ObraSocial os = _obraSocialService.GetObraSocial(2);
            paciente.IdObraSocialLookup = os;
            paciente.IdObraSocial = 2;
            _pacienteService.SavePaciente(paciente);
            
        }

    }
}
