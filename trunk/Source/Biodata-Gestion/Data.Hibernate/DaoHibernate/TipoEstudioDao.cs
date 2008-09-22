using System;
using System.Collections.Generic;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;

namespace Medusa.Biodata.Data
{
    public class TipoEstudioDao : AbstractNHibernateDao<TipoEstudio, System.Int32>, ITipoEstudioDao
    {
        public TipoEstudioDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
