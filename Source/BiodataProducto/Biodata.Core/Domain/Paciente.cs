using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
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
        private System.Int32 _TipoDocumento;
        private System.Decimal _NumeroDocumento;
        private System.String _CorreoElectronico;
        private System.DateTime? _FechaNacimiento;
        private System.String _Sexo;
        private System.String _Comentario;
        private System.String _Telefono;
        private System.Int32? _Celular;
        private System.Int32? _IDObraSocial;
        private System.Int32? _IDCiudad;
        private Ciudad _IDCiudadLookup;
        private IList<AudifonoPaciente> _AudifonoPacientes = new List<AudifonoPaciente>();
        private IList<HistoriaClinica> _HistoriaClinicas = new List<HistoriaClinica>();
        private IList<ObraSocialXPaciente> _ObraSocialXPacientes = new List<ObraSocialXPaciente>();

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

         public virtual System.Int32 TipoDocumento {
             get { return _TipoDocumento; }
             set { _TipoDocumento = value;}
         }

         public virtual System.Decimal NumeroDocumento {
             get { return _NumeroDocumento; }
             set { _NumeroDocumento = value;}
         }

         public virtual System.String CorreoElectronico {
             get { return _CorreoElectronico; }
             set { _CorreoElectronico = value;}
         }

         public virtual System.DateTime? FechaNacimiento {
             get { return _FechaNacimiento; }
             set { _FechaNacimiento = value;}
         }

         public virtual System.String Sexo {
             get { return _Sexo; }
             set { _Sexo = value;}
         }

         public virtual System.String Comentario {
             get { return _Comentario; }
             set { _Comentario = value;}
         }

         public virtual System.String Telefono {
             get { return _Telefono; }
             set { _Telefono = value;}
         }

         public virtual System.Int32? Celular {
             get { return _Celular; }
             set { _Celular = value;}
         }

         public virtual System.Int32? IDObraSocial {
             get { return _IDObraSocial; }
             set { _IDObraSocial = value;}
         }

         public virtual System.Int32? IDCiudad {
             get { return _IDCiudad; }
             set { _IDCiudad = value;}
         }

         public virtual Ciudad IDCiudadLookup{
             get { return _IDCiudadLookup; }
             set { _IDCiudadLookup = value;}
         }

         public virtual IList<AudifonoPaciente> AudifonoPacientes
         {
             get { return _AudifonoPacientes; }
             set { _AudifonoPacientes = value; }
         }

         public virtual IList<HistoriaClinica> HistoriaClinicas
         {
             get { return _HistoriaClinicas; }
             set { _HistoriaClinicas = value; }
         }

         public virtual IList<ObraSocialXPaciente> ObraSocialXPacientes
         {
             get { return _ObraSocialXPacientes; }
             set { _ObraSocialXPacientes = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
