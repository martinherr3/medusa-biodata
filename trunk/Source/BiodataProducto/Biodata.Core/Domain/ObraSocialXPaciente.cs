using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// ObraSocialXPaciente object for NHibernate mapped table ObraSocialXPaciente.
    /// </summary>
    [Serializable]
    public class ObraSocialXPaciente : DomainObject<ObraSocialXPaciente.DomainObjectID>
    {

        [Serializable]
        public class DomainObjectID
        {
            public DomainObjectID() {}

            private System.Int32 _IDPaciente;
            private System.Int32 _IDObraSocial;

            public DomainObjectID(System.Int32 iDPaciente, System.Int32 iDObraSocial)
            {
                _IDPaciente = iDPaciente;
                _IDObraSocial = iDObraSocial;
            }

         public System.Int32 IDPaciente {
             get { return _IDPaciente; }
             set { _IDPaciente = value;}
         }

         public System.Int32 IDObraSocial {
             get { return _IDObraSocial; }
             set { _IDObraSocial = value;}
         }


            public override bool Equals(object obj)
            {
                if (obj == this) return true;
                if (obj == null) return false;

                DomainObjectID that = obj as DomainObjectID;
                if (that == null)
                {
                    return false;
                }
                else
                {
                    if (this.IDPaciente != that.IDPaciente) return false;
                    if (this.IDObraSocial != that.IDObraSocial) return false;

                    return true;
                }

            }

            public override int GetHashCode()
            {
                return IDPaciente.GetHashCode() ^ IDObraSocial.GetHashCode();
            }

        }

        private System.String _NumeroAfiliado;
        private ObraSocial _IDObraSocialLookup;
        private Paciente _IDPacienteLookup;

        public ObraSocialXPaciente()
        {
            base.ID = new DomainObjectID();
        }

        public ObraSocialXPaciente(DomainObjectID id)
        {
            base.ID = id;
        }

         public virtual System.Int32 IDPaciente {
             get { return base.id.IDPaciente; }
             set { base.ID.IDPaciente = value; }
         }

         public virtual System.Int32 IDObraSocial {
             get { return base.id.IDObraSocial; }
             set { base.ID.IDObraSocial = value; }
         }

         public virtual System.String NumeroAfiliado {
             get { return _NumeroAfiliado; }
             set { _NumeroAfiliado = value;}
         }

         public virtual ObraSocial IDObraSocialLookup{
             get { return _IDObraSocialLookup; }
             set { _IDObraSocialLookup = value;}
         }

         public virtual Paciente IDPacienteLookup{
             get { return _IDPacienteLookup; }
             set { _IDPacienteLookup = value;}
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
