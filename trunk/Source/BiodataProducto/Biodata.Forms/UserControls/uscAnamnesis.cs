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
                uscAnamnesisPregunta PreguntaControl = new uscAnamnesisPregunta();
                PreguntaControl.Pregunta = myPregunta;
                PreguntaControl.Dock = DockStyle.Top;
                pnlPreguntasRespuestas.Controls.Add(PreguntaControl); 
            }
        }

        public override Estudio ObtenerDatosEstudio()
        {
            Anamnesi wAnamnesis = new Anamnesi();

            foreach (uscAnamnesisPregunta ControlPregunta in pnlPreguntasRespuestas.Controls)
            {
                AnamnesisPregunta ContenidoPregunta = new AnamnesisPregunta();
                ContenidoPregunta.Pregunta = ControlPregunta.Pregunta;
                ContenidoPregunta.Respuesta = ControlPregunta.Respuesta;
                //ContenidoPregunta.IDEstudio = 13;
                
                //ContenidoPregunta.IDEstudioLookup = (Estudio)wAnamnesis;

                wAnamnesis.AnamnesisPreguntases.Add(ContenidoPregunta);
            }
            
            return (Estudio)wAnamnesis;
        }
        #endregion

        #region "--[Events]--"
        private void uscAnamnesis_Load(object sender, EventArgs e)
        {
            CargarPreguntas();
        }
        #endregion
    }
}
