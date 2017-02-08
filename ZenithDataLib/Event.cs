using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenithDataLib
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public string EnteredBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool IsActive { get; set; }

        public Activity InActivity { get; set; }

    }
}
