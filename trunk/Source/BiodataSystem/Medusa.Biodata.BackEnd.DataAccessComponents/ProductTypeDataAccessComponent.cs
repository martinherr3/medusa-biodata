
using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Common.BusinessEntities;
using System.Data.Common;
using System.Data;

namespace Medusa.Biodata.BackEnd.DataAccessComponents
{
    /// <summary>
    /// DAC para ProductType.
    /// </summary>
    public class ProductTypeDataAccessComponent : BaseDataAccessComponent
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
                return ProductTypeTableDataGateway.Search(pBE);
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
                return ProductTypeTableDataGateway.Insert(pBE);
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
                return ProductTypeTableDataGateway.Delete(pBE);
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
                return ProductTypeTableDataGateway.Update(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
