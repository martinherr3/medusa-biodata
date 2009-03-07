using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class RecordatorioBusiness : AbstractBusiness<IRecordatorioDao, Recordatorio, System.Int32>
    {
        public RecordatorioBusiness(IRecordatorioDao dao) : base(dao)
        {

        }
    }
}
