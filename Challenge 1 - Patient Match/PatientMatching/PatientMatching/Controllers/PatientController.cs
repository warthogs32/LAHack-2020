using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http.Description;
using PatientMatching.DTOs;
using System.Web.Cors;
using System.Web.Http;
using PatientMatching.Repositories;
using PatientMatching.Models;

namespace PatientMatching.Controllers
{
    [RoutePrefix("api/patients")]
    public class PatientController : ApiController
    {
        private PatientRepository _patientRepo = new PatientRepository();

        [Route("getAllRecords/")]
        [ResponseType(typeof(GetAllPatientRecordsResponseDTO))]
        [HttpGet]
        public GetAllPatientRecordsResponseDTO GetAllEvents()
        {
            List<PatientRecord> allPatients = _patientRepo.GetAllPatientRecords();
            return new GetAllPatientRecordsResponseDTO()
            {
                Patients = allPatients
            };

        }
    }
}
