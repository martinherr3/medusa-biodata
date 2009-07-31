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

            object myLineasLeft;
            object myLineasSeriesLeft;

            object myLineasRight;
            object myLineasSeriesRight;

            //List<Liner.Main.Grid.Args.Line> wLineasEstudiosLeft = linerLeft.GenerateLinePointsArgs();
            //List<Liner.Main.Grid.Args.Line> wLineasEstudiosRight = linerRight.GenerateLinePointsArgs();

            linerLeft.GenerateLinePointsArgs(out myLineasLeft, out myLineasSeriesLeft);
            linerRight.GenerateLinePointsArgs(out myLineasRight, out myLineasSeriesRight);


            //String strLineasEstudiosLeft = Mds.Architecture.HelpersFunctions.SerializationFunctions.Serialize(wLineasEstudiosLeft);
            //String strLineasEstudiosRight = Mds.Architecture.HelpersFunctions.SerializationFunctions.Serialize(wLineasEstudiosRight);
            String strLineasEstudiosLeft = Mds.Architecture.HelpersFunctions.SerializationFunctions.Serialize(myLineasLeft);
            String strLineasEstudiosRight = Mds.Architecture.HelpersFunctions.SerializationFunctions.Serialize(myLineasRight);
            wAudiometria.AudiogramaIzquierdo = strLineasEstudiosLeft;
            wAudiometria.AudiogramaDerecho = strLineasEstudiosRight;
            if (this.EstudioActualID != null)
            {
                wAudiometria.ID = this.EstudioActualID.Value;
            }
            return (Estudio)wAudiometria;
        }

        public override void CargarDatosEstudio(Estudio pEstudio)
        {
            //base.CargarDatosEstudio(pEstudio);
            Audiometria wAudiometria = (Audiometria)pEstudio;

            Liner.Main.Collections.Collection AudiometriaLeft;
            AudiometriaLeft = (Liner.Main.Collections.Collection)Mds.Architecture.HelpersFunctions.SerializationFunctions.Deserialize(typeof(Liner.Main.Collections.Collection), wAudiometria.AudiogramaIzquierdo);
            Liner.Main.Collections.Collection AudiometriaRight;
            AudiometriaRight = (Liner.Main.Collections.Collection)Mds.Architecture.HelpersFunctions.SerializationFunctions.Deserialize(typeof(Liner.Main.Collections.Collection), wAudiometria.AudiogramaDerecho);

            linerLeft.AutoGenerateLine(AudiometriaLeft, AudiometriaLeft.GetCurrentLineSeries());
            linerRight.AutoGenerateLine(AudiometriaRight, AudiometriaRight.GetCurrentLineSeries());

            this.EstudioActualID = pEstudio.ID;
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
            if (radAereaIzq.Checked)
            {
                linerLeft.DashLineType = Pavr.Main.Base.DashLineType.DashDot;
                linerLeft.PointType = Pavr.Main.Base.PointType.X;
            }
            else
            {
                linerLeft.DashLineType = Pavr.Main.Base.DashLineType.Solid;
                linerLeft.PointType = Pavr.Main.Base.PointType.Greater; 
            }
        }

        private void linerRight_BeforeSeriesCreation(object sender)
        {
            //pSeriesConfig = new Liner.Main.Grid.Args.SeriesConfig();
            //pSeriesConfig.LineColor = Color.Red;
            //pSeriesConfig.LineType = System.Drawing.Drawing2D.DashStyle.Solid;
            //pSeriesConfig.PointType = Pavr.Main.Base.PointType.O;
            linerRight.LineColor = Color.Red;
            if (radAereaDer.Checked)
            {
                linerRight.DashLineType = Pavr.Main.Base.DashLineType.Solid;
                linerRight.PointType = Pavr.Main.Base.PointType.O;
            }
            else
            {
                linerRight.DashLineType = Pavr.Main.Base.DashLineType.Solid;
                linerRight.PointType = Pavr.Main.Base.PointType.Lower;
            }
        }
    }
}
