using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
//using Prominente.Framework.Bases.BackEnd;
using Medusa.Architecture.Bases.BackEnd;
//using Prominente.DocumentExplorer.CommonEntities;
using Medusa.Biodata.Common.BusinessEntities;
using System.Data.Common;
using System.Data;
//using Prominente.Framework.Exceptions;

namespace Medusa.Biodata.BackEnd.DataAccessComponents
{
	
	/// <summary>
	/// TDG para FormularioPersonalizadoItem.
	/// </summary>
	public class FormularioPersonalizadoItemTDG : TableDataGateway
	{
	
		/// <summary>
		/// Búsqueda  de FormularioPersonalizadoItem.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>FormularioPersonalizadoItemsEntities</returns>
		public static FormularioPersonalizadoItemEntities Search(FormularioPersonalizadoItemEntity pBE, String pOrdenDeRegistros)
		{
			FormularioPersonalizadoItemEntities wLista = new FormularioPersonalizadoItemEntities();

			try
			{
				Database wDataBase = DatabaseFactory.CreateDatabase("conexion");
				DbCommand wCmd = wDataBase.GetStoredProcCommand("FPIFormularioPersonalizadoItemSearch");

				wDataBase.AddInParameter(wCmd, "OrdenDeRegistros", System.Data.DbType.String, pOrdenDeRegistros);
				wDataBase.AddInParameter(wCmd, "FPIId", System.Data.DbType.Int32, pBE.Id);
				wDataBase.AddInParameter(wCmd, "PRTId", System.Data.DbType.Int32, pBE.Control.ProductType.ID);
				wDataBase.AddInParameter(wCmd, "FPROrden", System.Data.DbType.Int32, pBE.Control.Orden);
				wDataBase.AddInParameter(wCmd, "FPITexto", System.Data.DbType.String, pBE.Etiqueta);

				DataTable wDt = wDataBase.ExecuteDataSet(wCmd).Tables[0];

				foreach (DataRow wDr in wDt.Rows)
				{
					FormularioPersonalizadoItemEntity wItem = new FormularioPersonalizadoItemEntity();
					wItem.Id = Convert.ToInt32(wDr["FPIId"]);
					wItem.Control.ProductType.ID = Convert.ToInt32(wDr["PRTId"]);
					wItem.Control.Orden = Convert.ToInt32(wDr["FPROrden"]);
					wItem.Etiqueta = wDr["FPITexto"].ToString();
					wLista.Add(wItem);
				}
				return wLista;
			}
			catch (Exception ex)
			{
                throw ex;
			}
		}

		/// <summary>
		/// Búsqueda  de FormularioPersonalizadoItem.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>FormularioPersonalizadoItemEntities</returns>
		public static FormularioPersonalizadoItemEntities Search(FormularioPersonalizadoItemEntity pBE)
		{
			return Search(pBE, null);
		}

		/// <summary>
		/// Inserta FormularioPersonalizadoItem.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>Int32</returns>
		public static Int32 Insert(FormularioPersonalizadoItemEntity pBE)
		{
			try
			{
				Database wDataBase = DatabaseFactory.CreateDatabase("conexion");
				DbCommand wCmd = wDataBase.GetStoredProcCommand("FPIFormularioPersonalizadoItemInsert");

				wDataBase.AddOutParameter(wCmd, "FPIId", System.Data.DbType.Int32, 4);
				wDataBase.AddInParameter(wCmd, "PRTId", System.Data.DbType.Int32, pBE.Control.ProductType.ID);
				wDataBase.AddInParameter(wCmd, "FPROrden", System.Data.DbType.Int32, pBE.Control.Orden);
				wDataBase.AddInParameter(wCmd, "FPITexto", System.Data.DbType.String, pBE.Etiqueta);

				return wDataBase.ExecuteNonQuery(wCmd);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Borra FormularioPersonalizadoItem.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>Int32</returns>
		public static Int32 Delete(FormularioPersonalizadoItemEntity pBE)
		{
			try
			{
				Database wDataBase = DatabaseFactory.CreateDatabase("conexion");
				DbCommand wCmd = wDataBase.GetStoredProcCommand("FPIFormularioPersonalizadoItemDelete");

				wDataBase.AddInParameter(wCmd, "FPIId", System.Data.DbType.Int32, pBE.Id);
				wDataBase.AddInParameter(wCmd, "PRTId", System.Data.DbType.Int32, pBE.Control.ProductType.ID);
				wDataBase.AddInParameter(wCmd, "FPROrden", System.Data.DbType.Int32, pBE.Control.Orden);

				return wDataBase.ExecuteNonQuery(wCmd);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Actualiza FormularioPersonalizadoItem.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>Int32</returns>
		public static Int32 Update(FormularioPersonalizadoItemEntity pBE)
		{
			try
			{
				Database wDataBase = DatabaseFactory.CreateDatabase("conexion");
				DbCommand wCmd = wDataBase.GetStoredProcCommand("FPIFormularioPersonalizadoItemUpdate");

				wDataBase.AddInParameter(wCmd, "FPIId", System.Data.DbType.Int32, pBE.Id);
				wDataBase.AddInParameter(wCmd, "PRTId", System.Data.DbType.Int32, pBE.Control.ProductType.ID);
				wDataBase.AddInParameter(wCmd, "FPROrden", System.Data.DbType.Int32, pBE.Control.Orden);
				wDataBase.AddInParameter(wCmd, "FPITexto", System.Data.DbType.String, pBE.Etiqueta);

				return wDataBase.ExecuteNonQuery(wCmd);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Búsqueda de FormularioPersonalizadoItem por id.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>FormularioPersonalizadoItemsEntity</returns>
		public static FormularioPersonalizadoItemEntity Get(Int32 pId)
		{
			try
			{
				FormularioPersonalizadoItemEntity wItem = new FormularioPersonalizadoItemEntity();

				if (pId != 0)
				{
					FormularioPersonalizadoItemEntities wItems = Search(new FormularioPersonalizadoItemEntity(pId));

					if (wItems.Count > 0)
					{
						wItem = wItems[0];
					}
				}
				return wItem;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}