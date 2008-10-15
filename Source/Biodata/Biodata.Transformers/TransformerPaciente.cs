using System;
using System.Collections.Generic;
using System.Text;
using Biodata.Domain;
using Biodata.DTO;

namespace Biodata.Transformers
{
    public class TransformerPaciente
    {
        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static Paciente DTOToEntity(PacienteDTO pPaciente)
        {
            Paciente pReturn = new Paciente();
            pReturn.ID = pPaciente.ID;
            pReturn.Nombre = pPaciente.Nombre;
            pReturn.Apellido = pPaciente.Apellido;
            pReturn.Direccion = pPaciente.Direccion;
            pReturn.FechaNacimiento = pPaciente.FechaNacimiento;
            pReturn.NumDocumento = pPaciente.NumDocumento;
            pReturn.Sexo = pPaciente.Sexo;
            pReturn.IdObraSocial = pPaciente.IdObraSocial;
            if (pPaciente.IdObraSocialLookup != null)
                pReturn.IdObraSocialLookup = TransformerObraSocial.DTOToEntity(pPaciente.IdObraSocialLookup);
            //Audifonos
            if (pPaciente.Audifonos != null)
            {
                foreach (AudifonoPacienteDTO pObj in pPaciente.Audifonos)
                {
                    pReturn.Audifonos.Add(TransformerAudifonoPaciente.DTOToEntity(pObj));
                }
            }
            //HistoriasClinicas
            if (pPaciente.HistoriaClinicas != null)
            {
                foreach (HistoriaClinicaDTO pObj in pPaciente.HistoriaClinicas)
                {
                    pReturn.HistoriaClinicas.Add(TransformerHistoriaClinica.DTOToEntity(pObj));
                }
            }
            //Moldes
            if (pPaciente.Moldes != null)
            {
                foreach (MoldePacienteDTO pObj in pPaciente.Moldes)
                {
                    pReturn.Moldes.Add(TransformerMoldePaciente.DTOToEntity(pObj));
                }
            }

            return pReturn;
        }

        //Convierte una Entity de NHibernate en un objeto DTO, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static PacienteDTO EntityToDTO(Paciente pPaciente)
        {
            PacienteDTO pReturn = new PacienteDTO();
            pReturn.ID = pPaciente.ID;
            pReturn.Nombre = pPaciente.Nombre;
            pReturn.Apellido = pPaciente.Apellido;
            pReturn.Direccion = pPaciente.Direccion;
            pReturn.FechaNacimiento = pPaciente.FechaNacimiento;
            pReturn.NumDocumento = pPaciente.NumDocumento;
            pReturn.Sexo = pPaciente.Sexo;
            pReturn.IdObraSocial = pPaciente.IdObraSocial;
            if (pPaciente.IdObraSocialLookup != null)
                pReturn.IdObraSocialLookup = TransformerObraSocial.EntityToDTO(pPaciente.IdObraSocialLookup);
            //Audifonos
            if (pPaciente.Audifonos != null)
            {
                foreach (AudifonoPaciente pObj in pPaciente.Audifonos)
                {
                    pReturn.Audifonos.Add(TransformerAudifonoPaciente.EntityToDTO(pObj));
                }
            }
            //HistoriasClinicas
            if (pPaciente.HistoriaClinicas != null)
            {
                foreach (HistoriaClinica pObj in pPaciente.HistoriaClinicas)
                {
                    pReturn.HistoriaClinicas.Add(TransformerHistoriaClinica.EntityToDTO(pObj));
                }
            }
            //Moldes
            if (pPaciente.Moldes != null)
            {
                foreach (MoldePaciente pObj in pPaciente.Moldes)
                {
                    pReturn.Moldes.Add(TransformerMoldePaciente.EntityToDTO(pObj));
                }
            }

            return pReturn;
        }
    }
}
