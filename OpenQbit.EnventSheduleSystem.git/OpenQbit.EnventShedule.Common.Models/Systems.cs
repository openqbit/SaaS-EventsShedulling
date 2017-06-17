using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.EventShedule.Common.Models
{
    public class Systems
    {
        public int SystemsId { get; set; }
        public string Description { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<Schedule> Schedule { get; set; }

    }
}
