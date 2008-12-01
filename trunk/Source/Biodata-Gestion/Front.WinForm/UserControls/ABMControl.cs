using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

public delegate void EditEventHandler(object sender, EventArgs e);
public delegate void NewEventHandler(object sender, EventArgs e);
public delegate void DeleteEventHandler(object sender, EventArgs e);
public delegate void SelectEventHandler(object sender, EventArgs e);

namespace Medusa.Biodata.FrontEnd.UserControls
{
    public partial class ABMControl : UserControl
    {
        [ToolboxItem(true)]
        public event EditEventHandler ClickEdit;
        public event NewEventHandler ClickNew;
        public event DeleteEventHandler ClickDelete;
        public event SelectEventHandler ClickSelect;

        public ABMControl()
        {
            InitializeComponent();
        }

        public bool ButtonsEnabled
        {
            set 
            {
                btnEditar.Enabled = value;
                btnEliminar.Enabled = value;
                btnSeleccionar.Enabled = value;
                btnNuevo.Enabled = value;
            }
        }

        protected virtual void OnEdit(EventArgs e)
        {
            if (ClickEdit != null)
                ClickEdit(this, e);
        }

        protected virtual void OnSelect(EventArgs e)
        {
            if (ClickSelect != null)
                ClickSelect(this, e);
        }

        protected virtual void OnDelete(EventArgs e)
        {
            if (ClickDelete != null)
                ClickDelete(this, e);
        }

        protected virtual void OnNew(EventArgs e)
        {
            if (ClickNew != null)
                ClickNew(this, e);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            OnEdit(new EventArgs());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            OnNew(new EventArgs());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            OnDelete(new EventArgs());
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OnSelect(new EventArgs());
        }

        public void SetModo(Estado modo)
        {
            switch (modo)
            {
                case Estado.EDITAR:
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;
                    btnNuevo.Enabled = false;
                    break;
                case Estado.ELIMINAR:
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;
                    btnNuevo.Enabled = false;
                    break;
                case Estado.NUEVO:
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;
                    btnNuevo.Enabled = false;
                    break;
                case Estado.HABILITAR_TODO:
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnSeleccionar.Enabled = true;
                    btnNuevo.Enabled = true;
                    break;
                case Estado.DESHABILITAR_TODO:
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnSeleccionar.Enabled = false;
                    btnNuevo.Enabled = false;
                    break;
            }
        }
    }

    public enum Estado
    {
        EDITAR,
        ELIMINAR,
        NUEVO,
        HABILITAR_TODO,
        DESHABILITAR_TODO
    }
}
