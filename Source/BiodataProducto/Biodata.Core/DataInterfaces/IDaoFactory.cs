using System;
using System.Collections.Generic;

namespace Mds.Biodata.Core.DataInterfaces
{
    public interface IDaoFactory
    {
        IAnamnesiDao GetAnamnesiDao();
        IAudifonoDao GetAudifonoDao();
        IAudifonoPacienteDao GetAudifonoPacienteDao();
        IAudiometriaDao GetAudiometriaDao();
        ICiudadDao GetCiudadDao();
        IConjuntoPalabraDao GetConjuntoPalabraDao();
        IEstudioDao GetEstudioDao();
        IHistoriaClinicaDao GetHistoriaClinicaDao();
        IImpedanciometriaDinamicaDao GetImpedanciometriaDinamicaDao();
        IImpedanciometriaEstaticaDao GetImpedanciometriaEstaticaDao();
        IListadoPalabraDao GetListadoPalabraDao();
        ILogoAudiometriaDao GetLogoAudiometriaDao();
        IMoldeAudifonoDao GetMoldeAudifonoDao();
        IObraSocialDao GetObraSocialDao();
        IObraSocialXPacienteDao GetObraSocialXPacienteDao();
        IPacienteDao GetPacienteDao();
        IProvinciaDao GetProvinciaDao();
        IRecordatorioDao GetRecordatorioDao();
        ISeleccionAudifonoDao GetSeleccionAudifonoDao();
        ITimpanometriaDao GetTimpanometriaDao();
        IAnamnesisPreguntaDao GetAnamnesisPreguntaDao();
        IMarcaAudifonoDao GetMarcaAudifonoDao();
        ITestLingDao GetTestLingDao();
    }
}
