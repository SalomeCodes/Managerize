using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wegister.Models
{
    public class HourRegistration
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
    }
}
