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
