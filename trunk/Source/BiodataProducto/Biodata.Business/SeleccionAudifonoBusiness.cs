using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class SeleccionAudifonoBusiness : AbstractBusiness<ISeleccionAudifonoDao, SeleccionAudifono, System.Int32>
    {
        public SeleccionAudifonoBusiness(ISeleccionAudifonoDao dao) : base(dao)
        {

        }
    }
}
