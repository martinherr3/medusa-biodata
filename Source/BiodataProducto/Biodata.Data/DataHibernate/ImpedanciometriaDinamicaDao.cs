using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Data
{
    public class ImpedanciometriaDinamicaDao : AbstractNHibernateDao<ImpedanciometriaDinamica, System.Int32>, IImpedanciometriaDinamicaDao
    {
        public ImpedanciometriaDinamicaDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
