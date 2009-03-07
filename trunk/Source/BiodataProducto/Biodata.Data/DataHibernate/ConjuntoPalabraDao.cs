using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Data
{
    public class ConjuntoPalabraDao : AbstractNHibernateDao<ConjuntoPalabra, System.Int32>, IConjuntoPalabraDao
    {
        public ConjuntoPalabraDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
