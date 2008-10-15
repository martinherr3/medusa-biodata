using System;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace Biodata.DTO
{
    /// <summary>
    /// AudifonoPaciente object for NHibernate mapped table AudifonoPaciente.
    /// </summary>
    [Serializable]
    public class AudifonoPacienteDTO : DomainObject<AudifonoPacienteDTO.DomainObjectIDAudifonoPacienteDTO>
    {

        [Serializable]
        public class DomainObjectIDAudifonoPacienteDTO
        {
            public DomainObjectIDAudifonoPacienteDTO() { }

            private System.Int32 _IdAudifono;
            private System.Int32 _IdPaciente;

            public DomainObjectIDAudifonoPacienteDTO(System.Int32 idAudifono, System.Int32 idPaciente)
            {
                _IdAudifono = idAudifono;
                _IdPaciente = idPaciente;
            }

            public System.Int32 IdAudifono
            {
                get { return _IdAudifono; }
                //protected set { _IdAudifono = value;}
                set { _IdAudifono = value; }
            }

            public System.Int32 IdPaciente
            {
                get { return _IdPaciente; }
                //protected set { _IdPaciente = value;}
                set { _IdPaciente = value; }
            }


            public override bool Equals(object obj)
            {
                if (obj == this) return true;
                if (obj == null) return false;

                DomainObjectIDAudifonoPacienteDTO that = obj as DomainObjectIDAudifonoPacienteDTO;
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

        private AudifonoDTO _IdAudifonoLookup;
        private PacienteDTO _IdPacienteLookup;

        public AudifonoPacienteDTO()
        {
        }

        public AudifonoPacienteDTO(DomainObjectIDAudifonoPacienteDTO id)
        {

            base.ID = id;
        }

        public virtual System.Int32 IdAudifono
        {
            get { return base.id.IdAudifono; }
        }

        public virtual System.Int32 IdPaciente
        {
            get { return base.id.IdPaciente; }
        }

        public virtual AudifonoDTO IdAudifonoLookup
        {
            get { return _IdAudifonoLookup; }
            set { _IdAudifonoLookup = value; }
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
