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
