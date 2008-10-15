using System;
using System.Collections.Generic;
using System.Text;
using Biodata.Domain;
using Biodata.DTO;

namespace Biodata.Transformers
{
    public class TransformerMoldePaciente
    {
        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static MoldePaciente DTOToEntity(MoldePacienteDTO pMoldePaciente)
        {

            MoldePaciente.DomainObjectIDMoldePaciente pObjeto = new MoldePaciente.DomainObjectIDMoldePaciente();
            pObjeto.IdMolde = pMoldePaciente.IdMolde;
            pObjeto.IdPaciente = pMoldePaciente.IdPaciente;

            MoldePaciente pReturn = new MoldePaciente(pObjeto);

            return pReturn;
        }

        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static MoldePacienteDTO EntityToDTO(MoldePaciente pMoldePaciente)
        {

            MoldePacienteDTO.DomainObjectIDMoldePacienteDTO pObjeto = new MoldePacienteDTO.DomainObjectIDMoldePacienteDTO();
            pObjeto.IdMolde = pMoldePaciente.IdMolde;
            pObjeto.IdPaciente = pMoldePaciente.IdPaciente;

            MoldePacienteDTO pReturn = new MoldePacienteDTO(pObjeto);

            return pReturn;
        }
    }
}
