using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class TimpanometriaBusiness : AbstractBusiness<ITimpanometriaDao, Timpanometria, System.Int32>
    {
        public TimpanometriaBusiness(ITimpanometriaDao dao) : base(dao)
        {

        }
    }
}
