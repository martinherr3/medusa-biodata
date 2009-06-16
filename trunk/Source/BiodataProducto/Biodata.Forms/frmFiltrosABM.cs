using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mds.Biodata.Forms
{
    public partial class frmFiltrosABM : frmBase
    {
        public frmFiltrosABM()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Parent.Parent.Controls.Remove(this.Parent);
        }
    }
}
