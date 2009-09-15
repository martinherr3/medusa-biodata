using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Data
{
    public class UsuarioDao : AbstractNHibernateDao<Usuario, System.Int32>, IUsuarioDao
    {
        public UsuarioDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
