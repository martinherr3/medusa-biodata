using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Architecture.Utils;
using Mds.Biodata.Business;
using Mds.Biodata.Domain;
using ObjectViews;
using System.Collections;

namespace Mds.Biodata.Forms
{
    public partial class frmAudifonos : frmABMBase
    {
        #region "--[Properties]--"
        private AudifonoBusiness _AudifonoBP;

        public AudifonoBusiness AudifonoBP
        {
            get { return _AudifonoBP; }
            set { _AudifonoBP = value; }
        }

        private List<Audifono> _AudifonoEntities = new List<Audifono>();

        public List<Audifono> AudifonoEntities
        {
            get { return _AudifonoEntities; }
            set { _AudifonoEntities = value; }
        }

        private Audifono _AudifonoEntity;

        public Audifono AudifonoEntity
        {
            get { return _AudifonoEntity; }
            set { _AudifonoEntity = value; }
        }

        private ObjectView _AudifonoObjectView;

        public ObjectView AudifonoObjectView
        {
            get { return _AudifonoObjectView; }
            set { _AudifonoObjectView = value; }
        }
        private BindingManagerBase _AudifonoCurrencyManager;

        public BindingManagerBase AudifonoCurrencyManager
        {
            get { return _AudifonoCurrencyManager; }
            set { _AudifonoCurrencyManager = value; }
        }

        #endregion

        public frmAudifonos()
        {
            InitializeComponent();
        }

        private void frmAudifonos_Load(object sender, EventArgs e)
        {
            _AudifonoBP = new AudifonoBusiness(DaoFactory.GetAudifonoDao());
            LoadCombos();
            //LoadList();
        }

        private void InitializeObjectView()
        {
            this.AudifonoObjectView = new ObjectView(typeof(Audifono));
            this.AudifonoObjectView.AllowRemove = false;
            this.AudifonoObjectView.Columns.Add("NombreModelo", Translate("Nombre"));
            this.AudifonoObjectView.Columns.Add("Marca", Translate("Marca"));
            this.AudifonoObjectView.Columns.Add("Tipo", Translate("Tipo"));

            this.AudifonoCurrencyManager = this.dgvList.BindingContext[this.AudifonoObjectView];
        }

        /// <summary>
        /// Carga el combo de Provincia
        /// </summary>
        private void LoadCombos()
        {
            //Marca Audifonos
            MarcaAudifonoBusiness MarcaBP = new MarcaAudifonoBusiness(DaoFactory.GetMarcaAudifonoDao());
            List<MarcaAudifono> wMarcaEntities = MarcaBP.GetAll();
            cmbMarca.DataSource = wMarcaEntities;

            cmbMarca.ValueMember = "ID";
            cmbMarca.DisplayMember = "Nombre";

            //Tipo de Documento
            cmbTipoAudifono.DataSource = Enum.GetValues(typeof(Enumeraciones.TipoAudifono));
        }


        public override void Accion()
        {
            try
            {
                pnlDetails.Visible = true;

                switch (Estado)
                {
                    case EstadoForm.Nuevo:
                        textBox1.Text = string.Empty;
                        textBox1.Enabled = false;
                        //txtNombre.Text = string.Empty;
                        //txtApellido.Text = string.Empty;
                        //txtDireccion.Text = string.Empty;
                        //cmbTipoDocumento.SelectedItem = Enumeraciones.TipoDocumento.DNI;
                        //txtNumeroDocumento.Text = string.Empty;
                        //txtCorreoElectronico.Text = string.Empty;
                        //dtpFechaNacimiento.Value = DateTime.Now;
                        //cmbSexo.SelectedItem = Enumeraciones.Sexo.M;
                        //txtComentario.Text = string.Empty;
                        //txtTelefono.Text = string.Empty;
                        //txtCelular.Text = string.Empty;
                        //txtCiudad.Tag = string.Empty;
                        //txtCiudad.Text = string.Empty;
                        ////Limpieza de los controles de Historia Clinica
                        ///////////////////////////////////////////////////////////////////
                        //dtpInicioAtencion.Value = DateTime.Now;
                        //txtObservaciones.Text = string.Empty;
                        //txtAntecedentesHereditarios.Text = string.Empty;
                        //txtAntecedentesPersonales.Text = string.Empty;
                        //txtEstadoSalud.Text = string.Empty;
                        ///////////////////////////////////////////////////////////////////
                        ////Limpieza de la grilla de obras sociales
                        ///////////////////////////////////////////////////////////////////
                        //dgvObrasSociales.DataSource = null;
                        ///////////////////////////////////////////////////////////////////
                        textBox2.Focus();
                        //PacienteEntity = new Paciente();

                        break;

                    case EstadoForm.Editar:
                        //if (dgvList.Rows.Count > 0)
                        //{
                        //    txtID.Enabled = false;
                        //    LoadData();
                        //    txtNombre.Focus();
                        //}

                        break;

                    case EstadoForm.Eliminar:
                        //if (dgvList.Rows.Count > 0)
                        //{
                        //    txtID.Enabled = false;
                        //    LoadData();
                        //}

                        break;
                }
            }

            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

    }
}
