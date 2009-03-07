using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Medusa.Biodata.FrontEnd.UserControls
{
    public partial class TextBoxPersonalizado : System.Windows.Forms.TextBox
    {
        public TextBoxPersonalizado()
        {
            InitializeComponent();
        }

        public TextBoxPersonalizado(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        private string _TipoPersonalFiltro;
        public string TipoPersonalFiltro
        {
            get { return _TipoPersonalFiltro; }
            set
            {
                _TipoPersonalFiltro = value;
                TipoDato = _tipoDato;
            }
        }

        // Array para los dígitos válidos 
        protected char[] digitos;

        private TipoDatos _tipoDato;

        // El tipo de datos que admite el control 
        public virtual TipoDatos TipoDato
        {
            get { return _tipoDato; }
            set
            {
                string s;
                _tipoDato = value;
                switch (_tipoDato)
                {
                    case TipoDatos.Binario:
                        s = "01";
                        break;
                    case TipoDatos.Entero:
                        s = "0123456789-+";
                        break;
                    case TipoDatos.Hexadecimal:
                        s = "0123456789ABCDEFabcdef";
                        break;
                    case TipoDatos.Moneda:
                        s = "0123456789-+,";
                        break;
                    case TipoDatos.Octal:
                        s = "01234567";
                        break;
                    case TipoDatos.Personal:
                        s = TipoPersonalFiltro;
                        break;
                    case TipoDatos.Letras:
                        s = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁáÉéÍíÓóÚú' ";
                        break;
                    case TipoDatos.LetrasSencillas:
                        s = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";
                        break;
                    case TipoDatos.LetrasYPersonal:
                        s = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁáÉéÍíÓóÚú' " + TipoPersonalFiltro;
                        break;
                    case TipoDatos.LetrasSencillasYPersonal:
                        s = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ " + TipoPersonalFiltro;
                        break;
                    case TipoDatos.LetrasYNumeros:
                        s = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁáÉéÍíÓóÚú'0123456789 ";
                        break;
                    case TipoDatos.LetrasYNumerosYPersonal:
                        s = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁáÉéÍíÓóÚú'0123456789 " + TipoPersonalFiltro;
                        break;
                    //case TipoDatos.Libre:
                    //    s = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZÁáÉéÍíÓóÚú'0123456789,;:.-_´{}Ç]*+`^[?'¿¡=)(/&%$·#@!|ºª<> ";
                    //    break;
                    default:
                        s = string.Empty;
                        break;
                }
                digitos = (s + Microsoft.VisualBasic.Strings.ChrW(8)).ToCharArray();
            }
        }

        //protected override void OnKeyPress(KeyEventArgs e)
        //{
        //    if (TeclaValida(e.KeyChar) == false)
        //    {
        //        e.Handled = true;
        //    }
        //    base.OnKeyPress(e);
        //}

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (TeclaValida(e.KeyChar) == false)
            {
                e.Handled = true;
            }

            base.OnKeyPress(e);
        }

        protected virtual bool TeclaValida(char c)
        {
            return (Array.IndexOf(digitos, c) > -1);
        }

        //Los tipos de datos válidos para el control 
        public enum TipoDatos
        {
            Moneda,
            // Números decimales 
            Entero,
            // Números enteros 
            Hexadecimal,
            // Números hexadecimales 
            Octal,
            // Números octales 
            Binario,
            // Números binarios 
            Personal,
            //Personalizado 
            Letras,
            //Letras 
            LetrasSencillas,
            //Letras 
            LetrasYPersonal,
            LetrasSencillasYPersonal,
            LetrasYNumeros,
            LetrasYNumerosYPersonal,
            Libre
        }

        public override string Text
        {
            get { return base.Text; }
            set
            {
                if (this.DesignMode && this.Text == "")
                {
                }
                //MyBase.Text = value 
                else
                {
                    System.Text.StringBuilder s = new System.Text.StringBuilder();
                    foreach (char c in value)
                    {
                        if (TeclaValida(c))
                        {
                            s.Append(c);
                        }
                    }
                    base.Text = s.ToString();
                }
            }
        }

    }
}
