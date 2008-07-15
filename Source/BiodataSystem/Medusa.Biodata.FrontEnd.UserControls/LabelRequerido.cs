using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medusa.Biodata.FrontEnd.UserControls
{
    public partial class LabelRequerido : UserControl
    {
        public LabelRequerido()
        {
            InitializeComponent();
        }

        public override System.Drawing.Font Font
        {
            get { return Fuente; }
            set { Fuente = value; }
        }


        private System.Drawing.Font _font = System.Windows.Forms.Control.DefaultFont;

        public System.Drawing.Font Fuente
        {
            get { return _font; }
            set
            {
                _font = value;
                lblTitulo.Font = Fuente;
                Font wF = new Font(Fuente, FontStyle.Bold);
                lblAsterisco.Font = wF;
            }
        }

        private bool _Requerido = false;
        public bool Requerido
        {
            get { return _Requerido; }
            set
            {
                _Requerido = value;
                lblAsterisco.Visible = Requerido;
            }
        }

        private string _text = "Título";

        public string texto
        {
            get { return _text; }
            set
            {
                _text = value;
                lblTitulo.Text = texto;
                lblAsterisco.Left = lblTitulo.Width + Separacion - 5;
                Width = lblTitulo.Width + Separacion + lblAsterisco.Width - 5;
                Height = lblTitulo.Height;
            }
        }

        public override string Text
        {
            get { return texto; }
            set { texto = value; }
        }


        private Int32 _separacion = 1;

        public Int32 Separacion
        {
            get { return _separacion; }
            set { _separacion = value; }
        }

    } 

}
