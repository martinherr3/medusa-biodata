using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Data
{
    public class SeleccionAudifonoDao : AbstractNHibernateDao<SeleccionAudifono, System.Int32>, ISeleccionAudifonoDao
    {
        public SeleccionAudifonoDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
