//using System;
//using System.Collections.Generic;
//using Mds.Biodata.Core.DataInterfaces;
//using Mds.Biodata.Domain;
//using Medusa.Base.Data;

using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Data
{
    public class AudifonoDao : AbstractNHibernateDao<Audifono, System.Int32>, IAudifonoDao
    {
        public AudifonoDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
