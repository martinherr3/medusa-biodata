using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;
using NHibernate.Expression;

namespace Mds.Biodata.Data
{
    public class PacienteDao : AbstractNHibernateDao<Paciente, System.Int32>, IPacienteDao
    {
        public PacienteDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }

        public List<Paciente> GetPacientesByParameters(String pNombre, String pApellido, Decimal? pNumeroDocumento, String pSexo, Int32? pIDCiudad)
        {
            if (pIDCiudad == null)
            {
                if (pNumeroDocumento == null)
                {
                    ICriterion[] criterios = { Expression.Like("Sexo", pSexo, MatchMode.Start), Expression.Like("Nombre", pNombre, MatchMode.Start), Expression.Like("Apellido", pApellido, MatchMode.Start) };
                    return this.GetByCriteria(criterios);
                }
                else
                {
                    ICriterion[] criterios = { Expression.Like("Sexo", pSexo, MatchMode.Start), Expression.Like("Nombre", pNombre, MatchMode.Start), Expression.Like("Apellido", pApellido, MatchMode.Start), Expression.Eq("NumeroDocumento", pNumeroDocumento) };
                    return this.GetByCriteria(criterios);
                }
                
            }
            else
            {
                if (pNumeroDocumento == null)
                {
                    ICriterion[] criterios = { Expression.Like("Sexo", pSexo, MatchMode.Start), Expression.Like("Nombre", pNombre, MatchMode.Start), Expression.Like("Apellido", pApellido, MatchMode.Start), Expression.Eq("IDCiudad", pIDCiudad) };
                    return this.GetByCriteria(criterios);
                }
                else
                {
                    ICriterion[] criterios = { Expression.Like("Sexo", pSexo, MatchMode.Start), Expression.Like("Nombre", pNombre, MatchMode.Start), Expression.Like("Apellido", pApellido, MatchMode.Start), Expression.Eq("NumeroDocumento", pNumeroDocumento), Expression.Eq("IDCiudad", pIDCiudad) };
                    return this.GetByCriteria(criterios);
                }
            }
        }
    }
}
