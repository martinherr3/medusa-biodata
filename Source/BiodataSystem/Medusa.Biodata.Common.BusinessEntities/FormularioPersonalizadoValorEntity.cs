using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Medusa.Architecture.CommonEntities;

namespace Medusa.Biodata.Common.BusinessEntities
{

	/// <summary>
	/// Entidad de Negocios para FormularioPersonalizadoValor.
	/// </summary>
	[DataObjectAttribute]
	public class FormularioPersonalizadoValorEntity : CommonEntity
	{

		private String _Valor = null;
		/// <summary>
		/// Valor del control
		/// </summary>
		public String Valor
		{
			get { return _Valor; }
			set { _Valor = value; }
		}
		
		private ProductEntity _Product = null;
		/// <summary>
		/// Documento
		/// </summary>
        public ProductEntity Product
		{
            get { return _Product; }
            set { _Product = value; }
		}

		private FormularioPersonalizadoEntity _Control = null;
		/// <summary>
		/// Control de Formulario Personalizado
		/// </summary>
		public FormularioPersonalizadoEntity Control
		{
			get { return _Control; }
			set { _Control = value; }
		}
        


		/// <summary>
		/// Constructor por defecto.
		/// </summary>
		public FormularioPersonalizadoValorEntity()
		{
			this.Control = new FormularioPersonalizadoEntity();
            this.Product = new ProductEntity();
		}

		/// <summary>
		/// Constructor por defecto.
		/// </summary>
		public FormularioPersonalizadoValorEntity(Int32 pId) : this()
		{
            this.Control.ProductType.ID = pId;
		}

		
		
        ///// <summary>
        ///// Inserta FormularioPersonalizadoValor.
        ///// </summary>
        ///// <returns></returns>
        //public Int32 Insertar()
        //{
        //    ResponseService<Int32> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoValorEntity, ResponseService<Int32>>("DEFormularioPersonalizadoValorInsertService", this);
        //    if (wResultado.ServiceError.HasError)
        //    {
        //        throw new Exception(wResultado.ServiceError.Mensaje);
        //    }
        //    else
        //    {
        //        return wResultado.ServiceData;
        //    }
        //}

        ///// <summary>
        ///// Elimina FormularioPersonalizadoValor.
        ///// </summary>
        ///// <returns></returns>
        //public Int32 Eliminar()
        //{
        //    ResponseService<Int32> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoValorEntity, ResponseService<Int32>>("DEFormularioPersonalizadoValorDeleteService", this);
        //    if (wResultado.ServiceError.HasError)
        //    {
        //        throw new Exception(wResultado.ServiceError.Mensaje);
        //    }
        //    else
        //    {
        //        return wResultado.ServiceData;
        //    }
        //}

        ///// <summary>
        ///// Elimina FormularioPersonalizadoValor por DocId.
        ///// </summary>
        ///// <returns></returns>
        //public Int32 EliminarByDocId()
        //{
        //    ResponseService<Int32> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoValorEntity, ResponseService<Int32>>("DEFormularioPersonalizadoValorDeleteByDocIdService", this);
        //    if (wResultado.ServiceError.HasError)
        //    {
        //        throw new Exception(wResultado.ServiceError.Mensaje);
        //    }
        //    else
        //    {
        //        return wResultado.ServiceData;
        //    }
        //}

        ///// <summary>
        ///// Modifica FormularioPersonalizadoValor.
        ///// </summary>
        ///// <returns></returns>
        //public Int32 Modificar()
        //{
        //    ResponseService<Int32> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoValorEntity, ResponseService<Int32>>("DEFormularioPersonalizadoValorUpdateService", this);
        //    if (wResultado.ServiceError.HasError)
        //    {
        //        throw new Exception(wResultado.ServiceError.Mensaje);
        //    }
        //    else
        //    {
        //        return wResultado.ServiceData;
        //    }
        //}

		/// <summary>
		/// devuelve el valor
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Valor;
		}
		
	}



	/// <summary>
	/// Lista de FormularioPersonalizadoValor.
	/// </summary>
	[DataObjectAttribute]
	public class FormularioPersonalizadoValorEntities : ListCommonEntity<FormularioPersonalizadoValorEntity>
	{

        ///// <summary>
        ///// Llena una lista de FormularioPersonalizadoValor.
        ///// </summary>
        ///// <param name="pEntidad">Criterio de filtro.</param>
        //public void Llenar(FormularioPersonalizadoValorEntity pEntidad)
        //{
        //    this.Clear();
        //    ResponseService<FormularioPersonalizadoValorEntities> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoValorEntity, ResponseService<FormularioPersonalizadoValorEntities>>("DEFormularioPersonalizadoValorSearchService", pEntidad);
        //    if (wResultado.ServiceError.HasError)
        //    {
        //        throw new Exception(wResultado.ServiceError.Mensaje);
        //    }
        //    else
        //    {
        //        foreach (FormularioPersonalizadoValorEntity wp in wResultado.ServiceData)
        //        {
        //            this.Add(wp);
        //        }
        //    }
        //}

        ///// <summary>
        ///// Llena una lista de FormularioPersonalizadoValor.
        ///// </summary>
        //public void Llenar()
        //{
        //    Llenar(new FormularioPersonalizadoValorEntity());
        //}

        ///// <summary>
        ///// Graba lista de FormularioPersonalizadoValor.
        ///// </summary>
        //public Boolean Grabar()
        //{
        //    ResponseService<Boolean> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoValorEntities, ResponseService<Boolean>>("DEFormularioPersonalizadoValorGrabarService", this );
        //    if (wResultado.ServiceError.HasError)
        //    {
        //        throw new Exception(wResultado.ServiceError.Mensaje);
        //    }
        //    else
        //    {
        //        return wResultado.ServiceData;
        //    }
        //}

	}
}