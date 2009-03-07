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
    public partial class frmABMBase : frmBase
    {
        public event BotonClickEventHandler BotonClick;
        public delegate void BotonClickEventHandler();
        public event SeleccionFilaDistintaEventHandler SeleccionFilaDistinta;
        public delegate void SeleccionFilaDistintaEventHandler();
        public event SeleccionComplejaEventHandler SeleccionCompleja;
        public delegate void SeleccionComplejaEventHandler(bool pCerrar);


        //Public Enum EstadoForm 
        // Nuevo 
        // Eliminar 
        // Editar 
        // Ver 
        // Grilla 
        //End Enum 


        #region "--[Propiedades]--"

        private EstadoForm _estado = EstadoForm.Grilla;
        public EstadoForm Estado
        {
            get { return _estado; }
            set
            {
                lblDeleteItem.Visible = false;
                if (value == EstadoForm.Grilla)
                {
                    Habilitar(true);
                }
                else
                {
                    Habilitar(false);
                }
                _estado = value;
            }
        }

        private frmABMBase _llamador;
        public frmABMBase Llamador
        {
            get { return _llamador; }
            set { _llamador = value; }
        }

        private object _Seleccion = new object();
        public object Seleccion
        {
            get { return _Seleccion; }
            set
            {
                _Seleccion = value;
                if ((value != null))
                {
                    if (SeleccionCompleja != null)
                    {
                        SeleccionCompleja(true);
                    }
                }
                else
                {
                    if (SeleccionCompleja != null)
                    {
                        SeleccionCompleja(false);
                    }
                }
            }
        }

        #endregion

        #region "--[Eventos]--"

        public virtual void Accion()
        {
        
        }

        private void frmABMBase_Load(object sender, EventArgs e)
        {
            if ((Llamador != null))
            {
                this.btnSelect.Enabled = true;
            }
            if (!this.DesignMode)
            {
                CambiarTamaño(true);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Llamador.Activar();
            this.Llamador.Parent.Enabled = true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Estado = EstadoForm.Nuevo;
            CambiarTamaño(false);
            if (BotonClick != null)
            {
                BotonClick();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (ExistenciaRegistros())
            {
                Estado = EstadoForm.Editar;
                CambiarTamaño(false);
                if (BotonClick != null)
                {
                    BotonClick();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ExistenciaRegistros())
            {
                Estado = EstadoForm.Eliminar;
                lblDeleteItem.Visible = true;
                CambiarTamaño(false);
                if (BotonClick != null)
                {
                    BotonClick();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if ((Llamador != null))
            {
                Llamador.Activar();
                Llamador.Parent.Enabled = true;
                Cerrar();
            }
            else
            {
                Cerrar();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            //pnlDetails.Visible = false; 
            //Estado = EstadoForm.Grilla;
            //CambiarTamaño(true); 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Estado = EstadoForm.Grilla;
            pnlDetails.Visible = false;
            CambiarTamaño(true);
        }

        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (Estado == EstadoForm.Ver)
                {
                    if (SeleccionFilaDistinta != null)
                    {
                        SeleccionFilaDistinta();
                    }
                }
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void frmABMBase_SeleccionFilaDistinta()
        {
            if (BotonClick != null)
            {
                BotonClick();
            }
        }

        #endregion

        #region "--[Métodos]--"

        public frmABMBase()
        {
            InitializeComponent();
        }

        protected void Habilitar(bool pValor)
        {
            try
            {
                btnEdit.Enabled = pValor;
                btnDelete.Enabled = pValor;
                btnNew.Enabled = pValor;
                btnClose.Enabled = pValor;
                if ((Llamador != null) & pValor != false)
                {
                    this.btnSelect.Enabled = true;
                }
                else
                {
                    this.btnSelect.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        public void Activar()
        {
            ((TabControl)this.Parent.Parent).SelectedTab = (TabPage)this.Parent;
        }

        public void CambiarTamaño(bool pValor)
        {
            if (pValor)
            {
                //this.pnlList.Size = new Size(this.pnlList.Size.Width, this.Parent.Height - 50);
            }
            else
            {
                //this.pnlList.Size = new Size(this.pnlList.Size.Width, this.Parent.Height - 150 - this.pnlDetails.Height);
            }
            //this.ptbProgress.Location = new System.Drawing.Point(Convert.ToInt32((this.dgvList.Size.Width - 36) / 2), Convert.ToInt32((this.dgvList.Size.Height - 32) / 2));
        }

        private bool ExistenciaRegistros()
        {
            if (dgvList.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Cerrar()
        {
            this.Parent.Parent.Controls.Remove(this.Parent);
            this.Close();
        }

        #endregion

    }
}