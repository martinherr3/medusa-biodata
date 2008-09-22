using System;
using System.Collections.Generic;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;

namespace Medusa.Biodata.Data
{
    public class MoldePacienteDao : AbstractNHibernateDao<MoldePaciente, MoldePaciente.DomainObjectID>, IMoldePacienteDao
    {
        public MoldePacienteDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
