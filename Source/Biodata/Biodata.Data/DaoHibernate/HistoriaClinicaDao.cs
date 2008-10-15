using System;
using System.Collections.Generic;
using Biodata.Core.DataInterfaces;
using Biodata.Domain;

namespace Biodata.Data
{
    public class HistoriaClinicaDao : AbstractNHibernateDao<HistoriaClinica, System.Int32>, IHistoriaClinicaDao
    {
        public HistoriaClinicaDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
