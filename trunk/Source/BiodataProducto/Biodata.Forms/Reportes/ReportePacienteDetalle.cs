using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Domain;
using Mds.Biodata.Business;
using Microsoft.Reporting.WinForms;

namespace Mds.Biodata.Forms.Reportes
{
    public partial class ReportePacienteDetalle : ReporteBase
    {
        #region "--[Properties]--"
        private Paciente _PacienteParticular;

        public Paciente PacienteParticular
        {
            get { return _PacienteParticular; }
            set { _PacienteParticular = value; }
        }

        #endregion

        #region "--[Methods]--"
        public ReportePacienteDetalle()
        {
            InitializeComponent();
        }

        private void MostrarDetallePaciente()
        {
            try
            {
                //PacienteBusiness wPacienteBP = new PacienteBusiness(DaoFactory.GetPacienteDao());
                //this.PacienteEntities = wPacienteBP.GetAll();
                GenerarParametrosReporte();
                this.bscOrigenReporte.DataSource = this.PacienteParticular;//.HistoriaClinicas[0].Estudios;

                reportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SubreportProcessingEventHandler);
                
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                ProcesarExcepcion(ex);
            }
        }

        private void GenerarParametrosReporte()
        {
            // Creo una colección de parámetros de tipo ReportParameter para añadirlos al control ReportViewer.
            List<ReportParameter> parametros = new List<ReportParameter>();
            // Añado los parámetros necesarios.
            parametros.Add(new ReportParameter("Observaciones", PacienteParticular.HistoriaClinicas[0].Observaciones));
            parametros.Add(new ReportParameter("AntecedentesHistoricos", PacienteParticular.HistoriaClinicas[0].AntecedentesHereditarios));
            parametros.Add(new ReportParameter("AntecedentesPersonales", PacienteParticular.HistoriaClinicas[0].AntecedentesPersonales));
            parametros.Add(new ReportParameter("EstadoSalud", PacienteParticular.HistoriaClinicas[0].EstadoSalud));
            // Añado el/los parámetro/s al ReportViewer.
            this.reportViewer1.LocalReport.SetParameters(parametros);
        }

        #endregion

        #region "--[Events]--"
        private void ReportePacienteDetalle_Load(object sender, EventArgs e)
        {
            MostrarDetallePaciente();
        }

        void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
        {
            //e.DataSources.Add(new ReportDataSource("AdventureWorksDataSet_Contact", this.AdventureWorksDataSet.Contact));

            e.DataSources.Add(new ReportDataSource("Mds_Biodata_Domain_Estudio", this.PacienteParticular.HistoriaClinicas[0].Estudios));
        }
        #endregion
    }
}
