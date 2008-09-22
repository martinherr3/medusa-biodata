using System;
using System.Collections.Generic;

namespace Medusa.Biodata.Domain
{
    /// <summary>
    /// AudifonoPaciente object for NHibernate mapped table AudifonoPaciente.
    /// </summary>
    [Serializable]
    public class AudifonoPaciente : DomainObject<AudifonoPaciente.DomainObjectID>
    {

        [Serializable]
        public class DomainObjectID
        {
            public DomainObjectID() {}

            private System.Int32 _IdAudifono;
            private System.Int32 _IdPaciente;

            public DomainObjectID(System.Int32 idAudifono, System.Int32 idPaciente)
            {
                _IdAudifono = idAudifono;
                _IdPaciente = idPaciente;
            }

         public System.Int32 IdAudifono {
             get { return _IdAudifono; }
             protected set { _IdAudifono = value;}
         }

         public System.Int32 IdPaciente {
             get { return _IdPaciente; }
             protected set { _IdPaciente = value;}
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
                    if (this.IdAudifono != that.IdAudifono) return false;
                    if (this.IdPaciente != that.IdPaciente) return false;

                    return true;
                }

            }

            public override int GetHashCode()
            {
                return IdAudifono.GetHashCode() ^ IdPaciente.GetHashCode();
            }

        }

        private Audifono _IdAudifonoLookup;
        private Paciente _IdPacienteLookup;

        public AudifonoPaciente()
        {
        }

        public AudifonoPaciente(DomainObjectID id)
        {
            base.ID = id;
        }

         public virtual System.Int32 IdAudifono {
             get { return base.id.IdAudifono; }
         }

         public virtual System.Int32 IdPaciente {
             get { return base.id.IdPaciente; }
         }

         public virtual Audifono IdAudifonoLookup{
             get { return _IdAudifonoLookup; }
             set { _IdAudifonoLookup = value;}
         }

         public virtual Paciente IdPacienteLookup{
             get { return _IdPacienteLookup; }
             set { _IdPacienteLookup = value;}
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
