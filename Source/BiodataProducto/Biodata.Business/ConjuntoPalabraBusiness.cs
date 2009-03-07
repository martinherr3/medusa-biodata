using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class ConjuntoPalabraBusiness : AbstractBusiness<IConjuntoPalabraDao, ConjuntoPalabra, System.Int32>
    {
        public ConjuntoPalabraBusiness(IConjuntoPalabraDao dao) : base(dao)
        {

        }
    }
}
