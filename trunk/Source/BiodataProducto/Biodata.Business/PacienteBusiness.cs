using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class PacienteBusiness : AbstractBusiness<IPacienteDao, Paciente, System.Int32>
    {
        public PacienteBusiness(IPacienteDao dao) : base(dao)
        {

        }

        public List<Paciente> GetPacientesByParameters(String pNombre, String pApellido, Decimal? pNumeroDocumento, String pSexo, Int32? pIDCiudad)
        {
            return Dao.GetPacientesByParameters(pNombre, pApellido, pNumeroDocumento, pSexo, pIDCiudad);
        }
    }
}
