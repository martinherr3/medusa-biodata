using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Domain;
using Mds.Biodata.Business;

namespace Mds.Biodata.Forms.Reportes
{
    public partial class ReportePacientes : ReporteBase 
    {
        #region "--[Properties]--"
        private List<Paciente> _PacienteEntities = new List<Paciente>();

        public List<Paciente> PacienteEntities
        {
            get { return _PacienteEntities; }
            set { _PacienteEntities = value; }
        }

        private PacienteBusiness _PacienteBP;

        public PacienteBusiness PacienteBP
        {
            get { return _PacienteBP; }
            set { _PacienteBP = value; }
        }
        #endregion

        #region "--[Methods]--"
        public ReportePacientes()
        {
            InitializeComponent();
        }

        private void MostrarPacientes()
        {
            try
            {
                Decimal? ValorNumeroDocumento = null;

                if (txtDocumentoBuscar.Text != "")
                {
                    if (GereralFunctions.ValidarNumero(txtDocumentoBuscar.Text))
                    {
                        ValorNumeroDocumento = Convert.ToDecimal(txtDocumentoBuscar.Text);
                    }
                    else
                    {
                        ProcesarAdvertencia(Translate("El documento debe ser númerico"), "Dato no valido");
                        return;
                    }
                }

                Int32? ValorCiudad = null;

                if (cmbCiudadBuscar.SelectedIndex != 0)
                {
                    Ciudad oCiudad = (Ciudad)cmbCiudadBuscar.SelectedItem;
                    ValorCiudad = oCiudad.ID;
                }


                String strSexo = "";
                if (cmbSexoBuscar.SelectedIndex != 0)
                {
                    strSexo = cmbSexoBuscar.SelectedItem.ToString();
                }
                PacienteEntities = PacienteBP.GetPacientesByParameters(txtNombreBuscar.Text, txtApellidoBuscar.Text, ValorNumeroDocumento, strSexo, ValorCiudad);
                
                
                this.bscOrigenReporte.DataSource = this.PacienteEntities;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                ProcesarExcepcion(ex);
            }
        }

        /// <summary>
        /// Carga los combos de Tipo de Documento y Sexo para busqueda
        /// </summary>
        private void LoadCombosBusqueda()
        {
            try
            {
                Array miSexo = Enum.GetValues(typeof(Enumeraciones.Sexo));

                cmbSexoBuscar.Items.Add("--Sel--");

                for (Int32 i = 0; i < miSexo.Length; i++)
                {
                    cmbSexoBuscar.Items.Add(miSexo.GetValue(i));
                }

                cmbSexoBuscar.SelectedIndex = 0;

                CiudadBusiness CiudadBP = new CiudadBusiness(DaoFactory.GetCiudadDao());
                List<Ciudad> wCiudadEntitiesBuscar = CiudadBP.GetAll();
                //cmbCiudadBuscar.DataSource = wCiudadEntitiesBuscar;
                cmbCiudadBuscar.ValueMember = "ID";
                cmbCiudadBuscar.DisplayMember = "Descripcion";

                for (Int32 i = wCiudadEntitiesBuscar.Count - 1; i > -1; i--)
                {
                    cmbCiudadBuscar.Items.Insert(0, wCiudadEntitiesBuscar[i]);
                }

                cmbCiudadBuscar.Items.Insert(0, "--Sel--");

                cmbCiudadBuscar.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
        #endregion

        #region "--[Events]--"
        private void ReportePacientes_Load(object sender, EventArgs e)
        {
            _PacienteBP = new PacienteBusiness(DaoFactory.GetPacienteDao());
            LoadCombosBusqueda();
            MostrarPacientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarPacientes();
        }
        #endregion

        
    }
}
