using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
//using OpenQbit.EventShedule.
using OpenQbit.EventShedule.Common.Models;

namespace OpenQbit.EventShedule.DataAccess.DAL
{
    class ScheduleContext:DbContext
    {
        public ScheduleContext() : base("ScheduleDatabase") {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Customer> dbCustomer { get; set; }
        public DbSet<Schedule> dbSchedule { get; set; }
        public DbSet<ScheduleProductAllocation> dbScheduleProductAllocation { get; set; }
        public DbSet<ScheduleReasourceAllocation> dbScheduleReasourceAllocation { get; set; }
        public DbSet<Systems> dbSystems { get; set; }
    }
}
