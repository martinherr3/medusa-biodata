
using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Common.BusinessEntities;
using System.Data.Common;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Medusa.Biodata.BackEnd.DataAccessComponents
{
    /// <summary>
    /// TDG para DocumentType.
    /// </summary>
    public class DocumentTypeTableDataGateway : BaseTableDataGateway
    {
        /// <summary>
        /// Búsqueda  de DocumentType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>DocumentTypeEntities</returns>
        public static DocumentTypeEntities Search(DocumentTypeEntity pBE)
        {
            DocumentTypeEntities wLista = new DocumentTypeEntities();

            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("DOTDocumentType_s");

            wDataBase.AddInParameter(wCmd, "DOTId", DbType.Int32, pBE.ID);
            wDataBase.AddInParameter(wCmd, "DOTName", DbType.String, pBE.Name);
            wDataBase.AddInParameter(wCmd, "DOTDescription", DbType.String, pBE.Description);

            DataTable wDt = wDataBase.ExecuteDataSet(wCmd).Tables[0];

            foreach (DataRow wDr in wDt.Rows)
            {
                DocumentTypeEntity wDocument = new DocumentTypeEntity();
                wDocument.ID = Convert.ToInt32(wDr["DOTId"]);
                wDocument.Name = Convert.ToString(wDr["DOTName"]);
                wDocument.Description = Convert.ToString(wDr["DOTDescription"]);

                wLista.Add(wDocument);
            }

            return wLista;

        }

        /// <summary>
        /// Inserta DocumentType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Insert(DocumentTypeEntity pBE)
        {
            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("DOTDocumentType_i");

            wDataBase.AddOutParameter(wCmd, "DOTId", DbType.Int32, 4);
            wDataBase.AddInParameter(wCmd, "DOTName", DbType.String, pBE.Name);
            wDataBase.AddInParameter(wCmd, "DOTDescription", DbType.String, pBE.Description);

            wDataBase.ExecuteNonQuery(wCmd);

            return Convert.ToInt32(wDataBase.GetParameterValue(wCmd, "DOTId"));
        }

        /// <summary>
        /// Borra DocumentType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Delete(DocumentTypeEntity pBE)
        {
            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("DOTDocumentType_d");

            wDataBase.AddInParameter(wCmd, "DOTId", DbType.Int32, pBE.ID);

            return wDataBase.ExecuteNonQuery(wCmd);
        }

        /// <summary>
        /// Actualiza DocumentType.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Update(DocumentTypeEntity pBE)
        {
            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("DOTDocumentType_u");

            wDataBase.AddInParameter(wCmd, "DOTId", DbType.Int32, pBE.ID);
            wDataBase.AddInParameter(wCmd, "DOTName", DbType.String, pBE.Name);
            wDataBase.AddInParameter(wCmd, "DOTDescription", DbType.String, pBE.Description);

            return wDataBase.ExecuteNonQuery(wCmd);
        }

        /// <summary>
        /// Búsqueda de DocumentType por id.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>DocumentTypeEntity</returns>
        public static DocumentTypeEntity Get(Int32 pId)
        {
            DocumentTypeEntities woDocumentType;
            woDocumentType = Search(new DocumentTypeEntity(pId));
            if (woDocumentType.Count > 0)
            {
                return woDocumentType[0];
            }
            else
            {
                return null;
            }
        }
    }
}
