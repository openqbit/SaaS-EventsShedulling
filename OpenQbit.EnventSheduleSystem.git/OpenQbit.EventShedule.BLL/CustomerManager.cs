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
    public class CustomerManager : ICustomerManager
    {
        private IRepository _repository;

        private ILogger _log;

        public CustomerManager(IRepository repository,ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }

        public bool AddCustoemer(Customer customer)
        {
            _log.logError("");
            return _repository.Create < Customer > (customer);
        }

        public bool DeleteCustomer(Customer customer)
        {
            _log.logError("");

            return _repository.Delete<Customer>(customer);
        }

        public bool EditCustomer(Customer customer)
        {
            _log.logError("");

            return _repository.Update<Customer>(customer);
        }

        public Customer FindCustomer(int id)
        {
            _log.logError("");

            return _repository.Find<Customer>(S => S.CustomerId == id);
        }

        public List<Customer> FindCustomerList(List<Customer> customers)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }
    }
}
