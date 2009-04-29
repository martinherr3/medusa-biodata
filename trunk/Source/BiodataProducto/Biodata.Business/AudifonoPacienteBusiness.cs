//using System;
//using System.Collections.Generic;
//using Mds.Biodata.Core.DataInterfaces;
//using Mds.Biodata.Domain;
//using Medusa.Base.Business;

using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class AudifonoPacienteBusiness : AbstractBusiness<IAudifonoPacienteDao, AudifonoPaciente, System.Int32>
    {
        public AudifonoPacienteBusiness(IAudifonoPacienteDao dao) : base(dao)
        {

        }
    }
}
