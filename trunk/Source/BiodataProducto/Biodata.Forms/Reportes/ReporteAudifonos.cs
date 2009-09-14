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
    public partial class ReporteAudifonos : ReporteBase
    {
        #region "--[Properties]--"
        private List<Audifono> _AudifonoEntities = new List<Audifono>();

        public List<Audifono> AudifonoEntities
        {
            get { return _AudifonoEntities; }
            set { _AudifonoEntities = value; }
        }

        private AudifonoBusiness _AudifonoBP;

        public AudifonoBusiness AudifonoBP
        {
            get { return _AudifonoBP; }
            set { _AudifonoBP = value; }
        }
        #endregion

        #region "--[Methods]--"
        public ReporteAudifonos()
        {
            InitializeComponent();
        }

        private void MostrarAudifonos()
        {
            try
            {
                Decimal? ValorPresionSalida = null;

                if (txtPresionSalidaBuscar.Text != "")
                {
                    if (GereralFunctions.ValidarNumero(txtPresionSalidaBuscar.Text))
                    {
                        ValorPresionSalida = Convert.ToDecimal(txtPresionSalidaBuscar.Text);
                    }
                    else
                    {
                        ProcesarAdvertencia(Translate("La presión de salida debe ser númerica"), "Dato no valido");
                        return;
                    }
                }

                Int32? ValorMarca = null;

                if (cmbMarcaBuscar.SelectedIndex != 0)
                {
                    MarcaAudifono oMarca = (MarcaAudifono)cmbMarcaBuscar.SelectedItem;
                    ValorMarca = oMarca.ID;
                }

                Int32? ValorTipo = null;
                if (cmbTipoBuscar.SelectedIndex != 0)
                {
                    ValorTipo = Convert.ToInt32(cmbTipoBuscar.SelectedItem);
                }
                AudifonoEntities = _AudifonoBP.GetAudifonosByParameters(txtNombreModeloBuscar.Text, ValorMarca, ValorTipo, ValorPresionSalida);

                //AudifonoBusiness wAudifinoBP = new AudifonoBusiness(DaoFactory.GetAudifonoDao());
                //this.AudifonoEntities = wAudifinoBP.GetAll();
                this.bscOrigenReporte.DataSource = this.AudifonoEntities;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {

                ProcesarExcepcion(ex);
            }
        }

        /// <summary>
        /// Carga los combos de Tipo de Audifono y Marca Audifono para busqueda
        /// </summary>
        private void LoadCombosBusqueda()
        {
            try
            {
                Array miTipoAudifono = Enum.GetValues(typeof(Enumeraciones.TipoAudifono));

                cmbTipoBuscar.Items.Add("--Sel--");

                for (Int32 i = 0; i < miTipoAudifono.Length; i++)
                {
                    cmbTipoBuscar.Items.Add(miTipoAudifono.GetValue(i));
                }

                cmbTipoBuscar.SelectedIndex = 0;

                MarcaAudifonoBusiness MarcaBP = new MarcaAudifonoBusiness(DaoFactory.GetMarcaAudifonoDao());
                List<MarcaAudifono> wMarcaEntitiesBuscar = MarcaBP.GetAll();
                cmbMarcaBuscar.ValueMember = "ID";
                cmbMarcaBuscar.DisplayMember = "Nombre";

                for (Int32 i = wMarcaEntitiesBuscar.Count - 1; i > -1; i--)
                {
                    cmbMarcaBuscar.Items.Insert(0, wMarcaEntitiesBuscar[i]);
                }

                cmbMarcaBuscar.Items.Insert(0, "--Sel--");

                cmbMarcaBuscar.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
        #endregion

        #region "--[Events]--"
        private void ReporteAudifonos_Load(object sender, EventArgs e)
        {
            _AudifonoBP = new AudifonoBusiness(DaoFactory.GetAudifonoDao());
            LoadCombosBusqueda();
            MostrarAudifonos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MostrarAudifonos();
        }
        #endregion
    }
}
