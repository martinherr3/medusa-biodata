
using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Common.BusinessEntities;
using System.Data.Common;
using System.Data;

namespace Medusa.Biodata.BackEnd.DataAccessComponents
{
    /// <summary>
    /// DAC para DocumentType.
    /// </summary>
    public class DocumentTypeDataAccessComponent : BaseDataAccessComponent
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
                return DocumentTypeTableDataGateway.Search(pBE);
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
                return DocumentTypeTableDataGateway.Insert(pBE);
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
                return DocumentTypeTableDataGateway.Delete(pBE);
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
                return DocumentTypeTableDataGateway.Update(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
