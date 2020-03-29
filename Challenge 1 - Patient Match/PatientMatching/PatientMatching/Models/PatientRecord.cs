using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PatientMatching.Models
{
    public class PatientRecord
    {
        public int PatientId { get; set; } 
        public string AccountNum { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string CurrentStreet1 { get; set; }
        public string CurrentStreet2 { get; set; }
        public string CurrentCity { get; set; }
        public string CurrentState { get; set; }
        public int CurrentZipCode { get; set; }
        public string PreviousFirstName { get; set; }
        public string PreviousMiddleInitial { get; set; }
        public string PreviousLastName { get; set; }
        public string PreviousStreet1 { get; set; }
        public string PreviousStreet2 { get; set; }
        public string PreviousCity { get; set; }
        public string PreviousState { get; set; }
        public int PreviousZipCode { get; set; }


    }
}