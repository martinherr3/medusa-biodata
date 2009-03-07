using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class ObraSocialBusiness : AbstractBusiness<IObraSocialDao, ObraSocial, System.Int32>
    {
        public ObraSocialBusiness(IObraSocialDao dao) : base(dao)
        {

        }
    }
}
