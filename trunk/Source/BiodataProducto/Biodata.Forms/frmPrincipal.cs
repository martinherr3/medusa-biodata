using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mds.Biodata.Forms
{
    public partial class frmPrincipal : frmBase
    {
        #region "--[Properties]--"
        #endregion

        #region "--[Methods]--"
        public frmPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region "--[Events]--"
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            GereralFunctions.Principal = this;
        }
        #endregion

        #region "--[Llamadas a Ventanas de la aplicación--"
        
        #region "--[Paciente]--"
        private void tsmGestionPaciente_Click(object sender, EventArgs e)
        {
            OpenPaciente();
        }

        private void tsmGestionCiudad_Click(object sender, EventArgs e)
        {
            OpenCiudad();
        }

        private void tsmGestionObraSocial_Click(object sender, EventArgs e)
        {
            OpenObraSocial();
        }

        private void tsmSeleccionAudifono_Click(object sender, EventArgs e)
        {

        }

        private void OpenPaciente()
        {
            try
            {
                GereralFunctions.AbrirFormulario(new frmPaciente(), (TabControl)this.spcRight.Panel2.Controls[0], "Gestión de Pacientes", DockStyle.Fill);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void OpenCiudad()
        {
            try
            {
                GereralFunctions.AbrirFormulario(new frmCiudad(), (TabControl)this.spcRight.Panel2.Controls[0], "Gestión de Ciudades", DockStyle.Fill);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void OpenObraSocial()
        {
            try
            {
                GereralFunctions.AbrirFormulario(new frmObraSocial(), (TabControl)this.spcRight.Panel2.Controls[0], "Gestión de Obras Sociales", DockStyle.Fill);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
        #endregion

        #region "--[Estudio]--"
        private void tsmNuevoEstudio_Click(object sender, EventArgs e)
        {
            OpenEstudio();
        }

        private void tsmConsultarEstudio_Click(object sender, EventArgs e)
        {

        }

        private void OpenEstudio()
        {
            try
            {
                GereralFunctions.AbrirFormulario(new frmEstudio(), (TabControl)this.spcRight.Panel2.Controls[0], "Gestión de Estudios", DockStyle.Fill);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
        #endregion

        #region "--[Audifono]--"
        private void tsmGestionAudifono_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region "--[Agenda]--"
        private void tsmRecordatorio_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region "--[Reportes]--"
        private void tsmInformeFichaPaciente_Click(object sender, EventArgs e)
        {

        }

        private void tsmReportePaciente_Click(object sender, EventArgs e)
        {
            OpenReportePaciente();
        }

        private void tsmReporteAudifono_Click(object sender, EventArgs e)
        {

        }

        private void tsmReporteObraSocial_Click(object sender, EventArgs e)
        {

        }

        private void tsmReporteEstudiosPaciente_Click(object sender, EventArgs e)
        {

        }

        private void tsmReporteRecordatorio_Click(object sender, EventArgs e)
        {

        }

        private void tsmReportePacientesPorAudifono_Click(object sender, EventArgs e)
        {

        }

        private void tsmReporteAudifonosPorPaciente_Click(object sender, EventArgs e)
        {

        }

        private void OpenReportePaciente()
        {
            try
            {
                GereralFunctions.AbrirFormulario(new Reportes.ReportePacientes(), (TabControl)this.spcRight.Panel2.Controls[0], "Reporte de Pacientes", DockStyle.Fill);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
        #endregion

        #region "--[Herramientas y Seguridad]--"
        private void tsmGestionParametrosSistema_Click(object sender, EventArgs e)
        {

        }

        private void tsmCambioPasswordUsuario_Click(object sender, EventArgs e)
        {

        }

        private void tsmBackUpBaseDatos_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region "--[Ayuda]--"
        private void tsmManualAyuda_Click(object sender, EventArgs e)
        {

        }

        private void tsmAcercaDe_Click(object sender, EventArgs e)
        {

        }

        private void tsmSalir_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion
    }
}
