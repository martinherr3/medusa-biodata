using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace Mds.Biodata.Forms
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            

            log4net.Config.XmlConfigurator.Configure();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Init());
        }

        public static void Close()
        {
            Application.Exit();
        }
    }
}
