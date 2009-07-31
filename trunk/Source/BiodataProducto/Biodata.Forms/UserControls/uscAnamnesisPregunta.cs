using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Mds.Biodata.Forms.UserControls
{
    public partial class uscAnamnesisPregunta : uscBase 
    {
        private Int32? _PreguntaID;

        public Int32? PreguntaID
        {
            get { return _PreguntaID; }
            set { _PreguntaID = value; }
        }

        public String Pregunta
        {
            get { return txtPregunta.Text; }
            set { txtPregunta.Text = value; }
        }

        public String Respuesta
        {
            get { return txtRespuesta.Text; }
            set { txtRespuesta.Text = value; }
        }

        public uscAnamnesisPregunta()
        {
            InitializeComponent();
        }
    }
}
