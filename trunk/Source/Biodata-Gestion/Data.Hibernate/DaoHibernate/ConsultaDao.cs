using System;
using System.Collections.Generic;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;

namespace Medusa.Biodata.Data
{
    public class ConsultaDao : AbstractNHibernateDao<Consulta, System.Int32>, IConsultaDao
    {
        public ConsultaDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
