
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
    /// TDG para ProductType.
    /// </summary>
    public class ProductTypeTableDataGateway : BaseTableDataGateway
    {
        /// <summary>
        /// Búsqueda  de ProductType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>ProductTypeEntities</returns>
        public static ProductTypeEntities Search(ProductTypeEntity pBE)
        {
            ProductTypeEntities wLista = new ProductTypeEntities();

            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("PRTProductType_s");

            wDataBase.AddInParameter(wCmd, "PRTId", DbType.Int32, pBE.ID);
            wDataBase.AddInParameter(wCmd, "PRTName", DbType.String, pBE.Name);
            wDataBase.AddInParameter(wCmd, "PRTDescription", DbType.String, pBE.Description);

            DataTable wDt = wDataBase.ExecuteDataSet(wCmd).Tables[0];

            foreach (DataRow wDr in wDt.Rows)
            {
                ProductTypeEntity wProductType = new ProductTypeEntity();
                wProductType.ID = Convert.ToInt32(wDr["PRTId"]);
                wProductType.Name = Convert.ToString(wDr["PRTName"]);
                wProductType.Description = Convert.ToString(wDr["PRTDescription"]);

                wLista.Add(wProductType);
            }

            return wLista;

        }

        /// <summary>
        /// Inserta ProductType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Insert(ProductTypeEntity pBE)
        {
            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("PRTProductType_i");

            wDataBase.AddOutParameter(wCmd, "PRTId", DbType.Int32, 4);
            wDataBase.AddInParameter(wCmd, "PRTName", DbType.String, pBE.Name);
            wDataBase.AddInParameter(wCmd, "PRTDescription", DbType.String, pBE.Description);

            wDataBase.ExecuteNonQuery(wCmd);

            return Convert.ToInt32(wDataBase.GetParameterValue(wCmd, "PRTId"));
        }

        /// <summary>
        /// Borra ProductType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Delete(ProductTypeEntity pBE)
        {
            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("PRTProductType_d");

            wDataBase.AddInParameter(wCmd, "PRTId", DbType.Int32, pBE.ID);

            return wDataBase.ExecuteNonQuery(wCmd);
        }

        /// <summary>
        /// Actualiza ProductType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Update(ProductTypeEntity pBE)
        {
            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("PRTProductType_u");

            wDataBase.AddInParameter(wCmd, "PRTId", DbType.Int32, pBE.ID);
            wDataBase.AddInParameter(wCmd, "PRTName", DbType.String, pBE.Name);
            wDataBase.AddInParameter(wCmd, "PRTDescription", DbType.String, pBE.Description);

            return wDataBase.ExecuteNonQuery(wCmd);
        }

        /// <summary>
        /// Búsqueda de ProductType por id.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>ProductTypeEntity</returns>
        public static ProductTypeEntity Get(Int32 pId)
        {
            ProductTypeEntities woProductType;
            woProductType = Search(new ProductTypeEntity(pId));
            if (woProductType.Count > 0)
            {
                return woProductType[0];
            }
            else
            {
                return null;
            }
        }
    }
}
