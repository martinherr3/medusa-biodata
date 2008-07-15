
using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Common.BusinessEntities;
using Medusa.Biodata.BackEnd.DataAccessComponents;


namespace Medusa.Biodata.BackEnd.BusinessComponents
{
    /// <summary>
    /// Componente de negocios para Product.
    /// </summary>
    public class ProductBusinessComponent : BaseBusinessComponent
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
                return ProductDataAccessComponent.Search(pBE);
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
                return ProductDataAccessComponent.Insert(pBE);
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
                return ProductDataAccessComponent.Delete(pBE);
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
                return ProductDataAccessComponent.Update(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
