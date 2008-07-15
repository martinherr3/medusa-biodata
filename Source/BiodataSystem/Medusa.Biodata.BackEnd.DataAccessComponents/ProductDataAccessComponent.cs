
using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Common.BusinessEntities;
using System.Data.Common;
using System.Data;

namespace Medusa.Biodata.BackEnd.DataAccessComponents
{
    /// <summary>
    /// DAC para Product.
    /// </summary>
    public class ProductDataAccessComponent : BaseDataAccessComponent
    {
        /// <summary>
        /// Búsqueda  de Product.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>ProductEntities</returns>
        public static ProductEntities Search(ProductEntity pBE)
        {
            try
            {
                return ProductTableDataGateway.Search(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inserta Product.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Insert(ProductEntity pBE)
        {
            try
            {
                return ProductTableDataGateway.Insert(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Borra Product.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Delete(ProductEntity pBE)
        {
            try
            {
                return ProductTableDataGateway.Delete(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Actualiza Product.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Update(ProductEntity pBE)
        {
            try
            {
                return ProductTableDataGateway.Update(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
