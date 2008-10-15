using System;
using System.Collections.Generic;

namespace Biodata.Domain
{
    /// <summary>
    /// Molde object for NHibernate mapped table Molde.
    /// </summary>
    [Serializable]
    public class Molde : DomainObject<System.Int32>
    {


        private System.String _Descripcion;
        private IList<MoldePaciente> _Pacientes = new List<MoldePaciente>();

        public Molde()
        {
        }

        public Molde(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Descripcion {
             get { return _Descripcion; }
             set { _Descripcion = value;}
         }

         public virtual IList<MoldePaciente> Pacientes
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
