    using System;
using System.Collections.Generic;
using System.Text;

namespace Medusa.Biodata.Data.Interfaces
{
    /// <summary>
    /// Provides an interface for retrieving DAO objects
    /// </summary>
    public interface IDaoFactory
    {
        IPacienteDao GetPacienteDao();
    }
}
