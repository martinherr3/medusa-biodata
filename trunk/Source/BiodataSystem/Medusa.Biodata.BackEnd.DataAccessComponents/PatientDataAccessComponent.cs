
using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Common.BusinessEntities;
using System.Data.Common;
using System.Data;

namespace Medusa.Biodata.BackEnd.DataAccessComponents
{
    /// <summary>
    /// DAC para Patient.
    /// </summary>
    public class PatientDataAccessComponent : BaseDataAccessComponent
    {
        /// <summary>
        /// Búsqueda  de Patient.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>PatientEntities</returns>
        public static PatientEntities Search(PatientEntity pBE)
        {
            try
            {
                PatientEntities wPatients = PatientTableDataGateway.Search(pBE);
                foreach (PatientEntity wPatient in wPatients)
                {
                    wPatient.DocumentType = DocumentTypeTableDataGateway.Get(wPatient.DocumentType.ID.Value);
                }

                return wPatients;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inserta Patient.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Insert(PatientEntity pBE)
        {
            try
            {
                return PatientTableDataGateway.Insert(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// Borra Patient.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Delete(PatientEntity pBE)
        {
            try
            {
                return PatientTableDataGateway.Delete(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Actualiza Patient.
        /// </summary>
        /// <param name="pBE">Entidad.</param>
        /// <returns>Int32</returns>
        public static Int32 Update(PatientEntity pBE)
        {
            try
            {
                return PatientTableDataGateway.Update(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
