using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Domain.ServiceInterfaces
{
    interface IJobServices
    {
        List<WorkTime> ShowListOfTimes();
        string ShowPriceType(bool PriceType);
        IJob ShowJob();

    }
}
