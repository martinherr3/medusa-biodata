using System;
using System.Collections.Generic;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;

namespace Medusa.Biodata.Data
{
    public class AudifonoPacienteDao : AbstractNHibernateDao<AudifonoPaciente, AudifonoPaciente.DomainObjectID>, IAudifonoPacienteDao
    {
        public AudifonoPacienteDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
    }
}
