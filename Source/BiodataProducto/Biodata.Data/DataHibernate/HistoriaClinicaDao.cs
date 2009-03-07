using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Data
{
    public class HistoriaClinicaDao : AbstractNHibernateDao<HistoriaClinica, System.Int32>, IHistoriaClinicaDao
    {
        public HistoriaClinicaDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
