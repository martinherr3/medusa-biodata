using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// TestLing object for NHibernate mapped table TestLing.
    /// </summary>
    [Serializable]
    public class TestLing : Estudio
    {


        private System.String _TablaValores;
        //private Estudio _IDEstudioLookup;

        public TestLing()
        {
        }

        public TestLing(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String TablaValores {
             get { return _TablaValores; }
             set { _TablaValores = value;}
         }

         //public virtual Estudio IDEstudioLookup{
         //    get { return _IDEstudioLookup; }
         //    set { _IDEstudioLookup = value;}
         //}


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
