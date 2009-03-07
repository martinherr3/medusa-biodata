using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class AnamnesiBusiness : AbstractBusiness<IAnamnesiDao, Anamnesi, System.Int32>
    {
        public AnamnesiBusiness(IAnamnesiDao dao) : base(dao)
        {

        }
    }
}
