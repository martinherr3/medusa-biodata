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
	/// TDG para FormularioPersonalizadoValor.
	/// </summary>
	public class FormularioPersonalizadoValorTDG : TableDataGateway
	{

		/// <summary>
		/// Búsqueda  de FormularioPersonalizadoValor.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>FormularioPersonalizadoValorEntities</returns>
		public static FormularioPersonalizadoValorEntities Search(FormularioPersonalizadoValorEntity pBE, String pOrdenDeRegistros)
		{
			FormularioPersonalizadoValorEntities wLista = new FormularioPersonalizadoValorEntities();

			try
			{
				Database wDataBase = DatabaseFactory.CreateDatabase("conexion");
				DbCommand wCmd = wDataBase.GetStoredProcCommand("FPVFormularioPersonalizadoValorSearch");

				wDataBase.AddInParameter(wCmd, "OrdenDeRegistros", System.Data.DbType.String, pOrdenDeRegistros);
				wDataBase.AddInParameter(wCmd, "PRTId", System.Data.DbType.Int32, pBE.Control.ProductType.ID);
				wDataBase.AddInParameter(wCmd, "FPROrden", System.Data.DbType.Int32, pBE.Control.Orden);
				wDataBase.AddInParameter(wCmd, "PROId", System.Data.DbType.Int32, pBE.Product.ID);
				wDataBase.AddInParameter(wCmd, "FPVValor", System.Data.DbType.String, pBE.Valor);

				DataTable wDt = wDataBase.ExecuteDataSet(wCmd).Tables[0];

				foreach (DataRow wDr in wDt.Rows)
				{
					FormularioPersonalizadoValorEntity wFPValor = new FormularioPersonalizadoValorEntity();
					wFPValor.Control.ProductType.ID = Convert.ToInt32(wDr["PRTId"]);
					wFPValor.Control.Orden = Convert.ToInt32(wDr["FPROrden"]);
					wFPValor.Product.ID = Convert.ToInt32(wDr["PROId"]);
					wFPValor.Valor = wDr["FPVValor"].ToString();
					wLista.Add(wFPValor);
				}
				return wLista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Búsqueda  de FormularioPersonalizadoValor.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>FormularioPersonalizadoValorEntities</returns>
		public static FormularioPersonalizadoValorEntities Search(FormularioPersonalizadoValorEntity pBE)
		{
			return Search(pBE, null);
		}

		/// <summary>
		/// Inserta FormularioPersonalizadoValor.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>Int32</returns>
		public static Int32 Insert(FormularioPersonalizadoValorEntity pBE)
		{
			try
			{
				Database wDataBase = DatabaseFactory.CreateDatabase("conexion");
				DbCommand wCmd = wDataBase.GetStoredProcCommand("FPVFormularioPersonalizadoValorInsert");

				wDataBase.AddInParameter(wCmd, "PRTId", System.Data.DbType.Int32, pBE.Control.ProductType.ID);
				wDataBase.AddInParameter(wCmd, "FPROrden", System.Data.DbType.Int32, pBE.Control.Orden);
				wDataBase.AddInParameter(wCmd, "PROId", System.Data.DbType.Int32, pBE.Product.ID);
				wDataBase.AddInParameter(wCmd, "FPVValor", System.Data.DbType.String, pBE.Valor);

				return wDataBase.ExecuteNonQuery(wCmd);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Borra FormularioPersonalizadoValor.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>Int32</returns>
		public static Int32 Delete(FormularioPersonalizadoValorEntity pBE)
		{
			try
			{
				Database wDataBase = DatabaseFactory.CreateDatabase("conexion");
				DbCommand wCmd = wDataBase.GetStoredProcCommand("FPVFormularioPersonalizadoValorDelete");

				wDataBase.AddInParameter(wCmd, "PRTId", System.Data.DbType.Int32, pBE.Control.ProductType.ID);
				wDataBase.AddInParameter(wCmd, "FPROrden", System.Data.DbType.Int32, pBE.Control.Orden);
				wDataBase.AddInParameter(wCmd, "PROId", System.Data.DbType.Int32, pBE.Product.ID);

				return wDataBase.ExecuteNonQuery(wCmd);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Borra FormularioPersonalizadoValor Por DocId.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>Int32</returns>
		public static Int32 DeleteByPROId(FormularioPersonalizadoValorEntity pBE)
		{
			try
			{
				Database wDataBase = DatabaseFactory.CreateDatabase("conexion");
				DbCommand wCmd = wDataBase.GetStoredProcCommand("FPVFormularioPersonalizadoValorDeleteByPROId");

				wDataBase.AddInParameter(wCmd, "PROId", System.Data.DbType.Int32, pBE.Product.ID);

				return wDataBase.ExecuteNonQuery(wCmd);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Actualiza FormularioPersonalizadoValor.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>Int32</returns>
		public static Int32 Update(FormularioPersonalizadoValorEntity pBE)
		{
			try
			{
				Database wDataBase = DatabaseFactory.CreateDatabase("conexion");
				DbCommand wCmd = wDataBase.GetStoredProcCommand("FPVFormularioPersonalizadoValorUpdate");

				wDataBase.AddInParameter(wCmd, "PRTId", System.Data.DbType.Int32, pBE.Control.ProductType.ID);
				wDataBase.AddInParameter(wCmd, "FPROrden", System.Data.DbType.Int32, pBE.Control.Orden);
				wDataBase.AddInParameter(wCmd, "PROId", System.Data.DbType.Int32, pBE.Product.ID);
				wDataBase.AddInParameter(wCmd, "FPVValor", System.Data.DbType.String, pBE.Valor);

				return wDataBase.ExecuteNonQuery(wCmd);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Búsqueda de FormularioPersonalizadoValor por id de tipo de documento.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>FormularioPersonalizadoValorEntity</returns>
		public static FormularioPersonalizadoValorEntity Get(Int32 pId)
		{
			try
			{
				FormularioPersonalizadoValorEntity wFPValor = new FormularioPersonalizadoValorEntity();

				if (pId != 0)
				{
					FormularioPersonalizadoValorEntities wFPValores = Search(new FormularioPersonalizadoValorEntity(pId));

					if (wFPValores.Count > 0)
					{
						wFPValor = wFPValores[0];
					}
				}

				return wFPValor;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}