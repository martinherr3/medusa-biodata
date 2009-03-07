using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Data
{
    public class ListadoPalabraDao : AbstractNHibernateDao<ListadoPalabra, System.Int32>, IListadoPalabraDao
    {
        public ListadoPalabraDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
