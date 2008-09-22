using System;
using System.Collections.Generic;

namespace Medusa.Biodata.Domain
{
    /// <summary>
    /// Consulta object for NHibernate mapped table Consulta.
    /// </summary>
    [Serializable]
    public class Consulta : DomainObject<System.Int32>
    {


        private System.DateTime? _FechaConsulta;
        private System.String _Diagnostico;
        private System.Int32? _IdHistoriaClinica;
        private HistoriaClinica _IdHistoriaClinicaLookup;
        private IList<Estudio> _Estudios = new List<Estudio>();

        public Consulta()
        {
        }

        public Consulta(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.DateTime? FechaConsulta {
             get { return _FechaConsulta; }
             set { _FechaConsulta = value;}
         }

         public virtual System.String Diagnostico {
             get { return _Diagnostico; }
             set { _Diagnostico = value;}
         }

         public virtual System.Int32? IdHistoriaClinica {
             get { return _IdHistoriaClinica; }
             set { _IdHistoriaClinica = value;}
         }

         public virtual HistoriaClinica IdHistoriaClinicaLookup{
             get { return _IdHistoriaClinicaLookup; }
             set { _IdHistoriaClinicaLookup = value;}
         }

         public virtual IList<Estudio> Estudios{
             get { return _Estudios; }
             set { _Estudios = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
