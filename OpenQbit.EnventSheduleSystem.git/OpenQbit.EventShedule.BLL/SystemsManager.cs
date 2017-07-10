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
    class SystemsManager : ISystemManager
    {
        private IRepository _repository;

        private ILogger _log;

        public SystemsManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }

        public bool AddSystem(Systems system)
        {
            _log.logError("");

            return _repository.Create<Systems>(system);
        }

        public bool DeleteSystem(Systems system)
        {
            _log.logError("");

            return _repository.Delete<Systems>(system);
        }

        public bool EditSystem(Systems system)
        {
            _log.logError("");

            return _repository.Update<Systems>(system);
        }

        public Systems FindSystem(int id)
        {
            _log.logError("");

            return _repository.Find<Systems>(S => S.SystemsId == id);
        }

        public List<Systems> FindSystemList(List<Systems> system)
        {
            throw new NotImplementedException();
        }

        public List<Systems> GetAllSystems()
        {
            throw new NotImplementedException();
        }
    }
}
