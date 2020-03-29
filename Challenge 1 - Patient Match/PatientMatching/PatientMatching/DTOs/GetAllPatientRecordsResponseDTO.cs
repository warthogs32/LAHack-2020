using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PatientMatching.Models;

namespace PatientMatching.DTOs
{
    public class GetAllPatientRecordsResponseDTO
    {
        public List<PatientRecord> Patients { get; set; }
    }
}