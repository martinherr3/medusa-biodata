using System;
using System.Collections.Generic;

namespace Medusa.Biodata.Domain
{
    /// <summary>
    /// Estudio object for NHibernate mapped table Estudio.
    /// </summary>
    [Serializable]
    public class Estudio : DomainObject<System.Int32>
    {


        private System.DateTime? _FechaEstudio;
        private System.String _Datos;
        private System.String _Descripcion;
        private System.Int32? _IdConsulta;
        private System.Int32? _IdTipoEstudio;
        private Consulta _IdConsultaLookup;
        private TipoEstudio _IdTipoEstudioLookup;

        public Estudio()
        {
        }

        public Estudio(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.DateTime? FechaEstudio {
             get { return _FechaEstudio; }
             set { _FechaEstudio = value;}
         }

         public virtual System.String Datos {
             get { return _Datos; }
             set { _Datos = value;}
         }

         public virtual System.String Descripcion {
             get { return _Descripcion; }
             set { _Descripcion = value;}
         }

         public virtual System.Int32? IdConsulta {
             get { return _IdConsulta; }
             set { _IdConsulta = value;}
         }

         public virtual System.Int32? IdTipoEstudio {
             get { return _IdTipoEstudio; }
             set { _IdTipoEstudio = value;}
         }

         public virtual Consulta IdConsultaLookup{
             get { return _IdConsultaLookup; }
             set { _IdConsultaLookup = value;}
         }

         public virtual TipoEstudio IdTipoEstudioLookup{
             get { return _IdTipoEstudioLookup; }
             set { _IdTipoEstudioLookup = value;}
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
