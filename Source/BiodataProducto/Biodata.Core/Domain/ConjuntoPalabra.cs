using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// ConjuntoPalabra object for NHibernate mapped table ConjuntoPalabra.
    /// </summary>
    [Serializable]
    public class ConjuntoPalabra : DomainObject<System.Int32>
    {


        private System.String _Descripcion;
        private System.String _Palabras;
        private System.Int32? _IDListadoPalabra;
        private ListadoPalabra _IDListadoPalabraLookup;

        public ConjuntoPalabra()
        {
        }

        public ConjuntoPalabra(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Descripcion {
             get { return _Descripcion; }
             set { _Descripcion = value;}
         }

         public virtual System.String Palabras {
             get { return _Palabras; }
             set { _Palabras = value;}
         }

         public virtual System.Int32? IDListadoPalabra {
             get { return _IDListadoPalabra; }
             set { _IDListadoPalabra = value;}
         }

         public virtual ListadoPalabra IDListadoPalabraLookup{
             get { return _IDListadoPalabraLookup; }
             set { _IDListadoPalabraLookup = value;}
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
