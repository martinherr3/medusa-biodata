using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Biodata.Domain
{
    /// <summary>
    /// MoldePaciente object for NHibernate mapped table MoldePaciente.
    /// </summary>
    [Serializable]
    public class MoldePaciente : DomainObject<MoldePaciente.DomainObjectIDMoldePaciente>
    {

        [Serializable]
        public class DomainObjectIDMoldePaciente
        {
            public DomainObjectIDMoldePaciente() {}

            private System.Int32 _IdMolde;
            private System.Int32 _IdPaciente;

            public DomainObjectIDMoldePaciente(System.Int32 idMolde, System.Int32 idPaciente)
            {
                _IdMolde = idMolde;
                _IdPaciente = idPaciente;
            }

         public System.Int32 IdMolde {
             get { return _IdMolde; }
             set { _IdMolde = value;}
         }

         public System.Int32 IdPaciente {
             get { return _IdPaciente; }
             set { _IdPaciente = value;}
         }


            public override bool Equals(object obj)
            {
                if (obj == this) return true;
                if (obj == null) return false;

                DomainObjectIDMoldePaciente that = obj as DomainObjectIDMoldePaciente;
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

        public MoldePaciente(DomainObjectIDMoldePaciente id)
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
