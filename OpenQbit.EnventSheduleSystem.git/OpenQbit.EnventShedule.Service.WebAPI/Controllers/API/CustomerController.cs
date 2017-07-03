using OpenQbit.EnventShedule.Service.WebAPI.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OpenQbit.EnventShedule.Service.WebAPI.Controllers.API
{
    public class CustomerController : ApiController
    {
        public ApiCustomerModel Get(int CustomerId)
        {
            ApiCustomerModel customer = new ApiCustomerModel
            {

            };
            return customer;
        }

        public List<ApiCustomerModel> GetList()
        {
            List<ApiCustomerModel> customerList = new List<ApiCustomerModel>();

            ApiCustomerModel customer1 = new ApiCustomerModel
            {

            };

            ApiCustomerModel customer2 = new ApiCustomerModel
            {

            };
            customerList.Add(customer1);
            customerList.Add(customer2);

            return customerList;
        }
    }
}
