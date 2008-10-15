using System;
using System.Collections.Generic;

namespace Biodata.DTO
{
    /// <summary>
    /// ObraSocial object for NHibernate mapped table ObraSocial.
    /// </summary>
    [Serializable]
    public class ObraSocialDTO : DomainObject<System.Int32>
    {


        private System.String _RazonSocial;
        private System.String _Direccion;
        private System.String _Contacto;
        private List<PacienteDTO> _Pacientes = new List<PacienteDTO>();

        public ObraSocialDTO()
        {
        }

        public ObraSocialDTO(System.Int32 id)
        {
            base.ID = id;
        }

        public virtual System.String RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }

        public virtual System.String Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public virtual System.String Contacto
        {
            get { return _Contacto; }
            set { _Contacto = value; }
        }

        public virtual List<PacienteDTO> Pacientes
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
