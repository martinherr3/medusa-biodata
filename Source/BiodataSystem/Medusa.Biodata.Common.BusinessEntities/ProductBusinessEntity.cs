
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Medusa.Biodata.Common.BusinessEntities
{
    /// <summary>
    /// Entidad de Negocios para Product.
    /// </summary>
    [DataObjectAttribute]
    public class ProductEntity : BaseBusinessEntity
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
        private Int32? _CurrentStock;

        public Int32? CurrentStock
        {
            get { return _CurrentStock; }
            set { _CurrentStock = value; }
        }
        private Int32? _MinimumStock;

        public Int32? MinimumStock
        {
            get { return _MinimumStock; }
            set { _MinimumStock = value; }
        }
        private Decimal? _Price;

        public Decimal? Price
        {
            get { return _Price; }
            set { _Price = value; }
        }
        private Decimal? _Cost;

        public Decimal? Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }

        private ProductTypeEntity _ProductType;

        public ProductTypeEntity ProductType
        {
            get { return _ProductType; }
            set { _ProductType = value; }
        }


        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public ProductEntity()
        {
            this.ProductType = new ProductTypeEntity();
        }

        /// <summary>
        /// Constructor con Parametros.
        /// </summary>
        public ProductEntity(Int32 pID)
        {
            this.ID = pID;
            this.ProductType = new ProductTypeEntity();
        }

        public override string ToString()
        {
            throw new Exception("Debe implementar el método ToString() de la entidad Product.");
        }


    }

    /// <summary>
    /// Lista de Product.
    /// </summary>
    [DataObjectAttribute]
    public class ProductEntities : ListBaseBusinessEntity<ProductEntity>
    {

    }
}

