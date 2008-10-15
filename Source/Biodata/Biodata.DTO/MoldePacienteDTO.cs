using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Biodata.DTO
{
    /// <summary>
    /// MoldePaciente object for NHibernate mapped table MoldePaciente.
    /// </summary>
    [Serializable]
    public class MoldePacienteDTO : DomainObject<MoldePacienteDTO.DomainObjectIDMoldePacienteDTO>
    {

        [Serializable]
        public class DomainObjectIDMoldePacienteDTO
        {
            public DomainObjectIDMoldePacienteDTO() { }

            private System.Int32 _IdMolde;
            private System.Int32 _IdPaciente;

            public DomainObjectIDMoldePacienteDTO(System.Int32 idMolde, System.Int32 idPaciente)
            {
                _IdMolde = idMolde;
                _IdPaciente = idPaciente;
            }

            public System.Int32 IdMolde
            {
                get { return _IdMolde; }
                set { _IdMolde = value; }
            }

            public System.Int32 IdPaciente
            {
                get { return _IdPaciente; }
                set { _IdPaciente = value; }
            }


            public override bool Equals(object obj)
            {
                if (obj == this) return true;
                if (obj == null) return false;

                DomainObjectIDMoldePacienteDTO that = obj as DomainObjectIDMoldePacienteDTO;
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

        private MoldeDTO _IdMoldeLookup;
        private PacienteDTO _IdPacienteLookup;

        public MoldePacienteDTO()
        {
        }

        public MoldePacienteDTO(DomainObjectIDMoldePacienteDTO id)
        {
            base.ID = id;
        }

        public virtual System.Int32 IdMolde
        {
            get { return base.id.IdMolde; }
        }

        public virtual System.Int32 IdPaciente
        {
            get { return base.id.IdPaciente; }
        }

        public virtual MoldeDTO IdMoldeLookup
        {
            get { return _IdMoldeLookup; }
            set { _IdMoldeLookup = value; }
        }

        public virtual PacienteDTO IdPacienteLookup
        {
            get { return _IdPacienteLookup; }
            set { _IdPacienteLookup = value; }
        }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

    }
}
