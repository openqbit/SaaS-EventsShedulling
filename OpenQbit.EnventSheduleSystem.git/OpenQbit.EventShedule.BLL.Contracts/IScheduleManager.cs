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
    }
}
