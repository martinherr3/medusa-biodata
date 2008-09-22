using System;
using System.Collections.Generic;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;

namespace Medusa.Biodata.Data
{
    public class EstudioDao : AbstractNHibernateDao<Estudio, System.Int32>, IEstudioDao
    {
        public EstudioDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
