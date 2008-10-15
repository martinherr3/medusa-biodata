using System;
using System.Collections.Generic;
using System.Text;
using Biodata.Domain;
using Biodata.DTO;

namespace Biodata.Transformers
{
    public class TransformerConsulta
    {
        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static Consulta DTOToEntity(ConsultaDTO pConsulta)
        {
            Consulta pReturn = new Consulta();

            pReturn.ID = pConsulta.ID;
            pReturn.Diagnostico = pConsulta.Diagnostico;
            pReturn.FechaConsulta = pConsulta.FechaConsulta;
            pReturn.IdHistoriaClinica = pConsulta.IdHistoriaClinica;
            if (pConsulta.IdHistoriaClinicaLookup != null)
            {
                pReturn.IdHistoriaClinicaLookup = TransformerHistoriaClinica.DTOToEntity(pConsulta.IdHistoriaClinicaLookup);
            }


            //Estudios
            if (pConsulta.Estudios != null)
            {
                foreach (EstudioDTO pObj in pConsulta.Estudios)
                {
                    pReturn.Estudios.Add(TransformerEstudio.DTOToEntity(pObj));
                }
            }

            return pReturn;
        }

        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static ConsultaDTO EntityToDTO(Consulta pConsulta)
        {
            ConsultaDTO pReturn = new ConsultaDTO();

            pReturn.ID = pConsulta.ID;
            pReturn.Diagnostico = pConsulta.Diagnostico;
            pReturn.FechaConsulta = pConsulta.FechaConsulta;
            pReturn.IdHistoriaClinica = pConsulta.IdHistoriaClinica;
            if (pConsulta.IdHistoriaClinicaLookup != null)
            {
                pReturn.IdHistoriaClinicaLookup = TransformerHistoriaClinica.EntityToDTO(pConsulta.IdHistoriaClinicaLookup);
            }


            //Estudios
            if (pConsulta.Estudios != null)
            {
                foreach (Estudio pObj in pConsulta.Estudios)
                {
                    pReturn.Estudios.Add(TransformerEstudio.EntityToDTO(pObj));
                }
            }

            return pReturn;
        }
    }
}
