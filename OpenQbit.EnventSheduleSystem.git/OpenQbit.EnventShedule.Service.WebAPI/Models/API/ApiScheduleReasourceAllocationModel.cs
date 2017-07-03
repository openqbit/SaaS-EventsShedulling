using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.EnventShedule.Service.WebAPI.Models.API
{
    public class ApiScheduleReasourceAllocationModel
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }


        public string Description { get; set; }
    }
}