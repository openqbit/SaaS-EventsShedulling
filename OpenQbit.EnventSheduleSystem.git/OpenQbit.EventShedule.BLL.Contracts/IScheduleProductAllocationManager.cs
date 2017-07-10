using OpenQbit.EventShedule.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.EventShedule.BLL.Contracts
{
    public interface IScheduleProductAllocationManager
    {
        bool AddScheduleProductAllocation(ScheduleProductAllocation sheduleProductAllocation);
        bool EditScheduleProductAllocation(ScheduleProductAllocation sheduleProductAllocation);
        bool DeleteScheduleProductAllocation(ScheduleProductAllocation sheduleProductAllocation);
        List<ScheduleProductAllocation> GetAllScheduleProductAllocations();
        ScheduleProductAllocation FindScheduleProductAllocation(ScheduleProductAllocation sheduleProductAllocation);
        List<ScheduleProductAllocation> FindScheduleProductAllocationList(List<ScheduleProductAllocation> sheduleProductAllocation);
    }
}
