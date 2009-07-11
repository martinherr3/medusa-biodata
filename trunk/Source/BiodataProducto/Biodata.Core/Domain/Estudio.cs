using System;
using System.Collections.Generic;
using Mds.Architecture.Domain;

namespace Mds.Biodata.Domain
{
    /// <summary>
    /// Estudio object for NHibernate mapped table Estudio.
    /// </summary>
    [Serializable]
    public class Estudio : DomainObject<System.Int32>
    {


        private System.String _Nombre;
        private System.DateTime _FechaEstudio;
        private System.String _InstrumentosUtilizados;
        private System.String _Observaciones;
        private System.Int32? _TipoEstudio;
        private System.Int32? _IDHistoriaClinica;
        private HistoriaClinica _IDHistoriaClinicaLookup;

        //private IList<Anamnesi> _Anamnesises = new List<Anamnesi>();
        //private IList<Audiometria> _Audiometrias = new List<Audiometria>();
        //private IList<ImpedanciometriaDinamica> _ImpedanciometriaDinamicas = new List<ImpedanciometriaDinamica>();
        //private IList<ImpedanciometriaEstatica> _ImpedanciometriaEstaticas = new List<ImpedanciometriaEstatica>();
        //private IList<LogoAudiometria> _LogoAudiometrias = new List<LogoAudiometria>();
        //private IList<Timpanometria> _Timpanometrias = new List<Timpanometria>();

        public Estudio()
        {
        }

        public Estudio(System.Int32 id)
        {
            base.ID = id;
        }

         public virtual System.String Nombre {
             get { return _Nombre; }
             set { _Nombre = value;}
         }

         public virtual System.DateTime FechaEstudio {
             get { return _FechaEstudio; }
             set { _FechaEstudio = value;}
         }

         public virtual System.String InstrumentosUtilizados {
             get { return _InstrumentosUtilizados; }
             set { _InstrumentosUtilizados = value;}
         }

         public virtual System.String Observaciones {
             get { return _Observaciones; }
             set { _Observaciones = value;}
         }

         public virtual System.Int32? TipoEstudio {
             get { return _TipoEstudio; }
             set { _TipoEstudio = value;}
         }

         public virtual TipoEstudio TipoEstudioValue
         {
             get { return (TipoEstudio)_TipoEstudio; }
         }

         public virtual System.Int32? IDHistoriaClinica
         {
             get { return _IDHistoriaClinica; }
             set { _IDHistoriaClinica = value; }
         }

         public virtual HistoriaClinica IDHistoriaClinicaLookup
         {
             get { return _IDHistoriaClinicaLookup; }
             set { _IDHistoriaClinicaLookup = value; }
         }
         //public virtual IList<Anamnesi> Anamnesises{
         //    get { return _Anamnesises; }
         //    set { _Anamnesises = value; }
         //}

         //public virtual IList<Audiometria> Audiometrias
         //{
         //    get { return _Audiometrias; }
         //    set { _Audiometrias = value; }
         //}

         //public virtual IList<ImpedanciometriaDinamica> ImpedanciometriaDinamicas
         //{
         //    get { return _ImpedanciometriaDinamicas; }
         //    set { _ImpedanciometriaDinamicas = value; }
         //}

         //public virtual IList<ImpedanciometriaEstatica> ImpedanciometriaEstaticas
         //{
         //    get { return _ImpedanciometriaEstaticas; }
         //    set { _ImpedanciometriaEstaticas = value; }
         //}

         //public virtual IList<LogoAudiometria> LogoAudiometrias
         //{
         //    get { return _LogoAudiometrias; }
         //    set { _LogoAudiometrias = value; }
         //}

         //public virtual IList<Timpanometria> Timpanometrias
         //{
         //    get { return _Timpanometrias; }
         //    set { _Timpanometrias = value; }
         //}


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

     }

    public enum TipoEstudio
    {
        Anamnesis = 0,
        Audiometria = 1,
        //ImpedanciometriaEstatica=2,
        //ImpedanciometriaDinamica=3,
        LogoAudiometria = 4,
        Timpanometria = 5,
        TestDeLing = 6
    }
}
