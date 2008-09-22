using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Core.DataInterfaces;
using Medusa.Biodata.Domain;

namespace Medusa.Biodata.Service
{
    public class ObraSocialService
    {
        IDaoFactory _factory;

        public ObraSocialService(IDaoFactory factory)
        {
            _factory = factory;
        }

        public List<ObraSocial> GetObrasSociales()
        {
            IObraSocialDao dao = _factory.GetObraSocialDao();
            return dao.GetAll();
        }

        public ObraSocial GetObraSocial(int id)
        {
            IObraSocialDao dao = _factory.GetObraSocialDao();
            return dao.GetById(id, false);
        }
    }
}
