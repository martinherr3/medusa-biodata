using System;
using System.Collections.Generic;
using System.ComponentModel;
using Medusa.Architecture.ServiceInterfaceWrappers;
using Medusa.Architecture.CommonEntities;

namespace Biodata.DTO
{
    /// <summary>
    /// Paciente object for NHibernate mapped table Paciente.
    /// </summary>

    [Serializable]
    public class PacienteDTO : DomainObject<System.Int32>
    {

        private System.String _Nombre;
        private System.String _Apellido;
        private System.String _Direccion;
        private System.String _FechaNacimiento;
        private System.String _NumDocumento;
        private System.String _Sexo;
        private System.Int32? _IdObraSocial;
        private System.String _Comentario;
        private ObraSocialDTO _IdObraSocialLookup;
        private List<AudifonoPacienteDTO> _Audifonos = new List<AudifonoPacienteDTO>();
        private List<HistoriaClinicaDTO> _HistoriaClinicas = new List<HistoriaClinicaDTO>();
        private List<MoldePacienteDTO> _Moldes = new List<MoldePacienteDTO>();

        public PacienteDTO()
        {

        }

        public PacienteDTO(System.Int32 id)
        {
            base.ID = id;
        }

        public virtual System.String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public virtual System.String Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public virtual System.String Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public virtual System.String FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        public virtual System.String NumDocumento
        {
            get { return _NumDocumento; }
            set { _NumDocumento = value; }
        }

        public virtual System.String Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }

        public virtual System.Int32? IdObraSocial
        {
            get { return _IdObraSocial; }
            set { _IdObraSocial = value; }
        }

        public virtual System.String Comentario
        {
            get { return _Comentario; }
            set { _Comentario = value; }
        }

        public virtual ObraSocialDTO IdObraSocialLookup
        {
            get { return _IdObraSocialLookup; }
            set { _IdObraSocialLookup = value; }
        }

        public virtual List<AudifonoPacienteDTO> Audifonos
        {
            get { return _Audifonos; }
            set { _Audifonos = value; }
        }

        public virtual List<HistoriaClinicaDTO> HistoriaClinicas
        {
            get { return _HistoriaClinicas; }
            set { _HistoriaClinicas = value; }
        }

        public virtual List<MoldePacienteDTO> Moldes
        {
            get { return _Moldes; }
            set { _Moldes = value; }
        }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }


        /// <summary>
        /// Inserta Pacienye.
        /// </summary>
        /// <returns></returns>
        public Int32 Insertar()
        {
            ResponseService<Int32> wResul = new Wrapper().ExecuteService<PacienteDTO, ResponseService<Int32>>("BDPacienteInsertService", this);
            if (wResul.ServiceError.HasError)
            {
                throw new Exception(wResul.ServiceError.Mensaje);
            }
            else
            {
                return wResul.ServiceData;
            }

        }

        /// <summary>
        /// Elimina Paciente.
        /// </summary>
        /// <returns></returns>
        public Int32 Eliminar()
        {
            ResponseService<Int32> wResul = new Wrapper().ExecuteService<PacienteDTO, ResponseService<Int32>>("BDPacienteDeleteService", this);
            if (wResul.ServiceError.HasError)
            {
                throw new Exception(wResul.ServiceError.Mensaje);
            }
            else
            {
                return wResul.ServiceData;
            }
        }

        /// <summary>
        /// Modifica Paciente.
        /// </summary>
        /// <returns></returns>
        public Int32 Modificar()
        {
            ResponseService<Int32> wResul = new Wrapper().ExecuteService<PacienteDTO, ResponseService<Int32>>("BDPacienteUpdateService", this);
            if (wResul.ServiceError.HasError)
            {
                throw new Exception(wResul.ServiceError.Mensaje);
            }
            else
            {
                return wResul.ServiceData;
            }
        }

        /// <summary>
        /// Llena una lista de CajaDiaria.
        /// </summary>
        /// <param name="pEntidad">Criterio de filtro.</param>
        public List<PacienteDTO> Llenar()
        {

            ResponseService<List<PacienteDTO>> wResul = new Wrapper().ExecuteService<PacienteDTO, ResponseService<List<PacienteDTO>>>("BDPacienteSearchService", this);
            if (wResul.ServiceError.HasError)
            {
                throw new Exception(wResul.ServiceError.Mensaje);
            }
            else
            {
                return wResul.ServiceData;
            }
        }
    }
}
