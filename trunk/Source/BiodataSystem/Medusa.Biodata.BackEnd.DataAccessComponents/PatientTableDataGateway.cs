
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
    /// TDG para Patient.
    /// </summary>
    public class PatientTableDataGateway : BaseTableDataGateway
    {
        /// <summary>
        /// Búsqueda  de Patient.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>PatientEntities</returns>
        public static PatientEntities Search(PatientEntity pBE)
        {
            PatientEntities wLista = new PatientEntities();

            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("PATPatient_s");

            wDataBase.AddInParameter(wCmd, "PATId", DbType.Int32, pBE.ID);
            wDataBase.AddInParameter(wCmd, "PATFirstName", DbType.String, pBE.FirstName);
            wDataBase.AddInParameter(wCmd, "PATLastName", DbType.String, pBE.LastName);
            wDataBase.AddInParameter(wCmd, "DOTId", DbType.Int32, pBE.DocumentType.ID);
            wDataBase.AddInParameter(wCmd, "PATDocumentNumber", DbType.String, pBE.DocumentNumber);
            wDataBase.AddInParameter(wCmd, "PATAddress", DbType.String, pBE.Address);
            wDataBase.AddInParameter(wCmd, "PATPhone", DbType.String, pBE.Phone);
            wDataBase.AddInParameter(wCmd, "PATMobile", DbType.String, pBE.Mobile);
            wDataBase.AddInParameter(wCmd, "PATEmail", DbType.String, pBE.Email);
            wDataBase.AddInParameter(wCmd, "PATDateBirth", DbType.DateTime, pBE.DateBirth);
            wDataBase.AddInParameter(wCmd, "PATProfession", DbType.String, pBE.Profession);
            wDataBase.AddInParameter(wCmd, "PATHealthInsurance", DbType.String, pBE.HealthInsurance);

            DataTable wDt = wDataBase.ExecuteDataSet(wCmd).Tables[0];

            foreach (DataRow wDr in wDt.Rows)
            {
                PatientEntity wPatient = new PatientEntity();
                wPatient.ID = Convert.ToInt32(wDr["PATId"]);
                wPatient.FirstName = Convert.ToString(wDr["PATFirstName"]);
                wPatient.LastName = Convert.ToString(wDr["PATLastName"]);
                wPatient.DocumentType.ID = Convert.ToInt32(wDr["DOTId"]);
                wPatient.DocumentNumber = Convert.ToString(wDr["PATDocumentNumber"]);
                wPatient.Address = Convert.ToString(wDr["PATAddress"]);
                wPatient.Phone = Convert.ToString(wDr["PATPhone"]);
                wPatient.Mobile = Convert.ToString(wDr["PATMobile"]);
                wPatient.Email = Convert.ToString(wDr["PATEmail"]);
                wPatient.DateBirth = Convert.ToDateTime(wDr["PATDateBirth"]);
                wPatient.Profession = Convert.ToString(wDr["PATProfession"]);
                wPatient.HealthInsurance = Convert.ToString(wDr["PATHealthInsurance"]);

                wLista.Add(wPatient);
            }

            return wLista;

        }

        /// <summary>
        /// Inserta Patient.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Insert(PatientEntity pBE)
        {
            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("PATPatient_i");

            wDataBase.AddOutParameter(wCmd, "PATId", DbType.Int32, 4);
            wDataBase.AddInParameter(wCmd, "PATFirstName", DbType.String, pBE.FirstName);
            wDataBase.AddInParameter(wCmd, "PATLastName", DbType.String, pBE.LastName);
            wDataBase.AddInParameter(wCmd, "DOTId", DbType.Int32, pBE.DocumentType.ID);
            wDataBase.AddInParameter(wCmd, "PATDocumentNumber", DbType.String, pBE.DocumentNumber);
            wDataBase.AddInParameter(wCmd, "PATAddress", DbType.String, pBE.Address);
            wDataBase.AddInParameter(wCmd, "PATPhone", DbType.String, pBE.Phone);
            wDataBase.AddInParameter(wCmd, "PATMobile", DbType.String, pBE.Mobile);
            wDataBase.AddInParameter(wCmd, "PATEmail", DbType.String, pBE.Email);
            wDataBase.AddInParameter(wCmd, "PATDateBirth", DbType.DateTime, pBE.DateBirth);
            wDataBase.AddInParameter(wCmd, "PATProfession", DbType.String, pBE.Profession);
            wDataBase.AddInParameter(wCmd, "PATHealthInsurance", DbType.String, pBE.HealthInsurance);

            wDataBase.ExecuteNonQuery(wCmd);

            return Convert.ToInt32(wDataBase.GetParameterValue(wCmd, "PATId"));
        }

        /// <summary>
        /// Borra Patient.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Delete(PatientEntity pBE)
        {
            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("PATPatient_d");

            wDataBase.AddInParameter(wCmd, "PATId", DbType.Int32, pBE.ID);

            return wDataBase.ExecuteNonQuery(wCmd);
        }

        /// <summary>
        /// Actualiza Patient.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Update(PatientEntity pBE)
        {
            Database wDataBase = DatabaseFactory.CreateDatabase("conexion");

            DbCommand wCmd = wDataBase.GetStoredProcCommand("PATPatient_u");

            wDataBase.AddInParameter(wCmd, "PATId", DbType.Int32, pBE.ID);
            wDataBase.AddInParameter(wCmd, "PATFirstName", DbType.String, pBE.FirstName);
            wDataBase.AddInParameter(wCmd, "PATLastName", DbType.String, pBE.LastName);
            wDataBase.AddInParameter(wCmd, "DOTId", DbType.Int32, pBE.DocumentType.ID);
            wDataBase.AddInParameter(wCmd, "PATDocumentNumber", DbType.String, pBE.DocumentNumber);
            wDataBase.AddInParameter(wCmd, "PATAddress", DbType.String, pBE.Address);
            wDataBase.AddInParameter(wCmd, "PATPhone", DbType.String, pBE.Phone);
            wDataBase.AddInParameter(wCmd, "PATMobile", DbType.String, pBE.Mobile);
            wDataBase.AddInParameter(wCmd, "PATEmail", DbType.String, pBE.Email);
            wDataBase.AddInParameter(wCmd, "PATDateBirth", DbType.DateTime, pBE.DateBirth);
            wDataBase.AddInParameter(wCmd, "PATProfession", DbType.String, pBE.Profession);
            wDataBase.AddInParameter(wCmd, "PATHealthInsurance", DbType.String, pBE.HealthInsurance);

            return wDataBase.ExecuteNonQuery(wCmd);
        }

        /// <summary>
        /// Búsqueda de Patient por id.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>PatientEntity</returns>
        public static PatientEntity Get(Int32 pId)
        {
            PatientEntities woPatient;
            woPatient = Search(new PatientEntity(pId));
            if (woPatient.Count > 0)
            {
                return woPatient[0];
            }
            else
            {
                return null;
            }
        }
    }
}
      
