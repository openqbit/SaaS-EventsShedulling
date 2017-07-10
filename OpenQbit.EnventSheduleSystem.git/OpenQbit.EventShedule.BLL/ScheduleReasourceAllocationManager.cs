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
    class ScheduleReasourceAllocationManager : IScheduleReasourceAllocationManager
    {
        private IRepository _repository;

        private ILogger _log;

        public ScheduleReasourceAllocationManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }

        public bool AddScheduleReasourceAllocation(ScheduleReasourceAllocation sheduleReasourceAllocation)
        {
            _log.logError("");

            return _repository.Create<ScheduleReasourceAllocation>(sheduleReasourceAllocation);
        }

        public bool DeleteScheduleProductAllocation(ScheduleReasourceAllocation sheduleReasourceAllocation)
        {
            _log.logError("");

            return _repository.Delete<ScheduleReasourceAllocation>(sheduleReasourceAllocation);
        }

        public bool EditScheduleReasourceAllocation(ScheduleReasourceAllocation sheduleReasourceAllocation)
        {
            _log.logError("");

            return _repository.Update<ScheduleReasourceAllocation>(sheduleReasourceAllocation);
        }

        public ScheduleReasourceAllocation FindScheduleReasourceAllocation(int id)
        {
            _log.logError("");

            return _repository.Find<ScheduleReasourceAllocation>(S => S.ScheduleId == id);
        }

        public List<ScheduleReasourceAllocation> FindScheduleReasourceAllocationList(List<ScheduleReasourceAllocation> sheduleReasourceAllocation)
        {
            throw new NotImplementedException();
        }

        public List<ScheduleReasourceAllocation> GetAllScheduleReasourceAllocations()
        {
            throw new NotImplementedException();
        }

        public ScheduleReasourceAllocation FindScheduleReasourceAllocation(ScheduleReasourceAllocation sheduleReasourceAllocation)
        {
            throw new NotImplementedException();
        }
    }
}
