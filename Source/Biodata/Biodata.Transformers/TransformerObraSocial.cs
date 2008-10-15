using System;
using System.Collections.Generic;
using System.Text;
using Biodata.Domain;
using Biodata.DTO;

namespace Biodata.Transformers
{
    public class TransformerObraSocial
    {
        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static ObraSocial DTOToEntity(ObraSocialDTO pObraSocial)
        {

            ObraSocial pReturn = new ObraSocial();
            pReturn.ID = pObraSocial.ID;
            pReturn.RazonSocial = pObraSocial.RazonSocial;
            pReturn.Direccion = pObraSocial.Direccion;
            pReturn.Contacto = pObraSocial.Contacto;

            //Audifonos
            if (pObraSocial.Pacientes != null)
            {
                foreach (PacienteDTO pObj in pObraSocial.Pacientes)
                {
                    pReturn.Pacientes.Add(TransformerPaciente.DTOToEntity(pObj));
                }
            }


            return pReturn;
        }

        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static ObraSocialDTO EntityToDTO(ObraSocial pObraSocial)
        {

            ObraSocialDTO pReturn = new ObraSocialDTO();
            pReturn.ID = pObraSocial.ID;
            pReturn.RazonSocial = pObraSocial.RazonSocial;
            pReturn.Direccion = pObraSocial.Direccion;
            pReturn.Contacto = pObraSocial.Contacto;

            //Audifonos
            if (pObraSocial.Pacientes != null)
            {
                foreach (Paciente pObj in pObraSocial.Pacientes)
                {
                    pReturn.Pacientes.Add(TransformerPaciente.EntityToDTO(pObj));
                }
            }


            return pReturn;
        }
    }
}
