using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using PatientMatching.Models;

namespace PatientMatching.Repositories
{
    public class PatientRepository
    {
        public List<PatientRecord> GetAllPatientRecords()
        {
            List<PatientRecord> PatientEntries = new List<PatientRecord>();
            try
            {
                return PatientEntries;
            }
            catch (SqlException e)
            {
                return PatientEntries;
            }
        }
    }
}