using System;
using System.Collections.Generic;

namespace Medusa.Biodata.Domain
{
    /// <summary>
    /// MoldePaciente object for NHibernate mapped table MoldePaciente.
    /// </summary>
    [Serializable]
    public class MoldePaciente : DomainObject<MoldePaciente.DomainObjectID>
    {

        [Serializable]
        public class DomainObjectID
        {
            public DomainObjectID() {}

            private System.Int32 _IdMolde;
            private System.Int32 _IdPaciente;

            public DomainObjectID(System.Int32 idMolde, System.Int32 idPaciente)
            {
                _IdMolde = idMolde;
                _IdPaciente = idPaciente;
            }

         public System.Int32 IdMolde {
             get { return _IdMolde; }
             protected set { _IdMolde = value;}
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
                    if (this.IdMolde != that.IdMolde) return false;
                    if (this.IdPaciente != that.IdPaciente) return false;

                    return true;
                }

            }

            public override int GetHashCode()
            {
                return IdMolde.GetHashCode() ^ IdPaciente.GetHashCode();
            }

        }

        private Molde _IdMoldeLookup;
        private Paciente _IdPacienteLookup;

        public MoldePaciente()
        {
        }

        public MoldePaciente(DomainObjectID id)
        {
            base.ID = id;
        }

         public virtual System.Int32 IdMolde {
             get { return base.id.IdMolde; }
         }

         public virtual System.Int32 IdPaciente {
             get { return base.id.IdPaciente; }
         }

         public virtual Molde IdMoldeLookup{
             get { return _IdMoldeLookup; }
             set { _IdMoldeLookup = value;}
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
