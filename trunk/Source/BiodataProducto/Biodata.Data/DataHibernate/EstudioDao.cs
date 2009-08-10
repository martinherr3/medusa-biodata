using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;
using NHibernate.Expression;

namespace Mds.Biodata.Data
{
    public class EstudioDao : AbstractNHibernateDao<Estudio, System.Int32>, IEstudioDao
    {
        public EstudioDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }

        public List<Estudio> GetEstudiosByNombre(String pNombre, DateTime? pFechaEstudioDesde, DateTime? pFechaEstudioHasta, Int32? pTipoEstudio)
        {
            if (pTipoEstudio == null)
            {
                ICriterion[] criterios = { Expression.Like("Nombre", pNombre, MatchMode.Start), Expression.Between("FechaEstudio", pFechaEstudioDesde, pFechaEstudioHasta) };
                return this.GetByCriteria(criterios);
            }
            else
            {
                ICriterion[] criterios = { Expression.Like("Nombre", pNombre, MatchMode.Start), Expression.Between("FechaEstudio", pFechaEstudioDesde, pFechaEstudioHasta), Expression.Eq("TipoEstudio", pTipoEstudio) };
                return this.GetByCriteria(criterios);
            }
        }
    }
}
