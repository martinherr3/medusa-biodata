using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// Ciudad object for NHibernate mapped table Ciudad.
    /// </summary>
    [Serializable]
    public class Ciudad : DomainObject<System.Int32>
    {


        private System.String _Descripcion;
        private System.Int32? _IDProvincia;
        private Provincia _IDProvinciaLookup;
        private IList<Paciente> _Pacientes = new List<Paciente>();

        public Ciudad()
        {
        }

        public Ciudad(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Descripcion {
             get { return _Descripcion; }
             set { _Descripcion = value;}
         }

         public virtual System.Int32? IDProvincia {
             get { return _IDProvincia; }
             set { _IDProvincia = value;}
         }

         public virtual Provincia IDProvinciaLookup{
             get { return _IDProvinciaLookup; }
             set { _IDProvinciaLookup = value;}
         }

         public virtual IList<Paciente> Pacientes{
             get { return _Pacientes; }
             set { _Pacientes = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
