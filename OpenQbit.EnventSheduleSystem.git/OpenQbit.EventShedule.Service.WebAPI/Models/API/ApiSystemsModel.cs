using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.EventShedule.Service.WebAPI.Models.API
{
    public class ApiSystemsModel
    {
        public int SystemsId { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
    }
}