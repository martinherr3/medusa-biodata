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
    public class MoldeAudifonoDao : AbstractNHibernateDao<MoldeAudifono, System.Int32>, IMoldeAudifonoDao
    {
        public MoldeAudifonoDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
