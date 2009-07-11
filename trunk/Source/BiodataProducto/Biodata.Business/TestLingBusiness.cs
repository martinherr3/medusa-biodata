using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class TestLingBusiness : AbstractBusiness<ITestLingDao, TestLing, System.Int32>
    {
        public TestLingBusiness(ITestLingDao dao) : base(dao)
        {

        }
    }
}
