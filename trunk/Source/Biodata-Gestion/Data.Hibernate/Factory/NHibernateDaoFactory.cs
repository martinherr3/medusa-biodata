using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Data.Interfaces;

namespace Medusa.Biodata.Data
{
    /// <summary>
    /// Exposes access to NHibernate DAO classes.
    /// </summary>
    public class NHibernateDaoFactory : IDaoFactory
    {
        public NHibernateDaoFactory(string sessionFactoryConfigPath)
        {
            SessionFactoryConfigPath = sessionFactoryConfigPath;
        }

        protected string SessionFactoryConfigPath
        {
            get
            {
                return sessionFactoryConfigPath;
            }
            set
            {
                sessionFactoryConfigPath = value;
            }
        }

        public IPacienteDao GetPacienteDao()
        {
            return new PacienteDao(sessionFactoryConfigPath);
        }

        private string sessionFactoryConfigPath;
    }
}
