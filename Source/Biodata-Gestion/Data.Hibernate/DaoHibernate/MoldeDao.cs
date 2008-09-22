using System;
using System.Collections.Generic;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;

namespace Medusa.Biodata.Data
{
    public class MoldeDao : AbstractNHibernateDao<Molde, System.Int32>, IMoldeDao
    {
        public MoldeDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
