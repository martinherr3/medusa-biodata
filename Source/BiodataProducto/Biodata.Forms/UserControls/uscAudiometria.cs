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
    public partial class uscAudiometria : uscBase
    {

        #region "--[Properties]--"

        #endregion

        #region "--[Methods]--"
        public uscAudiometria()
        {
            InitializeComponent();
        }

        public override Estudio ObtenerDatosEstudio()
        {
            Audiometria wAudiometria = new Audiometria();

            List<Liner.Main.Grid.Args.Line> wLineasEstudiosLeft = linerLeft.GenerateLinePointsArgs();
            List<Liner.Main.Grid.Args.Line> wLineasEstudiosRight = linerRight.GenerateLinePointsArgs();

            String strLineasEstudiosLeft = Mds.Architecture.HelpersFunctions.SerializationFunctions.Serialize(wLineasEstudiosLeft);
            String strLineasEstudiosRight = Mds.Architecture.HelpersFunctions.SerializationFunctions.Serialize(wLineasEstudiosRight);
            wAudiometria.AudiogramaIzquierdo = strLineasEstudiosLeft;
            wAudiometria.AudiogramaDerecho = strLineasEstudiosRight;
            return (Estudio)wAudiometria;
        }
        #endregion

        #region "--[Events]--"
        private void uscAudiometria_Load(object sender, EventArgs e)
        {
            linerLeft.XInterval = "250, 8000, 2 , *";
            linerRight.XInterval = "250, 8000, 2 , *";
        }
        #endregion

        private void linerLeft_BeforeSeriesCreation(object sender)
        {
            //pSeriesConfig = new Liner.Main.Grid.Args.SeriesConfig();
            //pSeriesConfig.LineColor = Color.Blue;
            //pSeriesConfig.LineType = System.Drawing.Drawing2D.DashStyle.DashDot;
            //pSeriesConfig.PointType = Pavr.Main.Base.PointType.X;
            linerLeft.LineColor = Color.Blue;
            linerLeft.DashLineType = Pavr.Main.Base.DashLineType.DashDot;
            linerLeft.PointType = Pavr.Main.Base.PointType.X;

        }

        private void linerRight_BeforeSeriesCreation(object sender)
        {
            //pSeriesConfig = new Liner.Main.Grid.Args.SeriesConfig();
            //pSeriesConfig.LineColor = Color.Red;
            //pSeriesConfig.LineType = System.Drawing.Drawing2D.DashStyle.Solid;
            //pSeriesConfig.PointType = Pavr.Main.Base.PointType.O;
            linerRight.LineColor = Color.Red;
            linerRight.DashLineType = Pavr.Main.Base.DashLineType.Solid;
            linerRight.PointType = Pavr.Main.Base.PointType.O;
        }
    }
}
