using System;
using System.Collections.Generic;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;

namespace Medusa.Biodata.Service
{
    public class ObraSocialService : AbstractService<IObraSocialDao, ObraSocial, System.Int32>
    {
        public ObraSocialService(IObraSocialDao dao) : base(dao) { }
    }
}
