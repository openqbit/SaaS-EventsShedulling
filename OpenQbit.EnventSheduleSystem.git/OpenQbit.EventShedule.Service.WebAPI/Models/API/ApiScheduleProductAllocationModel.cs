using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.EventShedule.Service.WebAPI.Models.API
{
    public class ApiScheduleProductAllocationModel
    {
        public int Id { get; set; }
        public int ScheduleId { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime DepatureTime { get; set; }
    }
}