using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace OpenQbit.EnventShedule.Common.Models
{
   public class ScheduleReasourceAllocation
    {
        
        public int Id { get; set; }
        public int ScheduleId { get; set; }

        
        public string Description { get; set; }
        public virtual Schedule Schedule { get; set; }

    }
}
