using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Data
{
    public class LogoAudiometriaDao : AbstractNHibernateDao<LogoAudiometria, System.Int32>, ILogoAudiometriaDao
    {
        public LogoAudiometriaDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }
    }
}
