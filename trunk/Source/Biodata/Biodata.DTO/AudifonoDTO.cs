using System;
using System.Collections.Generic;

namespace Biodata.DTO
{
    /// <summary>
    /// Audifono object for NHibernate mapped table Audifono.
    /// </summary>
    [Serializable]
    public class AudifonoDTO : DomainObject<System.Int32>
    {


        private System.String _Descripcion;
        private List<AudifonoPacienteDTO> _Pacientes = new List<AudifonoPacienteDTO>();

        public AudifonoDTO()
        {
        }

        public AudifonoDTO(System.Int32 id)
        {
            base.ID = id;
        }

        public virtual System.String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public virtual List<AudifonoPacienteDTO> Pacientes
        {
            get { return _Pacientes; }
            set { _Pacientes = value; }
        }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

    }
}
