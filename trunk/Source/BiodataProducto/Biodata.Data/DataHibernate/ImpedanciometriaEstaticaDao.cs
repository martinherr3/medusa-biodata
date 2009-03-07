using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Data
{
    public class ImpedanciometriaEstaticaDao : AbstractNHibernateDao<ImpedanciometriaEstatica, System.Int32>, IImpedanciometriaEstaticaDao
    {
        public ImpedanciometriaEstaticaDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
