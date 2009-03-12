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

        #endregion


        #region "--[Methods]--"

        public frmRecordatorio()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Da formato a la grilla.
        /// </summary>
        private void BuildColumns()
        {
            try
            {
                dgvList.AutoGenerateColumns = false;
                dgvList.Columns.Clear();
                dgvList.Columns.Add("IDRecordatorio", "IDRecordatorio");
                dgvList.Columns[0].DataPropertyName= "IDRecordatorio";
                dgvList.Columns.Add("Descripcion", "Descripcion");
                dgvList.Columns[1].DataPropertyName ="Descripcion";
                dgvList.Columns.Add("FechaRecordatorio", "FechaRecordatorio");
                dgvList.Columns[2].DataPropertyName= "FechaRecordatorio";
                dgvList.Columns.Add("IDVinculado", "IDVinculado");
                dgvList.Columns[3].DataPropertyName= "IDVinculado";
                dgvList.Columns[3].Visible= false;
                dgvList.Columns.Add("TipoVinculado", "TipoVinculado");
                dgvList.Columns[4].DataPropertyName= "TipoVinculado";


            }
            catch(Exception e)
            {
                ProcesarExcepcion(e);
            }

        }

        /// <summary>
        /// Carga la grilla con los registros de la DB
        /// </summary>
        private void LoadList()
        {
            try
            {
                ptbProgress.Visible = true;
                BuildColumns();
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
            RecordatorioEntity = RecordatorioBP.GetById(((Recordatorio)dgvList.CurrentRow.DataBoundItem).ID);

            txtIDRecordatorio.Text = RecordatorioEntity.ID.ToString();
            txtDescripcion.Text = RecordatorioEntity.Descripcion.ToString();
            dtpFechaRecordatorio.Value = (DateTime)RecordatorioEntity.FechaRecordatorio;
            txtIDVinculado.Text= RecordatorioEntity.IDVinculado.ToString();
            txtTipoVinculado.Text= RecordatorioEntity.TipoVinculado.ToString();

        }

        /// <summary>
        /// Valida datos basicos antes de enviar la entidad
        /// </summary>
        /// <returns></returns>
        private Boolean ValidData()
        {
            return true;
        }

        #endregion


        #region "--[Events]--"
        private void frmRecordatorio_Load(object sender, EventArgs e)
        {
            _RecordatorioBP = new RecordatorioBusiness(DaoFactory.GetRecordatorioDao());
            LoadList();
        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            _RecordatorioEntities = _RecordatorioBP.GetAll();
        }

          private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvList.DataSource = _RecordatorioEntities;
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
                        txtTipoVinculado.Text = string.Empty;

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
                    RecordatorioEntity.TipoVinculado = Convert.ToInt32(txtTipoVinculado.Text);
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
