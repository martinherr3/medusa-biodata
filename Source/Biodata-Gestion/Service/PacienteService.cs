using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;

namespace Medusa.Biodata.Service
{
    public class PacienteService : AbstractService<IPacienteDao, Paciente, System.Int32>
    {
        public PacienteService(IPacienteDao dao) : base(dao){}
    }
}	
