using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// ObraSocialXPaciente object for NHibernate mapped table ObraSocialXPaciente.
    /// </summary>
    [Serializable]
    public class ObraSocialXPaciente : DomainObject<System.Int32>
    {


        private System.Int32 _IDPaciente;
        private System.Int32 _IDObraSocial;
        private System.String _NumeroAfiliado;
        private ObraSocial _IDObraSocialLookup;
        private Paciente _IDPacienteLookup;

        public ObraSocialXPaciente()
        {
        }

        public ObraSocialXPaciente(System.Int32 id)
        {
            base.ID = id;
        }

        public virtual System.Int32 IDPaciente
        {
            get { return _IDPaciente; }
            set { _IDPaciente = value; }
        }

        public virtual System.Int32 IDObraSocial
        {
            get { return _IDObraSocial; }
            set { _IDObraSocial = value; }
        }

        public virtual System.String NumeroAfiliado
        {
            get { return _NumeroAfiliado; }
            set { _NumeroAfiliado = value; }
        }

        public virtual ObraSocial IDObraSocialLookup
        {
            get { return _IDObraSocialLookup; }
            set { _IDObraSocialLookup = value; }
        }

        public virtual Paciente IDPacienteLookup
        {
            get { return _IDPacienteLookup; }
            set { _IDPacienteLookup = value; }
        }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

    }
}
