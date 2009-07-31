using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Domain;

namespace Mds.Biodata.Forms.UserControls
{
    public partial class uscTestLing : uscBase
    {
        #region "--[Properties]--"

        #endregion

        #region "--[Methods]--"
        public uscTestLing()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Da formato a la grilla
        /// </summary>
        public void DarFormatoGrillas()
        {
            DataTable oDT = new DataTable("Datos");

            oDT.Columns.Add("Sonidos");
            oDT.Columns.Add("Aciertos30cm");
            oDT.Columns.Add("Intentos30cm");
            oDT.Columns.Add("Aciertos5m");
            oDT.Columns.Add("Intentos5m");
            oDT.Columns.Add("AciertosAtravesPuerta");
            oDT.Columns.Add("IntentosAtravesPuerta");

            DataRow oDR = oDT.NewRow();
            DataRow oDR2 = oDT.NewRow();
            DataRow oDR3 = oDT.NewRow();
            DataRow oDR4 = oDT.NewRow();
            DataRow oDR5 = oDT.NewRow();
            DataRow oDR6 = oDT.NewRow();
            oDT.Rows.Add(oDR);
            oDT.Rows.Add(oDR2);
            oDT.Rows.Add(oDR3);
            oDT.Rows.Add(oDR4);
            oDT.Rows.Add(oDR5);
            oDT.Rows.Add(oDR6);

            dgvValores.DataSource = oDT;

            DeterminarAnchoColumnas();
            //String strDT = Mds.Architecture.HelpersFunctions.SerializationFunctions.Serialize(oDT);
            //DataTable kk = (DataTable)Mds.Architecture.HelpersFunctions.SerializationFunctions.DeserializeFromXml(typeof(DataTable), strDT);
        }

        private void DeterminarAnchoColumnas()
        {
            dgvValores.Columns["Sonidos"].Width = 80;
            dgvValores.Columns["Aciertos30cm"].Width = 80;
            dgvValores.Columns["Intentos30cm"].Width = 80;
            dgvValores.Columns["Aciertos5m"].Width = 80;
            dgvValores.Columns["Intentos5m"].Width = 80;
            dgvValores.Columns["AciertosAtravesPuerta"].Width = 115;
            dgvValores.Columns["IntentosAtravesPuerta"].Width = 115;
        }

        public override Estudio ObtenerDatosEstudio()
        {
            TestLing wTestLing = new TestLing();

            wTestLing.TablaValores = Mds.Architecture.HelpersFunctions.SerializationFunctions.Serialize((DataTable)dgvValores.DataSource);
            if (this.EstudioActualID != null)
            {
                wTestLing.ID = this.EstudioActualID.Value;
            }
            return (Estudio)wTestLing;
        }

        public override void CargarDatosEstudio(Estudio pEstudio)
        {
            //base.CargarDatosEstudio(pEstudio);
            TestLing wTestLing = (TestLing)pEstudio;

            DataTable wDt;
            wDt = (DataTable)Mds.Architecture.HelpersFunctions.SerializationFunctions.Deserialize(typeof(DataTable), wTestLing.TablaValores);
            dgvValores.DataSource = wDt;
            DeterminarAnchoColumnas();

            this.EstudioActualID = pEstudio.ID;
        }
        #endregion

        #region "--[Events]--"
        private void uscTestLing_Load(object sender, EventArgs e)
        {
            //DarFormatoGrillas();
            //CargarValoresInicialesGrilla();
        }

        /// <summary>
        /// Carga valores por defecto en la grilla los cuales pueden ser modificados
        /// </summary>
        public void CargarValoresInicialesGrilla()
        {
            dgvValores.Rows[0].Cells["Sonidos"].Value = "/m/";
            dgvValores.Rows[1].Cells["Sonidos"].Value = "/a/";
            dgvValores.Rows[2].Cells["Sonidos"].Value = "/e/";
            dgvValores.Rows[3].Cells["Sonidos"].Value = "/u/";
            dgvValores.Rows[4].Cells["Sonidos"].Value = "/ch/";
            dgvValores.Rows[5].Cells["Sonidos"].Value = "/s/";

            dgvValores.Rows[0].Cells["Sonidos"].Value = "/m/";
            dgvValores.Rows[1].Cells["Sonidos"].Value = "/a/";
            dgvValores.Rows[2].Cells["Sonidos"].Value = "/e/";
            dgvValores.Rows[3].Cells["Sonidos"].Value = "/u/";
            dgvValores.Rows[4].Cells["Sonidos"].Value = "/ch/";
            dgvValores.Rows[5].Cells["Sonidos"].Value = "/s/";

            for (Int32 i = 0; i < 6; i++)
            {
                dgvValores.Rows[i].Cells["Intentos30cm"].Value = "5";
                dgvValores.Rows[i].Cells["Intentos5m"].Value = "5";
                dgvValores.Rows[i].Cells["IntentosAtravesPuerta"].Value = "5";
            }

        }
        #endregion
    }
}
