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
        private System.Int32? _ReflejoEstapedialIzq; //Guarda el valor 0 para ".5" y 1 para "1.0"
        private System.Int32? _ReflejoEstapedialDer; //Guarda el valor 0 para ".5" y 1 para "1.0"
        private System.String _TablaReflejosIzq; //XML con Valores
        private System.String _TablaReflejosDer; //XML con Valores

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

         public virtual System.Int32? ReflejoEstapedialIzq
         {
             get { return _ReflejoEstapedialIzq; }
             set { _ReflejoEstapedialIzq = value; }
         }

         public virtual System.Int32? ReflejoEstapedialDer
         {
             get { return _ReflejoEstapedialDer; }
             set { _ReflejoEstapedialDer = value; }
         }

         public virtual System.String TablaReflejosIzq
         {
             get { return _TablaReflejosIzq; }
             set { _TablaReflejosIzq = value; }
         }

         public virtual System.String TablaReflejosDer
         {
             get { return _TablaReflejosDer; }
             set { _TablaReflejosDer = value; }
         }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
