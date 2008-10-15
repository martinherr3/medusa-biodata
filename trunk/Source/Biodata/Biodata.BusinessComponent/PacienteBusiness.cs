using System;
using System.Collections.Generic;
using System.Text;
using Biodata.Core.DataInterfaces;
using Biodata.Domain;

namespace Biodata.BusinessComponent
{
    public class PacienteBusiness : AbstractBusiness<IPacienteDao, Paciente, System.Int32>
    {
        public PacienteBusiness(IPacienteDao dao) : base(dao){}
    }
}	
