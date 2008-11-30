using System;
using System.Collections.Generic;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;
using NHibernate;
using NHibernate.Expression;

namespace Medusa.Biodata.Data
{
    public class PacienteDao : AbstractNHibernateDao<Paciente, System.Int32>, IPacienteDao
    {
        public PacienteDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath) { }

        #region IPacienteDao Members

        public List<Paciente> FiltrarPorApellido(string apellido)
        {
            ICriteria crit = NHibernateSession.CreateCriteria(typeof(Paciente));
            ICriterion[] criterion = {Expression.Like("Apellido", "%" + apellido + "%")};
            return GetByCriteria(criterion);
        }

        #endregion

    }
}
