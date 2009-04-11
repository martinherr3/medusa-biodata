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
    public partial class uscBase : UserControl
    {
        public uscBase()
        {
            InitializeComponent();
        }

        public virtual Estudio ObtenerDatosEstudio()
        {
            return null;
        }
    }
}
