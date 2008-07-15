using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Medusa.Architecture.CommonEntities;

namespace Medusa.Biodata.Common.BusinessEntities
{
    
	/// <summary>
    /// Entidad de Negocios para FormularioPersonalizadoItem.
    /// </summary>  
    [DataObjectAttribute]
    public class FormularioPersonalizadoItemEntity : CommonEntity
    {

		private Int32? _Id = null;
		/// <summary>
		/// Id
		/// </summary>
		public Int32? Id
		{
			get { return _Id; }
			set { _Id = value; }
		}
		
		private String _Etiqueta = null;
        /// <summary>
        /// Etiqueta
        /// </summary>
        public String Etiqueta
        {
            get { return _Etiqueta; }
            set { _Etiqueta = value; }
        }

        private FormularioPersonalizadoEntity _Control = null;
        /// <summary>
        /// Control del que depende
        /// </summary>
        public FormularioPersonalizadoEntity Control
        {
            get { return _Control; }
            set { _Control = value; }
        }       



        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FormularioPersonalizadoItemEntity()
        {
			this.Control = new FormularioPersonalizadoEntity();
        }

		/// <summary>
		/// Constructor.
		/// </summary>
		public FormularioPersonalizadoItemEntity(Int32 pId) : this()
		{
			Id = pId;
		}

        /// <summary>
        /// Constructor.
        /// </summary>
		public FormularioPersonalizadoItemEntity(String pEtiqueta, Int32 pId) : this(pId)
        {
            Etiqueta = pEtiqueta;
        }

        
		
        ///// <summary>
        ///// Inserta FormularioPersonalizadoItem.
        ///// </summary>
        ///// <returns></returns>
        //public Int32 Insertar()
        //{
        //    ResponseService<Int32> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoItemEntity, ResponseService<Int32>>("DEFormularioPersonalizadoItemInsertService", this);
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
        ///// Elimina FormularioPersonalizadoItem.
        ///// </summary>
        ///// <returns></returns>
        //public Int32 Eliminar()
        //{
        //    ResponseService<Int32> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoItemEntity, ResponseService<Int32>>("DEFormularioPersonalizadoItemDeleteService", this);
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
        ///// Modifica FormularioPersonalizadoItem.
        ///// </summary>
        ///// <returns></returns>
        //public Int32 Modificar()
        //{
        //    ResponseService<Int32> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoItemEntity, ResponseService<Int32>>("DEFormularioPersonalizadoItemUpdateService", this);
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
	/// Lista de FormularioPersonalizadoItem.
    /// </summary>
    [DataObjectAttribute]
	public class FormularioPersonalizadoItemEntities : ListCommonEntity<FormularioPersonalizadoItemEntity>
    {

        ///// <summary>
        ///// Llena una lista de FormularioPersonalizadoItem.
        ///// </summary>
        ///// <param name="pEntidad">Criterio de filtro.</param>
        //public void Llenar(FormularioPersonalizadoItemEntity pEntidad)
        //{
        //    ResponseService<FormularioPersonalizadoItemEntities> wResultado = new Wrapper().ExecuteService<FormularioPersonalizadoItemEntity, ResponseService<FormularioPersonalizadoItemEntities>>("DEFormularioPersonalizadoItemSearchService", pEntidad);
        //    if (wResultado.ServiceError.HasError)
        //    {
        //        throw new Exception(wResultado.ServiceError.Mensaje);
        //    }
        //    else
        //    {
        //        foreach (FormularioPersonalizadoItemEntity wp in wResultado.ServiceData)
        //        {
        //            this.Add(wp);
        //        }
        //    }
        //}

        ///// <summary>
        ///// Llena una lista de FormularioPersonalizadoItem.
        ///// </summary>
        //public void Llenar()
        //{
        //    Llenar(new FormularioPersonalizadoItemEntity());
        //}

    }
}