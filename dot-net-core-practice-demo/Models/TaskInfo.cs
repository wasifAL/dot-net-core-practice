using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dot_net_core_practice_demo.Models
{
    public class TaskInfo
    {
        [Key]
        public Guid TaskId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string AssignedBy { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }
    }

   
}
