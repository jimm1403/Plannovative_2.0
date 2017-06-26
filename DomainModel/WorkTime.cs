using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class WorkTime
    {
        TimeSpan StartTime { get; set; }
        TimeSpan EndTime { get; set; }
        DateTime WorkDate { get; set; }
        float TotalAmountOfWorkInHours { get; }

    }
}
