using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// AnamnesisListadoPregunta object for NHibernate mapped table AnamnesisListadoPregunta.
    /// </summary>
    [Serializable]
    public class AnamnesisListadoPregunta : DomainObject<System.Int32>
    {


        private System.String _Pregunta;
        private System.Int32? _ClasificacionPregunta;

        public AnamnesisListadoPregunta()
        {
        }

        public AnamnesisListadoPregunta(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Pregunta {
             get { return _Pregunta; }
             set { _Pregunta = value;}
         }

         public virtual System.Int32? ClasificacionPregunta {
             get { return _ClasificacionPregunta; }
             set { _ClasificacionPregunta = value;}
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
