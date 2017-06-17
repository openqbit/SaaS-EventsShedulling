using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.EnventShedule.Common.Models
{
   public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public int TelephoneNumber { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Systems> Systems { get; set; }
    }
}
