using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// MoldeAudifono object for NHibernate mapped table MoldeAudifono.
    /// </summary>
    [Serializable]
    public class MoldeAudifono : DomainObject<System.Int32>
    {

        private System.String _Nombre;
        private System.Int32 _Tipo;
        private System.Int32 _Material;
        private System.Boolean _Ventilacion;
        private System.Decimal? _MedidaVentilacion;
        private System.DateTime? _FechaRenovacion;
        private System.DateTime? _FechaFabricacion;
        //private System.Int32? _IDAudifono;
        //private Audifono _IDAudifonoLookup;
        //private IList<SeleccionAudifono> _SeleccionAudifonos = new List<SeleccionAudifono>();

        public MoldeAudifono()
        {
        }

        public MoldeAudifono(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Nombre
         {
            get { return _Nombre; }
            set { _Nombre = value; }
         }

         public virtual System.Int32 Tipo {
             get { return _Tipo; }
             set { _Tipo = value;}
         }

         public virtual TipoMolde TipoValue
         {
             get { return (TipoMolde)_Tipo; }
         }

         public virtual System.Int32 Material {
             get { return _Material; }
             set { _Material = value;}
         }

         public virtual MaterialMolde MaterialValue
         {
             get { return (MaterialMolde)_Material; }
         }

         public virtual System.Boolean Ventilacion {
             get { return _Ventilacion; }
             set { _Ventilacion = value;}
         }

         public virtual System.Decimal? MedidaVentilacion {
             get { return _MedidaVentilacion; }
             set { _MedidaVentilacion = value;}
         }

         public virtual System.DateTime? FechaRenovacion {
             get { return _FechaRenovacion; }
             set { _FechaRenovacion = value;}
         }

         public virtual System.DateTime? FechaFabricacion {
             get { return _FechaFabricacion; }
             set { _FechaFabricacion = value;}
         }

         //public virtual System.Int32? IDAudifono {
         //    get { return _IDAudifono; }
         //    set { _IDAudifono = value;}
         //}

         //public virtual Audifono IDAudifonoLookup{
         //    get { return _IDAudifonoLookup; }
         //    set { _IDAudifonoLookup = value;}
         //}

         //public virtual IList<SeleccionAudifono> SeleccionAudifonos
         //{
         //    get { return _SeleccionAudifonos; }
         //    set { _SeleccionAudifonos = value; }
         //}

        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }

    public enum TipoMolde
    {
        FullShell = 0,
        Shell = 1,
        Canal = 2,
        Skeleton = 3
    }

    public enum MaterialMolde
    {
        Siliconado = 0,
        Blando = 1,
        Acrilico = 2
    }
}
