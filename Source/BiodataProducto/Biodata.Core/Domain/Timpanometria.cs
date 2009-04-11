using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// Timpanometria object for NHibernate mapped table Timpanometria.
    /// </summary>
    [Serializable]
    public class Timpanometria : Estudio//DomainObject<System.Int32>
    {


        private System.String _TimpanometriaGrafico;
        //private Estudio _IDEstudioLookup;

        public Timpanometria()
        {
        }

        public Timpanometria(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String TimpanometriaGrafico {
             get { return _TimpanometriaGrafico; }
             set { _TimpanometriaGrafico = value;}
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
