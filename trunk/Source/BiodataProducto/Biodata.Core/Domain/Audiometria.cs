using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// Audiometria object for NHibernate mapped table Audiometria.
    /// </summary>
    [Serializable]
    public class Audiometria : DomainObject<System.Int32>
    {


        private System.String _AudiogramaIzquierdo;
        private System.String _AudiogramaDerecho;
        private Estudio _IDEstudioLookup;

        public Audiometria()
        {
        }

        public Audiometria(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String AudiogramaIzquierdo {
             get { return _AudiogramaIzquierdo; }
             set { _AudiogramaIzquierdo = value;}
         }

         public virtual System.String AudiogramaDerecho {
             get { return _AudiogramaDerecho; }
             set { _AudiogramaDerecho = value;}
         }

         public virtual Estudio IDEstudioLookup{
             get { return _IDEstudioLookup; }
             set { _IDEstudioLookup = value;}
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
