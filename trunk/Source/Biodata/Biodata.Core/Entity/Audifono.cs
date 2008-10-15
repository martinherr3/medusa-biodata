using System;
using System.Collections.Generic;

namespace Biodata.Domain
{
    /// <summary>
    /// Audifono object for NHibernate mapped table Audifono.
    /// </summary>
    [Serializable]
    public class Audifono : DomainObject<System.Int32>
    {


        private System.String _Descripcion;
        private IList<AudifonoPaciente> _Pacientes = new List<AudifonoPaciente>();

        public Audifono()
        {
        }

        public Audifono(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Descripcion {
             get { return _Descripcion; }
             set { _Descripcion = value;}
         }

         public virtual IList<AudifonoPaciente> Pacientes
         {
             get { return _Pacientes; }
             set { _Pacientes = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
