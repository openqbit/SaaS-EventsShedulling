using OpenQbit.EventShedule.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.EventShedule.BLL.Contracts
{
    public interface ICustomerManager
    {
        bool AddCustoemer(Customer customer);
        bool EditCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        List<Customer> GetAllCustomers();
        Customer FindCustomer(Customer customer);
        List<Customer> FindCustomerList(List<Customer> customers);
    }
}
