using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Domain;
using Mds.Biodata.Business;

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
            AnamnesisListadoPreguntaBusiness oListadoPreguntas = new AnamnesisListadoPreguntaBusiness(DaoFactory.GetAnamnesisListadoPreguntaDao());

            List<AnamnesisListadoPregunta> wListadoPreguntas = oListadoPreguntas.GetAll();

            foreach (AnamnesisListadoPregunta myPregunta in wListadoPreguntas)
            {
                uscAnamnesisPregunta PreguntaControl = new uscAnamnesisPregunta();
                PreguntaControl.Pregunta = myPregunta.Pregunta;
                PreguntaControl.Dock = DockStyle.Top;
                pnlPreguntasRespuestas.Controls.Add(PreguntaControl);
            }

            //PreguntasAnamnesis wPreguntas = new PreguntasAnamnesis();

            //foreach (String myPregunta in wPreguntas.Preguntas)
            //{
            //    uscAnamnesisPregunta PreguntaControl = new uscAnamnesisPregunta();
            //    PreguntaControl.Pregunta = myPregunta;
            //    PreguntaControl.Dock = DockStyle.Top;
            //    pnlPreguntasRespuestas.Controls.Add(PreguntaControl); 
            //}
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
                ContenidoPregunta.IDEstudioLookup = (Anamnesi)wAnamnesis;
                if (ControlPregunta.PreguntaID != null)
                {
                    ContenidoPregunta.ID = ControlPregunta.PreguntaID.Value;
                }
                wAnamnesis.AnamnesisPreguntases.Add(ContenidoPregunta);
            }

            if (this.EstudioActualID != null)
            {
                wAnamnesis.ID = this.EstudioActualID.Value;
            }
            return (Estudio)wAnamnesis;
        }

        public override void CargarDatosEstudio(Estudio pEstudio)
        {
            //base.CargarDatosEstudio(pEstudio);
            Anamnesi wAnamnesis = (Anamnesi)pEstudio;

            foreach (AnamnesisPregunta PreguntaRespuesta in wAnamnesis.AnamnesisPreguntases)
            {
                uscAnamnesisPregunta PreguntaControl = new uscAnamnesisPregunta();
                PreguntaControl.Pregunta = PreguntaRespuesta.Pregunta;
                PreguntaControl.Respuesta = PreguntaRespuesta.Respuesta;
                PreguntaControl.PreguntaID = PreguntaRespuesta.ID;
                PreguntaControl.Dock = DockStyle.Top;
                pnlPreguntasRespuestas.Controls.Add(PreguntaControl);

            }

            this.EstudioActualID = pEstudio.ID;
        }
        #endregion

        #region "--[Events]--"
        private void uscAnamnesis_Load(object sender, EventArgs e)
        {
            
            //CargarPreguntas();
        }
        #endregion
    }
}
