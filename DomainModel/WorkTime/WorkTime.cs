using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class WorkTime
    {
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        DateTime WorkDate { get; set; }
        float TotalAmountOfWorkInHours { get; }

    }
}
