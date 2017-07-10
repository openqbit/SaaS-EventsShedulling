using Microsoft.Owin.Logging;
using OpenQbit.EventShedule.BLL;
using OpenQbit.EventShedule.BLL.Contracts;
using OpenQbit.EventShedule.DataAccess.DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenQbit.EventShedule.Common.Models;

namespace OpenQbit.EnventShedule.Service.WebAPI.Controllers.API
{
    public class ScheduleController : IScheduleManager
    {
        public bool DeleteSchedule(Schedule schedule)
        {
            throw new NotImplementedException();
        }

        public bool EditSchedule(Schedule schedule)
        {
            throw new NotImplementedException();
        }

        public Schedule FindSchedule(Schedule schedule)
        {
            throw new NotImplementedException();
        }

        public List<Schedule> FindScheduleList(List<Schedule> schedule)
        {
            throw new NotImplementedException();
        }

        public List<Schedule> GetAllSchedules()
        {
            throw new NotImplementedException();
        }

        public bool RecoredSchedule(Schedule schedule)
        {
            throw new NotImplementedException();
        }
    }
}