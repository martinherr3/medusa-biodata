using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class ObraSocialXPacienteBusiness : AbstractBusiness<IObraSocialXPacienteDao, ObraSocialXPaciente, ObraSocialXPaciente.DomainObjectID>
    {
        public ObraSocialXPacienteBusiness(IObraSocialXPacienteDao dao) : base(dao)
        {

        }
    }
}
