using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Medusa.Biodata.FrontEnd.Forms
{
    public partial class TestBaseForm : BaseForm
    {

        #region -[Miembros]-
        private DataTable _mainTable;
        private BindingSource _mainBindingSource;
        private EstadoForm _estado;
        #endregion


        #region -[Propiedades]-
        protected EstadoForm Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        protected DataTable MainTable
        {
            get { return _mainTable; }
            set { _mainTable = value; }
        }

        protected BindingSource MainBindingSource
        {
            get { return _mainBindingSource; }
            set { _mainBindingSource = value; }
        }

        public TestBaseForm()
        {
            InitializeComponent();
        }

        private void TestBaseForm_Load(object sender, EventArgs e)
        {
            _mainBindingSource = new BindingSource();
        }
        #endregion


        #region -[Metodos]-
        /// <summary>
        /// Setea los controles del formulario solamente para visualizar (no editable)
        /// </summary>
        protected virtual void ModoEstatico()
        {
            abmControl.SetModo(Medusa.Biodata.FrontEnd.UserControls.Estado.HABILITAR_TODO);
            btnAceptar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        /// <summary>
        /// Setea los controles del formulario para ser editado
        /// </summary>
        protected virtual void ModoEditable()
        {
            abmControl.SetModo(Medusa.Biodata.FrontEnd.UserControls.Estado.DESHABILITAR_TODO);
            btnAceptar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        /// <summary>
        /// Limpia los controles de formulario
        /// </summary>
        protected virtual void LimpiarFormulario()
        {

        }

        /// <summary>
        /// Muestra los datos del DTO en el formulario
        /// </summary>
        protected virtual void MostrarEntidad()
        {

        }

        /// <summary>
        /// Copia los datos del formulario al DTO
        /// </summary>
        protected virtual void GrabarEntidad()
        {

        }

        /// <summary>
        /// Refresca la grilla desde el BindingNavigator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void btnRefrescar_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Refresca la grilla/s del formulario
        /// </summary>
        protected virtual void RefrescarGrilla()
        {
        }
        #endregion

    }

    /// <summary>
    /// Operaciones a realizar en los formularios asincronicamente
    /// </summary>
    internal enum Operacion
    {
        CARGAR_GRILLA,
        ELIMINAR,
        ACTUALIZAR,
        INSERTAR
    }
}
