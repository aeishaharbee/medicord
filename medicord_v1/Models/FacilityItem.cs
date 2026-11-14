using System;
using System.Collections.Generic;
using System.Text;

namespace medicord_v1.Models
{
    public record FacilityItem(int Id, string Name)
    {
        public override string ToString() => Name;  
    }
}
