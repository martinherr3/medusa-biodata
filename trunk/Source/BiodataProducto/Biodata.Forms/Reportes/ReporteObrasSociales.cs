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
    public partial class ReporteObrasSociales : ReporteBase
    {
        #region "--[Properties]--"
        private List<ObraSocial> _ObraSocialEntities = new List<ObraSocial>();

        public List<ObraSocial> ObraSocialEntities
        {
            get { return _ObraSocialEntities; }
            set { _ObraSocialEntities = value; }
        }
        #endregion

        #region "--[Methods]--"
        public ReporteObrasSociales()
        {
            InitializeComponent();
        }

        private void MostrarObrasSociales()
        {
            try
            {
                ObraSocialBusiness wObraSocialBP = new ObraSocialBusiness(DaoFactory.GetObraSocialDao());
                this.ObraSocialEntities = wObraSocialBP.GetAll();
                this.bscOrigenReporte.DataSource = this.ObraSocialEntities;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                ProcesarExcepcion(ex);
            }
        }
        #endregion

        #region "--[Events]--"
        private void ReporteObrasSociales_Load(object sender, EventArgs e)
        {
            MostrarObrasSociales();
        }
        #endregion
    }
}
