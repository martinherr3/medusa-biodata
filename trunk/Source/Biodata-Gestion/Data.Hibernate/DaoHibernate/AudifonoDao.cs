using System;
using System.Collections.Generic;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;

namespace Medusa.Biodata.Data
{
    public class AudifonoDao : AbstractNHibernateDao<Audifono, System.Int32>, IAudifonoDao
    {
        public AudifonoDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
