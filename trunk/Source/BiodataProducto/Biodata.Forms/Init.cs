using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mds.Biodata.Forms
{
    public class Init: System.Windows.Forms.ApplicationContext
    {
        public Init()
        {
            frmSplash frm = new frmSplash();
            frm.Show();
        }
    }
}
