using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Common.BusinessEntities;
using Medusa.Biodata.BackEnd.DataAccessComponents;


namespace Medusa.Biodata.BackEnd.BusinessComponents
{

	/// <summary>
	/// Componente de negocios para FormularioPersonalizado.
	/// </summary>
    public class FormularioPersonalizadoBC : BaseBusinessComponent
	{
	
		/// <summary>
		/// Búsqueda  de FormularioPersonalizado.
		/// </summary>
		/// <param name="pBE">Entidad.</param>
		/// <returns>FormularioPersonalizadoEntities</returns>
		public static FormularioPersonalizadoEntities Search(FormularioPersonalizadoEntity pBE)
		{
			try
			{
				return FormularioPersonalizadoDAC.Search(pBE);
			}
			catch (Exception ex)
			{
				throw ex;
			}
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
				return FormularioPersonalizadoTDG.Insert(pBE);
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
				return FormularioPersonalizadoTDG.Delete(pBE);
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
				return FormularioPersonalizadoTDG.Update(pBE);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		/// <summary>
		/// Actualiza Formularios Personalizados.
		/// </summary>
		/// <param name="pBE">Lista de Entidades.</param>
		/// <returns>Boolean</returns>
		public static Boolean Actualizar(FormularioPersonalizadoEntities pBE)
		{
			try
			{
				return FormularioPersonalizadoDAC.Actualizar(pBE);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

	}
}
