using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Medusa.Biodata.FrontEnd.UserControls
{
    public partial class GridView : DataGridView
    {
        public GridView()
        {
            InitializeComponent();
        }

        public GridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
