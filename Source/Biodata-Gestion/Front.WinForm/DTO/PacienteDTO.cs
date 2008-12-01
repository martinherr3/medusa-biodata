using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Domain;

namespace Medusa.Biodata.FrontEnd.DTO
{
    public class PacienteDTO : AbstractDTO
    {
        private int _ID;
        private String _Nombre;
        private String _Apellido;
        private String _Direccion;
        private String _FechaNacimiento;
        private String _NumDocumento;
        private String _Sexo;
        private String _ObraSocial;
        private String _Comentario;
        private int _ObraSocialId;

        public int ObraSocialId
        {
            get { return _ObraSocialId; }
            set { _ObraSocialId = value; }
        }

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public String Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public String Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }

        public String FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        public String NumDocumento
        {
            get { return _NumDocumento; }
            set { _NumDocumento = value; }
        }

        public String Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }

        public String ObraSocial
        {
            get { return _ObraSocial; }
            set { _ObraSocial = value; }
        }

        public String Comentario
        {
            get { return _Comentario; }
            set { _Comentario = value; }
        }

    }
}
