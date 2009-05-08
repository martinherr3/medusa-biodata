using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Domain;
using Mds.Biodata.Business;

namespace Mds.Biodata.Forms.Reportes
{
    public partial class ReportePacientes : ReporteBase 
    {
        #region "--[Properties]--"
        private List<Paciente> _PacienteEntities = new List<Paciente>();

        public List<Paciente> PacienteEntities
        {
            get { return _PacienteEntities; }
            set { _PacienteEntities = value; }
        }
        #endregion

        #region "--[Methods]--"
        public ReportePacientes()
        {
            InitializeComponent();
        }

        private void MostrarPacientes()
        {
            try
            {
                PacienteBusiness wPacienteBP = new PacienteBusiness(DaoFactory.GetPacienteDao());
                this.PacienteEntities = wPacienteBP.GetAll();
                this.bscOrigenReporte.DataSource = this.PacienteEntities;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                ProcesarExcepcion(ex);
            }
        }
        #endregion

        #region "--[Events]--"
        private void ReportePacientes_Load(object sender, EventArgs e)
        {
            MostrarPacientes();
        }
        #endregion
    }
}
