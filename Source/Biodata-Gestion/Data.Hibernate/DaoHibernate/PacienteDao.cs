using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Entity;
using Medusa.Biodata.Data.Interfaces;

namespace Medusa.Biodata.Data
{
    public class PacienteDao : AbstractNHibernateDao<Paciente, long>, IPacienteDao
    {
    }
}
