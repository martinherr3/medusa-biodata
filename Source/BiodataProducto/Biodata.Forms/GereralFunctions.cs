﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;

namespace Mds.Biodata.Forms
{
    public class GereralFunctions
    {
        private static frmPrincipal woPrincipal;
        public static frmPrincipal Principal
        {
            get { return woPrincipal; }
            set { woPrincipal = value; }
        } 


        /// <summary> 
        /// Abre un Formulario y lo coloca en una TabPage dentro del TabControl indicado. 
        /// </summary> 
        /// <param name="frm">Instancia del formulario que se desea abrir.</param> 
        /// <param name="tab">TabControl donde se desea alojar el formulario.</param> 
        /// <param name="TituloTab">Name del archivo de recursos que indica el titulo de la TabPage.</param> 
        /// <remarks></remarks> 
        public static void AbrirFormulario(frmBase frm, TabControl tab, string TituloTab)
        {
            AbrirFormulario(frm, tab, TituloTab, DockStyle.Fill, false, false);
        }

        /// <summary> 
        /// Abre un Formulario y lo coloca en una TabPage dentro del TabControl indicado. 
        /// </summary> 
        /// <param name="frm">Instancia del formulario que se desea abrir.</param> 
        /// <param name="tab">TabControl donde se desea alojar el formulario.</param> 
        /// <param name="TituloTab">Name del archivo de recursos que indica el titulo de la TabPage.</param> 
        /// <param name="pDock">Estilo de Llenado.</param> 
        /// <remarks></remarks> 
        public static void AbrirFormulario(frmBase frm, TabControl tab, string TituloTab, DockStyle pDock)
        {
            AbrirFormulario(frm, tab, TituloTab, pDock, false, false);
            //frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None 
            //frm.TopLevel = False 
            //frm.Dock = pDock 
            //frm.Principal = tab.Parent.Parent.Parent 
            //Dim p As New TabPage 
            //p.Controls.Add(frm) 
            //Dim idioma As New ManejadorIdioma("Prominente.DocumentExplorer.FrontEnd", "rsfIdioma") 
            //p.Text = idioma.GetResource(TituloTab, True) 
            //tab.Controls.Add(p) 
            //tab.SelectedTab = p 
            //frm.Show() 
        }

        /// <summary> 
        /// Abre un Use Control y lo coloca en una SplitterPanel. 
        /// </summary> 
        /// <param name="use">Instancia del Use Control que se desea abrir.</param> 
        /// <param name="myPanel">SplitterPanel donde se desea alojar el Use Control.</param> 
        /// <param name="pDock">Estilo de Llenado.</param> 
        public static void AbrirFormulario(UserControl use, SplitterPanel myPanel, DockStyle pDock)
        {
            //Dim wB As Boolean = False 
            //Dim p As TabPage = BuscarFormulario(CType(myPanel.Parent.Parent.Parent.Parent, frmPrincipalForm).tbc, "ArbolDirectorios") 

            //If Not p Is Nothing Then 
            // If Not TypeOf (use) Is useArbolDirectorios Then 
            // CType(p.Controls(0), Form).Close() 
            // CType(myPanel.Parent.Parent.Parent.Parent, frmPrincipalForm).tbc.Controls.Remove(p) 
            // Else 
            // wB = True 
            // End If 
            //End If 
            //If Not wB Then 
            myPanel.Controls.Clear();
            use.Dock = pDock;
            myPanel.Controls.Add(use);
            //End If 
        }

        /// <summary> 
        /// Abre un Formulario y lo coloca en una TabPage dentro del TabControl indicado. 
        /// </summary> 
        /// <param name="frm">Instancia del formulario que se desea abrir.</param> 
        /// <param name="tab">TabControl donde se desea alojar el formulario.</param> 
        /// <param name="TituloTab">Name del archivo de recursos que indica el titulo de la TabPage.</param> 
        /// <param name="pDock">Estilo de Llenado.</param> 
        /// <param name="NuevoTab">Indica si se agrega un nuevo tab para el formulario.</param> 
        /// <param name="RefrescarExistente">Indica se refresca el formulario en el tab.</param> 
        public static void AbrirFormulario(frmBase frm, TabControl tab, string TituloTab, DockStyle pDock, bool NuevoTab, bool RefrescarExistente)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = pDock;
            frm.Principal = (Form)tab.Parent.Parent.Parent;
            //////////////////////////////////////////////////////////////////////////// 
            //AGREGAR EL CONTROL DE ACCESO A USUARIOS 
            //Niega el acceso a ciertas ventanas dependiendo de los Perfiles del Usuario 
            //If frm.Name <> "frmPantallaBienvenida" Then 'Todos deben tener acceso a la Pantalla de Bienvenida 
            // If Not CType(frm.Principal, frmPrincipal).UsuarioLogueado.ValidarPermiso(frm.Name) Then 
            // MessageBox.Show("No tiene acceso a esta Funcionalidad", "Acceso Denegado", MessageBoxButtons.OK) 
            // Exit Sub 
            // End If 
            //End If 
            ////////////////////////////////////////////////////////////////////////////


            //Para agregar un menu contextual a cada tab
            ///////////////////////////////////////////////////////
            ContextMenuStrip cb = new ContextMenuStrip();
            cb.Items.Add("Cerrar");
            cb.Items.Add("Cerrar las otras pestañas");
            cb.Items.Add("Cerrar todas las pestañas");

            ((ToolStripItem)cb.Items[0]).Click += CloseOnly_Click;
            ((ToolStripItem)cb.Items[1]).Click += CloseOthers_Click;
            ((ToolStripItem)cb.Items[2]).Click += CloseAll_Click;

            TabPage p = new TabPage();
            p.ContextMenuStrip = cb;
            p.Controls.Add(frm);
            ///////////////////////////////////////////////////////


            //////////////////////////////////////////////////////////////////////////////////////////////////// 
            //AGREGAR EL MANEJADOR DE IDIOMA 
            //Dim idioma As New ManejadorIdioma("Prominente.DocumentExplorer.ManejadorDeIdioma", "rsfIdioma") 
            //p.Text = idioma.GetResource(TituloTab, True) 
            //////////////////////////////////////////////////////////////////////////////////////////////////// 
            p.Text = TituloTab;
            int i;
            bool Existe;
            Existe = false;
            for (i = 0; i <= tab.Controls.Count - 1; i++)
            {
                if (tab.Controls[i].Text == p.Text)
                {
                    Existe = true;
                    break; // TODO: might not be correct. Was : Exit For 
                }
            }

            if (NuevoTab)
            {
                tab.Controls.Add(p);
                tab.SelectedTab = p;
                frm.Show();
            }
            else
            {
                if (Existe)
                {
                    if (RefrescarExistente)
                    {
                        tab.Controls[i].Controls.Remove(tab.Controls[i].Controls[0]);
                        tab.Controls[i].Controls.Add(frm);
                        tab.SelectedTab = (TabPage)tab.Controls[i];
                        frm.Show();
                    }
                    else
                    {
                        tab.SelectedTab = (TabPage)tab.Controls[i];
                    }
                }
                else
                {
                    tab.Controls.Add(p);
                    tab.SelectedTab = p;
                    frm.Show();
                }
            }

        }

        private static void CloseOnly_Click(object sender, System.EventArgs e)
        {
            //frmPrincipal.tabPrincipal.TabPages.RemoveAt(frmPrincipal.tabPrincipal.SelectedIndex) 
            Principal.tbcPrincipal.TabPages.RemoveAt(Principal.tbcPrincipal.SelectedIndex);
        }

        private static void CloseOthers_Click(object sender, System.EventArgs e)
        {
            int totalPages = 0;
            totalPages = Principal.tbcPrincipal.TabPages.Count - 1;
            
            for (int i = 0; i <= totalPages; i++)
            {
                if (!(i == 0 | i == Principal.tbcPrincipal.SelectedIndex))
                {
                    Principal.tbcPrincipal.TabPages.RemoveAt(i);
                    i -= 1;
                    totalPages -= 1;
                }
                if (i == totalPages)
                {
                    break; // TODO: might not be correct. Was : Exit For 
                }
            }
        }


        private static void CloseAll_Click(object sender, System.EventArgs e)
        {
            int totalPages = 0;
            totalPages = Principal.tbcPrincipal.TabPages.Count - 1;
            for (int i = 0; i <= totalPages; i++)
            {
                if (!(i == 0))
                {
                    Principal.tbcPrincipal.TabPages.RemoveAt(i);
                    i -= 1;
                    totalPages -= 1;
                }
                if (i == totalPages)
                {
                    break; // TODO: might not be correct. Was : Exit For 
                }
            }
        } 


        public static TabPage BuscarFormulario(TabControl tab, string TituloTab)
        {
            //////////////////////////////////////////////////////////////////////////////////////////////////// 
            //AGREGAR EL MANEJADOR DE IDIOMA 
            //Dim idioma As New ManejadorIdioma("Prominente.DocumentExplorer.ManejadorDeIdioma", "rsfIdioma") 
            //Dim wText As String = idioma.GetResource(TituloTab, True) 
            //////////////////////////////////////////////////////////////////////////////////////////////////// 
            string wText = TituloTab;
            int i;
            bool Existe;
            Existe = false;
            TabPage p = new TabPage();
            for (i = 0; i <= tab.Controls.Count - 1; i++)
            {
                if (tab.Controls[i].Text == wText)
                {
                    Existe = true;
                    p = (TabPage)tab.Controls[i];
                    break; // TODO: might not be correct. Was : Exit For 
                }
            }
            if (Existe)
            {
                return p;
            }
            else
            {
                return null;
            }
        }

        /// <summary> 
        /// Indica si la pagina que contiene el formulario solicitado esta activa. 
        /// </summary> 
        /// <param name="frm">Instancia del formulario que se desea abrir.</param> 
        /// <param name="tab">TabControl donde se desea alojar el formulario.</param> 
        public static Boolean ValidarActivacionFRM(frmBase frm, TabControl tab)
        {
            try
            {
                int i;
                Boolean Existe;
                Existe = false;
                for (i = 0; i <= tab.SelectedTab.Controls.Count - 1; i++)
                {
                    if (tab.SelectedTab.Controls[i].Name == frm.Name)
                    {
                        Existe = true;
                        break; // TODO: might not be correct. Was : Exit For 
                    }
                }
                return Existe;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SoloLetras(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void SoloNumeros(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        //public static bool ValidarCodigoPostal(string pCodigo)
        //{
        //    int i;
        //    for (i = 0; i <= pCodigo.Length - 1; i++)
        //    {
        //        if (Information.IsNumeric(pCodigo(i)))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        public static string ConvertDataTableToXML(DataTable dtBuildSQL)
        {
            DataSet dsBuildSQL = new DataSet();

            StringBuilder sbSQL;
            StringWriter swSQL;
            string XMLformat;
            sbSQL = new StringBuilder();
            swSQL = new StringWriter(sbSQL);
            dsBuildSQL.Merge(dtBuildSQL);//, true, MissingSchemaAction.AddWithKey);
            dsBuildSQL.Tables[0].TableName = dtBuildSQL.ToString();
            foreach (DataColumn col in dsBuildSQL.Tables[0].Columns)
            {

                col.ColumnMapping = MappingType.Attribute;

            }
            dsBuildSQL.WriteXml(swSQL, XmlWriteMode.WriteSchema);
            XMLformat = sbSQL.ToString();
            return XMLformat;
        }

        public static Boolean ValidarNumero(String NumeroaValidar)
        {
            String Patron = "^[0-9]+$";
            Regex ExpresionRegular = new Regex(Patron);
            return ExpresionRegular.IsMatch(NumeroaValidar);
        }
    }
}
