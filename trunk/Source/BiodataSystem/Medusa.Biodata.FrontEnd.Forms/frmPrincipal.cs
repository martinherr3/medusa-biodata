using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Medusa.Biodata.FrontEnd.Forms
{
    public partial class frmPrincipal : frmBase 
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void tiposDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDocumentType();
        }

        private void OpenDocumentType()
        {
            try
            {
                GereralFunctions.AbrirFormulario(new frmDocumentTypeABM(), (TabControl)this.spcRight.Panel2.Controls[0], "Tipos de Documentos", DockStyle.Fill); 
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void gestionDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPatients();
        }

        private void OpenPatients()
        {
            try
            {
                GereralFunctions.AbrirFormulario(new frmPatientABM(), (TabControl)this.spcRight.Panel2.Controls[0], "Gestion de Pacientes", DockStyle.Fill);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void formularioPersonalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormulariosPers();
        }

        private void OpenFormulariosPers()
        {
            try
            {
                GereralFunctions.AbrirFormulario(new frmPersonalizedForm(), (TabControl)this.spcRight.Panel2.Controls[0], "Tipos de Documentos", DockStyle.Fill);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void gestionDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenProducts();
        }

        private void OpenProducts()
        {
            try
            {
                GereralFunctions.AbrirFormulario(new frmProductABM(), (TabControl)this.spcRight.Panel2.Controls[0], "Gestion de Productos", DockStyle.Fill);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void tiposDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenProductTypes();
        }

        private void OpenProductTypes()
        {
            try
            {
                GereralFunctions.AbrirFormulario(new frmProductTypeABM(), (TabControl)this.spcRight.Panel2.Controls[0], "Gestion de Tipos de Productos", DockStyle.Fill);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
    }
}
