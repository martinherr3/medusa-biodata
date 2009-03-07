using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// SeleccionAudifono object for NHibernate mapped table SeleccionAudifono.
    /// </summary>
    [Serializable]
    public class SeleccionAudifono : DomainObject<System.Int32>
    {


        private System.DateTime _FechaSeleccion;
        private System.String _InstrumentosUtilizados;
        private System.String _Observaciones;
        private System.Boolean _LecturaLabial;
        private System.Boolean? _UsoDeAudifono;
        private System.DateTime _ProximaVisita;
        private System.String _NroSerie;
        private System.Int32 _IDAudifono;
        private System.Int32? _IDMolde;
        private Audifono _IDAudifonoLookup;
        private MoldeAudifono _IDMoldeLookup;

        public SeleccionAudifono()
        {
        }

        public SeleccionAudifono(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.DateTime FechaSeleccion {
             get { return _FechaSeleccion; }
             set { _FechaSeleccion = value;}
         }

         public virtual System.String InstrumentosUtilizados {
             get { return _InstrumentosUtilizados; }
             set { _InstrumentosUtilizados = value;}
         }

         public virtual System.String Observaciones {
             get { return _Observaciones; }
             set { _Observaciones = value;}
         }

         public virtual System.Boolean LecturaLabial {
             get { return _LecturaLabial; }
             set { _LecturaLabial = value;}
         }

         public virtual System.Boolean? UsoDeAudifono {
             get { return _UsoDeAudifono; }
             set { _UsoDeAudifono = value;}
         }

         public virtual System.DateTime ProximaVisita {
             get { return _ProximaVisita; }
             set { _ProximaVisita = value;}
         }

         public virtual System.String NroSerie {
             get { return _NroSerie; }
             set { _NroSerie = value;}
         }

         public virtual System.Int32 IDAudifono {
             get { return _IDAudifono; }
             set { _IDAudifono = value;}
         }

         public virtual System.Int32? IDMolde {
             get { return _IDMolde; }
             set { _IDMolde = value;}
         }

         public virtual Audifono IDAudifonoLookup{
             get { return _IDAudifonoLookup; }
             set { _IDAudifonoLookup = value;}
         }

         public virtual MoldeAudifono IDMoldeLookup{
             get { return _IDMoldeLookup; }
             set { _IDMoldeLookup = value;}
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
