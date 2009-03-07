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
    }
}
