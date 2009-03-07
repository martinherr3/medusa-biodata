using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class ListadoPalabraBusiness : AbstractBusiness<IListadoPalabraDao, ListadoPalabra, System.Int32>
    {
        public ListadoPalabraBusiness(IListadoPalabraDao dao) : base(dao)
        {

        }
    }
}
