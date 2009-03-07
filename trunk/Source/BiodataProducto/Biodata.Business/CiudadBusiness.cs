using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class CiudadBusiness : AbstractBusiness<ICiudadDao, Ciudad, System.Int32>
    {
        public CiudadBusiness(ICiudadDao dao) : base(dao)
        {

        }
    }
}
