using System;
using System.Collections.Generic;
using Biodata.Core.DataInterfaces;
using Biodata.Domain;

namespace Biodata.Data
{
    public class MoldeDao : AbstractNHibernateDao<Molde, System.Int32>, IMoldeDao
    {
        public MoldeDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
