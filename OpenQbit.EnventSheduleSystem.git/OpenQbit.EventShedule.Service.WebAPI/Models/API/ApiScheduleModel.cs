using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.EventShedule.Service.WebAPI.Models.API
{
    public class ApiScheduleModel
    {
        public int ScheduleId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public String Description { get; set; }
        public int PrimaryReasourceId { get; set; }

        public int ParentScheduleId { get; set; }

        public int SystemsId { get; set; }
    }
}