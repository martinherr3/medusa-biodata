
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace Medusa.Biodata.Common.BusinessEntities
{
    /// <summary>
    /// Entidad de Negocios para Patient.
    /// </summary>
    [DataObjectAttribute]
    public class PatientEntity : PersonEntity 
    {
        private String _Profession;

        public String Profession
        {
            get { return _Profession; }
            set { _Profession = value; }
        }
        private String _HealthInsurance;

        public String HealthInsurance
        {
            get { return _HealthInsurance; }
            set { _HealthInsurance = value; }
        }


        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public PatientEntity()
        {
            this.DocumentType = new DocumentTypeEntity();
        }

        /// <summary>
        /// Constructor con Parametros.
        /// </summary>
        public PatientEntity(Int32 pID)
        {
            this.ID = pID;
            this.DocumentType = new DocumentTypeEntity();
        }

        public override string ToString()
        {
            throw new Exception("Debe implementar el método ToString() de la entidad Patient.");
        }


    }

    /// <summary>
    /// Lista de Patient.
    /// </summary>
    [DataObjectAttribute]
    public class PatientEntities : ListBaseBusinessEntity<PatientEntity>
    {

    }
}

