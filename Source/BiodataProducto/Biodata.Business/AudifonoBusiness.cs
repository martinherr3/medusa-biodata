//using System;
//using System.Collections.Generic;
//using Mds.Biodata.Core.DataInterfaces;
//using Mds.Biodata.Domain;
//using Medusa.Base.Business;

using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class AudifonoBusiness : AbstractBusiness<IAudifonoDao, Audifono, System.Int32>
    {
        public AudifonoBusiness(IAudifonoDao dao) : base(dao)
        {

        }

        public List<Audifono> GetAudifonosByParameters(String pNombreModelo, Int32? pMarca, Int32? pTipo, Decimal? pPresionSalida)
        {
            return Dao.GetAudifonosByParameters(pNombreModelo, pMarca, pTipo, pPresionSalida);
        }
    }
}
