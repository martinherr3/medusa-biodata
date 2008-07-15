using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Architecture.HelpersFunctions;

namespace Medusa.Architecture.ProcessManagement
{

	/// <summary>
	/// Proveedor de instancias de implementaciones de IProcessConfigurationManager.
	/// </summary>
	/// <remarks>
	/// Recupera el tipo a instanciar de los settings de la aplicaci�n.
	/// </remarks>
	/// <date>2006-02-10T00:00:00</date>
	/// <author>gmedina</author>
	public class ObjectProvider
	{
		/// <summary>
		/// Instancia una clase implementadora de IProcessConfigurationManager.
		/// </summary>
		/// <remarks>Recupera el tipo a instanciar de los settings de la aplicaci�n.</remarks>
		/// <returns>Administrador de configuraci�n de proceso.</returns>
		/// <date>2006-02-10T00:00:00</date>
		/// <author>gmedina</author>
		public static IProcessConfigurationManager GetProcessConfigurationManager()
		{
			// Instanciaci�n del ProcessConfigurationManager.
			IProcessConfigurationManager wResult = (IProcessConfigurationManager)ReflectionFunctions.CreateInstance(Properties.Settings.Default.ProcessConfigurationManagerType);
			return wResult;
		}
	}
}
