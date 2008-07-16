using System;
using System.Collections.Generic;
using System.Text;

namespace Medusa.Biodata.Entity
{
    public class Paciente : DomainObject<long>
    {
        /// <summary>
        /// NHibernate necesita un contructor por defecto
        /// </summary>
        public Paciente() { }


        #region -[Members]-
        private long _id;
        private string _nombre;
        private string _apellido;
        private int _edad;
        #endregion


        #region -[Properties]-
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }     

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }    

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        #endregion


        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

    }
}
