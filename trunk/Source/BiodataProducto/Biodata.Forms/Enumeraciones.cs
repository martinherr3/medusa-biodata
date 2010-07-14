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
            CiudadSeleccion=0,        //frmCiudad
            ObraSocialSeleccion=1,    //frmObraSocial
            AudifonosSeleccion=2,               //frmAudifono
            MoldeAudifonoSeleccion=3           //frmMoldeAudifono
        }

        public enum TipoEstudio
        {
            Anamnesis=0,
            Audiometria=1,
            //ImpedanciometriaEstatica=2,
            //ImpedanciometriaDinamica=3,
            LogoAudiometria=4,
            Timpanometria=5,
            TestDeLing=6
        }

        public enum TipoAudifono
        {
            Retroauricular=0,
            Minicanal=1,
            Cic=2,
            Canal=3,
            HalfShell=4,
            FullShell=5
        }

        public enum SenalAudifono
        {
            Digital=0,
            Analogico=1
        }

        public enum TipoUsuario
        {
            Administrador=0,
            UsuarioComun=1
        }

        public enum TipoMolde
        {
            FullShell=0,
            Shell=1,
            Canal=2,
            Skeleton=3
        }

        public enum MaterialMolde
        {
            Siliconado=0, 
            Blando=1,
            Acrilico=2
        }

        public enum LadoOido
        {
            Izquierdo = 0,
            Derecho = 1
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
            _Preguntas = new[] { "¿Usó antes audífono?", "-¿Cómo oye en ambientes ruidosos?", "-¿Entiende lo que le dicen?", "-¿Comprende cada palabra?"};
        }

        private String[] _Preguntas;

        public String[] Preguntas
        {
            get { return _Preguntas; }
            set { _Preguntas = value; }
        }
    }
}
