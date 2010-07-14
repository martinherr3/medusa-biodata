using System;
using System.Collections.Generic;
using Mds.Biodata.Core.DataInterfaces;
using Mds.Biodata.Domain;
using Mds.Architecture.Business;
using Mds.Biodata.Helpers;

namespace Mds.Biodata.Business
{
    public class UsuarioBusiness : AbstractBusiness<IUsuarioDao, Usuario, System.Int32>
    {
        public UsuarioBusiness(IUsuarioDao dao) : base(dao)
        {

        }

        public Usuario ValidarUsuario(String pNick, String pPassword)
        {

            //pPassword = CryptoHelper.Encrypt(pPassword);

            List<Usuario> wUsuarios = Dao.GetUsuariosForNick(pNick);

            if (wUsuarios.Count > 0)
            {
                if (CryptoHelper.ComparePasswordMD5(pPassword, wUsuarios[0].Password))
                {
                    return wUsuarios[0];
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
