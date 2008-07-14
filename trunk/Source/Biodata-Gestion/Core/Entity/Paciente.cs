using System;
using System.Collections.Generic;
using System.Text;

namespace Medusa.Biodata.Entity
{
    public class Paciente : DomainObject<long>
    {

        #region -[Members]-
        private long _id;
        private string _nombre;
        private string _apellido;
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
        #endregion


        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }

    }
}
