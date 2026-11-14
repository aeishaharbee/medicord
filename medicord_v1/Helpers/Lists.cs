using System;
using System.Collections.Generic;
using System.Text;

namespace medicord_v1.Helpers
{
    public static class Lists
    {
        public static readonly string[] Nationalities =
        {
            "Afghanistan", "Armenia", "Azerbaijan", "Bahrain", "Bangladesh", "Bhutan",
            "Brunei", "Burma (Myanmar)", "Cambodia", "China", "Cyprus", "East Timor",
            "Egypt", "Georgia", "India", "Indonesia", "Iran", "Iraq", "Israel", "Japan",
            "Jordan", "Kazakhstan", "Kuwait", "Kyrgyzstan", "Laos", "Lebanon", "Malaysia",
            "Maldives", "Mongolia", "Nepal", "North Korea", "Oman", "Pakistan", "Palestine",
            "Philippines", "Qatar", "Russia", "Saudi Arabia", "Singapore", "South Korea",
            "Sri Lanka", "Syria", "Taiwan", "Tajikistan", "Thailand", "Turkey", "Turkmenistan",
            "United Arab Emirates", "Uzbekistan", "Vietnam", "Yemen", "Other"
        };
        public static readonly string[] States =
        { "Johor", "Kedah", "Kelantan", "Melaka", "Negeri Sembilan", "Pahang", "Perak", "Perlis",
          "Pulau Pinang", "Sabah", "Sarawak", "Selangor", "Terengganu", "Kuala Lumpur", "Labuan", "Putrajaya" };
        public static readonly string[] IdTypes = { "NRIC", "Passport", "MyKid" };
        public static readonly string[] MedicalRoles =
        { "Medical Officer", "Medical Assistant", "Staff Nurse", "Specialist" };

        public static readonly string[] FacilityCategories =
        {
            "General Clinic", "Specialist Clinic", "Hospital",
            "Diagnostic & Lab Centre", "Long-Term & Rehab Centre"
        };
        public static readonly string[] ApptDurations = { "15 minutes", "20 minutes", "30 minutes", "45 minutes", "60 minutes" };
        public static readonly string[] RecordCategories = { "Visit", "Lab result", "Prescription", "Other" };

    }
}
