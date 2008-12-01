using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Medusa.Biodata.FrontEnd.UserControls
{
    public partial class ButtonUC : UserControl
    {
        public delegate void ClickEventHandler(object sender, System.EventArgs e);
        [Category("Action")]
        [Description("Fires when the Submit button is clicked.")]
        public new event ClickEventHandler Click;

        public ButtonUC()
        {
            InitializeComponent();
        }

        private string _texto;
        public string Texto
        {
            get { return _texto; }
            set
            {
                _texto = value;
                btn.Text = Texto;
            }
        }

        public override string Text
        {
            get { return Texto; }
            set { Texto = value; }
        }

        public Image Image
        {
            get { return btn.Image; }
            set { btn.Image = value; }
        }

        public ContentAlignment ImageAlign
        {
            get { return btn.ImageAlign; }
            set { btn.ImageAlign = value; }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (Click != null)
            {
                Click(sender, e);
            }
        }

    }
}
