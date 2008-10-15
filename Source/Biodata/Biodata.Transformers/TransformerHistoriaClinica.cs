using System;
using System.Collections.Generic;
using System.Text;
using Biodata.Domain;
using Biodata.DTO;

namespace Biodata.Transformers
{
    public class TransformerHistoriaClinica
    {
        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static HistoriaClinica DTOToEntity(HistoriaClinicaDTO pHistoriaClinica)
        {

            HistoriaClinica pReturn = new HistoriaClinica();
            pReturn.ID = pHistoriaClinica.ID;
            pReturn.IdPaciente = pHistoriaClinica.IdPaciente;
            pReturn.AntecedentesFamiliares = pHistoriaClinica.AntecedentesFamiliares;
            pReturn.AntecedentesPersonales = pHistoriaClinica.AntecedentesPersonales;
            pReturn.DatosDeInteres = pHistoriaClinica.DatosDeInteres;
            if (pHistoriaClinica.IdPacienteLookup != null)
                pReturn.IdPacienteLookup = TransformerPaciente.DTOToEntity(pHistoriaClinica.IdPacienteLookup);

            //Consultas
            if (pHistoriaClinica.Consultas != null)
            {
                foreach (ConsultaDTO pObj in pHistoriaClinica.Consultas)
                {
                    pReturn.Consultas.Add(TransformerConsulta.DTOToEntity(pObj));
                }
            }

            return pReturn;
        }

        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static HistoriaClinicaDTO EntityToDTO(HistoriaClinica pHistoriaClinica)
        {

            HistoriaClinicaDTO pReturn = new HistoriaClinicaDTO();
            pReturn.ID = pHistoriaClinica.ID;
            pReturn.IdPaciente = pHistoriaClinica.IdPaciente;
            pReturn.AntecedentesFamiliares = pHistoriaClinica.AntecedentesFamiliares;
            pReturn.AntecedentesPersonales = pHistoriaClinica.AntecedentesPersonales;
            pReturn.DatosDeInteres = pHistoriaClinica.DatosDeInteres;
            if (pHistoriaClinica.IdPacienteLookup != null)
                pReturn.IdPacienteLookup = TransformerPaciente.EntityToDTO(pHistoriaClinica.IdPacienteLookup);

            //Consultas
            if (pHistoriaClinica.Consultas != null)
            {
                foreach (Consulta pObj in pHistoriaClinica.Consultas)
                {
                    pReturn.Consultas.Add(TransformerConsulta.EntityToDTO(pObj));
                }
            }

            return pReturn;
        }
    }
}
