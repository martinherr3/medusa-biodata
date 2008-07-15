using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Medusa.Architecture.CommonEntities;

namespace Medusa.Biodata.Common.BusinessEntities
{
	
	public enum TipoControl
	{
		Texto,
		Multilinea,
		Opcion,
		Chequeo,
		Combo,
		Seleccionar
	}
	
	/// <summary>
	/// Entidad de Negocios para FormularioPersonalizado.
	/// </summary>
	[DataObjectAttribute]
	public class FormularioPersonalizadoEntity : CommonEntity
	{

		private FormularioPersonalizadoItemEntities _Lista = null;
		/// <summary>
		/// Lista de Items
		/// </summary>
		public FormularioPersonalizadoItemEntities Lista
		{
			get { return _Lista; }
			set { _Lista = value; }
		}

		private ProductTypeEntity _ProductType = null;
		/// <summary>
		/// Tipo Documento
		/// </summary>
        public ProductTypeEntity ProductType
		{
            get { return _ProductType; }
            set { _ProductType = value; }
		}

		private TipoControl? _TipoControl = null;
		/// <summary>
		/// Tipo de Control Personalizado
		/// </summary>
		public TipoControl? TipoControl
		{
			get { return _TipoControl; }
			set { _TipoControl = value; }
		}
		
		private Int32? _Orden = null;
		/// <summary>
		/// Orden
		/// </summary>
		public Int32? Orden
		{
			get { return _Orden; }
			set { _Orden = value; }
		}

		private Boolean? _Requerido = null;
		/// <summary>
		/// Si es requerido o no el Control
		/// </summary>
		public Boolean? Requerido
		{
			get { return _Requerido; }
			set { _Requerido = value; }
		}

		private String _Etiqueta = null;
		/// <summary>
		/// Texto del control
		/// </summary>
		public String Etiqueta
		{
			get { return _Etiqueta; }
			set { _Etiqueta = value; }
		}



		/// <summary>
		/// Constructor por defecto.
		/// </summary>
		public FormularioPersonalizadoEntity()
		{
            this.ProductType = new ProductTypeEntity();
			this.Lista = new FormularioPersonalizadoItemEntities();
		}

		/// <summary>
		/// Constructor por defecto.
		/// </summary>
		public FormularioPersonalizadoEntity(Int32 pId) : this()
		{
			this.ProductType.ID = pId;
		}



		/// <summary>
		/// Inserta FormularioPersonalizado.
		/// </summary>
		/// <returns></returns>
        //public Int32 Insertar()
        //{
        //    ResponseService<Int32> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoEntity, ResponseService<Int32>>("DEFormularioPersonalizadoInsertService", this);
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
        ///// Elimina FormularioPersonalizado.
        ///// </summary>
        ///// <returns></returns>
        //public Int32 Eliminar()
        //{
        //    ResponseService<Int32> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoEntity, ResponseService<Int32>>("DEFormularioPersonalizadoDeleteService", this);
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
        ///// Modifica FormularioPersonalizado.
        ///// </summary>
        ///// <returns></returns>
        //public Int32 Modificar()
        //{
        //    ResponseService<Int32> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoEntity, ResponseService<Int32>>("DEFormularioPersonalizadoUpdateService", this);
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
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Etiqueta;
		}

	}


	/// <summary>
	/// Lista de FormularioPersonalizado.
	/// </summary>
	[DataObjectAttribute]
	public class FormularioPersonalizadoEntities : ListCommonEntity<FormularioPersonalizadoEntity>
	{

        ///// <summary>
        ///// Llena una lista de FormularioPersonalizado.
        ///// </summary>
        ///// <param name="pEntidad">Criterio de filtro.</param>
        //public void Llenar(FormularioPersonalizadoEntity pEntidad)
        //{
        //    this.Clear();
        //    ResponseService<FormularioPersonalizadoEntities> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoEntity, ResponseService<FormularioPersonalizadoEntities>>("DEFormularioPersonalizadoSearchService", pEntidad);
        //    if (wResultado.ServiceError.HasError)
        //    {
        //        throw new Exception(wResultado.ServiceError.Mensaje);
        //    }
        //    else
        //    {
        //        foreach (FormularioPersonalizadoEntity wp in wResultado.ServiceData)
        //        {
        //            this.Add(wp);
        //        }
        //    }
        //}

        ///// <summary>
        ///// Llena una lista de FormularioPersonalizado.
        ///// </summary>
        //public void Llenar()
        //{
        //    Llenar(new FormularioPersonalizadoEntity());
        //}

        ///// <summary>
        ///// Actualiza un conjunto de Formularios Personalizados
        ///// que sería un conjunto de controles personalizados
        ///// </summary>
        ///// <returns>Devuelve verdadero si se logró actualizar con éxito.</returns>
        ////public Boolean Actualizar(FormularioPersonalizadoEntities pEntidades)
        //public Boolean Actualizar()
        //{
        //    ResponseService<Boolean> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoEntities, ResponseService<Boolean>>("DEFormularioPersonalizadoActualizarService", this);
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