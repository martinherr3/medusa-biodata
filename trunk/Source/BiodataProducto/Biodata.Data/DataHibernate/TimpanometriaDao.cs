using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Data
{
    public class TimpanometriaDao : AbstractNHibernateDao<Timpanometria, System.Int32>, ITimpanometriaDao
    {
        public TimpanometriaDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
