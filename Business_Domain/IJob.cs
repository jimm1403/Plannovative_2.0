using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Domain
{
    public interface IJob
    {

        string Name { get; set; }
        string Description { get; set; }
        DateTime DeadLine { get; set; }
        bool PriceType { get; }
        int Price { get; set; }
        List<WorkTime> WorkTimeList { get; set; }
    }
}
