using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Data
{
    public class AnamnesisListadoPreguntaDao : AbstractNHibernateDao<AnamnesisListadoPregunta, System.Int32>, IAnamnesisListadoPreguntaDao
    {
        public AnamnesisListadoPreguntaDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
