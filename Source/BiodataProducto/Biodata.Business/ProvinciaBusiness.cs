using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class ProvinciaBusiness : AbstractBusiness<IProvinciaDao, Provincia, System.Int32>
    {
        public ProvinciaBusiness(IProvinciaDao dao) : base(dao)
        {

        }
    }
}
