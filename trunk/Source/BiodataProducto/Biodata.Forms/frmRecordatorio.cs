using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mds.Architecture.Utils;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Business;
using Mds.Biodata.Domain;
using ObjectViews;
using System.Collections;

namespace Mds.Biodata.Forms
{
    public partial class frmRecordatorio : frmABMBase
    {
        #region "--[Properties]--"
        
        private RecordatorioBusiness _RecordatorioBP;

        public RecordatorioBusiness RecordatorioBP
        {
            get { return _RecordatorioBP; }
            set { _RecordatorioBP = value; }
        }

        private List<Recordatorio> _RecordatorioEntities = new List<Recordatorio>();

        public List<Recordatorio> RecordatorioEntities
        {
            get {return(_RecordatorioEntities);}
            set {_RecordatorioEntities= value;}
        }

        private Recordatorio _RecordatorioEntity;

        public Recordatorio RecordatorioEntity
        {
            get {return(_RecordatorioEntity);}
            set {_RecordatorioEntity = value;}
        }

        private ObjectView _RecordatorioObjectView;

        public ObjectView RecordatorioObjectView
        {
            get { return _RecordatorioObjectView; }
            set { _RecordatorioObjectView = value; }
        }
        private BindingManagerBase _RecordatorioCurrencyManager;

        public BindingManagerBase RecordatorioCurrencyManager
        {
            get { return _RecordatorioCurrencyManager; }
            set { _RecordatorioCurrencyManager = value; }
        }


        #endregion


        #region "--[Methods]--"

        public frmRecordatorio()
        {
            InitializeComponent();
        }

        ///// <summary>
        ///// Da formato a la grilla.
        ///// </summary>
        //private void BuildColumns()
        //{
        //    try
        //    {
        //        dgvList.AutoGenerateColumns = false;
        //        dgvList.Columns.Clear();
        //        dgvList.Columns.Add("IDRecordatorio", "IDRecordatorio");
        //        dgvList.Columns[0].DataPropertyName= "IDRecordatorio";
        //        dgvList.Columns.Add("Descripcion", "Descripcion");
        //        dgvList.Columns[1].DataPropertyName ="Descripcion";
        //        dgvList.Columns.Add("FechaRecordatorio", "FechaRecordatorio");
        //        dgvList.Columns[2].DataPropertyName= "FechaRecordatorio";
        //        dgvList.Columns.Add("IDVinculado", "IDVinculado");
        //        dgvList.Columns[3].DataPropertyName= "IDVinculado";
        //        dgvList.Columns[3].Visible= false;
        //        dgvList.Columns.Add("TipoVinculado", "TipoVinculado");
        //        dgvList.Columns[4].DataPropertyName= "TipoVinculado";


        //    }
        //    catch(Exception e)
        //    {
        //        ProcesarExcepcion(e);
        //    }

        //}

        private void InitializeObjectView()
        {
            this.RecordatorioObjectView = new ObjectView(typeof(Recordatorio));
            this.RecordatorioObjectView.AllowRemove = false;
            this.RecordatorioObjectView.Columns.Add("ID", "ID Recordatorio");
            this.RecordatorioObjectView.Columns.Add("Descripcion", "Descripcion");
            this.RecordatorioObjectView.Columns.Add("FechaRecordatorio", "Fecha Recordatorio");
            this.RecordatorioObjectView.Columns.Add("TipoVinculadoString", "TipoVinculado");
            this.RecordatorioCurrencyManager = this.dgvList.BindingContext[this.RecordatorioObjectView];
        }

        
        /// <summary>
        /// Carga la grilla con los registros de la DB
        /// </summary>
        private void LoadList()
        {
            try
            {
                ptbProgress.Visible = true;
                //BuildColumns();
                InitializeObjectView();
                dgvList.DataSource = null;
                Habilitar(false);
                btnClose.Enabled = true;
                bgwLoad.RunWorkerAsync();
            }
            catch(Exception e)
            {
                ProcesarExcepcion(e);
            } 
        }

        private void LoadData()
        {
            ObjectViews.ObjectViewRow RowSelected = (ObjectViewRow)dgvList.CurrentRow.DataBoundItem;
            RecordatorioEntity = RecordatorioBP.GetById(((Recordatorio)RowSelected.InnerObject).ID);

            //RecordatorioEntity = RecordatorioBP.GetById(((Recordatorio)dgvList.CurrentRow.DataBoundItem).ID);

            txtIDRecordatorio.Text = RecordatorioEntity.ID.ToString();
            txtDescripcion.Text = RecordatorioEntity.Descripcion.ToString();
            dtpFechaRecordatorio.Value = (DateTime)RecordatorioEntity.FechaRecordatorio;
            txtIDVinculado.Text= RecordatorioEntity.IDVinculado.ToString();
            cmbTipoVinculado.SelectedItem = (Enumeraciones.TipoRecordatorioVinculado)RecordatorioEntity.TipoVinculado;
            //txtTipoVinculado.Text= RecordatorioEntity.TipoVinculado.ToString();

        }


        /// <summary>
        /// Carga los combos de Tipo Vinculado del recordatorio
        /// </summary>
        private void LoadCombos()
        {
            //Tipo Vinculado
            cmbTipoVinculado.DataSource = Enum.GetValues(typeof(Enumeraciones.TipoRecordatorioVinculado));
            ////Sexo
            //cmbSexo.DataSource = Enum.GetValues(typeof(Enumeraciones.Sexo));
            ////Ciudad
            //CiudadBusiness CiudadBP = new CiudadBusiness(DaoFactory.GetCiudadDao());
            //List<Ciudad> wCiudadEntities = CiudadBP.GetAll();
            //cmbCiudad.DataSource = wCiudadEntities;

            //cmbCiudad.ValueMember = "ID";
            //cmbCiudad.DisplayMember = "Descripcion";

        }




        /// <summary>
        /// Valida datos basicos antes de enviar la entidad
        /// </summary>
        /// <returns></returns>
        private Boolean ValidData()
        {
            if (txtDescripcion.Text == "" || txtDescripcion.Text == null)
            {
                ProcesarAdvertencia("Debe ingresar una descripción para el recordatorio");
                return false;
            }
         
            return true;
        }

        #endregion


        #region "--[Events]--"
        private void frmRecordatorio_Load(object sender, EventArgs e)
        {
            _RecordatorioBP = new RecordatorioBusiness(DaoFactory.GetRecordatorioDao());
            LoadCombos();
            this.dtpFechaRecordatorio.CustomFormat = "dd/MM/yy : hh:mm";
            this.dtpFechaRecordatorio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            LoadList();
        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            _RecordatorioEntities = _RecordatorioBP.GetAll();
        }

          private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //dgvList.DataSource = _RecordatorioEntities;
              ///////////////
            this.RecordatorioObjectView.DataSource = (IList)this._RecordatorioEntities;
            this.dgvList.DataSource = this.RecordatorioObjectView;
             //////////////
            ptbProgress.Visible = false;
            Habilitar(true);
        }

        public override void Accion()
        {
            try
            {
                pnlDetails.Visible = true;

                switch (Estado)
                {
                    case EstadoForm.Nuevo:
                        txtIDRecordatorio.Text = string.Empty;
                        txtIDRecordatorio.Enabled = false;
                        txtDescripcion.Text = string.Empty;
                        dtpFechaRecordatorio.Value = DateTime.Now;
                        txtIDVinculado.Text = string.Empty;
                        txtIDVinculado.Enabled = false;
                        cmbTipoVinculado.SelectedItem = Enumeraciones.TipoRecordatorioVinculado.Personal;
                        cmbTipoVinculado.Enabled = false;

                        txtDescripcion.Focus();
                        RecordatorioEntity = new Recordatorio();
                        break;

                    case EstadoForm.Editar:
                        if (dgvList.Rows.Count > 0)
                        {
                            txtIDRecordatorio.Enabled = false;
                            LoadData();
                            txtDescripcion.Focus();
                        }

                        break;

                    case EstadoForm.Eliminar:
                        if (dgvList.Rows.Count > 0)
                        {
                            txtIDRecordatorio.Enabled = false;
                            LoadData();
                        }

                        break;
                }
            }

            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidData())
                {

                    RecordatorioEntity.Descripcion = txtDescripcion.Text;
                    RecordatorioEntity.FechaRecordatorio = dtpFechaRecordatorio.Value;
                    RecordatorioEntity.TipoVinculado = (Int32)cmbTipoVinculado.SelectedItem;

                    //RecordatorioEntity.TipoVinculado = Convert.ToInt32(txtTipoVinculado.Text);
                    //RecordatorioEntity.IDVinculado = Convert.ToInt32(txtIDVinculado.Text);
                                       
                    switch (Estado)
                    {
                        case EstadoForm.Editar:
                            RecordatorioBP.Update(RecordatorioEntity);
                            RecordatorioBP.Commit();
                            break;
                        case EstadoForm.Eliminar:
                            RecordatorioBP.Delete(RecordatorioEntity);
                            RecordatorioBP.Commit();
                            break;
                        case EstadoForm.Nuevo:
                            RecordatorioBP.Insert(RecordatorioEntity);
                            break;
                    }
                    pnlDetails.Visible = false;
                    CambiarTamaño(true);
                    Estado = EstadoForm.Grilla;
                    LoadList();
                }
            }

            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        

        

        #endregion
    }
}
