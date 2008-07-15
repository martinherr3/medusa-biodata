using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
//using Prominente.Framework.Bases.BackEnd;
using Medusa.Architecture.Bases.BackEnd;
//using Prominente.DocumentExplorer.CommonEntities;
using Medusa.Biodata.Common.BusinessEntities;
using System.Data.Common;
using System.Data;
//using Prominente.Framework.Exceptions;

namespace Medusa.Biodata.BackEnd.DataAccessComponents
{

	/// <summary>
	/// DAC para FormularioPersonalizado.
	/// </summary>
	public class FormularioPersonalizadoDAC : DataAccessComponent
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
				FormularioPersonalizadoEntities wFormulariosPersonalizados = new FormularioPersonalizadoEntities();
				wFormulariosPersonalizados = FormularioPersonalizadoTDG.Search(pBE);

				foreach (FormularioPersonalizadoEntity wFormularioPersonalizado in wFormulariosPersonalizados)
				{
					if (wFormularioPersonalizado.ProductType.ID.HasValue)
					{
						wFormularioPersonalizado.ProductType = ProductTypeTableDataGateway.Get(Convert.ToInt32(wFormularioPersonalizado.ProductType.ID));
						//busco los items del prod. per.
						FormularioPersonalizadoItemEntity wItem = new FormularioPersonalizadoItemEntity();
                        wItem.Control.ProductType.ID = wFormularioPersonalizado.ProductType.ID;
						wItem.Control.Orden = wFormularioPersonalizado.Orden;
						
						FormularioPersonalizadoItemEntities wItems = new FormularioPersonalizadoItemEntities();
						wItems = FormularioPersonalizadoItemTDG.Search(wItem);
						//agrego cada item a la lista
						foreach (FormularioPersonalizadoItemEntity wItemX in wItems)
						{
							if (wItemX.Id.HasValue)
							{
								wFormularioPersonalizado.Lista.Add(FormularioPersonalizadoItemTDG.Get(Convert.ToInt32(wItemX.Id)));
							}
						}
					}
				}

				return wFormulariosPersonalizados;
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
		/// Actualiza formularios personalizados
		/// </summary>
		/// <param name="pBE">Lista de Entidades</param>
		/// <returns>Boolean</returns>
		public static Boolean Actualizar(FormularioPersonalizadoEntities pBE)
		{
			try
			{
				//Obtengo los formularios personalizados para el tipo de producto pasado en la pBE
				FormularioPersonalizadoEntity wFormularioPersonalizado = new FormularioPersonalizadoEntity();
                wFormularioPersonalizado.ProductType.ID = pBE[0].ProductType.ID;
				FormularioPersonalizadoEntities wFormulariosPersonalizados = FormularioPersonalizadoTDG.Search(wFormularioPersonalizado);

				//lleno, la lista de controles y sus itmes, para cada FP encontrado para el Tipo de Prod. pasado como param.
				foreach (FormularioPersonalizadoEntity wFP in wFormulariosPersonalizados)
				{
					FormularioPersonalizadoItemEntity wFPItem = new FormularioPersonalizadoItemEntity();
                    wFPItem.Control.ProductType.ID = wFP.ProductType.ID;
					if (wFP.Orden.HasValue)
					{
						wFPItem.Control.Orden = wFP.Orden;
						wFP.Lista = FormularioPersonalizadoItemTDG.Search(wFPItem);
					}
				}

				//Elimino, Inserto o dejo como está en función de la situación.
				foreach (FormularioPersonalizadoEntity wFormularioPersonalizadoA in pBE)
				{
					//recorro cada FP
					Int32 encuentra = 0;
					foreach (FormularioPersonalizadoEntity wFormularioPersonalizadoB in wFormulariosPersonalizados)
					{
						if (wFormularioPersonalizadoA.ProductType.ID == wFormularioPersonalizadoB.ProductType.ID &&
							wFormularioPersonalizadoA.Orden == wFormularioPersonalizadoB.Orden &&
							wFormularioPersonalizadoA.TipoControl == wFormularioPersonalizadoB.TipoControl &&
							wFormularioPersonalizadoA.Requerido == wFormularioPersonalizadoB.Requerido &&
							wFormularioPersonalizadoA.Etiqueta == wFormularioPersonalizadoB.Etiqueta)
						{
							encuentra = 1;
							break;
						}
					}
					if (encuentra == 0)
					{
						if (wFormularioPersonalizadoA.ProductType.ID != null &&
							wFormularioPersonalizadoA.Orden != null &&
							wFormularioPersonalizadoA.TipoControl != null &&
							wFormularioPersonalizadoA.Requerido != null &&
							wFormularioPersonalizadoA.Etiqueta != null)
						{
							//FormularioPersonalizadoTDG.Delete(wFormularioPersonalizadoA);
							FormularioPersonalizadoTDG.Insert(wFormularioPersonalizadoA);
							foreach (FormularioPersonalizadoItemEntity wItem in wFormularioPersonalizadoA.Lista)
							{
								FormularioPersonalizadoItemTDG.Insert(wItem);
							}
						}
					}
				}

				foreach (FormularioPersonalizadoEntity wFormularioPersonalizadoA in wFormulariosPersonalizados)
				{
					Int32 encuentra = 0;
					foreach (FormularioPersonalizadoEntity wFormularioPersonalizadoB in pBE)
					{
						if (wFormularioPersonalizadoA.ProductType.ID == wFormularioPersonalizadoB.ProductType.ID &&
							wFormularioPersonalizadoA.Orden == wFormularioPersonalizadoB.Orden &&
							wFormularioPersonalizadoA.TipoControl == wFormularioPersonalizadoB.TipoControl &&
							wFormularioPersonalizadoA.Requerido == wFormularioPersonalizadoB.Requerido &&
							wFormularioPersonalizadoA.Etiqueta == wFormularioPersonalizadoB.Etiqueta)
						{
							encuentra = 1;
							break;
						}
					}
					if (encuentra == 0)
					{
						if (wFormularioPersonalizadoA.ProductType.ID != null &&
							wFormularioPersonalizadoA.Orden != null &&
							wFormularioPersonalizadoA.TipoControl != null &&
							wFormularioPersonalizadoA.Requerido != null &&
							wFormularioPersonalizadoA.Etiqueta != null)
						{
							FormularioPersonalizadoTDG.Delete(wFormularioPersonalizadoA);
							foreach (FormularioPersonalizadoItemEntity wItem in wFormularioPersonalizadoA.Lista)
							{
								FormularioPersonalizadoItemTDG.Delete(wItem);
							}
						}
					}
				}
				return true;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private static void ActualizarLista(FormularioPersonalizadoEntities pBE)
		{
			//Obtengo los items del control
			FormularioPersonalizadoItemEntity wFPItem = new FormularioPersonalizadoItemEntity();
            wFPItem.Control.ProductType.ID = pBE[0].Lista[0].Control.ProductType.ID;
			FormularioPersonalizadoItemEntities wFormulariosPersonalizadosItems = FormularioPersonalizadoItemTDG.Search(wFPItem);

			//Elimino, Inserto o dejo como está en función de la situación.
			foreach (FormularioPersonalizadoItemEntity wFormularioPersonalizadoItemA in pBE[0].Lista)
			{
				Int32 encuentraItem = 0;
				foreach (FormularioPersonalizadoItemEntity wFormularioPersonalizadoItemB in wFormulariosPersonalizadosItems)
				{
					if (wFormularioPersonalizadoItemA.Id == wFormularioPersonalizadoItemB.Id &&
						wFormularioPersonalizadoItemA.Control.ProductType.ID == wFormularioPersonalizadoItemB.Control.ProductType.ID &&
						wFormularioPersonalizadoItemA.Control.Orden == wFormularioPersonalizadoItemB.Control.Orden &&
						wFormularioPersonalizadoItemA.Control.Etiqueta == wFormularioPersonalizadoItemB.Control.Etiqueta)
					{
						encuentraItem = 1;
						break;
					}
				}
				if (encuentraItem == 0)
				{
					if (wFormularioPersonalizadoItemA.Id != null &&
						wFormularioPersonalizadoItemA.Control.ProductType.ID != null &&
						wFormularioPersonalizadoItemA.Control.Orden != null &&
						wFormularioPersonalizadoItemA.Control.Etiqueta != null)
					{
						FormularioPersonalizadoItemTDG.Insert(wFormularioPersonalizadoItemA);
					}
				}
			}

			foreach (FormularioPersonalizadoItemEntity wFormularioPersonalizadoItemA in wFormulariosPersonalizadosItems)
			{
				Int32 encuentraItem = 0;
				foreach (FormularioPersonalizadoItemEntity wFormularioPersonalizadoItemB in pBE[0].Lista)
				{
					if (wFormularioPersonalizadoItemA.Id == wFormularioPersonalizadoItemB.Id &&
						wFormularioPersonalizadoItemA.Control.ProductType.ID == wFormularioPersonalizadoItemB.Control.ProductType.ID &&
						wFormularioPersonalizadoItemA.Control.Orden == wFormularioPersonalizadoItemB.Control.Orden &&
						wFormularioPersonalizadoItemA.Control.Etiqueta == wFormularioPersonalizadoItemB.Control.Etiqueta)
					{
						encuentraItem = 1;
						break;
					}
				}
				if (encuentraItem == 0)
				{
					if (wFormularioPersonalizadoItemA.Id != null &&
						wFormularioPersonalizadoItemA.Control.ProductType.ID != null &&
						wFormularioPersonalizadoItemA.Control.Orden != null &&
						wFormularioPersonalizadoItemA.Control.Etiqueta != null)
					{
						FormularioPersonalizadoItemTDG.Delete(wFormularioPersonalizadoItemA);
					}
				}
			}
		}

	}
}