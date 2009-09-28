using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;

namespace Mds.Biodata.Business
{
    public class UsuarioBusiness : AbstractBusiness<IUsuarioDao, Usuario, System.Int32>
    {
        public UsuarioBusiness(IUsuarioDao dao) : base(dao)
        {

        }

        public Boolean ValidarUsuario(String pNick, String pPassword)
        {
            return true;
        }
    }
}
