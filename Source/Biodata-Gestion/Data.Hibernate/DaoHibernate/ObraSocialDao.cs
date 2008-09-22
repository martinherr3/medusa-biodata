using System;
using System.Collections.Generic;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;

namespace Medusa.Biodata.Data
{
    public class ObraSocialDao : AbstractNHibernateDao<ObraSocial, System.Int32>, IObraSocialDao
    {
        public ObraSocialDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
