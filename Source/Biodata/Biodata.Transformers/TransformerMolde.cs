using System;
using System.Collections.Generic;
using System.Text;
using Biodata.Domain;
using Biodata.DTO;

namespace Biodata.Transformers
{
    public class TransformerMolde
    {
        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static Molde DTOToEntity(MoldeDTO pMolde)
        {

            Molde pReturn = new Molde();

            pReturn.ID = pMolde.ID;
            pReturn.Descripcion = pMolde.Descripcion;

            //Paciente - MoldePaciente
            if (pMolde.Pacientes != null)
            {
                foreach (MoldePacienteDTO pObj in pMolde.Pacientes)
                {
                    pReturn.Pacientes.Add(TransformerMoldePaciente.DTOToEntity(pObj));
                }
            }


            return pReturn;
        }

        //Convierte un objeto DTO en una Entity de NHibernate, sus propiedades basicas
        //y utiliza el metodo Transformer de sus objetos mas complejos
        public static MoldeDTO EntityToDTO(Molde pMolde)
        {

            MoldeDTO pReturn = new MoldeDTO();

            pReturn.ID = pMolde.ID;
            pReturn.Descripcion = pMolde.Descripcion;

            //Paciente - MoldePaciente
            if (pMolde.Pacientes != null)
            {
                foreach (MoldePaciente pObj in pMolde.Pacientes)
                {
                    pReturn.Pacientes.Add(TransformerMoldePaciente.EntityToDTO(pObj));
                }
            }


            return pReturn;
        }
    }
}
