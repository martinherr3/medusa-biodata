using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Castle.Windsor;
using log4net.Config;
using Medusa.Biodata.Util.Forms;

namespace Medusa.Biodata.Util
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize log4net
            XmlConfigurator.Configure();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PacienteForm());
        }
    }
}
