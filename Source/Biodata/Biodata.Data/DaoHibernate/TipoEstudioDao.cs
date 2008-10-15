using System;
using System.Collections.Generic;
using Biodata.Core.DataInterfaces;
using Biodata.Domain;

namespace Biodata.Data
{
    public class TipoEstudioDao : AbstractNHibernateDao<TipoEstudio, System.Int32>, ITipoEstudioDao
    {
        public TipoEstudioDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
