using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Medusa.Architecture.ProcessManagement.Database
{
	/// <summary>
	/// Secci�n de configuraci�n para el administrador de configuraci�n de procesos con repositorio en base de datos.
	/// </summary>
	/// <date>2006-02-14T00:00:00</date>
	/// <author>gmedina</author>
	internal class DatabaseConfigSection : ConfigurationSection
	{
		#region <public properties>

		/// <summary>
		/// Cadena de conexi�n para acceder a la base de datos que sirve de repositorio de configuraci�n.
		/// </summary>
		/// <remarks>
		/// Si esta propiedad no se setea en la configuraci�n de la aplicaci�n el valor por defecto es "BPConfig". Este valor es usado por <see cref="DatabaseProcessConfigurationManager"/> para conectarse al repositorio.
		/// </remarks>
		/// <date>2006-02-10T00:00:00</date>
		/// <author>gmedina</author>
		[ConfigurationProperty("ConnectionName", DefaultValue = "BPConfig")]
		public string ConnectionName
		{
			get
			{
				string wResult = (string)base["ConnectionName"];
				return wResult;
			}
			set
			{
				base["ConnectionName"] = value;
			}
		}
		#endregion
	}
}
