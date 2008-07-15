
using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Common.BusinessEntities;
using Medusa.Biodata.BackEnd.DataAccessComponents;


namespace Medusa.Biodata.BackEnd.BusinessComponents
{
    /// <summary>
    /// Componente de negocios para ProductType.
    /// </summary>
    public class ProductTypeBusinessComponent : BaseBusinessComponent
    {
        /// <summary>
        /// Búsqueda  de ProductType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>ProductTypeEntities</returns>
        public static ProductTypeEntities Search(ProductTypeEntity pBE)
        {
            try
            {
                return ProductTypeDataAccessComponent.Search(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inserta ProductType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Insert(ProductTypeEntity pBE)
        {
            try
            {
                return ProductTypeDataAccessComponent.Insert(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Borra ProductType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Delete(ProductTypeEntity pBE)
        {
            try
            {
                return ProductTypeDataAccessComponent.Delete(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Actualiza ProductType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Update(ProductTypeEntity pBE)
        {
            try
            {
                return ProductTypeDataAccessComponent.Update(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
