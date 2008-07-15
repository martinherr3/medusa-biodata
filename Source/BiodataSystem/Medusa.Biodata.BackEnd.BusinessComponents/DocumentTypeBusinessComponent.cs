
using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Common.BusinessEntities;
using Medusa.Biodata.BackEnd.DataAccessComponents;


namespace Medusa.Biodata.BackEnd.BusinessComponents
{
    /// <summary>
    /// Componente de negocios para DocumentType.
    /// </summary>
    public class DocumentTypeBusinessComponent : BaseBusinessComponent
    {
        /// <summary>
        /// Búsqueda  de DocumentType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>DocumentTypeEntities</returns>
        public static DocumentTypeEntities Search(DocumentTypeEntity pBE)
        {
            try
            {
                return DocumentTypeDataAccessComponent.Search(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inserta DocumentType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Insert(DocumentTypeEntity pBE)
        {
            try
            {
                return DocumentTypeDataAccessComponent.Insert(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Borra DocumentType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Delete(DocumentTypeEntity pBE)
        {
            try
            {
                return DocumentTypeDataAccessComponent.Delete(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Actualiza DocumentType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Update(DocumentTypeEntity pBE)
        {
            try
            {
                return DocumentTypeDataAccessComponent.Update(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
