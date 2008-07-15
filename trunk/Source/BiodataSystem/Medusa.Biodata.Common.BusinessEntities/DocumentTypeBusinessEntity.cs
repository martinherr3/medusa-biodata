
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Medusa.Biodata.Common.BusinessEntities
{
    /// <summary>
    /// Entidad de Negocios para DocumentType.
    /// </summary>
    [DataObjectAttribute]
    public class DocumentTypeEntity : BaseBusinessEntity
    {
        private Int32? _ID;

        public Int32? ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private String _Name;

        public String Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        private String _Description;

        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }


        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public DocumentTypeEntity()
        {

        }

        /// <summary>
        /// Constructor con Parametros.
        /// </summary>
        public DocumentTypeEntity(Int32 pID)
        {

        }

        public override string ToString()
        {
            return this.Name;
            //throw new Exception("Debe implementar el método ToString() de la entidad DocumentType.");
        }


    }

    /// <summary>
    /// Lista de DocumentType.
    /// </summary>
    [DataObjectAttribute]
    public class DocumentTypeEntities : ListBaseBusinessEntity<DocumentTypeEntity>
    {

    }
}

