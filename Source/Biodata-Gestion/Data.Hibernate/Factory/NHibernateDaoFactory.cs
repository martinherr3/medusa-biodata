using System;
using System.Collections.Generic;
using System.Text;

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

        public ICustomerDao GetCustomerDao()
        {
            return new CustomerDao(sessionFactoryConfigPath);
        }

        public IHistoricalOrderSummaryDao GetHistoricalOrderSummaryDao()
        {
            return new HistoricalOrderSummaryDao(sessionFactoryConfigPath);
        }

        public IOrderDao GetOrderDao()
        {
            return new OrderDao(sessionFactoryConfigPath);
        }

        public ISupplierDao GetSupplierDao()
        {
            return new SupplierDao(sessionFactoryConfigPath);
        }

        #region Inline DAO implementations

        /// <summary>
        /// Concrete DAO for accessing instances of <see cref="Customer" /> from DB.
        /// This should be extracted into its own class-file if it needs to extend the
        /// inherited DAO functionality.
        /// </summary>
        public class CustomerDao : AbstractNHibernateDao<Customer, string>, ICustomerDao
        {
            public CustomerDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
        }

        public class SupplierDao : AbstractNHibernateDao<Supplier, long>, ISupplierDao
        {
            public SupplierDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }
        }

        #endregion

        private string sessionFactoryConfigPath;
    }
}
