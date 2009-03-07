using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class ImpedanciometriaEstaticaBusiness : AbstractBusiness<IImpedanciometriaEstaticaDao, ImpedanciometriaEstatica, System.Int32>
    {
        public ImpedanciometriaEstaticaBusiness(IImpedanciometriaEstaticaDao dao) : base(dao)
        {

        }
    }
}
