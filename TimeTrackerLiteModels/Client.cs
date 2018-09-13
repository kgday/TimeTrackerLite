using System;
using System.Collections.Generic;
using System.Text;

namespace TimeTrackerLite.Models
{
    public class Client : BaseModel
    {
        public string Name { get; set; }
        public string PhoneNo { get; set; }
        public bool IsActive { get; set; }
    }
}
