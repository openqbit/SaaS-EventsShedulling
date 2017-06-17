using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.EnventShedule.Common.Models
{
   public class ScheduleProductAllocation
    {

        public int Id { get; set; }
        public int ScheduleId { get; set; }        

        public DateTime ArrivalTime { get; set; }

        public DateTime DepatureTime { get; set; }

        public virtual Schedule Schedule { get; set; }
    }
}
