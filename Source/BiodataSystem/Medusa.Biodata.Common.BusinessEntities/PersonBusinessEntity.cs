
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Medusa.Biodata.Common.BusinessEntities
{
    /// <summary>
    /// Entidad de Negocios para Person.
    /// </summary>
    [DataObjectAttribute]
    public class PersonEntity : BaseBusinessEntity
    {
        private Int32? _ID;

        public Int32? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private String _FirstName;

        public String FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        private String _LastName;

        public String LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        private DocumentTypeEntity _DocumentType;

        public DocumentTypeEntity DocumentType
        {
            get { return _DocumentType; }
            set { _DocumentType = value; }
        }
        private String _DocumentNumber;

        public String DocumentNumber
        {
            get { return _DocumentNumber; }
            set { _DocumentNumber = value; }
        }
        private String _Address;

        public String Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        private String _Phone;

        public String Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        private String _Mobile;

        public String Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }
        private String _Email;

        public String Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private DateTime? _DateBirth;

        public DateTime? DateBirth
        {
            get { return _DateBirth; }
            set { _DateBirth = value; }
        }

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public PersonEntity()
        {

        }

        public override string ToString()
        {
            throw new Exception("Debe implementar el método ToString() de la entidad Person.");
        }


    }

    /// <summary>
    /// Lista de Person.
    /// </summary>
    [DataObjectAttribute]
    public class PersonEntities : ListBaseBusinessEntity<PersonEntity>
    {

    }
}

