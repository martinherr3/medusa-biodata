//using System;
//using System.Collections.Generic;
//using Mds.Biodata.Core.DataInterfaces;
//using Mds.Biodata.Domain;
//using Medusa.Base.Data;

using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;
using NHibernate.Expression;

namespace Mds.Biodata.Data
{
    public class AudifonoDao : AbstractNHibernateDao<Audifono, System.Int32>, IAudifonoDao
    {
        public AudifonoDao(string sessionFactoryConfigPath) : base(sessionFactoryConfigPath)
        {

        }

        public List<Audifono> GetAudifonosByParameters(String pNombreModelo, Int32? pMarca, Int32? pTipo, Decimal? pPresionSalida)
        {
            if (pMarca == null)
            {
                if (pTipo == null)
                {
                    if (pPresionSalida == null)
                    {
                        ICriterion[] criterios = { Expression.Like("NombreModelo", pNombreModelo, MatchMode.Start) };
                        return this.GetByCriteria(criterios);
                    }
                    else
                    {
                        ICriterion[] criterios = { Expression.Like("NombreModelo", pNombreModelo, MatchMode.Start), Expression.Eq("PresionMaximaSalida", pPresionSalida) };
                        return this.GetByCriteria(criterios);
                    }
                }
                else
                {
                    if (pPresionSalida == null)
                    {
                        ICriterion[] criterios = { Expression.Like("NombreModelo", pNombreModelo, MatchMode.Start), Expression.Eq("Tipo", pTipo) };
                        return this.GetByCriteria(criterios);
                    }
                    else
                    {
                        ICriterion[] criterios = { Expression.Like("NombreModelo", pNombreModelo, MatchMode.Start), Expression.Eq("Tipo", pTipo), Expression.Eq("PresionMaximaSalida", pPresionSalida) };
                        return this.GetByCriteria(criterios);
                    }
                }

            }
            else
            {
                if (pTipo == null)
                {
                    if (pPresionSalida == null)
                    {
                        ICriterion[] criterios = { Expression.Like("NombreModelo", pNombreModelo, MatchMode.Start), Expression.Eq("IDMarca", pMarca) };
                        return this.GetByCriteria(criterios);
                    }
                    else
                    {
                        ICriterion[] criterios = { Expression.Like("NombreModelo", pNombreModelo, MatchMode.Start), Expression.Eq("IDMarca", pMarca), Expression.Eq("PresionMaximaSalida", pPresionSalida) };
                        return this.GetByCriteria(criterios);
                    }
                }
                else
                {
                    if (pPresionSalida == null)
                    {
                        ICriterion[] criterios = { Expression.Like("NombreModelo", pNombreModelo, MatchMode.Start), Expression.Eq("IDMarca", pMarca), Expression.Eq("Tipo", pTipo) };
                        return this.GetByCriteria(criterios);
                    }
                    else
                    {
                        ICriterion[] criterios = { Expression.Like("NombreModelo", pNombreModelo, MatchMode.Start), Expression.Eq("IDMarca", pMarca), Expression.Eq("Tipo", pTipo), Expression.Eq("PresionMaximaSalida", pPresionSalida) };
                        return this.GetByCriteria(criterios);
                    }
                }
            }

            
        }
    }
}
