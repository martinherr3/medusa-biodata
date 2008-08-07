using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Data.Interfaces;
using Medusa.Biodata.Entity;

namespace Medusa.Biodata.Service
{
    public class PacienteService
    {
        IDaoFactory _factory;

        public PacienteService(IDaoFactory factory)
        {
            _factory = factory;
        }

        public void SavePaciente(Paciente paciente)
        {
            IPacienteDao dao = _factory.GetPacienteDao();
            dao.Save(paciente);

            dao.pepe("asdasd");
        }
    }
}
