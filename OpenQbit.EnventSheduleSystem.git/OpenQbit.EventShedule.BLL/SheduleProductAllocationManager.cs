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
    class SheduleProductAllocationManager : IScheduleProductAllocationManager
    {
        private IRepository _repository;

        private ILogger _log;

        public SheduleProductAllocationManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }

        public bool AddScheduleProductAllocation(ScheduleProductAllocation sheduleProductAllocation)
        {
            _log.logError("");
            return _repository.Create<ScheduleProductAllocation>(sheduleProductAllocation);
        }

        public bool DeleteScheduleProductAllocation(ScheduleProductAllocation sheduleProductAllocation)
        {
            _log.logError("");
            return _repository.Delete<ScheduleProductAllocation>(sheduleProductAllocation);
        }

        public bool EditScheduleProductAllocation(ScheduleProductAllocation sheduleProductAllocation)
        {
            _log.logError("");
            return _repository.Update<ScheduleProductAllocation>(sheduleProductAllocation); 
        }

        public ScheduleProductAllocation FindScheduleProductAllocation(int id)
        {
            _log.logError("");
            return _repository.Find<ScheduleProductAllocation>(S => S.ScheduleId == id);
        }

        public List<ScheduleProductAllocation> FindScheduleProductAllocationList(List<ScheduleProductAllocation> sheduleProductAllocation)
        {
            throw new NotImplementedException();
        }

        public List<ScheduleProductAllocation> GetAllScheduleProductAllocations()
        {
            throw new NotImplementedException();
        }
    }
}
