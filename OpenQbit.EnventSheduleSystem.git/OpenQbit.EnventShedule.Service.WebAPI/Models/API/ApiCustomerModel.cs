using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.EnventShedule.Service.WebAPI.Models.API
{
    public class ApiCustomerModel
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int TelephoneNumber { get; set; }

        public string Email { get; set; }
    }
}