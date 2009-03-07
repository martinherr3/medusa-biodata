using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class LogoAudiometriaBusiness : AbstractBusiness<ILogoAudiometriaDao, LogoAudiometria, System.Int32>
    {
        public LogoAudiometriaBusiness(ILogoAudiometriaDao dao) : base(dao)
        {

        }
    }
}
