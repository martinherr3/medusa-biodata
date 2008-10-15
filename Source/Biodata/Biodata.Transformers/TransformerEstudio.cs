using System;
using System.Collections.Generic;
using System.Text;
using Biodata.Domain;
using Biodata.DTO;

namespace Biodata.Transformers
{
    public class TransformerEstudio
    {
        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static Estudio DTOToEntity(EstudioDTO pEstudio)
        {

            Estudio pReturn = new Estudio();

            pReturn.ID = pEstudio.ID;
            pReturn.Datos = pEstudio.Datos;
            pReturn.Descripcion = pEstudio.Descripcion;
            pReturn.FechaEstudio = pEstudio.FechaEstudio;
            pReturn.IdConsulta = pEstudio.IdConsulta;
            if (pEstudio.IdConsultaLookup != null)
                pReturn.IdConsultaLookup = TransformerConsulta.DTOToEntity(pEstudio.IdConsultaLookup);
            pReturn.IdTipoEstudio = pEstudio.IdTipoEstudio;
            if (pEstudio.IdTipoEstudioLookup != null)
                pReturn.IdTipoEstudioLookup = TransformerTipoEstudio.DTOToEntity(pEstudio.IdTipoEstudioLookup);

            return pReturn;
        }

        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static EstudioDTO EntityToDTO(Estudio pEstudio)
        {

            EstudioDTO pReturn = new EstudioDTO();

            pReturn.ID = pEstudio.ID;
            pReturn.Datos = pEstudio.Datos;
            pReturn.Descripcion = pEstudio.Descripcion;
            pReturn.FechaEstudio = pEstudio.FechaEstudio;
            pReturn.IdConsulta = pEstudio.IdConsulta;
            if (pEstudio.IdConsultaLookup != null)
                pReturn.IdConsultaLookup = TransformerConsulta.EntityToDTO(pEstudio.IdConsultaLookup);
            pReturn.IdTipoEstudio = pEstudio.IdTipoEstudio;
            if (pEstudio.IdTipoEstudioLookup != null)
                pReturn.IdTipoEstudioLookup = TransformerTipoEstudio.EntityToDTO(pEstudio.IdTipoEstudioLookup);

            return pReturn;
        }
    }
}
