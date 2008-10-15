using System;
using System.Collections.Generic;
using Biodata.Core.DataInterfaces;
using Biodata.Domain;

namespace Biodata.Data
{
    public class PacienteDao : AbstractNHibernateDao<Paciente, System.Int32>, IPacienteDao
    {
        public PacienteDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
