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


    public class PreguntasAnamnesis
    {
        public PreguntasAnamnesis()
        {
            _Preguntas = new[]{"¿Usó antes audífono?", "-¿Cómo oye en ambientes ruidosos?", "-¿Entiende lo que le dicen?"};
        }

        private String[] _Preguntas;

        public String[] Preguntas
        {
            get { return _Preguntas; }
            set { _Preguntas = value; }
        }
    }
}
