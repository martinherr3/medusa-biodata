using System;
using System.IO;
using System.Text;
using System.Data;
using System.Reflection;
using System.Collections.Generic;
using Medusa.Architecture.HelpersFunctions;
using Medusa.Architecture.ProcessManagement;
using Medusa.Architecture.Transaction;


namespace Medusa.Architecture.BusinessFacades.Utils
{
	/// <summary>
	/// Enumeraci�n que define el modo en que se aditar� la ejecuci�n del servicio.
	/// </summary>
	/// <date>2007-12-20T00:00:00</date>
	/// <author>gmedina</author>
	public enum AuditMode
	{
		/// <summary>
		/// Se auditar� la ejecuci�n del servicio, sin importar la configuraci�n del mismo.
		/// </summary>
		Required,
		/// <summary>
		/// Se auditar� la ejecuci�n del servicio si �ste est� configurado para ser auditado.
		/// </summary>
		Optional,
		/// <summary>
		/// No se auditar� la ejecuci�n del servicio, sin importar la configuraci�n del mismo.
		/// </summary>
		None
	}

	/// <summary>
	/// Provee soporte a las clases que implementan IBusinessFacade.
	/// </summary>
	/// <remarks>
	/// Toda la funcionalidad que sea reutilizable por las distintas fachadas de negocio debe estar implementada por esta clase.
	/// </remarks>
	/// <date>2007-12-20T00:00:00</date>
	/// <author>gmedina</author>
	public sealed class FacadeHelper
	{
		/// <summary>
		/// Recupera la configuraci�n del servicio de negocio.
		/// </summary>
		/// <remarks>Lee la configuraci�n utilizando un ServiceConfigurationManager del tipo especificado en los settings de la aplicaci�n.</remarks>
		/// <param name="pServiceName">Nombre del servicio de negocio.</param>
		/// <returns>Configuraci�n del servicio de negocio.</returns>
		/// <date>2007-12-20T00:00:00</date>
		/// <author>gmedina</author>
		public ProcessConfiguration GetServiceConfiguration(string pServiceName)
		{
			// Instanciaci�n del ServiceConfigurationManager.
			IProcessConfigurationManager wServiceConfigurationManager = ObjectProvider.GetProcessConfigurationManager();

			// Obtenci�n de la configuraci�n del servicio.
			ProcessConfiguration wResult = wServiceConfigurationManager.GetProcessConfiguration(pServiceName);
			return wResult;
		}

        //public ServiceConfiguration GetServiceConfiguration(string pServiceName)
        //{
        //    // Instanciaci�n del ServiceConfigurationManager.
        //    IServiceConfigurationManager wServiceConfigurationManager = ObjectProvider.GetServiceConfigurationManager();

        //    // Obtenci�n de la configuraci�n del servicio.
        //    ServiceConfiguration wResult = wServiceConfigurationManager.GetServiceConfiguration(pServiceName);
        //    return wResult;
        //}


		/// <summary>
		/// Crea un �mbito de transacci�n en base a la configuraci�n del servicio de negocio.
		/// </summary>
		/// <param name="pServiceConfiguration">Configuraci�n del servicio de negocio.</param>
		/// <returns>�mbito de transacci�n.</returns>
		/// <date>2007-12-20T00:00:00</date>
		/// <author>gmedina</author>
		private TransactionScopeHandler CreateTransactionScopeHandler(ProcessConfiguration pServiceConfiguration)
		{
			//Creaci�n del �mbito de la transacci�n.
			TransactionScopeHandler wResult = new TransactionScopeHandler(pServiceConfiguration.ProcessTransactionalBehaviour, pServiceConfiguration.ProcessIsolationLevel, new TimeSpan(0, 0, pServiceConfiguration.Timeout));

			return wResult;

		}

		/// <summary>
		/// Asigna datos a un dataset.
		/// </summary>
		/// <param name="pData">XML para cargar en el dataset.</param>
		/// <param name="pDataSet">Dataset sobre el que se cargar� el XML de entrada.</param>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		private void AssignData(string pData, DataSet pDataSet)
		{
			StringReader wReader = new StringReader(pData);
			pDataSet.ReadXml(wReader);

			wReader.Dispose();
			wReader = null;
		}

		/// <summary>
		/// Ejecuta el servicio de negocio.
		/// </summary>
		/// <param name="pData">XML con datos de entrada.</param>
		/// <param name="pServiceConfiguration">Configuraci�n del servicio.</param>
		/// <returns>XML que representa el resultado de la ejecuci�n del servicio.</returns>
		/// <date>2007-06-28</date>
		/// <author>gmedina</author>
		private string RunProcess(string pData, ProcessConfiguration pServiceConfiguration)
		{
            //por desgracia no transacciona porque no mandamos una excepcion. deberan ver como solucionarlo.
            //no es grave, pero no llegu� a ver como hacerlo. saludos. rodrigo.
            //obtengo el tipo de request
            Type wTipoEntidad = ReflectionFunctions.CreateType(pServiceConfiguration.Request);
            //Creo un array de Objetos para pasar como parametro.
            Object[] o = new Object[1];
            o[0] = SerializationFunctions.Deserialize(wTipoEntidad, pData);
            			
			// Obtenci�n del Response.
			Type wProcessType = ReflectionFunctions.CreateType(pServiceConfiguration.Handler);
			Object wProcessInstance = Activator.CreateInstance(wProcessType);
			Object wResponse = wProcessType.GetMethod("Execute").Invoke(wProcessInstance, o);
            
            return SerializationFunctions.Serialize(wResponse);
		}

		/// <summary>
		/// Valida que el servicio est� disponible para ser ejecutado.
		/// </summary>
		/// <param name="pServiceConfiguration">Configuraci�n del servicio.</param>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		public void ValidateAvailability(ProcessConfiguration pServiceConfiguration)
		{
			// Validaci�n de disponibilidad del servicio.
			if (!pServiceConfiguration.Available)
            {
                #region < Log >
                LogNotAvailableExcecution(pServiceConfiguration);    
                #endregion

                throw new Exception("El servicio no se encuentra disponible");
			}
		}

		/// <summary>
		/// Ejecuta un servicio de negocio dentro de un �mbito transaccional.
		/// </summary>
		/// <param name="pData">XML con datos de entrada.</param>
		/// <param name="pServiceConfiguration">Configuraci�n del servicio.</param>
		/// <returns>XML con datos de salida del servicio.</returns>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		public string RunTransactionalProcess(string pData, ProcessConfiguration pServiceConfiguration)
		{
			string wResult;
			TransactionScopeHandler wTransactionScopeHandler = this.CreateTransactionScopeHandler(pServiceConfiguration);

			try
			{
				// Ejecuci�n del servicio.
				wTransactionScopeHandler.InitScope();
				wResult = this.RunProcess(pData, pServiceConfiguration);
				wTransactionScopeHandler.Complete();

                #region < Log >
                if (pServiceConfiguration.Audit == true)
                {
                    LogSuccessfulExecution(pData, wResult, pServiceConfiguration);
                }
                #endregion
            }
			catch (Exception ex)
			{
				wTransactionScopeHandler.Abort();

                #region < Log >
                if (pServiceConfiguration.Audit == true)
                {
                    LogNonSucessfulExecution(ex, pServiceConfiguration);
                }
                #endregion

                throw ex;
			}
			finally
			{
				wTransactionScopeHandler.Dispose();
				wTransactionScopeHandler = null;
			}
			return wResult;
		}

		/// <summary>
		/// Ejecuta un servicio de negocio dentro de un �mbito transaccional.
		/// </summary>
		/// <param name="pData">XML con datos de entrada.</param>
		/// <param name="pServiceConfiguration">Configuraci�n del servicio.</param>
		/// <returns>XML con datos de salida del servicio.</returns>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		public string RunNonTransactionalProcess(string pData, ProcessConfiguration pServiceConfiguration)
		{
			string wResult;
		
			try
			{
				wResult = this.RunProcess(pData, pServiceConfiguration);
			}
			catch (Exception ex)
			{
				throw ex;
			}

			return wResult;
		}

        /// <summary>
        /// Genera un log de tipo "Warning" cuando se ha intentado ejecutar
        /// un servicio que est� deshabilitado.
        /// </summary>
        /// <param name="pConfig">Configuraci�n del servicio.</param>
        private void LogNotAvailableExcecution(ProcessConfiguration pConfig)
        {
            //Logger wLogger = new Logger();
            //wLogger.Warning("Application", "Se ha intentado ejecutar un servicio que est� configurado como no disponible.");
            //wLogger = null;
        }

        /// <summary>
        /// Genera un log de tipo "Information" cuando se ha ejecutado
        /// correctamente un servicio.
        /// </summary>
        /// <param name="pRequestData">Datos del Request del servicio.</param>
        /// <param name="pResultData">Datos del Response del servicio.</param>
        /// <param name="pConfig">Configuraci�n del servicio.</param>
        private void LogSuccessfulExecution(string pRequestData, string pResultData, ProcessConfiguration pConfig)
        {
            //Logger wLogger = new Logger();
            //StringBuilder wMessage = new StringBuilder();

            //wMessage.Append("[Request]");
            //wMessage.Append("\r\n\t"); 
            //wMessage.Append("Name: ");
            //wMessage.Append(pConfig.Request);
            //wMessage.Append("\r\n\t"); 
            //wMessage.Append("Data: ");
            //wMessage.Append(pRequestData);
            //wMessage.Append("\r\n\r\n"); 

            //wMessage.Append("[Response]");
            //wMessage.Append("\r\n\t"); 
            //wMessage.Append("Name: ");
            //wMessage.Append(pConfig.Response);
            //wMessage.Append("\r\n\t"); 
            //wMessage.Append("Data: ");
            //wMessage.Append(pResultData);

            //wLogger.Information("Application", wMessage.ToString());
            //wLogger = null;
        }

        /// <summary>
        /// Genera un log de tipo "Error" cuando se ha producido
        /// un error en la ejecuci�n del servicio.
        /// </summary>
        /// <param name="pException">Excepci�n.</param>
        /// <param name="pConfig">Configuraci�n del servicio.</param>
        private void LogNonSucessfulExecution(Exception pException, ProcessConfiguration pConfig)
        {
            //Logger wLogger = new Logger();
            //wLogger.Error("Application", pException.ToString());
            //wLogger = null;
        }
    }
}
