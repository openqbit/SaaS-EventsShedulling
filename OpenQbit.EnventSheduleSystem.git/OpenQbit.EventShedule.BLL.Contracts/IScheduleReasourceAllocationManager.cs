using OpenQbit.EventShedule.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.EventShedule.BLL.Contracts
{
    public interface IScheduleReasourceAllocationManager
    {
        bool AddScheduleReasourceAllocation(ScheduleReasourceAllocation sheduleReasourceAllocation);
        bool EditScheduleReasourceAllocation(ScheduleReasourceAllocation sheduleReasourceAllocation);
        bool DeleteScheduleProductAllocation(ScheduleReasourceAllocation sheduleReasourceAllocation);
        List<ScheduleReasourceAllocation> GetAllScheduleReasourceAllocations();
        ScheduleReasourceAllocation FindScheduleReasourceAllocation(ScheduleReasourceAllocation sheduleReasourceAllocation);
        List<ScheduleReasourceAllocation> FindScheduleReasourceAllocationList(List<ScheduleReasourceAllocation> sheduleReasourceAllocation);
    }
}
