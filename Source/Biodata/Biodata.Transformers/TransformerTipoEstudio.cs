using System;
using System.Collections.Generic;
using System.Text;
using Biodata.Domain;
using Biodata.DTO;

namespace Biodata.Transformers
{
    public class TransformerTipoEstudio
    {
        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static TipoEstudio DTOToEntity(TipoEstudioDTO pTipoEstudio)
        {

            TipoEstudio pReturn = new TipoEstudio();

            pReturn.ID = pTipoEstudio.ID;
            pReturn.Descripcion = pTipoEstudio.Descripcion;
            pReturn.EsquemaDatos = pTipoEstudio.EsquemaDatos;
            pReturn.Nombre = pTipoEstudio.Nombre;

            //Estudios
            if (pTipoEstudio.Estudios != null)
            {
                foreach (EstudioDTO pObj in pTipoEstudio.Estudios)
                {
                    pReturn.Estudios.Add(TransformerEstudio.DTOToEntity(pObj));
                }
            }

            return pReturn;
        }

        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static TipoEstudioDTO EntityToDTO(TipoEstudio pTipoEstudio)
        {

            TipoEstudioDTO pReturn = new TipoEstudioDTO();

            pReturn.ID = pTipoEstudio.ID;
            pReturn.Descripcion = pTipoEstudio.Descripcion;
            pReturn.EsquemaDatos = pTipoEstudio.EsquemaDatos;
            pReturn.Nombre = pTipoEstudio.Nombre;

            //Estudios
            if (pTipoEstudio.Estudios != null)
            {
                foreach (Estudio pObj in pTipoEstudio.Estudios)
                {
                    pReturn.Estudios.Add(TransformerEstudio.EntityToDTO(pObj));
                }
            }

            return pReturn;
        }
    }
}
