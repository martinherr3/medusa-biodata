using System;
using System.Collections.Generic;
using Biodata.Core.DataInterfaces;
using Biodata.Domain;

namespace Biodata.Data
{
    public class ObraSocialDao : AbstractNHibernateDao<ObraSocial, System.Int32>, IObraSocialDao
    {
        public ObraSocialDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
