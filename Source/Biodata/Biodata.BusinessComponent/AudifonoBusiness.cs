using System;
using System.Collections.Generic;
using Biodata.Core.DataInterfaces;
using Biodata.Domain;

namespace Biodata.BusinessComponent
{
    public class AudifonoBusiness : AbstractBusiness<IAudifonoDao, Audifono, System.Int32>
    {
        public AudifonoBusiness(IAudifonoDao dao) : base(dao) { }
    }
}
