using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// ListadoPalabra object for NHibernate mapped table ListadoPalabra.
    /// </summary>
    [Serializable]
    public class ListadoPalabra : DomainObject<System.Int32>
    {


        private System.String _Descripcion;
        private IList<ConjuntoPalabra> _ConjuntoPalabras = new List<ConjuntoPalabra>();
        private IList<LogoAudiometria> _LogoAudiometrias = new List<LogoAudiometria>();

        public ListadoPalabra()
        {
        }

        public ListadoPalabra(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Descripcion {
             get { return _Descripcion; }
             set { _Descripcion = value;}
         }

         public virtual IList<ConjuntoPalabra> ConjuntoPalabras
         {
             get { return _ConjuntoPalabras; }
             set { _ConjuntoPalabras = value; }
         }

         public virtual IList<LogoAudiometria> LogoAudiometrias
         {
             get { return _LogoAudiometrias; }
             set { _LogoAudiometrias = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
