using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Data.Interfaces;

namespace Medusa.Biodata.Data
{
    /// <summary>
    /// Exposes access to NHibernate DAO classes.
    /// </summary>
    public class NHibernateDaoFactory
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

        public IPacienteDao GetCustomerDao()
        {
            return new PacienteDao();
        }

        private string sessionFactoryConfigPath;
    }
}
