using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mds.Biodata.Forms
{
    public partial class frmStartForm : frmBase
    {
        public frmStartForm()
        {
            InitializeComponent();
        }

        private void frmStartForm_Load(object sender, EventArgs e)
        {
            flaPresentacion.Movie = Application.StartupPath + "\\Imagenes\\Biodata.swf";
        }
    }
}
