using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mds.Biodata.Forms
{
    public partial class frmSplash : frmBase
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            tmr.Start();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            frmLogin frmLogueo = new frmLogin();

            frmLogueo.Show();

            tmr.Stop();

            this.Close();
        }
    }
}
