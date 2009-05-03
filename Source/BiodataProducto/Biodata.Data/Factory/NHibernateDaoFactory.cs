using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;

namespace Mds.Biodata.Data
{
    public class NHibernateDaoFactory : IDaoFactory
    {

        private string sessionFactoryConfigPath;
        public NHibernateDaoFactory(string sessionFactoryConfigPath)
        {
            SessionFactoryConfigPath = sessionFactoryConfigPath;
        }
        protected string SessionFactoryConfigPath
        {
            get { return sessionFactoryConfigPath; }
            set { sessionFactoryConfigPath = value; }
        }
        public IAnamnesiDao GetAnamnesiDao()
        {
            return new AnamnesiDao(SessionFactoryConfigPath);
        }
        public IAudifonoDao GetAudifonoDao()
        {
            return new AudifonoDao(SessionFactoryConfigPath);
        }
        public IAudifonoPacienteDao GetAudifonoPacienteDao()
        {
            return new AudifonoPacienteDao(SessionFactoryConfigPath);
        }
        public IAudiometriaDao GetAudiometriaDao()
        {
            return new AudiometriaDao(SessionFactoryConfigPath);
        }
        public ICiudadDao GetCiudadDao()
        {
            return new CiudadDao(SessionFactoryConfigPath);
        }
        public IConjuntoPalabraDao GetConjuntoPalabraDao()
        {
            return new ConjuntoPalabraDao(SessionFactoryConfigPath);
        }
        public IEstudioDao GetEstudioDao()
        {
            return new EstudioDao(SessionFactoryConfigPath);
        }
        public IHistoriaClinicaDao GetHistoriaClinicaDao()
        {
            return new HistoriaClinicaDao(SessionFactoryConfigPath);
        }
        public IImpedanciometriaDinamicaDao GetImpedanciometriaDinamicaDao()
        {
            return new ImpedanciometriaDinamicaDao(SessionFactoryConfigPath);
        }
        public IImpedanciometriaEstaticaDao GetImpedanciometriaEstaticaDao()
        {
            return new ImpedanciometriaEstaticaDao(SessionFactoryConfigPath);
        }
        public IListadoPalabraDao GetListadoPalabraDao()
        {
            return new ListadoPalabraDao(SessionFactoryConfigPath);
        }
        public ILogoAudiometriaDao GetLogoAudiometriaDao()
        {
            return new LogoAudiometriaDao(SessionFactoryConfigPath);
        }
        public IMoldeAudifonoDao GetMoldeAudifonoDao()
        {
            return new MoldeAudifonoDao(SessionFactoryConfigPath);
        }
        public IObraSocialDao GetObraSocialDao()
        {
            return new ObraSocialDao(SessionFactoryConfigPath);
        }
        public IObraSocialXPacienteDao GetObraSocialXPacienteDao()
        {
            return new ObraSocialXPacienteDao(SessionFactoryConfigPath);
        }
        public IPacienteDao GetPacienteDao()
        {
            return new PacienteDao(SessionFactoryConfigPath);
        }
        public IProvinciaDao GetProvinciaDao()
        {
            return new ProvinciaDao(SessionFactoryConfigPath);
        }
        public IRecordatorioDao GetRecordatorioDao()
        {
            return new RecordatorioDao(SessionFactoryConfigPath);
        }
        public ISeleccionAudifonoDao GetSeleccionAudifonoDao()
        {
            return new SeleccionAudifonoDao(SessionFactoryConfigPath);
        }
        public ITimpanometriaDao GetTimpanometriaDao()
        {
            return new TimpanometriaDao(SessionFactoryConfigPath);
        }
        public IAnamnesisPreguntaDao GetAnamnesisPreguntaDao()
        {
            return new AnamnesisPreguntaDao(SessionFactoryConfigPath);
        }
        public IMarcaAudifonoDao GetMarcaAudifonoDao()
        {
            return new MarcaAudifonoDao(SessionFactoryConfigPath);
        }
    }
}
