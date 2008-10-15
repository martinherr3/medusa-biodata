
using System;
using System.Collections.Generic;
using System.Text;
using Medusa.Architecture.CommonEntities;
using Biodata.BusinessComponent;
using Biodata.Domain;
using Biodata.Core.DataInterfaces;
using Biodata.Utils;
using Medusa.Architecture.Bases.BackEnd;
using Biodata.DTO;
using Biodata.Transformers;

namespace Biodata.Service
{
    /// <summary>
    /// Servicio para Borrar Paciente
    /// </summary>


    class PacienteDeleteService : IBusinessService<PacienteDTO, ResponseService<Int32>>
    {

        /// <summary>
        /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
        /// </summary>
        public IDaoFactory DaoFactory
        {
            get
            {
                return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
            }
        }

        #region IBusinessService<PacienteDTO,ResponseService<Int32>> Members

        public ResponseService<Int32> Execute(PacienteDTO pServiceRequest)
        {
            ResponseService<Int32> wRes = new ResponseService<Int32>();
            try
            {
                PacienteBusiness _pacienteBusiness;
                _pacienteBusiness = new PacienteBusiness(DaoFactory.GetPacienteDao());
                Paciente myPaciente;
                myPaciente = TransformerPaciente.DTOToEntity(pServiceRequest);
                _pacienteBusiness.Delete(myPaciente);
                wRes.ServiceData = 1;
            }
            catch (Exception ex)
            {
                wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
            }
            return wRes;
        }


        #endregion
    }


    /// <summary>
    /// Servicio para agregar Paciente
    /// </summary>
    class PacienteSaveService : IBusinessService<PacienteDTO, ResponseService<Int32>>
    {

        /// <summary>
        /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
        /// </summary>
        public IDaoFactory DaoFactory
        {
            get
            {
                return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
            }
        }

        #region IBusinessService<PacienteDTO,ResponseService<Int32>> Members

        public ResponseService<Int32> Execute(PacienteDTO pServiceRequest)
        {
            ResponseService<Int32> wRes = new ResponseService<Int32>();
            try
            {
                PacienteBusiness _pacienteBusiness;
                _pacienteBusiness = new PacienteBusiness(DaoFactory.GetPacienteDao());
                Paciente myPaciente;
                myPaciente = TransformerPaciente.DTOToEntity(pServiceRequest);
                _pacienteBusiness.Insert(myPaciente);
                wRes.ServiceData = 1;
            }
            catch (Exception ex)
            {
                wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
            }
            return wRes;

        }

        #endregion
    }


    /// <summary>
    /// Servicio para consultar Paciente por atributos de la misma
    /// </summary>
    //class PacienteGetByEntityService : IBusinessService<Paciente, ResponseService<List<Paciente>>>
    //{
    //    #region IBusinessService<Paciente,ResponseService<List<Paciente>>> Members
    //    public ResponseService<List<Paciente>> Execute(Paciente pServiceRequest)
    //    {
    //        ResponseService<List<Paciente>> wRes = new ResponseService<List<Paciente>>();
    //        try
    //        {
    //            wRes.ServiceData = PacienteBC.GetByEntity(pServiceRequest);
    //        }
    //        catch (Exception ex)
    //        {
    //            wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
    //        }
    //        return wRes;


    //    }
    //    #endregion
    //}


    /// <summary>
    /// Servicio para consultar Paciente por su ID
    /// </summary>
    //class PacienteGetByIdService : IBusinessService<Int32, ResponseService<List<Paciente>>>
    //{
    //    #region IBusinessService<Int32,ResponseService<List<Paciente>>> Members
    //    public ResponseService<List<Paciente>> Execute(Int32 pServiceRequest)
    //    {
    //        ResponseService<List<Paciente>> wRes = new ResponseService<List<Paciente>>();
    //        try
    //        {
    //            wRes.ServiceData = PacienteBC.GetById(pServiceRequest);
    //        }
    //        catch (Exception ex)
    //        {
    //            wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
    //        }
    //        return wRes;


    //    }
    //    #endregion
    //}


    // <summary>
    // Servicio para consultar Pacientes
    // </summary>
    class PacienteGetAllService : IBusinessService<PacienteDTO, ResponseService<List<PacienteDTO>>>
    {
        /// <summary>
        /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
        /// </summary>
        public IDaoFactory DaoFactory
        {
            get
            {
                return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
            }
        }

        #region IBusinessService<PacienteDTO,ResponseService<List<PacienteDTO>>> Members
        public ResponseService<List<PacienteDTO>> Execute(PacienteDTO pServiceRequest)
        {
            ResponseService<List<PacienteDTO>> wRes = new ResponseService<List<PacienteDTO>>();
            try
            {
                PacienteBusiness _pacienteBusiness;
                _pacienteBusiness = new PacienteBusiness(DaoFactory.GetPacienteDao());
                List<Paciente> Pacientes = _pacienteBusiness.GetAll();

                List<PacienteDTO> PacientesDTO = new List<PacienteDTO>();

                foreach (Paciente wObj in Pacientes)
                {
                    PacientesDTO.Add(TransformerPaciente.EntityToDTO(wObj));
                }

                wRes.ServiceData = PacientesDTO;
            }
            catch (Exception ex)
            {
                wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
            }
            return wRes;


        }
        #endregion
    }


    // <summary>
    // Servicio para modificar Paciente
    // </summary>
    class PacienteUpdateService : IBusinessService<PacienteDTO, ResponseService<Int32>>
    {

         /// <summary>
        /// Exposes accessor for the <see cref="IDaoFactory" /> used by all pages.
        /// </summary>
        public IDaoFactory DaoFactory
        {
            get
            {
                return (IDaoFactory)ContainerHelper.WindsorContainer()[typeof(IDaoFactory)];
            }
        }

        #region IBusinessService<PacienteDTO,ResponseService<Int32>> Members

        public ResponseService<Int32> Execute(PacienteDTO pServiceRequest)
        {
            ResponseService<Int32> wRes = new ResponseService<Int32>();
            try
            {
                PacienteBusiness _pacienteBusiness;
                _pacienteBusiness = new PacienteBusiness(DaoFactory.GetPacienteDao());
                Paciente myPaciente;
                myPaciente = TransformerPaciente.DTOToEntity(pServiceRequest);
                _pacienteBusiness.Update(myPaciente);
                wRes.ServiceData = 1;
            }
            catch (Exception ex)
            {
                wRes.ServiceError = new ServiceError(ex.Message, ex.Source, ex.StackTrace);
            }
            return wRes;

        }

        #endregion
    }
}

