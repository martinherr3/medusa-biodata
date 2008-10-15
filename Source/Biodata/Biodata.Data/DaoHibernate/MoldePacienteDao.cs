using System;
using System.Collections.Generic;
using Biodata.Core.DataInterfaces;
using Biodata.Domain;

namespace Biodata.Data
{
    public class MoldePacienteDao : AbstractNHibernateDao<MoldePaciente, MoldePaciente.DomainObjectIDMoldePaciente>, IMoldePacienteDao
    {
        public MoldePacienteDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
