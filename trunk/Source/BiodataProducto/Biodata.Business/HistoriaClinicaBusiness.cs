using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class HistoriaClinicaBusiness : AbstractBusiness<IHistoriaClinicaDao, HistoriaClinica, System.Int32>
    {
        public HistoriaClinicaBusiness(IHistoriaClinicaDao dao) : base(dao)
        {

        }
    }
}
