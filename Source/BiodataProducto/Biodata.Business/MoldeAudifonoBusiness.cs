using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class MoldeAudifonoBusiness : AbstractBusiness<IMoldeAudifonoDao, MoldeAudifono, System.Int32>
    {
        public MoldeAudifonoBusiness(IMoldeAudifonoDao dao) : base(dao)
        {

        }
    }
}
