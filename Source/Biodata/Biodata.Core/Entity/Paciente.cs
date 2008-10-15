using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Biodata.Domain
{
    /// <summary>
    /// Paciente object for NHibernate mapped table Paciente.
    /// </summary>
    
    [Serializable]
    public class Paciente : DomainObject<System.Int32>
    {
        
        private System.String _Nombre;
        private System.String _Apellido;
        private System.String _Direccion;
        private System.String _FechaNacimiento;
        private System.String _NumDocumento;
        private System.String _Sexo;
        private System.Int32? _IdObraSocial;
        private System.String _Comentario;
        private ObraSocial _IdObraSocialLookup;
        private IList<AudifonoPaciente> _Audifonos = new List<AudifonoPaciente>();
        private IList<HistoriaClinica> _HistoriaClinicas = new List<HistoriaClinica>();
        private IList<MoldePaciente> _Moldes = new List<MoldePaciente>();

        public Paciente()
        {
           
        }

        public Paciente(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Nombre {
             get { return _Nombre; }
             set { _Nombre = value;}
         }

         public virtual System.String Apellido {
             get { return _Apellido; }
             set { _Apellido = value;}
         }

         public virtual System.String Direccion {
             get { return _Direccion; }
             set { _Direccion = value;}
         }

         public virtual System.String FechaNacimiento {
             get { return _FechaNacimiento; }
             set { _FechaNacimiento = value;}
         }

         public virtual System.String NumDocumento {
             get { return _NumDocumento; }
             set { _NumDocumento = value;}
         }

         public virtual System.String Sexo {
             get { return _Sexo; }
             set { _Sexo = value;}
         }

         public virtual System.Int32? IdObraSocial {
             get { return _IdObraSocial; }
             set { _IdObraSocial = value;}
         }

         public virtual System.String Comentario {
             get { return _Comentario; }
             set { _Comentario = value;}
         }

         public virtual ObraSocial IdObraSocialLookup
         {
             get { return _IdObraSocialLookup; }
             set { _IdObraSocialLookup = value; }
         }

         public virtual IList<AudifonoPaciente> Audifonos
         {
             get { return _Audifonos; }
             set { _Audifonos = value; }
         }

         public virtual IList<HistoriaClinica> HistoriaClinicas
         {
             get { return _HistoriaClinicas; }
             set { _HistoriaClinicas = value; }
         }

         public virtual IList<MoldePaciente> Moldes
         {
             get { return _Moldes; }
             set { _Moldes = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }
    }
}
