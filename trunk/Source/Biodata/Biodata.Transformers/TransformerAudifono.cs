using System;
using System.Collections.Generic;
using System.Text;
using Biodata.Domain;
using Biodata.DTO;

namespace Biodata.Transformers
{
    public class TransformerAudifono
    {
        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static Audifono DTOToEntity(AudifonoDTO pAudifono)
        {

            Audifono pReturn = new Audifono();

            pReturn.ID = pAudifono.ID;
            pReturn.Descripcion = pAudifono.Descripcion;

            //Paciente-Audifonos
            if (pAudifono.Pacientes != null)
            {
                foreach (AudifonoPacienteDTO pObj in pAudifono.Pacientes)
                {
                    pReturn.Pacientes.Add(TransformerAudifonoPaciente.DTOToEntity(pObj));
                }

            }

            return pReturn;
        }

        //Convierte un objeto Entity  de NHibernate en un DTO, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static AudifonoDTO EntityToDTO(Audifono pAudifono)
        {

            AudifonoDTO pReturn = new AudifonoDTO();

            pReturn.ID = pAudifono.ID;
            pReturn.Descripcion = pAudifono.Descripcion;

            //Paciente-Audifonos
            if (pAudifono.Pacientes != null)
            {
                foreach (AudifonoPaciente pObj in pAudifono.Pacientes)
                {
                    pReturn.Pacientes.Add(TransformerAudifonoPaciente.EntityToDTO(pObj));
                }

            }

            return pReturn;
        }
    }
}
