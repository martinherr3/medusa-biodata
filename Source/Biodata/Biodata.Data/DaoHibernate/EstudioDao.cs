using System;
using System.Collections.Generic;
using Biodata.Core.DataInterfaces;
using Biodata.Domain;

namespace Biodata.Data
{
    public class EstudioDao : AbstractNHibernateDao<Estudio, System.Int32>, IEstudioDao
    {
        public EstudioDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
