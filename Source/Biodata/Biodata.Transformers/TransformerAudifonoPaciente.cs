using System;
using System.Collections.Generic;
using System.Text;
using Biodata.Domain;
using Biodata.DTO;

namespace Biodata.Transformers
{
    public class TransformerAudifonoPaciente
    {
        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static AudifonoPaciente DTOToEntity(AudifonoPacienteDTO pAudifonoPaciente)
        {

            AudifonoPaciente.DomainObjectIDAudifonoPaciente pObjeto = new AudifonoPaciente.DomainObjectIDAudifonoPaciente();

            pObjeto.IdAudifono = pAudifonoPaciente.IdAudifono;
            pObjeto.IdPaciente = pAudifonoPaciente.IdPaciente;

            AudifonoPaciente pReturn = new AudifonoPaciente(pObjeto);

            return pReturn;
        }

        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static AudifonoPacienteDTO EntityToDTO(AudifonoPaciente pAudifonoPaciente)
        {

            AudifonoPacienteDTO.DomainObjectIDAudifonoPacienteDTO pObjeto = new AudifonoPacienteDTO.DomainObjectIDAudifonoPacienteDTO();

            pObjeto.IdAudifono = pAudifonoPaciente.IdAudifono;
            pObjeto.IdPaciente = pAudifonoPaciente.IdPaciente;

            AudifonoPacienteDTO pReturn = new AudifonoPacienteDTO(pObjeto);

            return pReturn;
        }
    }
}
