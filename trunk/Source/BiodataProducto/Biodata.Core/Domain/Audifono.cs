//using System;
//using System.Collections.Generic;
//using Medusa.Base.Domain;

using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// Audifono object for NHibernate mapped table Audifono.
    /// </summary>
    [Serializable]
    public class Audifono : DomainObject<System.Int32>
    {


        private System.String _NombreModelo;
        private System.Int32 _Marca;
        private System.String _Observacion;
        private System.Int32 _Tipo;
        private System.Int32? _Senal;
        private System.Boolean? _Programable;
        private System.String _FranjaAdaptacion;
        private System.Decimal? _PresionMaximaSalida;
        private MarcaAudifono _IDAudifonoLookup;
        private IList<AudifonoPaciente> _AudifonoPacientes = new List<AudifonoPaciente>();
        private IList<MoldeAudifono> _MoldeAudifonos = new List<MoldeAudifono>();
        private IList<SeleccionAudifono> _SeleccionAudifonos = new List<SeleccionAudifono>();

        public Audifono()
        {
        }

        public Audifono(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String NombreModelo {
             get { return _NombreModelo; }
             set { _NombreModelo = value;}
         }

         public virtual System.Int32 Marca {
             get { return _Marca; }
             set { _Marca = value;}
         }

         public virtual System.String Observacion {
             get { return _Observacion; }
             set { _Observacion = value;}
         }

         public virtual System.Int32 Tipo {
             get { return _Tipo; }
             set { _Tipo = value;}
         }

         public virtual System.Int32? Senal {
             get { return _Senal; }
             set { _Senal = value;}
         }

         public virtual System.Boolean? Programable {
             get { return _Programable; }
             set { _Programable = value;}
         }

         public virtual System.String FranjaAdaptacion {
             get { return _FranjaAdaptacion; }
             set { _FranjaAdaptacion = value;}
         }

         public virtual System.Decimal? PresionMaximaSalida {
             get { return _PresionMaximaSalida; }
             set { _PresionMaximaSalida = value;}
         }

         public virtual MarcaAudifono IDAudifonoLookup
         {
             get { return _IDAudifonoLookup; }
             set { _IDAudifonoLookup = value; }
         }

         public virtual IList<AudifonoPaciente> AudifonoPacientes
         {
             get { return _AudifonoPacientes; }
             set { _AudifonoPacientes = value; }
         }

         public virtual IList<MoldeAudifono> MoldeAudifonos
         {
             get { return _MoldeAudifonos; }
             set { _MoldeAudifonos = value; }
         }

         public virtual IList<SeleccionAudifono> SeleccionAudifonos
         {
             get { return _SeleccionAudifonos; }
             set { _SeleccionAudifonos = value; }
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
