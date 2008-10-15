using System;
using System.Collections.Generic;

namespace Biodata.Domain
{
    /// <summary>
    /// TipoEstudio object for NHibernate mapped table TipoEstudio.
    /// </summary>
    [Serializable]
    public class TipoEstudio : DomainObject<System.Int32>
    {


        private System.String _Nombre;
        private System.String _Descripcion;
        private System.String _EsquemaDatos;
        private IList<Estudio> _Estudios = new List<Estudio>();

        public TipoEstudio()
        {
        }

        public TipoEstudio(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Nombre {
             get { return _Nombre; }
             set { _Nombre = value;}
         }

         public virtual System.String Descripcion {
             get { return _Descripcion; }
             set { _Descripcion = value;}
         }

         public virtual System.String EsquemaDatos {
             get { return _EsquemaDatos; }
             set { _EsquemaDatos = value;}
         }

         public virtual IList<Estudio> Estudios{
             get { return _Estudios; }
             set { _Estudios = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
