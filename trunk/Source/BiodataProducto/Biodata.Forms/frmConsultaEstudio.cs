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
    public partial class frmConsultaEstudio : frmFiltrosABM
    {
        #region "--[Properties]--"
        private EstudioBusiness _EstudioBP;

        public EstudioBusiness EstudioBP
        {
            get { return _EstudioBP; }
            set { _EstudioBP = value; }
        }

        private List<Estudio> _EstudioEntities = new List<Estudio>();

        public List<Estudio> EstudioEntities
        {
            get { return _EstudioEntities; }
            set { _EstudioEntities = value; }
        }

        private Estudio _EstudioEntity;

        public Estudio EstudioEntity
        {
            get { return _EstudioEntity; }
            set { _EstudioEntity = value; }
        }

        private ObjectView _EstudioObjectView;

        public ObjectView EstudioObjectView
        {
            get { return _EstudioObjectView; }
            set { _EstudioObjectView = value; }
        }
        private BindingManagerBase _EstudioCurrencyManager;

        public BindingManagerBase EstudioCurrencyManager
        {
            get { return _EstudioCurrencyManager; }
            set { _EstudioCurrencyManager = value; }
        }
        #endregion

        #region "--[Methods]--"
        public frmConsultaEstudio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Da formato a la grilla y crea lo necesario para el bindeo
        /// </summary>
        private void InitializeObjectView()
        {
            this.EstudioObjectView = new ObjectView(typeof(Estudio));
            this.EstudioObjectView.AllowRemove = false;
            this.EstudioObjectView.Columns.Add("ID", "ID");
            this.EstudioObjectView.Columns.Add("Nombre", "Nombre");
            this.EstudioObjectView.Columns.Add("FechaEstudio", "Fecha de Estudio");
            //this.EstudioObjectView.Columns.Add("TipoEstudio", "Tipo de Estudio");
            this.EstudioObjectView.Columns.Add("TipoEstudioValue", "Tipo de Estudio");
            this.EstudioObjectView.Columns.Add("IDHistoriaClinicaLookup.IDPacienteLookup.ApellidoNombre", "Paciente");
            this.EstudioCurrencyManager = this.dgvConsultas.BindingContext[this.EstudioObjectView];
        }

        /// <summary>
        /// Carga la grilla con los registros de la DB
        /// </summary>
        private void LoadList(Boolean ContarParametrosBusqueda)
        {
            try
            {
                ptbProgress.Visible = true;
                InitializeObjectView();
                dgvConsultas.DataSource = null;
                //Habilitar(false);
                btnCerrar.Enabled = true;
                bgwLoad.RunWorkerAsync(ContarParametrosBusqueda);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        /// <summary>
        /// Carga los tipos de estudios para la seleccion
        /// </summary>
        private void LoadTipoEstudios()
        {
            Array miTipos = Enum.GetValues(typeof(Enumeraciones.TipoEstudio));

            cmbTipoEstudio.Items.Add("--Seleccione Item--");

            for (Int32 i = 0; i < miTipos.Length; i++)
            {
                cmbTipoEstudio.Items.Add(miTipos.GetValue(i));
            }

            cmbTipoEstudio.SelectedIndex = 0;
        }

        /// <summary>
        /// Permite modificar un estudio cargando los controles necesarios según el tipo de estudio
        /// </summary>
        private void ModificarEstudio()
        {

            frmEstudio frm = new frmEstudio();
            frm.Estado = EstadoForm.Editar;

            ObjectViews.ObjectViewRow RowSelected = (ObjectViewRow)dgvConsultas.CurrentRow.DataBoundItem;
            frm.EstudioActualID = ((Estudio)RowSelected.InnerObject).ID;

            GereralFunctions.AbrirFormulario(frm, (TabControl)this.Parent.Parent, "Gestion de Estudio", DockStyle.Fill, false, true);
        }

        /// <summary>
        /// Abre el formulario para crear un nuevo estudio
        /// </summary>
        private void NuevoEstudio()
        {
            try
            {
                frmEstudio frm = new frmEstudio();
                frm.Estado = EstadoForm.Nuevo;
                //frm.Llamador = this;
                //this.Parent.Enabled = false;
                GereralFunctions.AbrirFormulario(frm, (TabControl)this.Parent.Parent, "Gestión de Estudios", DockStyle.Fill, false, true);

            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
        #endregion

        #region "--[Events]--"
        private void frmConsultaEstudio_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            _EstudioBP = new EstudioBusiness(DaoFactory.GetEstudioDao());
            //LoadList(false);
            LoadTipoEstudios();
        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!Convert.ToBoolean(e.Argument))
            {
                _EstudioEntities = _EstudioBP.GetAll();
            }
            else
            {
                Int32? ValorTipoEstudio = null;

                if (cmbTipoEstudio.SelectedIndex != 0)
                {
                    ValorTipoEstudio = Convert.ToInt32((Enumeraciones.TipoEstudio)cmbTipoEstudio.SelectedItem);
                }

                _EstudioEntities = _EstudioBP.GetEstudiosNombre(txtNombre.Text, dtpFechaEstudioDesde.Value, dtpFechaEstudioHasta.Value, ValorTipoEstudio);

            }
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //dgvList.DataSource = _PacienteEntities;
            this.EstudioObjectView.DataSource = (IList)this._EstudioEntities;
            this.dgvConsultas.DataSource = this.EstudioObjectView;
            ptbProgress.Visible = false;
            //Habilitar(true);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            LoadList(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ModificarEstudio();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NuevoEstudio();
        }
        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EliminarEstudio();
        }

        private void EliminarEstudio()
        {
            if (ProcesarMensaje("Esta seguro que desea eliminar el estudio seleccionado", "Eliminación de estudio", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ObjectViews.ObjectViewRow RowSelected = (ObjectViewRow)dgvConsultas.CurrentRow.DataBoundItem;
                Estudio pEntity = (Estudio)RowSelected.InnerObject;
                _EstudioBP.Delete(pEntity);
                _EstudioBP.Commit();

                LoadList(true);
            }
        }

    }
}
