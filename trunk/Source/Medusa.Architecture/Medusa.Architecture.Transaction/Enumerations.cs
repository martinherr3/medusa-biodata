using System;
using System.Collections.Generic;
using System.Text;

namespace Medusa.Architecture.Transaction
{
	/// <summary>
	/// Define el comportamiento del �mbito transaccional.
	/// </summary>
	/// <remarks>Los valores de esta enumeraci�n se traducen en los valores propios de la tecnolog�a con que se implementa el soporte transaccional.</remarks>
	/// <date>2006-02-07T00:00:00</date>
	/// <author>gmedina</author>
	public enum TransactionalBehaviour
	{
		/// <summary>
		/// Si hay una transacci�n en curso, se hace uso de dicho �mbito. En caso contrario no transacciona.
		/// </summary>
		Support,
		/// <summary>
		/// El proceso transacciona. Si hay un �mbito transaccional ya abierto, utiliza el existente, en caso contrario crea una nueva transaccion.
		/// </summary>
		Required,
		/// <summary>
		/// Siempre se crea una nueva transacci�n.
		/// </summary>
		RequiresNew,
		/// <summary>
		/// No transacciona, todas las operaciones se hacen sin estar en un �mbito transaccional. 
		/// </summary>
		Suppres
	}

	/// <summary>
	/// Especifica el nivel de aislamiento de la transacci�n.
	/// </summary>
	/// <remarks>Los valores de esta enumeraci�n se traducen en los valores propios de la tecnolog�a con que se implementa el soporte transaccional.</remarks>
	/// <date>2006-02-07T00:00:00</date>
	/// <author>gmedina</author>
	public enum IsolationLevel
	{
		/// <summary>
		/// Los cambios pendientes de transacciones m�s aisladas no puede ser sobreescritos.
		/// </summary>
		Chaos,
		/// <summary>
		/// Los datos vol�tites no puede ser leidos durante la transacci�n, pero pueden ser modificados.
		/// </summary>
		ReadCommitted,
		/// <summary>
		/// Los datos vol�tines pueden ser leidos y modificados durante la transacci�n.
		/// </summary>
		ReadUncommitted,
		/// <summary>
		/// Los datos vol�tiles pueden ser leidos pero no modificados durante la transaci�n. Nuevos datos pueden ser creados.
		/// </summary>
		RepeatableRead,
		/// <summary>
		/// Los datos vol�tiles pueden ser leidos pero no modificados, y no es posible crear nuevos datos durante la transacci�n.
		/// </summary>
		Serializable,
		/// <summary>
		/// Los datos vol�tiles pueden ser leidos. Antes de modificarse datos,  se verifica que otra transacci�n los haya cambiado luego de haber sido leidos. Si los datos se actualizaron, se levanta una excepci�n.
		/// </summary>
		Snapshot
	}
}
