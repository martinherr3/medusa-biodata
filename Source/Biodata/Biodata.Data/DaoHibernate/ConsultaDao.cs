using System;
using System.Collections.Generic;
using Biodata.Core.DataInterfaces;
using Biodata.Domain;

namespace Biodata.Data
{
    public class ConsultaDao : AbstractNHibernateDao<Consulta, System.Int32>, IConsultaDao
    {
        public ConsultaDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
