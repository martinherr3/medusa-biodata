using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// AnamnesisPregunta object for NHibernate mapped table AnamnesisPreguntas.
    /// </summary>
    [Serializable]
    public class AnamnesisPregunta : DomainObject<System.Int32>
    {


        private System.Int32 _IDEstudio;
        private System.String _Pregunta;
        private System.String _Respuesta;
        private Anamnesi _IDEstudioLookup;

        public AnamnesisPregunta()
        {
        }

        public AnamnesisPregunta(System.Int32 id)
        {
            base.ID = id;
        }

        public virtual System.Int32 IDEstudio
        {
            get { return _IDEstudio; }
            set { _IDEstudio = value; }
        }

        public virtual System.String Pregunta
        {
            get { return _Pregunta; }
            set { _Pregunta = value; }
        }

        public virtual System.String Respuesta
        {
            get { return _Respuesta; }
            set { _Respuesta = value; }
        }

        public virtual Anamnesi IDEstudioLookup
        {
            get { return _IDEstudioLookup; }
            set { _IDEstudioLookup = value; }
        }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
