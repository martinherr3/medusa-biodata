using System;
using System.Collections.Generic;
using Biodata.Core.DataInterfaces;
using Biodata.Domain;

namespace Biodata.Data
{
    public class AudifonoDao : AbstractNHibernateDao<Audifono, System.Int32>, IAudifonoDao
    {
        public AudifonoDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
