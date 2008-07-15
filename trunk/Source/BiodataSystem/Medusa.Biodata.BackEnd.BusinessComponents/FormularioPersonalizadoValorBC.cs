using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Common.BusinessEntities;
using Medusa.Biodata.BackEnd.DataAccessComponents;


namespace Medusa.Biodata.BackEnd.BusinessComponents
{

	/// <summary>
	/// Componente de negocios para FormularioPersonalizadoValor.
	/// </summary>
    public class FormularioPersonalizadoValorBC : BaseBusinessComponent
	{

		/// <summary>
		/// Búsqueda  de FormularioPersonalizadoValor.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>FormularioPersonalizadoValorEntities</returns>
		public static FormularioPersonalizadoValorEntities Search(FormularioPersonalizadoValorEntity pBE)
		{
			try
			{
				return FormularioPersonalizadoValorTDG.Search(pBE);
			}
			catch (Exception ex)
			{
				throw ex;
			}
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
				return FormularioPersonalizadoValorTDG.Insert(pBE);
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
				return FormularioPersonalizadoValorTDG.Delete(pBE);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Borra FormularioPersonalizadoValor por DocId.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>Int32</returns>
        public static Int32 DeleteByPROId(FormularioPersonalizadoValorEntity pBE)
		{
			try
			{
				return FormularioPersonalizadoValorTDG.DeleteByPROId(pBE);
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
				return FormularioPersonalizadoValorTDG.Update(pBE);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}