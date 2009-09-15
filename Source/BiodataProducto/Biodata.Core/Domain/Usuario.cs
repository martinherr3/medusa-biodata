using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// Usuario object for NHibernate mapped table Usuario.
    /// </summary>
    [Serializable]
    public class Usuario : DomainObject<System.Int32>
    {


        private System.String _Nombre;
        private System.String _Apellido;
        private System.String _Nick;
        private System.String _Password;

        public Usuario()
        {
        }

        public Usuario(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Nombre {
             get { return _Nombre; }
             set { _Nombre = value;}
         }

         public virtual System.String Apellido {
             get { return _Apellido; }
             set { _Apellido = value;}
         }

         public virtual System.String Nick {
             get { return _Nick; }
             set { _Nick = value;}
         }

         public virtual System.String Password {
             get { return _Password; }
             set { _Password = value;}
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
