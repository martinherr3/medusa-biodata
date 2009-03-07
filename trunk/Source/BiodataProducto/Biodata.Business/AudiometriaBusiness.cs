using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class AudiometriaBusiness : AbstractBusiness<IAudiometriaDao, Audiometria, System.Int32>
    {
        public AudiometriaBusiness(IAudiometriaDao dao) : base(dao)
        {

        }
    }
}
