
using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Common.BusinessEntities;
using System.Data.Common;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Medusa.Biodata.BackEnd.DataAccessComponents
{
    /// <summary>
    /// TDG para Product.
    /// </summary>
    public class ProductTableDataGateway : BaseTableDataGateway
    {
        /// <summary>
        /// Búsqueda  de Product.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>ProductEntities</returns>
        public static ProductEntities Search(ProductEntity pBE)
        {
            ProductEntities wLista = new ProductEntities();

            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("PROProduct_s");

            wDataBase.AddInParameter(wCmd, "PROId", DbType.Int32, pBE.ID);
            wDataBase.AddInParameter(wCmd, "PROName", DbType.String, pBE.Name);
            wDataBase.AddInParameter(wCmd, "PRODescription", DbType.String, pBE.Description);
            wDataBase.AddInParameter(wCmd, "PROCurrentStock", DbType.Int32, pBE.CurrentStock);
            wDataBase.AddInParameter(wCmd, "PROMinimumStock", DbType.Int32, pBE.MinimumStock);
            wDataBase.AddInParameter(wCmd, "PROPrice", DbType.Decimal, pBE.Price);
            wDataBase.AddInParameter(wCmd, "PROCost", DbType.Decimal, pBE.Cost);
            wDataBase.AddInParameter(wCmd, "PRTId", DbType.Int32, pBE.ProductType.ID);

            DataTable wDt = wDataBase.ExecuteDataSet(wCmd).Tables[0];

            foreach (DataRow wDr in wDt.Rows)
            {
                ProductEntity wProduct = new ProductEntity();
                wProduct.ID = Convert.ToInt32(wDr["PROId"]);
                wProduct.Name = Convert.ToString(wDr["PROName"]);
                wProduct.Description = Convert.ToString(wDr["PRODescription"]);
                wProduct.CurrentStock = Convert.ToInt32(wDr["PROCurrentStock"]);
                wProduct.MinimumStock = Convert.ToInt32(wDr["PROMinimumStock"]);
                wProduct.Price = Convert.ToDecimal(wDr["PROPrice"]);
                wProduct.Cost = Convert.ToDecimal(wDr["PROCost"]);
                wProduct.ProductType.ID = Convert.ToInt32(wDr["PRTId"]);

                wLista.Add(wProduct);
            }

            return wLista;

        }

        /// <summary>
        /// Inserta Product.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Insert(ProductEntity pBE)
        {
            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("PROProduct_i");

            wDataBase.AddOutParameter(wCmd, "PROId", DbType.Int32, 4);
            wDataBase.AddInParameter(wCmd, "PROName", DbType.String, pBE.Name);
            wDataBase.AddInParameter(wCmd, "PRODescription", DbType.String, pBE.Description);
            wDataBase.AddInParameter(wCmd, "PROCurrentStock", DbType.Int32, pBE.CurrentStock);
            wDataBase.AddInParameter(wCmd, "PROMinimumStock", DbType.Int32, pBE.MinimumStock);
            wDataBase.AddInParameter(wCmd, "PROPrice", DbType.Decimal, pBE.Price);
            wDataBase.AddInParameter(wCmd, "PROCost", DbType.Decimal, pBE.Cost);
            wDataBase.AddInParameter(wCmd, "PRTId", DbType.Int32, pBE.ProductType.ID);

            wDataBase.ExecuteNonQuery(wCmd);

            return Convert.ToInt32(wDataBase.GetParameterValue(wCmd, "PROId"));
        }

        /// <summary>
        /// Borra Product.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Delete(ProductEntity pBE)
        {
            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("PROProduct_d");

            wDataBase.AddInParameter(wCmd, "PROId", DbType.Int32, pBE.ID);

            return wDataBase.ExecuteNonQuery(wCmd);
        }

        /// <summary>
        /// Actualiza Product.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Update(ProductEntity pBE)
        {
            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("PROProduct_u");

            wDataBase.AddInParameter(wCmd, "PROId", DbType.Int32, pBE.ID);
            wDataBase.AddInParameter(wCmd, "PROName", DbType.String, pBE.Name);
            wDataBase.AddInParameter(wCmd, "PRODescription", DbType.String, pBE.Description);
            wDataBase.AddInParameter(wCmd, "PROCurrentStock", DbType.Int32, pBE.CurrentStock);
            wDataBase.AddInParameter(wCmd, "PROMinimumStock", DbType.Int32, pBE.MinimumStock);
            wDataBase.AddInParameter(wCmd, "PROPrice", DbType.Decimal, pBE.Price);
            wDataBase.AddInParameter(wCmd, "PROCost", DbType.Decimal, pBE.Cost);
            wDataBase.AddInParameter(wCmd, "PRTId", DbType.Int32, pBE.ProductType.ID);

            return wDataBase.ExecuteNonQuery(wCmd);
        }

        /// <summary>
        /// Búsqueda de Product por id.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>ProductEntity</returns>
        public static ProductEntity Get(Int32 pId)
        {
            ProductEntities woProduct;
            woProduct = Search(new ProductEntity(pId));
            if (woProduct.Count > 0)
            {
                return woProduct[0];
            }
            else
            {
                return null;
            }
        }
    }
}
