using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Architecture.Utils;

namespace Mds.Biodata.Forms
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            System.Globalization.CultureInfo.CurrentCulture.ClearCachedData();
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(System.Globalization.CultureInfo.CurrentCulture.Name.Substring(0, 2));
            InitializeComponent();
        }

        /// <summary>
        /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
        /// </summary>
        public IDaoFactory DaoFactory
        {
            get
            {
                return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
            }
        }

        public enum EstadoForm
        {
            Nuevo,
            Eliminar,
            Editar,
            Ver,
            Grilla
        }
        private Form _principal;
        public Form Principal
        {

            get { return _principal; }
            set { _principal = value; }
        }

        protected void ProcesarExcepcion(Exception ex)
        {
            ProcesarExcepcion(ex, MessageBoxIcon.Information);
        }

        protected void ProcesarExcepcion(Exception ex, MessageBoxIcon pIcon)
        {
            MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, pIcon);
        }

        protected void ProcesarMensaje(String message)
        {
            ProcesarMensaje(message, "Mensaje");
        }

        protected DialogResult ProcesarMensaje(String message, String Title, MessageBoxButtons Buttons)
        {
            return MessageBox.Show(message, Title, Buttons);
        }

        protected void ProcesarMensaje(String message, String Title)
        {
            System.Resources.ResourceManager mdsRM = new System.Resources.ResourceManager(this.GetType());
            
            MessageBox.Show(message, Title);
        }

        protected void ProcesarAdvertencia(String message)
        {
            ProcesarAdvertencia(message, "Mensaje");
        }

        protected void ProcesarAdvertencia(String message, String Title)
        {
            MessageBox.Show(message, Title);
        }
    }
}