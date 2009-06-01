using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class ObraSocialXPacienteBusiness : AbstractBusiness<IObraSocialXPacienteDao, ObraSocialXPaciente, System.Int32>
    {
        public ObraSocialXPacienteBusiness(IObraSocialXPacienteDao dao)
            : base(dao)
        {

        }
    }
}
