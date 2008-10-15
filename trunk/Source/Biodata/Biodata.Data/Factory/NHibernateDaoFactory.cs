using System;
using System.Collections.Generic;
using System.Text;
using Biodata.Core.DataInterfaces;

namespace Biodata.Data
{
    /// <summary>
    /// Exposes access to NHibernate DAO classes.
    /// </summary>
    public class NHibernateDaoFactory : IDaoFactory
    {
        private string sessionFactoryConfigPath;

        public NHibernateDaoFactory(string sessionFactoryConfigPath)
        {
            SessionFactoryConfigPath = sessionFactoryConfigPath;
        }

        protected string SessionFactoryConfigPath
        {
            get{ return sessionFactoryConfigPath;  }
            set{ sessionFactoryConfigPath = value; }
        }

        public IPacienteDao GetPacienteDao()
        {
            return new PacienteDao(sessionFactoryConfigPath);
        }
        public IAudifonoDao GetAudifonoDao()
        {
            return new AudifonoDao(sessionFactoryConfigPath);
        }
        public IAudifonoPacienteDao GetAudifonoPacienteDao()
        {
            return new AudifonoPacienteDao(sessionFactoryConfigPath);
        }
        public IConsultaDao GetConsultaDao()
        {
            return new ConsultaDao(sessionFactoryConfigPath);
        }
        public IEstudioDao GetEstudioDao()
        {
            return new EstudioDao(sessionFactoryConfigPath);
        }
        public IHistoriaClinicaDao GetHistoriaClinicaDao()
        {
            return new HistoriaClinicaDao(sessionFactoryConfigPath);
        }
        public IMoldeDao GetMoldeDao()
        {
            return new MoldeDao(sessionFactoryConfigPath);
        }
        public IMoldePacienteDao GetMoldePacienteDao()
        {
            return new MoldePacienteDao(sessionFactoryConfigPath);
        }
        public IObraSocialDao GetObraSocialDao()
        {
            return new ObraSocialDao(sessionFactoryConfigPath);
        }
        public ITipoEstudioDao GetTipoEstudioDao()
        {
            return new TipoEstudioDao(sessionFactoryConfigPath);
        }
       
    }
}
