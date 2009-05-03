using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Data
{
    public class AnamnesisPreguntaDao : AbstractNHibernateDao<AnamnesisPregunta, System.Int32>, IAnamnesisPreguntaDao
    {
        public AnamnesisPreguntaDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
