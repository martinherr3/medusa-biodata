using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// Provincia object for NHibernate mapped table Provincia.
    /// </summary>
    [Serializable]
    public class Provincia : DomainObject<System.Int32>
    {


        private System.String _Descripcion;
        private IList<Ciudad> _Ciudads = new List<Ciudad>();

        public Provincia()
        {
        }

        public Provincia(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Descripcion {
             get { return _Descripcion; }
             set { _Descripcion = value;}
         }

         public virtual IList<Ciudad> Ciudads
         {
             get { return _Ciudads; }
             set { _Ciudads = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
