using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Architecture.Utils;
using System.Text.RegularExpressions;

namespace Mds.Biodata.Forms
{
    public partial class frmBase : Form
    {
        private System.Resources.ResourceManager mdsRM;

        public frmBase()
        {
            mdsRM = new System.Resources.ResourceManager(this.GetType());
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

        /// <summary>
        /// Traduce el mensaje, en caso de encontrar su significado, segun el idioma seleccionado
        /// </summary>
        /// <param name="pMessage"></param>
        /// <returns></returns>
        protected String Translate(String pMessage)
        {
            if (mdsRM.GetString(pMessage) == "" || mdsRM.GetString(pMessage) == null)
            {
                return pMessage;
            }
            else
            {
                return mdsRM.GetString(pMessage);
            }
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
            return MessageBox.Show(Translate(message), Translate(Title), Buttons);
        }

        protected void ProcesarMensaje(String message, String Title)
        {
            //System.Resources.ResourceManager mdsRM = new System.Resources.ResourceManager(this.GetType());

            MessageBox.Show(Translate(message), Translate(Title));
        }

        protected void ProcesarAdvertencia(String message)
        {
            ProcesarAdvertencia(message, "Mensaje");
        }

        protected void ProcesarAdvertencia(String message, String Title)
        {
            MessageBox.Show(Translate(message), Translate(Title));
        }

        public Boolean ValidarNumero(String NumeroaValidar)
        {
            String Patron = "^[0-9]+$";
            Regex ExpresionRegular = new Regex(Patron);
            return ExpresionRegular.IsMatch(NumeroaValidar);
        }

    }
}