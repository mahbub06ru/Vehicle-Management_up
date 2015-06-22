using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleManagementSoftware.Model
{
    public class Shedule
    {
        public int Sid { get; set; }
        public int Vid { get; set; }
        public DateTime Date { get; set; }
        public string Shift { get; set; }
        public string BookedBy { get; set; }
        public string Address { get; set; }
    }
}