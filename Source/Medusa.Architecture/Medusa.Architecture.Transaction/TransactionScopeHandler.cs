using System;
using System.Collections.Generic;
using System.Text;
using SysTrans = System.Transactions;


namespace Medusa.Architecture.Transaction
{


	/// <summary>
	/// Clase para encapsular manejo de transacciones.
	/// </summary>
	/// <remarks>
	/// Encapsula la instanciaci�n de los tipos necesarios para llevar a cabo una transacci�n, independizando el resto de la aplicaci�n de la tecnolog�a utilizada a su efecto.
	/// </remarks>
	/// <date>2006-02-07T00:00:00</date>
	/// <author>gmedina</author>
	public sealed class TransactionScopeHandler: IDisposable
	{

		/// <summary>
		/// Comportamiento del �mbito transaccional .
		/// </summary>
		TransactionalBehaviour _TransactionalBehaviour;

		/// <summary>
		/// Nivel de aislamiento.
		/// </summary>
		IsolationLevel _IsolationLevel;

		/// <summary>
		/// Intervalo de tiempo para la ejecuci�n de la transacci�n.
		/// </summary>
		TimeSpan _Timeout;

		/// <summary>
		/// �mbito transaccional.
		/// </summary>
		SysTrans.TransactionScope _TransactionScope;

		/// <summary>
		/// Flag que indica si la instancia ya fue pasada a disponibilidad o no.
		/// </summary>
		bool _Disposed = false;


		/// <summary>
		/// Traduce el valor que define el comportamiento a un valor propio de la tecnolog�a con que se implementa el soporte transaccional.
		/// </summary>
		/// <remarks></remarks>
		/// <returns>Opci�n del ambiente transaccional.</returns>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		private SysTrans.TransactionScopeOption GetTransactionScopeOption()
		{
			switch (_TransactionalBehaviour)
			{
				case TransactionalBehaviour.Support:
					{
					    throw new Exception("El comportamiento no est� soportado por la actual implementaci�n");
					}
				case TransactionalBehaviour.Required:
					{
						return SysTrans.TransactionScopeOption.Required;
					}
				case TransactionalBehaviour.RequiresNew:
					{
						return SysTrans.TransactionScopeOption.RequiresNew;
					}
				case TransactionalBehaviour.Suppres:
					{
						return SysTrans.TransactionScopeOption.Suppress;
					}
				default:
					{
                        throw new Exception("El comportamiento no est� soportado por la actual implementaci�n");
					}
			}
		}


		/// <summary>
		/// Traduce los valors que definen las opciones del �mbito de la transacci�n a un valor propio de la tecnolog�a con que se implementa el soporte transaccional.
		/// </summary>
		/// <remarks></remarks>
		/// <returns>Opci�n del ambiente transaccional.</returns>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		private SysTrans.TransactionOptions GetTransactionOptions()
		{
			SysTrans.TransactionOptions wResult = new SysTrans.TransactionOptions();

			switch (_IsolationLevel)
			{
				case IsolationLevel.Chaos:
					{
						wResult.IsolationLevel = SysTrans.IsolationLevel.Chaos;
						break;
					}
				case IsolationLevel.ReadCommitted:
					{
						wResult.IsolationLevel = SysTrans.IsolationLevel.ReadCommitted;
						break;
					}
				case IsolationLevel.ReadUncommitted:
					{
						wResult.IsolationLevel = SysTrans.IsolationLevel.ReadUncommitted;
						break;
					}
				case IsolationLevel.RepeatableRead:
					{
						wResult.IsolationLevel = SysTrans.IsolationLevel.RepeatableRead;
						break;
					}
				case IsolationLevel.Serializable:
					{
						wResult.IsolationLevel = SysTrans.IsolationLevel.Serializable;
						break;
					}
				case IsolationLevel.Snapshot:
					{
						wResult.IsolationLevel = SysTrans.IsolationLevel.Snapshot;
						break;
					}
				default:
					{
                        throw new Exception("El comportamiento no est� soportado por la actual implementaci�n");
					}
			}

			wResult.Timeout = _Timeout;			

			return wResult;
		}
		
		/// <summary>
		/// Constructor por defecto.
		/// </summary>
		/// <remarks>
		/// Levanta configuraci�n por defecto de los settings.
		/// </remarks>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		public TransactionScopeHandler()
		{
			ConfigureScope((TransactionalBehaviour)Enum.Parse(typeof(TransactionalBehaviour), Properties.Settings.Default.TransactionalBehaviour), (IsolationLevel)Enum.Parse(typeof(IsolationLevel), Properties.Settings.Default.IsolationLevel), Properties.Settings.Default.Timeout);
		}


		/// <summary>
		/// Constructor que recibe par�metros de inicializaci�n para el �mbito de la transacci�n.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <param name="pTransactionalBehaviour">Comportamiento del �mbito transaccional.</param>
		/// <param name="pIsolationLevel">Nivel de aislamiento de la transacci�n.</param>
		/// <param name="pTimeOut">Intervalo de tiempo que puede durar la transacci�n.</param>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		public TransactionScopeHandler(TransactionalBehaviour pTransactionalBehaviour, IsolationLevel pIsolationLevel, TimeSpan pTimeOut)
		{
			ConfigureScope(pTransactionalBehaviour, pIsolationLevel, pTimeOut);
		}

		/// <summary>
		/// Configura los par�metros de inicializaci�n para el alcance de la transacci�n.
		/// </summary>
		/// <remarks>
		/// No inicializa el �mbito transaccional, solamente setea valores de configuraci�n que ser�n utilizados por <see cref="InitScope"/>.
		/// </remarks>
		/// <param name="pTransactionalBehaviour">Comportamiento del �mbito transaccional.</param>
		/// <param name="pIsolationLevel">Nivel de aislamiento de la transacci�n.</param>
		/// <param name="pTimeOut">Intervalo de tiempo que puede durar la transacci�n.</param>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		public void ConfigureScope(TransactionalBehaviour pTransactionalBehaviour, IsolationLevel pIsolationLevel, TimeSpan pTimeOut)
		{
			_TransactionalBehaviour = pTransactionalBehaviour ;
			_IsolationLevel = pIsolationLevel;
			_Timeout = pTimeOut;
		}
		
		/// <summary>
		/// Inicializa el �mbito de transacci�n.
		/// </summary>
		/// <remarks>
		/// Hace uso de la configuraci�n especificada por <see cref="ConfigureScope"/>.
		/// </remarks>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		public void InitScope()
		{
			CheckDisposed();

			if (_TransactionScope != null)
			{
                throw new Exception("El alcance de transacci�n ya ha sido inicializado");
			}

			_TransactionScope = CreateScope();
		}

		private SysTrans.TransactionScope CreateScope()
		{
			SysTrans.TransactionScope wResult = new SysTrans.TransactionScope(GetTransactionScopeOption(), GetTransactionOptions());
			return wResult;
		}

		/// <summary>
		/// Indica que se debe completar la ejecuci�n de la transacci�n.
		/// </summary>
		/// <remarks>
		/// Completa la ejecuci�n de la transacci�n y pasa a disposici�n el �mbito creado en <see cref="InitScope"/>.
		/// </remarks>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		public void Complete()
		{
			CheckDisposed();
			CheckInitialized();
			_TransactionScope.Complete();
			DisposeScope();
		}


		/// <summary>
		/// Aborta las actualizaciones realizadas dentro del alcance de la transacci�n.
		/// </summary>
		/// <remarks>
		/// Al abortar la ejecuci�n, se pasa a disposici�n el �mbito creado en <b>InitScope</b>.
		/// </remarks>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		public void Abort()
		{
			CheckDisposed();
			CheckInitialized();
			DisposeScope();
		}

		/// <summary>
		/// Verifica si ya se ha inicializado el alcance de la transacci�n.
		/// </summary>
		/// <remarks>
		/// Si no se inicializ� el �mbito, se dispara una excepci�n. Para inicializar el �mbito transaccional ejecutar <see cref="InitScope"/>.
		/// </remarks>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		private void CheckInitialized()
		{
			if (_TransactionScope == null)
			{
			    throw new Exception("No hay un alcance de transacci�n inicializado.");
			}
		}

		/// <summary>
		/// Verifica si ya se ha pasado a disponibilidad el alcance de la transacci�n.
		/// </summary>
		/// <remarks>
		/// Si la instancia ya fue pasada a disponibilidad, dispara una excepci�n.
		/// </remarks>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		private void CheckDisposed()
		{
			if (_Disposed)
			{
				throw new System.ObjectDisposedException(this.GetType().FullName);
			}
		}

		/// <summary>
		/// Pasa el alcance de transacci�n a disponibilidad y libera la referencia a este.
		/// </summary>
		/// <remarks>
		/// Al pasar a disponibilidad el �mbito, se aborta impl�citamente la transacci�n. Para aceptar los cambios realizados, se debe ejecutar previamente <see cref="Complete"/>.
		/// </remarks>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		private void DisposeScope()
		{
			_TransactionScope.Dispose();
			_TransactionScope = null;
		}

		#region IDisposable Members

		/// <summary>
		/// Implementacion de IDisposable.Dispose.
		/// </summary>
		/// <remarks>
		/// En caso de que haya un ambiente transaccional activo, se lo pasa a disposici�n abortando la transacci�n.
		/// </remarks>
		/// <date>2006-02-07T00:00:00</date>
		/// <author>gmedina</author>
		public void Dispose()
		{
			if (!_Disposed)
			{
				_Disposed = true;

				if (_TransactionScope != null)
				{
					DisposeScope();
				}
			}
		}

		#endregion
	}
}
