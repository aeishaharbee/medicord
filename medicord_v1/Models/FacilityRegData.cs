using System;
using System.Collections.Generic;
using System.Text;

namespace medicord_v1.Models
{
    public class FacilityRegData
    {
        public string Name = "", Category = "", Description = "";
        public byte[]? Logo;
        public string Address = "", City = "", Postcode = "", State = "", Phone = "";
        public TimeSpan OpenTime, CloseTime;
        public int SlotMinutes, MaxPerSlot = 1;
        public bool WalkInAvailable = true;
        public string Email = "", Password = "";
        public List<int> OpenDays = new() { 1, 2, 3, 4, 5 };      //Mon-Fri by default
        public bool LogoChanged;

    }
}
