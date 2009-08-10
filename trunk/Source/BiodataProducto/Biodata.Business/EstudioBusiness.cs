using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class EstudioBusiness : AbstractBusiness<IEstudioDao, Estudio, System.Int32>
    {
        public EstudioBusiness(IEstudioDao dao) : base(dao)
        {
            
        }

        public List<Estudio> GetEstudiosNombre(String pNombre, DateTime? pFechaEstudioDesde, DateTime? pFechaEstudioHasta, Int32? pTipoEstudio)
        {
            return Dao.GetEstudiosByNombre(pNombre, pFechaEstudioDesde, pFechaEstudioHasta, pTipoEstudio);
        }
    }
}
