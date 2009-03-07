using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// ObraSocial object for NHibernate mapped table ObraSocial.
    /// </summary>
    [Serializable]
    public class ObraSocial : DomainObject<System.Int32>
    {


        private System.String _RazonSocial;
        private System.String _Direccion;
        private System.String _Telefono;
        private System.String _Contacto;
        private System.String _CUIT;
        private System.String _CorreoElectronico;
        private System.String _PaginaWeb;
        private IList<ObraSocialXPaciente> _ObraSocialXPacientes = new List<ObraSocialXPaciente>();

        public ObraSocial()
        {
        }

        public ObraSocial(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String RazonSocial {
             get { return _RazonSocial; }
             set { _RazonSocial = value;}
         }

         public virtual System.String Direccion {
             get { return _Direccion; }
             set { _Direccion = value;}
         }

         public virtual System.String Telefono {
             get { return _Telefono; }
             set { _Telefono = value;}
         }

         public virtual System.String Contacto {
             get { return _Contacto; }
             set { _Contacto = value;}
         }

         public virtual System.String CUIT {
             get { return _CUIT; }
             set { _CUIT = value;}
         }

         public virtual System.String CorreoElectronico {
             get { return _CorreoElectronico; }
             set { _CorreoElectronico = value;}
         }

         public virtual System.String PaginaWeb {
             get { return _PaginaWeb; }
             set { _PaginaWeb = value;}
         }

         public virtual IList<ObraSocialXPaciente> ObraSocialXPacientes
         {
             get { return _ObraSocialXPacientes; }
             set { _ObraSocialXPacientes = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
