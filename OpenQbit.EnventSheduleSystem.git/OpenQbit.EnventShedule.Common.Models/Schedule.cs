using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.EventShedule.Common.Models
{
  public  class Schedule
    {
        public int ScheduleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String Description { get; set; }
        public int PrimaryReasourceId { get; set; }

        public int ParentScheduleId { get; set; }

        public int SystemsId { get; set; }

        public virtual ICollection<ScheduleReasourceAllocation> scheduleReasourceAllocation { get; set; }
        public virtual ICollection<ScheduleProductAllocation> scheduleProductAllocation { get; set; }
        public virtual Systems Systems { get; set; }
    }
}
