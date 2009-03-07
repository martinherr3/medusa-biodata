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
             set { _TipoVinculado = value;}
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
