using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medusa.Biodata.BackEnd.BusinessComponents;
using Medusa.Biodata.Common.BusinessEntities;
using FormularioPersonalizado;

namespace Medusa.Biodata.FrontEnd.Forms
{
    public partial class frmProductABM : frmABMBase
    {
        #region "--[Properties]--"
        private ProductEntities _Products;

        public ProductEntities Products
        {
            get { return _Products; }
            set { _Products = value; }
        }

        private Boolean wValoresCargados = false;

        private Boolean wCambioTipoDocumento = false;

        //private Boolean wActualizar = false;

        private Boolean wEsLoad = false;
        #endregion

        #region "--[Events]--"
        private void frmProductABM_Load(object sender, EventArgs e)
        {
            wEsLoad = true;
            LoadProductTypes();
            LoadList();
        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Products = ProductBusinessComponent.Search(new ProductEntity());
        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dgvList.DataSource = Products;
            ptbProgress.Visible = false;
            Habilitar(true);
        }

        private void Accion()
        {
            try
            {
                pnlDetails.Visible = true;
                tbcDatos.SelectedIndex = 0;
                switch (Estado)
                {
                    case EstadoForm.Nuevo:
                        txtID.Text = string.Empty;
                        txtID.Enabled = false;
                        txtName.Text = string.Empty;
                        txtDescription.Text = string.Empty;
                        txtCurrentStock.Text = string.Empty;
                        txtMinimumStock.Text = string.Empty;
                        txtPrice.Text = string.Empty;
                        txtCost.Text = string.Empty;

                        txtName.Focus();
                        break;

                    case EstadoForm.Editar:
                        if (dgvList.Rows.Count > 0)
                        {
                            txtID.Enabled = false;
                            LoadData();
                            txtName.Focus();
                        }

                        break;

                    case EstadoForm.Eliminar:
                        if (dgvList.Rows.Count > 0)
                        {
                            txtID.Enabled = false;
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
                    ProductEntity wProduct = new ProductEntity();
                    wProduct.Name = txtName.Text;
                    wProduct.Description = txtDescription.Text;
                    wProduct.CurrentStock = Convert.ToInt32(txtCurrentStock.Text);
                    wProduct.MinimumStock = Convert.ToInt32(txtMinimumStock.Text);
                    wProduct.Price = Convert.ToDecimal(txtPrice.Text);
                    wProduct.Cost = Convert.ToDecimal(txtCost.Text);
                    wProduct.ProductType.ID = Convert.ToInt32(cboProductType.SelectedValue);

                    //Deberia estar en el capa DAC o BC un proceso que realice todo en una transaccion y no 
                    //en el Front separados producto y sus datos personalizados.
                    switch (Estado)
                    {
                        case EstadoForm.Editar:
                            wProduct.ID = Convert.ToInt32(txtID.Text.Trim());
                            ProductBusinessComponent.Update(wProduct);
                            UpdateValors(wProduct.ID.Value);
                            break;
                        case EstadoForm.Eliminar:
                            wProduct.ID = Convert.ToInt32(txtID.Text.Trim());
                            ProductBusinessComponent.Delete(wProduct);
                            //Elimino sus valores de personalizacion
                            FormularioPersonalizadoValorEntity wFPValor = new FormularioPersonalizadoValorEntity();
                            wFPValor.Product.ID = Convert.ToInt32(txtID.Text);
                            FormularioPersonalizadoValorBC.DeleteByPROId(wFPValor);
                            break;
                        case EstadoForm.Nuevo:
                            Int32 IdProd;
                            IdProd = ProductBusinessComponent.Insert(wProduct);
                            SaveValors(IdProd);
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

        private void cboProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if ((cboProductType.SelectedIndex != -1))
                {
                    wValoresCargados = false;
                    if (!wEsLoad)
                    {
                        //If wPrimeraCarga Then 
                        //wCambioTipoDocumento = True 
                        //Else 
                        //wPrimeraCarga = True 
                        //wActualizar = true;
                        wCambioTipoDocumento = true;
                        //End If 
                    }

                    BuscarFormularioPersonalizado((ProductTypeEntity)cboProductType.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void tbcDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Estado != EstadoForm.Nuevo)
                {
                    if (tbcDatos.SelectedIndex == 1)
                    {
                        if (!wValoresCargados)
                        {
                            wValoresCargados = true;
                            LoadValors();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }

        }
        #endregion

        #region "--[Methods]--"
        public frmProductABM()
        {
            InitializeComponent();
        }

        private void LoadList()
        {
            try
            {
                ptbProgress.Visible = true;
                BuildColumns();
                dgvList.DataSource = null;
                Habilitar(false);
                //btnClose.Enabled = true;
                bgwLoad.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void LoadData()
        {
            ProductEntity wProduct = (ProductEntity)dgvList.CurrentRow.DataBoundItem;

            txtID.Text = wProduct.ID.Value.ToString();
            txtName.Text = wProduct.Name;
            txtDescription.Text = wProduct.Description;
            txtCurrentStock.Text = wProduct.CurrentStock.ToString();
            txtMinimumStock.Text = wProduct.MinimumStock.ToString();
            txtPrice.Text = wProduct.Price.ToString();
            txtCost.Text = wProduct.Cost.ToString();
            cboProductType.SelectedValue = wProduct.ProductType.ID;
            wEsLoad = false;
            //LoadValors();
        }

        private Boolean ValidData()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Falta ingresar el nombre", "Nombre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            //Controla que los campos requeridos no esten vacios. 
            foreach (useBasePers wControl in pnlDatosPersonalizados.Controls)
            {
                if (wControl.Requerido)
                {
                    switch (wControl.TipoControl)
                    {
                        case TipoControl.Chequeo:
                            if (wControl.Valor == "0")
                            {
                                MessageBox.Show("Faltan Datos requeridos", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }

                            break;
                        case TipoControl.Texto:
                            if (wControl.Valor == "")
                            {
                                MessageBox.Show("Faltan Datos requeridos", "Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }

                            break;
                        case TipoControl.Multilinea:
                            if (wControl.Valor == "")
                            {
                                MessageBox.Show("Faltan Datos requeridos", "Documento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }

                            break;
                    }
                }
            } 


            return true;
        }

        private void BuildColumns()
        {
            try
            {
                dgvList.AutoGenerateColumns = false;
                dgvList.Columns.Clear();
                dgvList.Columns.Add("ID", "ID");
                dgvList.Columns[0].DataPropertyName = "ID";
                dgvList.Columns[0].Visible = false;
                dgvList.Columns.Add("Nombre", "Nombre");
                dgvList.Columns[1].DataPropertyName = "Name";
                dgvList.Columns.Add("Descripcion", "Descripcion");
                dgvList.Columns[2].DataPropertyName = "Description";
                dgvList.Columns.Add("Precio", "Precio");
                dgvList.Columns[3].DataPropertyName = "Price";
                dgvList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void LoadProductTypes()
        {
            ProductTypeEntities wProductTypes;
            wProductTypes = ProductTypeBusinessComponent.Search(new ProductTypeEntity());

            ProductTypeEntity wItem = new ProductTypeEntity();


            wItem.Description = "Seleccionar";
            wItem.ID = -1;
            wProductTypes.Add(wItem);
            //ptbProgreso.Visible = false;
            cboProductType.DataSource = wProductTypes;
            cboProductType.ValueMember = "Id";
            cboProductType.DisplayMember = "Description";

            cboProductType.SelectedItem = wItem;
        }

        private void BuscarFormularioPersonalizado(ProductTypeEntity pProductType)
        {
            try
            {
                pnlDatosPersonalizados.Controls.Clear();

                FormularioPersonalizadoEntities wFormulariosPersonalizados = new FormularioPersonalizadoEntities();
                FormularioPersonalizadoEntity wFormularioPersonalizado = new FormularioPersonalizadoEntity();

                wFormularioPersonalizado.ProductType = pProductType;
                //wFormulariosPersonalizados.Llenar(wFormularioPersonalizado);

                wFormulariosPersonalizados = FormularioPersonalizadoBC.Search(wFormularioPersonalizado);

                foreach (FormularioPersonalizadoEntity wFormularioPersonalizadoX in wFormulariosPersonalizados)
                {
                    CrearControl(wFormularioPersonalizadoX);
                }
            }

            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void CrearControl(FormularioPersonalizadoEntity pFormularioPersonalizado)
        {
            try
            {
                TipoControl wTipo = pFormularioPersonalizado.TipoControl.Value;
                useBasePers wUse;

                switch (wTipo)
                {
                    case TipoControl.Texto:
                        wUse = new useTexto();
                        break;
                    case TipoControl.Multilinea:
                        wUse = new useMultiple();
                        break;
                    case TipoControl.Opcion:
                        wUse = new useOpcion();
                        ((useOpcion)wUse).Lista = pFormularioPersonalizado.Lista;
                        break;
                    case TipoControl.Chequeo:
                        wUse = new useChequeo();
                        ((useChequeo)wUse).Lista = pFormularioPersonalizado.Lista;
                        break;
                    case TipoControl.Combo:
                        wUse = new useCombo();
                        ((useCombo)wUse).Lista = pFormularioPersonalizado.Lista;
                        break;
                    default:
                        wUse = new useBasePers();
                        break;
                }

                wUse.Texto = pFormularioPersonalizado.Etiqueta.Trim().ToString();
                wUse.Requerido = pFormularioPersonalizado.Requerido.Value;
                wUse.Orden = pFormularioPersonalizado.Orden.Value;
                wUse.ModoEdicion = false;
                wUse.ProductType = pFormularioPersonalizado.ProductType;
                wUse.Name = "cfp" + pFormularioPersonalizado.Orden.ToString();
                //wUse.Valor = "" 

                wUse.Dock = DockStyle.Top;
                pnlDatosPersonalizados.Controls.Add(wUse);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }
        private void SaveValors(Int32 pId)
        {
            //recopilo los datos del f. personalizado y 
            //los grabo en la BD (FPValor) 
            foreach (useBasePers wControl in pnlDatosPersonalizados.Controls)
            {
                //Inserto en FPV 
                FormularioPersonalizadoValorEntity wFPValor = new FormularioPersonalizadoValorEntity();
                wFPValor.Control.ProductType.ID = wControl.ProductType.ID;
                wFPValor.Control.Orden = wControl.Orden;
                wFPValor.Product.ID = pId;
                wFPValor.Valor = wControl.Valor;
                //if (wFPValor.Insertar() > 0)
                if (FormularioPersonalizadoValorBC.Insert(wFPValor) > 0)
                {
                    //wPasoInsertFPV = true;
                }
                else
                {
                    //wPasoInsertFPV = false;
                }
            }

        }

        private void LoadValors()
        {
            try
            {
                //para cada control, debo obtener el valor 
                foreach (useBasePers wControl in pnlDatosPersonalizados.Controls)
                {
                    FormularioPersonalizadoValorEntities wFPValores;
                    FormularioPersonalizadoValorEntity wFPValor = new FormularioPersonalizadoValorEntity();

                    wFPValor.Control.Orden = wControl.Orden;
                    wFPValor.Control.ProductType.ID = wControl.ProductType.ID;
                    wFPValor.Product.ID = Convert.ToInt32(txtID.Text);
                    //wFPValores.Llenar(wFPValor);
                    wFPValores = FormularioPersonalizadoValorBC.Search(wFPValor);

                    if (wFPValores.Count > 0)
                    {
                        wControl.Valor = wFPValores[0].Valor;
                    }
                }
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private void UpdateValors(Int32 pId)
        {
            //recopilo los datos del f. personalizado y 
            //los grabo en la BD (FPValor) 
            //pero antes debo comprobar si cambió el tipo de producto porque
            //si así fue debo borrar los valores que tenía el otro tipo de producto para este producto 
            if (wCambioTipoDocumento)
            {
                FormularioPersonalizadoValorEntity wFPValor = new FormularioPersonalizadoValorEntity();
                wFPValor.Product.ID = Convert.ToInt32(txtID.Text);
                //if (wFPValor.EliminarByDocId() > 0)
                if (FormularioPersonalizadoValorBC.DeleteByPROId(wFPValor) > 0)
                {
                    //wPasoDeleteFPV = true;
                }
                else
                {
                    //wPasoDeleteFPV = false;
                }
            }
            //ahora grabo los valores 
            foreach (useBasePers wControl in pnlDatosPersonalizados.Controls)
            {
                //Inserto en FPV 
                FormularioPersonalizadoValorEntity wFPValor = new FormularioPersonalizadoValorEntity();
                wFPValor.Control.ProductType.ID = wControl.ProductType.ID;
                wFPValor.Control.Orden = wControl.Orden;
                wFPValor.Product.ID = Convert.ToInt32(txtID.Text);
                wFPValor.Valor = wControl.Valor;
                if (wCambioTipoDocumento)
                {
                    //if (wFPValor.Insertar() > 0)
                    if (FormularioPersonalizadoValorBC.Insert(wFPValor) > 0)
                    {
                        //wPasoInsertFPV = true;
                    }
                    else
                    {
                        //wPasoInsertFPV = false;
                    }
                }
                else
                {
                    //if (wFPValor.Modificar() > 0)
                    if (FormularioPersonalizadoValorBC.Update(wFPValor) > 0)
                    {
                        //wPasoUpdateFPV = true;
                    }
                    else
                    {
                        //wPasoUpdateFPV = false;
                    }
                }
            }

        }

        #endregion
    }
}
