using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class AnamnesisListadoPreguntaBusiness : AbstractBusiness<IAnamnesisListadoPreguntaDao, AnamnesisListadoPregunta, System.Int32>
    {
        public AnamnesisListadoPreguntaBusiness(IAnamnesisListadoPreguntaDao dao) : base(dao)
        {

        }
    }
}
