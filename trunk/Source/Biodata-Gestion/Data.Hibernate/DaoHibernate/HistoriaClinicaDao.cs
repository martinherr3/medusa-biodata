using System;
using System.Collections.Generic;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;

namespace Medusa.Biodata.Data
{
    public class HistoriaClinicaDao : AbstractNHibernateDao<HistoriaClinica, System.Int32>, IHistoriaClinicaDao
    {
        public HistoriaClinicaDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
