using System;
using System.Collections.Generic;
using System.Text;

namespace Mds.Biodata.Forms
{
    public class Enumeraciones
    {
        public enum TipoDocumento
        {
            DNI,
            LC,
            LE
        }

        public enum Sexo
        {
            M,
            F
        }

 		public enum TipoRecordatorioVinculado
        {
            Personal,
            ProximaLimpieza,
            ProximoService
        }


 		//Esta enum indica a que formulario llamo para realizar una "Seleccion"
        public enum SeleccionDestino
        {
            CiudadSeleccion,        //frmCiudad
            ObraSocialSeleccion     //frmObraSocial
        }

        public enum TipoEstudio
        {
            Anamnesis,
            Audiometria,
            ImpedanciometriaEstatica, 
            ImpedanciometriaDinamica,
            LogoAudiometria,
            Timpanometria
        }

    }

    public class Constantes
    {
        public class Sexo
        {
            public const String Masculino = "M";
            public const String Femenino = "F";
        }
    }
}
