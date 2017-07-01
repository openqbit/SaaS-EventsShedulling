using OpenQbit.EventShedule.BLL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.EventShedule.Common.Models;


namespace OpenQbit.EventShedule.BLL
{
    public class ScheduleManager : IScheduleManager
    {
        private IRepository _repository;

        private Ilogger _log;

        [InjectionConstructor]
        public ScheduleManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }
        public bool RecoredSchedule(Schedule schedule)
        {
            _log.LogError("");

            return _repository.Create<Schedule>(schedule);
        }
    }
}
