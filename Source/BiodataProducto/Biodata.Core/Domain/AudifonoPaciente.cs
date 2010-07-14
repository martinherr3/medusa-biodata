using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// AudifonoPaciente object for NHibernate mapped table AudifonoPaciente.
    /// </summary>
    [Serializable]
    public class AudifonoPaciente : DomainObject<System.Int32>
    {


        private System.String _NroSerie;
        private System.DateTime? _FechaFabricacion;
        private System.DateTime? _ProximoService;
        private System.String _Observacion;
        private System.String _Estado;
        private System.Int32? _LadoOido;
        private System.Int32? _IDPaciente;
        private System.Int32? _IDAudifono;
        private System.Int32? _IDMolde;
        private Audifono _IDAudifonoLookup;
        private Paciente _IDPacienteLookup;
        private MoldeAudifono _IDMoldeLookup;

        public AudifonoPaciente()
        {
        }

        public AudifonoPaciente(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String NroSerie {
             get { return _NroSerie; }
             set { _NroSerie = value;}
         }

         public virtual System.DateTime? FechaFabricacion {
             get { return _FechaFabricacion; }
             set { _FechaFabricacion = value;}
         }

         public virtual System.DateTime? ProximoService {
             get { return _ProximoService; }
             set { _ProximoService = value;}
         }

         public virtual System.String Observacion {
             get { return _Observacion; }
             set { _Observacion = value;}
         }

         public virtual System.String Estado {
             get { return _Estado; }
             set { _Estado = value;}
         }

         public virtual System.Int32? LadoOido {
             get { return _LadoOido; }
             set { _LadoOido = value;}
         }

         public virtual System.Int32? IDPaciente {
             get { return _IDPaciente; }
             set { _IDPaciente = value;}
         }

         public virtual System.Int32? IDAudifono {
             get { return _IDAudifono; }
             set { _IDAudifono = value;}
         }

         public virtual System.Int32? IDMolde
         {
             get { return _IDMolde; }
             set { _IDMolde = value; }
         }

         public virtual Audifono IDAudifonoLookup{
             get { return _IDAudifonoLookup; }
             set { _IDAudifonoLookup = value;}
         }

         public virtual Paciente IDPacienteLookup{
             get { return _IDPacienteLookup; }
             set { _IDPacienteLookup = value;}
         }

         public virtual MoldeAudifono IDMoldeLookup
         {
             get { return _IDMoldeLookup; }
             set { _IDMoldeLookup = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
