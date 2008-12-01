using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.FrontEnd.DTO;
using Medusa.Biodata.Domain;
using System.Collections;

namespace Medusa.Biodata.FrontEnd.Assembler
{
    public class PacienteAssembler : IAssembler<PacienteDTO, Paciente>
    {

        #region IAssembler<PacienteDTO,Paciente> Members

        public PacienteDTO CreateDTO(Paciente domain)
        {
            PacienteDTO dto = new PacienteDTO();
            dto.Nombre = domain.Nombre;
            dto.Apellido = domain.Apellido;
            dto.Direccion = domain.Direccion;
            dto.Comentario = domain.Comentario;
            dto.NumDocumento = domain.NumDocumento;
            if (domain.IdObraSocialLookup != null)
            {
                dto.ObraSocial = domain.IdObraSocialLookup.RazonSocial;
                dto.ObraSocialId = domain.IdObraSocialLookup.ID;
            }
            dto.Sexo = domain.Sexo;
            dto.ID = domain.ID;

            return dto;
        }

        public Paciente CreateDomainObject(PacienteDTO dto)
        {
            Paciente paciente = new Paciente();

            paciente.Nombre = dto.Nombre;
            paciente.Apellido = dto.Apellido;
            paciente.Comentario = dto.Comentario;
            paciente.Direccion = dto.Direccion;
            paciente.FechaNacimiento = dto.FechaNacimiento;
            paciente.ID = dto.ID;
            paciente.NumDocumento = dto.NumDocumento;
            paciente.Sexo = dto.Sexo;
            paciente.IdObraSocial = dto.ObraSocialId;

            return paciente;
        }

        public IList<PacienteDTO> CreateDTOGenericList(IList<Paciente> list)
        {
            IList<PacienteDTO> dtos = new List<PacienteDTO>();

            foreach (Paciente paciente in list)
            {
                dtos.Add(CreateDTO(paciente));
            }

            return dtos;
        }

        public IList CreateDTOArrayList(IList<Paciente> list)
        {
            IList dtos = new ArrayList();

            foreach (Paciente paciente in list)
            {
                dtos.Add(CreateDTO(paciente));
            }

            return dtos;
        }

        #endregion
    }
}
