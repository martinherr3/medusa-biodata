using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Utils;

namespace Medusa.Biodata.FrontEnd.Forms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        public enum EstadoForm
        {
            NUEVO,
            ELIMINAR,
            EDITAR,
            VER,
            GRILLA
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

        /// <summary>
        /// Exposes accessor for the <see cref="IDaoFactory" /> used by all forms.
        /// </summary>
        public IDaoFactory DaoFactory
        {
            get
            {
                return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
            }
        }

    }
}