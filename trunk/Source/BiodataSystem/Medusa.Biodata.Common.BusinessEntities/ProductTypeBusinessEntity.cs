
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Medusa.Biodata.Common.BusinessEntities
{
    /// <summary>
    /// Entidad de Negocios para ProductType.
    /// </summary>
    [DataObjectAttribute]
    public class ProductTypeEntity : BaseBusinessEntity
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
        public ProductTypeEntity()
        {

        }

        /// <summary>
        /// Constructor con Parametros.
        /// </summary>
        public ProductTypeEntity(Int32 pID)
        {
            this.ID = pID;
        }

        public override string ToString()
        {
            return this.Name;
        }


    }

    /// <summary>
    /// Lista de ProductType.
    /// </summary>
    [DataObjectAttribute]
    public class ProductTypeEntities : ListBaseBusinessEntity<ProductTypeEntity>
    {

    }
}

