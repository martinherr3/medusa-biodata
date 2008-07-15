using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Architecture.HelpersFunctions;

namespace Medusa.Architecture.Bases.BackEnd
{
	/// <summary>
	/// Clase base que representa una entidad.
	/// </summary>
	public abstract class Entity
	{
		/// <summary>
		/// Devuelve la representación en xml de los datos mantenidos en la entidad.
		/// </summary>
		public string GetXml()
		{
			return SerializationFunctions.Serialize(this);
		}
	}
}
