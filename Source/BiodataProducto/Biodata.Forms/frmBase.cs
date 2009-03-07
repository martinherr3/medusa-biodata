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

    }
}