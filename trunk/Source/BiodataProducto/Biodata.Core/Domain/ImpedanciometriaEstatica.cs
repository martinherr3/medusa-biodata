using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// ImpedanciometriaEstatica object for NHibernate mapped table ImpedanciometriaEstatica.
    /// </summary>
    [Serializable]
    public class ImpedanciometriaEstatica : DomainObject<System.Int32>
    {


        private System.Int32 _Lado;
        private System.Decimal? _Presion200;
        private System.Decimal? _PresionPaciente;
        private System.Decimal? _Za;
        private System.Decimal? _Cm;
        private Estudio _IDEstudioLookup;

        public ImpedanciometriaEstatica()
        {
        }

        public ImpedanciometriaEstatica(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.Int32 Lado {
             get { return _Lado; }
             set { _Lado = value;}
         }

         public virtual System.Decimal? Presion200 {
             get { return _Presion200; }
             set { _Presion200 = value;}
         }

         public virtual System.Decimal? PresionPaciente {
             get { return _PresionPaciente; }
             set { _PresionPaciente = value;}
         }

         public virtual System.Decimal? Za {
             get { return _Za; }
             set { _Za = value;}
         }

         public virtual System.Decimal? Cm {
             get { return _Cm; }
             set { _Cm = value;}
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
