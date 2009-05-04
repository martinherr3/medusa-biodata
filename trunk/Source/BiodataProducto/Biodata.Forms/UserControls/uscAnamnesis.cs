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
    public partial class uscAnamnesis : uscBase
    {
       
        #region "--[Properties]--"

        #endregion

        #region "--[Methods]--"
        public uscAnamnesis()
        {
            InitializeComponent();
        }

        public void CargarPreguntas()
        {
            PreguntasAnamnesis wPreguntas = new PreguntasAnamnesis();

            foreach (String myPregunta in wPreguntas.Preguntas)
            {

            }
        }

        public override Estudio ObtenerDatosEstudio()
        {
            Anamnesi wAnamnesis = new Anamnesi();

            //List<Liner.Main.Grid.Args.Line> wLineasEstudio = linerCentral.GenerateLinePointsArgs();

            //String strLineasEstudio = Mds.Architecture.HelpersFunctions.SerializationFunctions.Serialize(wLineasEstudio);

            //wTimpanometria.TimpanometriaGrafico = strLineasEstudio;
            return (Estudio)wAnamnesis;
        }
        #endregion

        #region "--[Events]--"
        private void uscAnamnesis_Load(object sender, EventArgs e)
        {
            //linerCentral.XInterval = "-400, 200, 100 , +";
            //linerCentral.YInterval = "0, 4, 0,5 , +";
        }
        #endregion
    }
}
