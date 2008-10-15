using System;
using System.Collections.Generic;

namespace Biodata.DTO
{
    /// <summary>
    /// TipoEstudio object for NHibernate mapped table TipoEstudio.
    /// </summary>
    [Serializable]
    public class TipoEstudioDTO : DomainObject<System.Int32>
    {


        private System.String _Nombre;
        private System.String _Descripcion;
        private System.String _EsquemaDatos;
        private List<EstudioDTO> _Estudios = new List<EstudioDTO>();

        public TipoEstudioDTO()
        {
        }

        public TipoEstudioDTO(System.Int32 id)
        {
            base.ID = id;
        }

        public virtual System.String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public virtual System.String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public virtual System.String EsquemaDatos
        {
            get { return _EsquemaDatos; }
            set { _EsquemaDatos = value; }
        }

        public virtual List<EstudioDTO> Estudios
        {
            get { return _Estudios; }
            set { _Estudios = value; }
        }


        public override int GetHashCode()
        {
            return ID.GetHashCode();
        }

    }
}
