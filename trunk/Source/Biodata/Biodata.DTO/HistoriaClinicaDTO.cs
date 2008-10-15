using System;
using System.Collections.Generic;

namespace Biodata.DTO
{
    /// <summary>
    /// HistoriaClinica object for NHibernate mapped table HistoriaClinica.
    /// </summary>
    [Serializable]
    public class HistoriaClinicaDTO : DomainObject<System.Int32>
    {


        private System.String _AntecedentesFamiliares;
        private System.String _AntecedentesPersonales;
        private System.String _DatosDeInteres;
        private System.Int32 _IdPaciente;
        private PacienteDTO _IdPacienteLookup;
        private List<ConsultaDTO> _Consultas = new List<ConsultaDTO>();

        public HistoriaClinicaDTO()
        {
        }

        public HistoriaClinicaDTO(System.Int32 id)
        {
            base.ID = id;
        }

        public virtual System.String AntecedentesFamiliares
        {
            get { return _AntecedentesFamiliares; }
            set { _AntecedentesFamiliares = value; }
        }

        public virtual System.String AntecedentesPersonales
        {
            get { return _AntecedentesPersonales; }
            set { _AntecedentesPersonales = value; }
        }

        public virtual System.String DatosDeInteres
        {
            get { return _DatosDeInteres; }
            set { _DatosDeInteres = value; }
        }

        public virtual System.Int32 IdPaciente
        {
            get { return _IdPaciente; }
            set { _IdPaciente = value; }
        }

        public virtual PacienteDTO IdPacienteLookup
        {
            get { return _IdPacienteLookup; }
            set { _IdPacienteLookup = value; }
        }

        public virtual List<ConsultaDTO> Consultas
        {
            get { return _Consultas; }
            set { _Consultas = value; }
        }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

    }
}
