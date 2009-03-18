using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// Recordatorio object for NHibernate mapped table Recordatorio.
    /// </summary>
    [Serializable]
    public class Recordatorio : DomainObject<System.Int32>
    {


        private System.DateTime? _FechaRecordatorio;
        private System.String _Descripcion;
        private System.Int32? _IDVinculado;
        private System.Int32? _TipoVinculado;
        private System.String _TipoVinculadoString;

      

        public Recordatorio()
        {
        }

        public Recordatorio(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.DateTime? FechaRecordatorio {
             get { return _FechaRecordatorio; }
             set { _FechaRecordatorio = value;}
         }

         public virtual System.String Descripcion {
             get { return _Descripcion; }
             set { _Descripcion = value;}
         }

         public virtual System.Int32? IDVinculado {
             get { return _IDVinculado; }
             set { _IDVinculado = value;}
         }

         public virtual System.Int32? TipoVinculado {
             get { return _TipoVinculado; }
             set { 
                 _TipoVinculado = value;

                 switch (value)
                 {
                     case 0:
                         TipoVinculadoString = "Personal";
                         break;
                     case 1:
                         TipoVinculadoString = "Proxima Limpieza";
                         break;
                     case 2:
                         TipoVinculadoString = "Proximo Service";
                         break;
                     //case default:
                     //     TipoVinculadoString = "Personal";
                 }
             }
         }

         public virtual System.String TipoVinculadoString
         {
             get { return _TipoVinculadoString; }
             set { _TipoVinculadoString = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }



     }
}
