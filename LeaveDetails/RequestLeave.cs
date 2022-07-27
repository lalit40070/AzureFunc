using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveDetails
{
    public class RequestLeave
    {
            [JsonProperty(PropertyName = "employeeId")]
            public string EmployeeId { get; set; }
            public string EmployeeName { get; set; }
            public DateTime FromDate { get; set; }
            public DateTime ToDate { get; set; }
        
    }
}
