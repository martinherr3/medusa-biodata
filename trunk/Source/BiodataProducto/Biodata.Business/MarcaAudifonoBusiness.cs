using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;


namespace Mds.Biodata.Business
{
    public class MarcaAudifonoBusiness : AbstractBusiness<IMarcaAudifonoDao, MarcaAudifono, System.Int32>
    {
        public MarcaAudifonoBusiness(IMarcaAudifonoDao dao) : base(dao)
        {

        }
    }
}
