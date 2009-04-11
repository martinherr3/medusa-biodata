using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// Anamnesi object for NHibernate mapped table Anamnesis.
    /// </summary>
    [Serializable]
    public class Anamnesi : Estudio//DomainObject<System.Int32>
    {


        private System.String _Pregunta;
        private System.String _Respuesta;
        //private Estudio _IDEstudioLookup;

        public Anamnesi()
        {
        }

        public Anamnesi(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Pregunta {
             get { return _Pregunta; }
             set { _Pregunta = value;}
         }

         public virtual System.String Respuesta {
             get { return _Respuesta; }
             set { _Respuesta = value;}
         }

         //public virtual Estudio IDEstudioLookup{
         //    get { return _IDEstudioLookup; }
         //    set { _IDEstudioLookup = value;}
         //}


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
