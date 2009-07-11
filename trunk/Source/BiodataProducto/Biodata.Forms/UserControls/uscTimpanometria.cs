﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Domain;

namespace Mds.Biodata.Forms.UserControls
{
    public partial class uscTimpanometria : uscBase
    {
        #region "--[Properties]--"

        #endregion

        #region "--[Methods]--"
        public uscTimpanometria()
        {
            InitializeComponent();
        }

        public override Estudio ObtenerDatosEstudio()
        {
            Timpanometria wTimpanometria = new Timpanometria();

            List<Liner.Main.Grid.Args.Line> wLineasEstudio = linerCentral.GenerateLinePointsArgs();

            String strLineasEstudio = Mds.Architecture.HelpersFunctions.SerializationFunctions.Serialize(wLineasEstudio);

            wTimpanometria.TimpanometriaGrafico = strLineasEstudio;
            if (rad05Izq.Checked)
            {
                wTimpanometria.ReflejoEstapedialIzq = 0;
            }
            else
            {
                wTimpanometria.ReflejoEstapedialIzq = 1;
            }
            if (rad05Der.Checked)
            {
                wTimpanometria.ReflejoEstapedialDer = 0;
            }
            else
            {
                wTimpanometria.ReflejoEstapedialDer = 1;
            }
            wTimpanometria.TablaReflejosIzq = Mds.Architecture.HelpersFunctions.SerializationFunctions.Serialize((DataTable)dgvTablaReflejosIzq.DataSource);
            wTimpanometria.TablaReflejosDer = Mds.Architecture.HelpersFunctions.SerializationFunctions.Serialize((DataTable)dgvTablaReflejosDer.DataSource); 

            return (Estudio)wTimpanometria;
        }

        private void DarFormatoGrillas()
        {
            DataTable oDTIzq = new DataTable("Datos");

            oDTIzq.Columns.Add("-250-");
            oDTIzq.Columns.Add("-500-");
            oDTIzq.Columns.Add("-1K-");
            oDTIzq.Columns.Add("-2K-");
            oDTIzq.Columns.Add("-4K-");

            DataRow oDR = oDTIzq.NewRow();
            DataRow oDR2 = oDTIzq.NewRow();
            oDTIzq.Rows.Add(oDR);
            oDTIzq.Rows.Add(oDR2);

            DataTable oDTDer = oDTIzq.Copy();

            dgvTablaReflejosIzq.DataSource = oDTIzq;
            dgvTablaReflejosDer.DataSource = oDTDer;

            dgvTablaReflejosIzq.Columns["-250-"].Width = 56;
            dgvTablaReflejosIzq.Columns["-500-"].Width = 56;
            dgvTablaReflejosIzq.Columns["-1K-"].Width = 56;
            dgvTablaReflejosIzq.Columns["-2K-"].Width = 55;
            dgvTablaReflejosIzq.Columns["-4K-"].Width = 55;

            dgvTablaReflejosDer.Columns["-250-"].Width = 56;
            dgvTablaReflejosDer.Columns["-500-"].Width = 56;
            dgvTablaReflejosDer.Columns["-1K-"].Width = 56;
            dgvTablaReflejosDer.Columns["-2K-"].Width = 55;
            dgvTablaReflejosDer.Columns["-4K-"].Width = 55;

            //String strDT = Mds.Architecture.HelpersFunctions.SerializationFunctions.Serialize(oDT);
            //DataTable kk = (DataTable)Mds.Architecture.HelpersFunctions.SerializationFunctions.DeserializeFromXml(typeof(DataTable), strDT);


        }
        #endregion

        #region "--[Events]--"
        private void uscTimpanometria_Load(object sender, EventArgs e)
        {
            DarFormatoGrillas();
        }
        #endregion
    }
}
