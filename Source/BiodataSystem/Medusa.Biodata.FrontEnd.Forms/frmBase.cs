using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Medusa.Biodata.FrontEnd.Forms
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
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