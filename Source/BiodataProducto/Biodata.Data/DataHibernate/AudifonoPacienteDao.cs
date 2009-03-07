using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Data
{
    public class AudifonoPacienteDao : AbstractNHibernateDao<AudifonoPaciente, System.Int32>, IAudifonoPacienteDao
    {
        public AudifonoPacienteDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
