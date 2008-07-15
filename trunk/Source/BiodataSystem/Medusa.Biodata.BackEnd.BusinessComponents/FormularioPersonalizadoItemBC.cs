using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Common.BusinessEntities;
using Medusa.Biodata.BackEnd.DataAccessComponents;


namespace Medusa.Biodata.BackEnd.BusinessComponents
{

	/// <summary>
	/// Componente de negocios para FormularioPersonalizadoItem.
	/// </summary>
    public class FormularioPersonalizadoItemBC : BaseBusinessComponent
	{

		/// <summary>
		/// Búsqueda  de FormularioPersonalizadoItem.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>FormularioPersonalizadoItemEntities</returns>
		public static FormularioPersonalizadoItemEntities Search(FormularioPersonalizadoItemEntity pBE)
		{
			try
			{
				return FormularioPersonalizadoItemTDG.Search(pBE);
			}
			catch (Exception ex)
			{
				throw ex;
			}
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
				return FormularioPersonalizadoItemTDG.Insert(pBE);
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
				return FormularioPersonalizadoItemTDG.Delete(pBE);
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
				return FormularioPersonalizadoItemTDG.Update(pBE);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}