using System;
using System.Collections.Generic;
using Mds.Biodata.Domain;
using Mds.Architecture.Data;

namespace Mds.Biodata.Core.DataInterfaces
{
    /// <summary>
    /// Since this extends the <see cref="IDao{TypeOfListItem, IdT}" /> behavior, it's a good idea to 
    /// place it in its own file for manageability.  In this way, it can grow further without
    /// cluttering up <see cref="IDaoFactory" />.
    /// </summary>
    public interface IEstudioDao : IDao<Estudio, System.Int32>
    {
        List<Estudio> GetEstudiosByNombre(String pNombre, DateTime? pFechaEstudioDesde, DateTime? pFechaEstudioHasta, Int32? pTipoEstudio);
    }
}