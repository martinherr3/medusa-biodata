using System;
using System.Collections.Generic;
using Biodata.Core.DataInterfaces;
using Biodata.Domain;

namespace Biodata.Data
{
    public class AudifonoPacienteDao : AbstractNHibernateDao<AudifonoPaciente, AudifonoPaciente.DomainObjectIDAudifonoPaciente>, IAudifonoPacienteDao
    {
        public AudifonoPacienteDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
