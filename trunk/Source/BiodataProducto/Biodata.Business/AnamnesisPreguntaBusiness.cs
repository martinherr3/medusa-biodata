using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class AnamnesisPreguntaBusiness : AbstractBusiness<IAnamnesisPreguntaDao, AnamnesisPregunta, System.Int32>
    {
        public AnamnesisPreguntaBusiness(IAnamnesisPreguntaDao dao) : base(dao)
        {

        }
    }
}
