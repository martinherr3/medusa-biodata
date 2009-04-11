using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// HistoriaClinica object for NHibernate mapped table HistoriaClinica.
    /// </summary>
    [Serializable]
    public class HistoriaClinica : DomainObject<System.Int32>
    {


        private System.DateTime _FechaInicioAtencion;
        private System.String _Observaciones;
        private System.String _AntecedentesHereditarios;
        private System.String _AntecedentesPersonales;
        private System.String _EstadoSalud;
        private System.Int32? _IDPaciente;
        private Paciente _IDPacienteLookup;
        private IList<Estudio> _Estudios = new List<Estudio>();

        public HistoriaClinica()
        {
        }

        public HistoriaClinica(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.DateTime FechaInicioAtencion {
             get { return _FechaInicioAtencion; }
             set { _FechaInicioAtencion = value;}
         }

         public virtual System.String Observaciones {
             get { return _Observaciones; }
             set { _Observaciones = value;}
         }

         public virtual System.String AntecedentesHereditarios {
             get { return _AntecedentesHereditarios; }
             set { _AntecedentesHereditarios = value;}
         }

         public virtual System.String AntecedentesPersonales {
             get { return _AntecedentesPersonales; }
             set { _AntecedentesPersonales = value;}
         }

         public virtual System.String EstadoSalud {
             get { return _EstadoSalud; }
             set { _EstadoSalud = value;}
         }

         public virtual System.Int32? IDPaciente {
             get { return _IDPaciente; }
             set { _IDPaciente = value;}
         }

         public virtual Paciente IDPacienteLookup{
             get { return _IDPacienteLookup; }
             set { _IDPacienteLookup = value;}
         }

         public virtual IList<Estudio> Estudios
         {
             get { return _Estudios; }
             set { _Estudios = value; }
         }

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
