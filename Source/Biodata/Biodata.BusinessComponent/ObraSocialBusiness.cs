using System;
using System.Collections.Generic;
using Biodata.Core.DataInterfaces;
using Biodata.Domain;

namespace Biodata.BusinessComponent
{
    public class ObraSocialBusiness : AbstractBusiness<IObraSocialDao, ObraSocial, System.Int32>
    {
        public ObraSocialBusiness(IObraSocialDao dao) : base(dao) { }
    }
}
