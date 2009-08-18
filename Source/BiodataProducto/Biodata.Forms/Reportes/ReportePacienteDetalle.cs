using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mds.Biodata.Forms.Reportes
{
    public partial class ReportePacienteDetalle : ReporteBase
    {
        public ReportePacienteDetalle()
        {
            InitializeComponent();
        }

        private void ReportePacienteDetalle_Load(object sender, EventArgs e)
        {
            MostrarDetallePaciente();
        }

        private void MostrarDetallePaciente()
        {
            try
            {
                //PacienteBusiness wPacienteBP = new PacienteBusiness(DaoFactory.GetPacienteDao());
                //this.PacienteEntities = wPacienteBP.GetAll();
                //this.bscOrigenReporte.DataSource = this.PacienteEntities;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                ProcesarExcepcion(ex);
            }
        }
    }
}
