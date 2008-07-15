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
	/// TDG para FormularioPersonalizado.
	/// </summary>
	public class FormularioPersonalizadoTDG : TableDataGateway
	{
	
		/// <summary>
		/// Búsqueda  de FormularioPersonalizado.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>FormularioPersonalizadoEntities</returns>
		public static FormularioPersonalizadoEntities Search(FormularioPersonalizadoEntity pBE, String pOrdenDeRegistros)
		{
			FormularioPersonalizadoEntities wLista = new FormularioPersonalizadoEntities();

			try
			{
				Database wDataBase = DatabaseFactory.CreateDatabase("conexion");
				DbCommand wCmd = wDataBase.GetStoredProcCommand("FPRFormularioPersonalizadoSearch");

				wDataBase.AddInParameter(wCmd, "OrdenDeRegistros", System.Data.DbType.String, pOrdenDeRegistros);
				wDataBase.AddInParameter(wCmd, "PRTId", System.Data.DbType.Int32, pBE.ProductType.ID);
				wDataBase.AddInParameter(wCmd, "FPROrden", System.Data.DbType.Int32, pBE.Orden);
				wDataBase.AddInParameter(wCmd, "FPRTipoControl", System.Data.DbType.Int32, pBE.TipoControl);
				wDataBase.AddInParameter(wCmd, "FPRRequerido", System.Data.DbType.Boolean, pBE.Requerido);
				wDataBase.AddInParameter(wCmd, "FPREtiqueta", System.Data.DbType.String, pBE.Etiqueta);

				DataTable wDt = wDataBase.ExecuteDataSet(wCmd).Tables[0];

				foreach (DataRow wDr in wDt.Rows)
				{
					FormularioPersonalizadoEntity wFPersonalizado = new FormularioPersonalizadoEntity();
					wFPersonalizado.ProductType.ID = Convert.ToInt32(wDr["PRTId"]);
					wFPersonalizado.Orden = Convert.ToInt32(wDr["FPROrden"]);
					wFPersonalizado.TipoControl = (TipoControl)wDr["FPRTipoControl"];
					wFPersonalizado.Requerido = Convert.ToBoolean(wDr["FPRRequerido"]);
					wFPersonalizado.Etiqueta = wDr["FPREtiqueta"].ToString();
					wLista.Add(wFPersonalizado);
				}
				return wLista;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Búsqueda  de FromularioPersonalizado.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>FormularioPersonalizadoEntities</returns>
		public static FormularioPersonalizadoEntities Search(FormularioPersonalizadoEntity pBE)
		{
			return Search(pBE, null);
		}

		/// <summary>
		/// Inserta FormularioPersonalizado.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>Int32</returns>
		public static Int32 Insert(FormularioPersonalizadoEntity pBE)
		{
			try
			{
				Database wDataBase = DatabaseFactory.CreateDatabase("conexion");
				DbCommand wCmd = wDataBase.GetStoredProcCommand("FPRFormularioPersonalizadoInsert");

				wDataBase.AddInParameter(wCmd, "PRTId", System.Data.DbType.Int32, pBE.ProductType.ID);
				wDataBase.AddInParameter(wCmd, "FPROrden", System.Data.DbType.Int32, pBE.Orden);
				wDataBase.AddInParameter(wCmd, "FPRTipoControl", System.Data.DbType.Int32, pBE.TipoControl);
				wDataBase.AddInParameter(wCmd, "FPRRequerido", System.Data.DbType.Boolean, pBE.Requerido);
				wDataBase.AddInParameter(wCmd, "FPREtiqueta", System.Data.DbType.String, pBE.Etiqueta);

				return wDataBase.ExecuteNonQuery(wCmd);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Borra FormularioPersonalizado.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>Int32</returns>
		public static Int32 Delete(FormularioPersonalizadoEntity pBE)
		{
			try
			{
			Database wDataBase = DatabaseFactory.CreateDatabase("conexion");
			DbCommand wCmd = wDataBase.GetStoredProcCommand("FPRFormularioPersonalizadoDelete");

			wDataBase.AddInParameter(wCmd, "PRTId", System.Data.DbType.Int32, pBE.ProductType.ID);
			wDataBase.AddInParameter(wCmd, "FPROrden", System.Data.DbType.Int32, pBE.Orden);

			return wDataBase.ExecuteNonQuery(wCmd);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Actualiza FormularioPersonalizado.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>Int32</returns>
		public static Int32 Update(FormularioPersonalizadoEntity pBE)
		{
			try
			{
				Database wDataBase = DatabaseFactory.CreateDatabase("conexion");
				DbCommand wCmd = wDataBase.GetStoredProcCommand("FPRFormularioPersonalizadoUpdate");

				wDataBase.AddInParameter(wCmd, "PRTId", System.Data.DbType.Int32, pBE.ProductType.ID);
				wDataBase.AddInParameter(wCmd, "FPROrden", System.Data.DbType.Int32, pBE.Orden);
				wDataBase.AddInParameter(wCmd, "FPRTipoControl", System.Data.DbType.Int32, pBE.TipoControl);
				wDataBase.AddInParameter(wCmd, "FPRRequerido", System.Data.DbType.Boolean, pBE.Requerido);
				wDataBase.AddInParameter(wCmd, "FPREtiqueta", System.Data.DbType.String, pBE.Etiqueta);

				return wDataBase.ExecuteNonQuery(wCmd);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Búsqueda de FormularioPersonalizado por id.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>FormularioPersonalizadoEntity</returns>
		public static FormularioPersonalizadoEntity Get(Int32 pId)
		{
			try
			{
				FormularioPersonalizadoEntity wFPersonalizado = new FormularioPersonalizadoEntity();

				if (pId != 0)
				{
					FormularioPersonalizadoEntities wFPersonalizados = Search(new FormularioPersonalizadoEntity(pId));

					if (wFPersonalizados.Count > 0)
					{
						wFPersonalizado = wFPersonalizados[0];
					}
				}
					
				return wFPersonalizado;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}