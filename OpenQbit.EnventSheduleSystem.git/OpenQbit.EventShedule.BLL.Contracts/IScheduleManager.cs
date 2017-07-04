using OpenQbit.EventShedule.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.EventShedule.BLL.Contracts
{
    public interface IScheduleManager
    {
        bool RecoredSchedule(Schedule schedule);
        bool EditSchedule(Schedule schedule);
        bool DeleteSchedule(Schedule schedule);
        List<Schedule> GetAllSchedules();
        Schedule FindSchedule(Schedule schedule);
        List<Schedule> FindScheduleList(List<Schedule> schedule);
        
    }
}
