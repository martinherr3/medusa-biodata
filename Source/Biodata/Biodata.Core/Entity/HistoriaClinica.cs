using System;
using System.Collections.Generic;

namespace Biodata.Domain
{
    /// <summary>
    /// HistoriaClinica object for NHibernate mapped table HistoriaClinica.
    /// </summary>
    [Serializable]
    public class HistoriaClinica : DomainObject<System.Int32>
    {


        private System.String _AntecedentesFamiliares;
        private System.String _AntecedentesPersonales;
        private System.String _DatosDeInteres;
        private System.Int32 _IdPaciente;
        private Paciente _IdPacienteLookup;
        private IList<Consulta> _Consultas = new List<Consulta>();

        public HistoriaClinica()
        {
        }

        public HistoriaClinica(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String AntecedentesFamiliares {
             get { return _AntecedentesFamiliares; }
             set { _AntecedentesFamiliares = value;}
         }

         public virtual System.String AntecedentesPersonales {
             get { return _AntecedentesPersonales; }
             set { _AntecedentesPersonales = value;}
         }

         public virtual System.String DatosDeInteres {
             get { return _DatosDeInteres; }
             set { _DatosDeInteres = value;}
         }

         public virtual System.Int32 IdPaciente {
             get { return _IdPaciente; }
             set { _IdPaciente = value;}
         }

         public virtual Paciente IdPacienteLookup{
             get { return _IdPacienteLookup; }
             set { _IdPacienteLookup = value;}
         }

         public virtual IList<Consulta> Consultas{
             get { return _Consultas; }
             set { _Consultas = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
