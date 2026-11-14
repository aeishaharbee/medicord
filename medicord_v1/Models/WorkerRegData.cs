using System;
using System.Collections.Generic;
using System.Text;

namespace medicord_v1.Models
{
    public class WorkerRegData
    {
        public int FacilityID;
        public string Nationality = "", IdType = "", IdNumber = "", FullName = "", MedicalRole = "", Phone = "";
        public List<int> Days = new();  
        public string Email = "", Password = "";
    }
}
