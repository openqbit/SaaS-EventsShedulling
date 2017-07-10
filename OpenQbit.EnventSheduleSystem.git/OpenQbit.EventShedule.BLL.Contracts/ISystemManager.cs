using OpenQbit.EventShedule.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.EventShedule.BLL.Contracts
{
    public interface ISystemManager
    {
        bool AddSystem(Systems system);
        bool EditSystem(Systems system);
        bool DeleteSystem(Systems system);
        List<Systems> GetAllSystems();
        Systems FindSystem(Systems system);
        List<Systems> FindSystemList(List<Systems> system);
    }
}
