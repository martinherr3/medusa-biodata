using System;
using System.Collections.Generic;

namespace Biodata.DTO
{
    /// <summary>
    /// Molde object for NHibernate mapped table Molde.
    /// </summary>
    [Serializable]
    public class MoldeDTO : DomainObject<System.Int32>
    {


        private System.String _Descripcion;
        private List<MoldePacienteDTO> _Pacientes = new List<MoldePacienteDTO>();

        public MoldeDTO()
        {
        }

        public MoldeDTO(System.Int32 id)
        {
            base.ID = id;
        }

        public virtual System.String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public virtual List<MoldePacienteDTO> Pacientes
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
