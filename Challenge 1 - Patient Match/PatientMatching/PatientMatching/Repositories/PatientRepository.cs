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
                PatientRecord retrievedRecord;  
                using (SqlConnection conn = new SqlConnection(PatientMatching.Resource1.ConnectString))
                {
                    conn.Open();
                    string getPatientsQuery = "select * from dbo.DataExport";
                    using (SqlCommand cmd = new SqlCommand(getPatientsQuery, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                retrievedRecord = new PatientRecord()
                                {
                                    AccountNum = reader["AccountNum"].ToString(),
                                    FirstName = reader["FirstName"].ToString().ToUpper(),
                                    MiddleInitial = reader["MiddleInitial"].ToString().ToUpper(),
                                    LastName = reader["LastName"].ToString().ToUpper(),
                                    DateOfBirth = string.IsNullOrEmpty(reader["DateOfBirth"].ToString()) ? DateTime.MinValue : DateTime.Parse(reader["DateOfBirth"].ToString()),
                                    Sex = reader["Sex"].ToString().ToUpper(),
                                    CurrentStreet1 = reader["CurrentStreet1"].ToString().ToUpper(),
                                    CurrentStreet2 = reader["CurrentStreet2"].ToString().ToUpper(),
                                    CurrentCity = reader["CurrentCity"].ToString().ToUpper(),
                                    CurrentState = reader["CurrentState"].ToString().ToUpper(),
                                    CurrentZipCode = string.IsNullOrEmpty(reader["CurrentZipCode"].ToString()) ? 0 : Int32.Parse(reader["CurrentZipCode"].ToString()),
                                    PreviousFirstName = reader["PreviousFirstName"].ToString().ToUpper(),
                                    PreviousMiddleInitial = reader["PreviousMiddleInitial"].ToString().ToUpper(),
                                    PreviousLastName = reader["PreviousLastName"].ToString().ToUpper(),
                                    PreviousStreet1 = reader["PreviousStreet1"].ToString().ToUpper(),
                                    PreviousStreet2 = reader["PreviousStreet2"].ToString().ToUpper(),
                                    PreviousCity = reader["PreviousCity"].ToString().ToUpper(),
                                    PreviousState = reader["PreviousState"].ToString().ToUpper(),
                                    PreviousZipCode = string.IsNullOrEmpty(reader["PreviousZipCode"].ToString()) ? 0 : Int32.Parse(reader["PreviousZipCode"].ToString())
                                };
                                PatientEntries.Add(retrievedRecord);
                            }
                        }
                    }
                }
                return PatientEntries;
            }
            catch (SqlException e)
            {
                return PatientEntries;
            }
        }


        private void GroupPatients(List<PatientRecord> PatientEntries)
        {
            List <List<PatientRecord>> RecordList = new List<List<PatientRecord>>();
            /*
                first group into broad, general groups based on LAST name
            */
            PatientRecord patient;
            foreach(PatientRecord entry in PatientEntries)
            {
                CurrentLastName = entry.LastName;
                foreach(List)
            }



        }
    }
