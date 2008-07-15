using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Medusa.Biodata.Common.BusinessEntities;
using Medusa.Biodata.BackEnd.BusinessComponents;
using FormularioPersonalizado;

namespace Medusa.Biodata.FrontEnd.Forms
{
    public partial class frmPersonalizedForm : frmBase
    {
        #region "--[Properties]--"

        private FormularioPersonalizadoEntities wFormulariosPersonalizados = new FormularioPersonalizadoEntities();
        //private TipoDocumentoEntities wTiposDocumentos = new TipoDocumentoEntities();
        private ProductTypeEntities wProductTypes = new ProductTypeEntities();
        private Enumeraciones.AccionFormularioPersonalizado wAccion;
        private Boolean wEsLoad;
        private Boolean wCambioGenerado;

        #endregion



        #region "--[Events]--"
        private void frmPersonalizedForm_Load(object sender, EventArgs e)
        {
            //la siguiente línea se declara para que no haya problemas al intentar acceder al control 
            //que fue creado por otro proceso o hilo (el cmbTipoDocumento fue creado con el hilo bgwLoad) 
            //Excepcion: Se ha tenido acceso al control 'nombre de control' desde un subproceso 
            //distinto en el que se ha creado 
            //se podría tratar de otra manera, creando delegados, pero esto es más sencillo. 
            CheckForIllegalCrossThreadCalls = false;

            Array wItems;

            try
            {
                wEsLoad = true;
                bgwLoad.RunWorkerAsync();

                wItems = System.Enum.GetNames(typeof(TipoControl));
                foreach (string wItem in wItems)
                {
                    cmbTipoControl.Items.Add(wItem);
                }
                cmbTipoControl.SelectedItem = TipoControl.Seleccionar.ToString();

                MostrarLista(false);
            }

            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }

        }

        private void bgwLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                //wTiposDocumentos.Llenar();
                wProductTypes = ProductTypeBusinessComponent.Search(new ProductTypeEntity());
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }

        }

        private void bgwLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                //TipoDocumentoEntity wItem = new TipoDocumentoEntity();
                ProductTypeEntity wItem = new ProductTypeEntity();


                wItem.Description = "Seleccionar";
                wItem.ID = -1;
                //wTiposDocumentos.Add(wItem);
                wProductTypes.Add(wItem);

                ptbProgreso.Visible = false;

                //cmbProductType.DataSource = wTiposDocumentos;
                cmbProductType.DataSource = wProductTypes;
                cmbProductType.ValueMember = "Id";
                cmbProductType.DisplayMember = "Description";

                cmbProductType.SelectedItem = wItem;

                LimpiarCampos();
                //ActualizarIdioma();
                wEsLoad = false;
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }

        }

        private void bgwCargarControles_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                e.Result = CargarControles();
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }

        }

        private void bgwCargarControles_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                ptbProgreso.Visible = false;
                foreach (FormularioPersonalizadoEntity wFormularioPersonalizado in (FormularioPersonalizadoEntities)e.Result)
                {
                    CrearControl(wFormularioPersonalizado);
                }
                LimpiarCampos();
                //ActualizarIdioma();
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }

        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (!wEsLoad)
                {
                    if ((wCambioGenerado == true))
                    {
                        GuardarDatos();
                    }
                    if ((cmbProductType.SelectedIndex != -1) & (Convert.ToInt32(((ProductTypeEntity)cmbProductType.SelectedItem).ID) != -1))
                    {
                        pnlControles.Controls.Clear();
                        ptbProgreso.Visible = true;
                        bgwCargarControles.RunWorkerAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }

        }

        private void cmbTipoControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!wEsLoad)
            {
                if ((cmbTipoControl.SelectedItem.ToString() == TipoControl.Opcion.ToString()) | (cmbTipoControl.SelectedItem.ToString() == TipoControl.Chequeo.ToString() | (cmbTipoControl.SelectedItem.ToString() == TipoControl.Combo.ToString())))
                {
                    MostrarLista(true);
                }
                //grbItems.Visible = True 
                else
                {
                    MostrarLista(false);
                    //grbItems.Visible = False 
                }
            }

            txtOrdenX.Text = ObtenerNroOrden().ToString();
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            if ((txtTextoItemX.Text.Trim() != ""))
            {
                FormularioPersonalizadoItemEntity wFPItem = new FormularioPersonalizadoItemEntity();

                wFPItem.Etiqueta = txtTextoItemX.Text.Trim();
                wFPItem.Id = lstControles.Items.Count;
                //wFPItem.Control.TipoDocumento = cmbTipoDocumento.SelectedItem;
                wFPItem.Control.ProductType = (ProductTypeEntity)cmbProductType.SelectedItem;
                wFPItem.Control.Orden = Convert.ToInt32(txtOrdenX.Text);

                lstControles.Items.Add(wFPItem);
                lstControles.SelectedIndex = lstControles.Items.Count - 1;
                txtTextoItemX.Text = string.Empty;
                txtTextoItemX.Focus();
            }

        }

        private void btnEliminarItem_Click(object sender, EventArgs e)
        {
            int IndiceSeleccionado;

            if ((lstControles.SelectedIndex != -1))
            {
                IndiceSeleccionado = lstControles.SelectedIndex;
                lstControles.Items.Remove(lstControles.SelectedItem);

                if ((IndiceSeleccionado != 0))
                {
                    lstControles.SelectedIndex = IndiceSeleccionado - 1;
                }
                else
                {
                    if ((lstControles.Items.Count > 0))
                    {
                        lstControles.SelectedIndex = 0;
                    }
                }
            }

        }

        private void btnAgregarControl_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarDatos())
                {
                    FormularioPersonalizadoItemEntities wItems = new FormularioPersonalizadoItemEntities();
                    useBasePers wUse;
                    string Tipo = cmbTipoControl.SelectedItem.ToString();

                    foreach (FormularioPersonalizadoItemEntity wItem in lstControles.Items)
                    {
                        //wItem.Control.TipoDocumento = (TipoDocumentoEntity)cmbTipoDocumento.SelectedItem;
                        wItem.Control.ProductType = (ProductTypeEntity)cmbProductType.SelectedItem;
                        wItem.Control.Orden = Convert.ToInt32(txtOrdenX.Text);
                        wItems.Add(wItem);
                    }

                    switch (Tipo)
                    {
                        //case TipoControl.Texto.ToString():
                        case "Texto":
                            wUse = new useTexto();
                            break;
                        //case TipoControl.Multilinea.ToString():
                        case "Multilinea":
                            wUse = new useMultiple();
                            break;
                        //case TipoControl.Opcion.ToString():
                        case "Opcion":
                            wUse = new useOpcion();
                            ((useOpcion)wUse).Lista = wItems;
                            break;
                        //case TipoControl.Chequeo.ToString():
                        case "Chequeo":
                            wUse = new useChequeo();
                            ((useChequeo)wUse).Lista = wItems;
                            break;
                        //case TipoControl.Combo.ToString():
                        case "Combo":
                            wUse = new useCombo();
                            ((useCombo)wUse).Lista = wItems;
                            break;
                        default:
                            wUse = new useBasePers();
                            break;
                    }

                    wUse.Texto = txtEtiquetaX.Text.ToString().Trim();
                    wUse.Requerido = chkRequerido.Checked;
                    wUse.ModoEdicion = true;
                    wUse.Orden = Convert.ToInt32(txtOrdenX.Text);
                    wUse.ProductType = (ProductTypeEntity)cmbProductType.SelectedItem;

                    wUse.Dock = DockStyle.Top;
                    pnlControles.Controls.Add(wUse);

                    lstControles.Items.Clear();
                    txtEtiquetaX.Text = string.Empty;
                    chkRequerido.Checked = false;
                    txtOrdenX.Text = ObtenerNroOrden().ToString();
                    wCambioGenerado = true;
                }
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }

        }

        private void btnModificarControl_Click(object sender, EventArgs e)
        {
            try
            {
                int CantidadControlesSeleccionados = HayControlesSeleccionados();
                if (CantidadControlesSeleccionados > 0)
                {
                    if (CantidadControlesSeleccionados > 1)
                    {
                        MessageBox.Show("Hay varios controles seleccionados, sólo debe tener seleccionado un control para hacer la modificación.", "Varios Controles Seleccionados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ModificarControl();
                        wCambioGenerado = true;
                    }
                }
                else
                {
                    MessageBox.Show("No hay controles seleccionados.", "Sin Controles Seleccionados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);

            }

        }

        private void btnEliminarControl_Click(object sender, EventArgs e)
        {
            try
            {
                if (HayControlesSeleccionados() > 0)
                {
                    if (MessageBox.Show("¿Desea eliminar los controles seleccionados?", "Eliminar Controles", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        for (int i = 1; i <= pnlControles.Controls.Count; i++)
                        {
                            EliminarControl();
                            wCambioGenerado = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay controles seleccionados.", "Sin Controles Seleccionados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((wAccion == Enumeraciones.AccionFormularioPersonalizado.ModificarControl))
                {
                    //ubico el control, lo borro y creo uno nuevo con los datos nuevos 
                    foreach (useBasePers wControl in pnlControles.Controls)
                    {
                        if (wControl.Seleccionado == true)
                        {
                            pnlControles.Controls.Remove(wControl);
                        }
                    }
                    if (ValidarDatos())
                    {
                        FormularioPersonalizadoItemEntities wItems = new FormularioPersonalizadoItemEntities();
                        useBasePers wUse;
                        string Tipo = cmbTipoControl.SelectedItem.ToString();

                        foreach (FormularioPersonalizadoItemEntity wItem in lstControles.Items)
                        {
                            wItem.Control.ProductType = (ProductTypeEntity)cmbProductType.SelectedItem;
                            wItem.Control.Orden = Convert.ToInt32(txtOrdenX.Text);
                            wItems.Add(wItem);
                        }

                        switch (Tipo)
                        {
                            //case TipoControl.Texto.ToString():
                            case "Texto":
                                wUse = new useTexto();
                                break;
                            //case TipoControl.Multilinea.ToString():
                            case "Multilinea":
                                wUse = new useMultiple();
                                break;
                            //case TipoControl.Opcion.ToString():
                            case "Opcion":
                                wUse = new useOpcion();
                                ((useOpcion)wUse).Lista = wItems;
                                break;
                            //case TipoControl.Chequeo.ToString():
                            case "Chequeo":
                                wUse = new useChequeo();
                                ((useChequeo)wUse).Lista = wItems;
                                break;
                            //case TipoControl.Combo.ToString():
                            case "Combo":
                                wUse = new useCombo();
                                ((useCombo)wUse).Lista = wItems;
                                break;
                            default:
                                wUse = new useBasePers();
                                break;
                        }

                        wUse.Texto = txtEtiquetaX.Text.ToString().Trim();
                        wUse.Requerido = chkRequerido.Checked;
                        wUse.ModoEdicion = true;
                        wUse.Orden = Convert.ToInt32(txtOrdenX.Text);
                        wUse.ProductType = (ProductTypeEntity)cmbProductType.SelectedItem;

                        wUse.Dock = DockStyle.Top;
                        pnlControles.Controls.Add(wUse);

                        lstControles.Items.Clear();
                        txtEtiquetaX.Text = string.Empty;
                        chkRequerido.Checked = false;
                        txtOrdenX.Text = ObtenerNroOrden().ToString();
                    }

                    //cambio el estado de los botones y combos 
                    HabilitarControles(true);

                    wAccion = Enumeraciones.AccionFormularioPersonalizado.Nada;
                }
                else
                {
                    GuardarDatos();
                }
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((wAccion == Enumeraciones.AccionFormularioPersonalizado.ModificarControl))
                {
                    HabilitarControles(true);
                    wAccion = Enumeraciones.AccionFormularioPersonalizado.Nada;
                }
                else
                {
                    if ((wCambioGenerado == true))
                    {
                        GuardarDatos();
                    }
                    this.Parent.Parent.Controls.Remove(this.Parent);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }

        }
        #endregion


        #region "--[Methods]--"

        public frmPersonalizedForm()
        {
            InitializeComponent();
        }

        private void MostrarLista(bool pVisible)
        {
            if (pVisible)
            {
                pnlMenu.Controls["grbDocumentos"].Dock = DockStyle.Top;
                pnlMenu.Controls["grbItems"].Dock = DockStyle.Top;
                pnlMenu.Controls["grbItems"].Visible = true;
                pnlMenu.Controls["grbAccion"].Dock = DockStyle.Top;
                pnlMenu.Controls["grbBotones"].Dock = DockStyle.Top;
            }
            else
            {
                pnlMenu.Controls["grbDocumentos"].Dock = DockStyle.Top;
                pnlMenu.Controls["grbItems"].Dock = DockStyle.Top;
                pnlMenu.Controls["grbItems"].Visible = false;
                pnlMenu.Controls["grbAccion"].Dock = DockStyle.Top;
                pnlMenu.Controls["grbBotones"].Dock = DockStyle.Top;
            }

        }

        private FormularioPersonalizadoEntities CargarControles()
        {
            try
            {
                FormularioPersonalizadoEntity wFormularioPersonalizado = new FormularioPersonalizadoEntity();
                //TipoDocumentoEntity wTipoDocumento = new TipoDocumentoEntity();
                ProductTypeEntity wProductType = new ProductTypeEntity();

                wProductType = (ProductTypeEntity)this.cmbProductType.SelectedItem;
                wFormularioPersonalizado.ProductType = wProductType;

                //wFormulariosPersonalizados.Llenar(wFormularioPersonalizado);
                wFormulariosPersonalizados = FormularioPersonalizadoBC.Search(wFormularioPersonalizado);
                if (wFormulariosPersonalizados.Count == 0)
                {
                    btnModificarControl.Enabled = true;
                }
                else
                {
                    btnModificarControl.Enabled = false;
                }
                return wFormulariosPersonalizados;
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
                return null;
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
                wUse.ModoEdicion = true;
                //wUse.TipoDocumento = pFormularioPersonalizado.TipoDocumento;
                wUse.ProductType = pFormularioPersonalizado.ProductType;

                wUse.Dock = DockStyle.Top;
                pnlControles.Controls.Add(wUse);
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private int ObtenerNroOrden()
        {
            int NroOrden = 0;
            foreach (Control wControl in pnlControles.Controls)
            {
                if ((((useBasePers)wControl).Orden > NroOrden))
                {
                    NroOrden = ((useBasePers)wControl).Orden;
                }
            }
            return NroOrden + 1;
        }

        private void ModificarControl()
        {
            try
            {
                wAccion = Enumeraciones.AccionFormularioPersonalizado.ModificarControl;
                //en este recorrido solo voy a encontrar un solo control que va a ser el que 
                //está seleccionado 
                foreach (useBasePers wControl in pnlControles.Controls)
                {
                    if (wControl.Seleccionado == true)
                    {

                        HabilitarControles(false);

                        cmbTipoControl.SelectedItem = wControl.TipoControl.ToString();
                        txtOrdenX.Text = wControl.Orden.ToString();
                        txtEtiquetaX.Text = wControl.Texto;
                        chkRequerido.Checked = wControl.Requerido;
                        lstControles.Items.Clear();

                        if ((wControl is useBaseLista))
                        {
                            foreach (FormularioPersonalizadoItemEntity wItem in ((useBaseLista)wControl).Items)
                            {
                                lstControles.Items.Add(wItem);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private Boolean ValidarDatos()
        {
            try
            {
                //if ((cmbTipoDocumento.SelectedIndex == -1) | (Convert.ToInt32(((TipoDocumentoEntity)cmbTipoDocumento.SelectedItem).Id) == -1))
                if ((cmbProductType.SelectedIndex == -1) || (Convert.ToInt32(((ProductTypeEntity)cmbProductType.SelectedItem).ID) == -1))
                {
                    MessageBox.Show("Debe seleccionar un Tipo de Producto.", "Tipo Producto");
                    cmbProductType.Focus();
                    return false;
                }

                if ((cmbTipoControl.SelectedIndex == -1) || (cmbTipoControl.SelectedItem.ToString() == TipoControl.Seleccionar.ToString()))
                {
                    MessageBox.Show("Debe seleccionar un Tipo de Control.", "Tipo de Control");
                    cmbTipoControl.Focus();
                    return false;
                }

                if (cmbTipoControl.Text == TipoControl.Combo.ToString() || cmbTipoControl.Text == TipoControl.Chequeo.ToString() || cmbTipoControl.Text == TipoControl.Opcion.ToString())
                {
                    if (lstControles.Items.Count == 0)
                    {
                        MessageBox.Show("Debe ingresar al menos un ítem para el Tipo de Control seleccionado.", "Tipo de Control");
                        txtTextoItemX.Focus();
                        return false;
                    }
                }

                if (txtEtiquetaX.Text == string.Empty)
                {
                    MessageBox.Show("Debe ingresar la etiqueta.", "Etiqueta");
                    txtEtiquetaX.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
                return false;
            }
        }

        private void EliminarControl()
        {
            try
            {
                foreach (useBasePers wControl in pnlControles.Controls)
                {
                    if (wControl.Seleccionado == true)
                    {
                        pnlControles.Controls.Remove(wControl);
                        break; // TODO: might not be correct. Was : Exit For 
                    }
                }
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                ProcesarExcepcion(ex);
            }
        }

        private int HayControlesSeleccionados()
        {
            int i = 0;
            foreach (useBasePers wControl in pnlControles.Controls)
            {
                if (wControl.Seleccionado == true)
                {
                    i = i + 1;
                }
            }
            return i;
        }

        private void HabilitarControles(bool pHabilitar)
        {
            if (pHabilitar)
            {
                foreach (useBasePers wControl in pnlControles.Controls)
                {
                    if (wControl.Seleccionado == false)
                    {
                        wControl.Enabled = true;
                    }
                }

                cmbProductType.Enabled = true;
                cmbTipoControl.SelectedItem = TipoControl.Seleccionar;
                btnAgregarControl.Enabled = true;
                btnEliminarControl.Enabled = true;
                btnModificarControl.Enabled = true;

                btnGuardar.Text = "Guardar";
                btnCerrar.Text = "Cerrar";

                LimpiarCampos();
            }
            else
            {
                foreach (useBasePers wControl in pnlControles.Controls)
                {
                    if (wControl.Seleccionado == false)
                    {
                        wControl.Enabled = false;
                    }
                }

                cmbProductType.Enabled = false;
                btnAgregarControl.Enabled = false;
                btnEliminarControl.Enabled = false;
                btnModificarControl.Enabled = false;

                btnGuardar.Text = "Modificar";
                btnCerrar.Text = "Cancelar";
            }
        }

        private void LimpiarCampos()
        {
            txtOrdenX.Text = ObtenerNroOrden().ToString();
            txtEtiquetaX.Text = string.Empty;
            lstControles.Items.Clear();
            txtTextoItemX.Text = string.Empty;
        }

        private void GuardarDatos()
        {
            try
            {
                if ((MessageBox.Show("¿Desea guardar los cambios realizados?", "Guardar Formulario Personalizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes))
                {
                    FormularioPersonalizadoEntities wFormulariosPersonalizados = new FormularioPersonalizadoEntities();

                    if (pnlControles.Controls.Count > 0)
                    {
                        foreach (useBasePers wControl in pnlControles.Controls)
                        {
                            FormularioPersonalizadoEntity wFormularioPersonalizado = new FormularioPersonalizadoEntity();

                            //wFormularioPersonalizado.TipoDocumento = wControl.TipoDocumento;
                            wFormularioPersonalizado.ProductType = wControl.ProductType;
                            wFormularioPersonalizado.Orden = wControl.Orden;
                            wFormularioPersonalizado.Etiqueta = wControl.Texto;
                            wFormularioPersonalizado.Requerido = wControl.Requerido;
                            wFormularioPersonalizado.TipoControl = wControl.TipoControl;

                            if ((wControl is useBaseLista))
                            {
                                wFormularioPersonalizado.Lista = ((useBaseLista)wControl).Items;
                            }

                            wFormulariosPersonalizados.Add(wFormularioPersonalizado);
                        }
                    }
                    else
                    {
                        FormularioPersonalizadoEntity wFormularioPersonalizado = new FormularioPersonalizadoEntity();
                        //wFormularioPersonalizado.TipoDocumento = cmbTipoDocumento.SelectedItem;
                        wFormularioPersonalizado.ProductType = (ProductTypeEntity)cmbProductType.SelectedItem;
                        wFormulariosPersonalizados.Add(wFormularioPersonalizado);
                    }

                    //if (wFormulariosPersonalizados.Actualizar())
                    if (FormularioPersonalizadoBC.Actualizar(wFormulariosPersonalizados))
                    {
                        //operacion con exito 
                        MessageBox.Show("Los datos han sido guardados de manera exitosa.", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnModificarControl.Enabled = false;
                        wCambioGenerado = false;
                    }
                    else
                    {
                        //operacion sin exito 
                        MessageBox.Show("Los datos no han podido ser guardados.", "Datos No Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LimpiarCampos();
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
