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
    public partial class ReporteAudifonos : ReporteBase
    {
        #region "--[Properties]--"
        private List<Audifono> _AudifonoEntities = new List<Audifono>();

        public List<Audifono> AudifonoEntities
        {
            get { return _AudifonoEntities; }
            set { _AudifonoEntities = value; }
        }
       
        #endregion

        #region "--[Methods]--"
        public ReporteAudifonos()
        {
            InitializeComponent();
        }

        private void MostrarAudifonos()
        {
            try
            {
                AudifonoBusiness wAudifinoBP = new AudifonoBusiness(DaoFactory.GetAudifonoDao());
                this.AudifonoEntities = wAudifinoBP.GetAll();
                this.bscOrigenReporte.DataSource = this.AudifonoEntities;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                ProcesarExcepcion(ex);
            }
        }
        #endregion

        #region "--[Events]--"
        private void ReporteAudifonos_Load(object sender, EventArgs e)
        {
            MostrarAudifonos();
        }
        #endregion
      
    }
}
