using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;

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
        }
    }
}
