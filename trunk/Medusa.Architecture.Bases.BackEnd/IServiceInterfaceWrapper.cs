using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace Medusa.Architecture.Bases.BackEnd
{

	/// <summary>
	/// Interfaz para clases que funcionan como wrappers de interfaces de servicio.
	/// </summary>
	/// <remarks>
	/// Las clases que implementen esta interfaz deben ser capaces de solicitar la ejecuci�n de procesos de negocio a trav�s de m�todos de la intefaz de servicio utilizada, y devolver el resultado del mismo como resultado de la ejecuci�n.
	/// </remarks>
	/// <date>2006-04-27T00:00:00</date>
	/// <author>gmedina</author>
	public interface IServiceInterfaceWrapper
	{
		/// <summary>
		/// Ejecuta un proceso de negocio.
		/// </summary>
		/// <param name="pProcessName">Nombre del proceso.</param>
		/// <param name="pData">XML con datos de entrada para la ejecuci�n del proceso.</param>
		/// <returns>XML con datos de salida del proceso.</returns>
		/// <date>2006-04-27T00:00:00</date>
		/// <author>gmedina</author>
		string ExecuteProcess(string pProcessName, string pData);

		/// <summary>
		/// Ejecuta un proceso de negocio.
		/// </summary>
		/// <param name="pProcessName">Nombre del proceso.</param>
		/// <param name="pData">Dataset con datos de entrada para la ejecuci�n del proceso.</param>
		/// <returns>Dataset con datos de respuesta del proceso.</returns>
		/// <date>2006-04-27T00:00:00</date>
		/// <author>gmedina</author>
		TResponse ExecuteProcess<TRequest, TResponse>(string pProcessName, TRequest pData) 
			where TRequest : DataSet
			where TResponse : DataSet, new();

	}
}
