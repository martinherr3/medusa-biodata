using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Data
{
    public class ObraSocialXPacienteDao : AbstractNHibernateDao<ObraSocialXPaciente, System.Int32>, IObraSocialXPacienteDao
    {
        public ObraSocialXPacienteDao(string sessionFactoryConfigPath)
            : base(sessionFactoryConfigPath)
        {

        }
    }
}
