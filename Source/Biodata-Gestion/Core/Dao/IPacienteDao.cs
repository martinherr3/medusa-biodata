using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Entity;

namespace Medusa.Biodata.Data.Interfaces
{
    public interface IPacienteDao : IDao<Paciente,long>
    {
        void pepe(string x);

        Paciente medina();
    }
}
