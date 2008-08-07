using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Entity;
using Medusa.Biodata.Data.Interfaces;

namespace Medusa.Biodata.Data
{
    /// <summary>
    /// Concrete DAO for accessing instances of <see cref="Paciente" /> from DB.
    /// </summary>
    public class PacienteDao : AbstractNHibernateDao<Paciente, long>, IPacienteDao
    {
        public PacienteDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }

        #region IPacienteDao Members

        public void pepe(string x)
        {

        }

        #endregion

        #region IPacienteDao Members


        public Paciente medina()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
