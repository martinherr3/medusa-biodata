using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Medusa.Biodata.FrontEnd.UserControls;

public delegate void SearchEventHandler(object sender, SearchArgs e);

namespace Medusa.Biodata.FrontEnd.UserControls
{
    public partial class SearchControl : UserControl
    {

        #region -[Members]-
        public event SearchEventHandler ClickSearch;
        #endregion


        #region -[Constructor]-
        public SearchControl()
        {
            InitializeComponent();
        }
        #endregion


        #region -[Properties]-
        /// <summary>
        /// Setea los campos por los que buscar
        /// </summary>
        public IList<SearchItem> Campos
        {
            set{
                cmbCampos.DataSource = value;
                cmbCampos.ValueMember = "ValueMember";
                cmbCampos.DisplayMember = "DisplayMember";
            }
        }

        /// <summary>
        /// Setea los criterios de busqueda, Ejemplo: igual, mayor, etc.
        /// </summary>
        public IList<SearchItem> Criterios
        {
            set
            {
                cmbCriterio.DataSource = value;
                cmbCriterio.ValueMember = "ValueMember";
                cmbCriterio.DisplayMember = "DisplayMember";
            }
        }

        /// <summary>
        /// Retorna el item seleccionado (campo, criterio y valor).
        /// </summary>
        public SelectedItem ItemSelecionado
        {
            get
            {
                SelectedItem selectedItem = new SelectedItem();
                
                if(cmbCampos.SelectedValue != null)
                    selectedItem.Campo = cmbCampos.SelectedValue.ToString();
                if(cmbCriterio.SelectedValue != null)
                    selectedItem.Criterio = cmbCriterio.SelectedValue.ToString();
                
                selectedItem.Valor = txtValor.Text;

                return selectedItem;
            }
        }
        #endregion


        #region -[Eventos]-
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchControl_Load(object sender, EventArgs e)
        {
            //nada
        }

        /// <summary>
        /// Evento click del boton buscar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SearchArgs args = new SearchArgs();
            args.ItemSeleccionado = this.ItemSelecionado;
            OnSearch(args);
        }
        #endregion


        #region -[Methods]-
        protected virtual void OnSearch(SearchArgs e)
        {
            if (ClickSearch != null)
                ClickSearch(this, e);
        }
        #endregion

    }

    /// <summary>
    /// Representa un item para agregar a un combo
    /// </summary>
    public class SearchItem
    {
        private string valueMember;
        private string displayMember;

        public string ValueMember
        {
            get { return valueMember; }
            set { valueMember = value; }
        }

        public string DisplayMember
        {
            get { return displayMember; }
            set { displayMember = value; }
        }
    }

    /// <summary>
    /// Representa al valor seleccionado 
    /// </summary>
    public class SelectedItem
    {
        private string campo;
        private string criterio;
        private string valor;

        public string Campo
        {
            get { return campo; }
            set { campo = value; }
        }

        public string Criterio
        {
            get { return criterio; }
            set { criterio = value; }
        }

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }

    /// <summary>
    /// Argumento del evento Search
    /// </summary>
    public class SearchArgs : EventArgs
    {
        SelectedItem itemSeleccionado;

        public SelectedItem ItemSeleccionado
        {
            get { return itemSeleccionado; }
            set { itemSeleccionado = value; }
        }
    }
}
