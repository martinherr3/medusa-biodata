using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class ImpedanciometriaDinamicaBusiness : AbstractBusiness<IImpedanciometriaDinamicaDao, ImpedanciometriaDinamica, System.Int32>
    {
        public ImpedanciometriaDinamicaBusiness(IImpedanciometriaDinamicaDao dao) : base(dao)
        {

        }
    }
}
