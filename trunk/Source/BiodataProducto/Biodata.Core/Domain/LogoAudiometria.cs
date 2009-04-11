using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// LogoAudiometria object for NHibernate mapped table LogoAudiometria.
    /// </summary>
    [Serializable]
    public class LogoAudiometria : Estudio//DomainObject<System.Int32>
    {


        private System.Decimal? _CantidadPalabra;
        private System.String _LogoAudiometriaGrafico;
        private System.Decimal? _CantidadPalabraAcertada;
        private System.Int32? _IDListadoPalabra;
        private System.Int32? _TipoLogometriaLogoAudiometria;
        //private Estudio _IDEstudioLookup;
        private ListadoPalabra _IDListadoPalabraLookup;

        public LogoAudiometria()
        {
        }

        public LogoAudiometria(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.Decimal? CantidadPalabra {
             get { return _CantidadPalabra; }
             set { _CantidadPalabra = value;}
         }

         public virtual System.String LogoAudiometriaGrafico {
             get { return _LogoAudiometriaGrafico; }
             set { _LogoAudiometriaGrafico = value; }
         }

         public virtual System.Decimal? CantidadPalabraAcertada {
             get { return _CantidadPalabraAcertada; }
             set { _CantidadPalabraAcertada = value;}
         }

         public virtual System.Int32? IDListadoPalabra {
             get { return _IDListadoPalabra; }
             set { _IDListadoPalabra = value;}
         }

         public virtual System.Int32? TipoLogometriaLogoAudiometria {
             get { return _TipoLogometriaLogoAudiometria; }
             set { _TipoLogometriaLogoAudiometria = value;}
         }

         //public virtual Estudio IDEstudioLookup{
         //    get { return _IDEstudioLookup; }
         //    set { _IDEstudioLookup = value;}
         //}

         public virtual ListadoPalabra IDListadoPalabraLookup{
             get { return _IDListadoPalabraLookup; }
             set { _IDListadoPalabraLookup = value;}
         }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }
}
