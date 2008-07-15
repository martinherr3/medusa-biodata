
using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Biodata.Common.BusinessEntities;
using Medusa.Biodata.BackEnd.DataAccessComponents;


namespace Medusa.Biodata.BackEnd.BusinessComponents
{
    /// <summary>
    /// Componente de negocios para Patient.
    /// </summary>
    public class PatientBusinessComponent : BaseBusinessComponent
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
                return PatientDataAccessComponent.Search(pBE);
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
                return PatientDataAccessComponent.Insert(pBE);
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
                return PatientDataAccessComponent.Delete(pBE);
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
                return PatientDataAccessComponent.Update(pBE);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}    
      
