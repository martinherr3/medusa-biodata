using System;
using System.Collections.Generic;

namespace Biodata.Core.DataInterfaces
{
    public interface IDaoFactory
    {
        IAudifonoDao GetAudifonoDao();
        IAudifonoPacienteDao GetAudifonoPacienteDao();
        IConsultaDao GetConsultaDao();
        IEstudioDao GetEstudioDao();
        IHistoriaClinicaDao GetHistoriaClinicaDao();
        IMoldeDao GetMoldeDao();
        IMoldePacienteDao GetMoldePacienteDao();
        IObraSocialDao GetObraSocialDao();
        IPacienteDao GetPacienteDao();
        ITipoEstudioDao GetTipoEstudioDao();
    }
}
