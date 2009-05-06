using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// MarcaAudifono object for NHibernate mapped table MarcaAudifono.
    /// </summary>
    [Serializable]
    public class MarcaAudifono : DomainObject<System.Int32>
    {


        private System.String _Nombre;
        private List<Audifono> _Audifonos = new List<Audifono>();

        public MarcaAudifono()
        {
        }

        public MarcaAudifono(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Nombre {
             get { return _Nombre; }
             set { _Nombre = value;}
         }

         public virtual List<Audifono> Audifonos{
             get { return _Audifonos; }
             set { _Audifonos = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
