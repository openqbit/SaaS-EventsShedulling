using OpenQbit.EventShedule.BLL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.EventShedule.Common.Models;
using OpenQbit.EventShedule.DataAccess.DAL.Contracts;
using OpenQbit.EventShedule.Common.Utils.Logs;

namespace OpenQbit.EventShedule.BLL
{
    public class ScheduleManager : IScheduleManager
    {
        private IRepository _repository;

        private ILogger _log;

       // [InjectionConstructor]
        public ScheduleManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }
        public bool RecoredSchedule(Schedule schedule)
        {
            _log.logError("");

            return _repository.Create<Schedule>(schedule);
        }
    }
}
