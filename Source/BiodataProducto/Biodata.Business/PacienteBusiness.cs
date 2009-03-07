using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class PacienteBusiness : AbstractBusiness<IPacienteDao, Paciente, System.Int32>
    {
        public PacienteBusiness(IPacienteDao dao) : base(dao)
        {

        }
    }
}
