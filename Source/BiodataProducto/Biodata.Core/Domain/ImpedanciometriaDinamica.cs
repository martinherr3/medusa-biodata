using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// ImpedanciometriaDinamica object for NHibernate mapped table ImpedanciometriaDinamica.
    /// </summary>
    [Serializable]
    public class ImpedanciometriaDinamica : DomainObject<System.Int32>
    {


        private System.Int32 _Lado;
        private System.Int32 _Clase;
        private System.Int32 _Tipo;
        private System.Decimal? _U;
        private System.Decimal? _UR;
        private System.Decimal? _ISU;
        private Estudio _IDEstudioLookup;

        public ImpedanciometriaDinamica()
        {
        }

        public ImpedanciometriaDinamica(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.Int32 Lado {
             get { return _Lado; }
             set { _Lado = value;}
         }

         public virtual System.Int32 Clase {
             get { return _Clase; }
             set { _Clase = value;}
         }

         public virtual System.Int32 Tipo {
             get { return _Tipo; }
             set { _Tipo = value;}
         }

         public virtual System.Decimal? U {
             get { return _U; }
             set { _U = value;}
         }

         public virtual System.Decimal? UR {
             get { return _UR; }
             set { _UR = value;}
         }

         public virtual System.Decimal? ISU {
             get { return _ISU; }
             set { _ISU = value;}
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
