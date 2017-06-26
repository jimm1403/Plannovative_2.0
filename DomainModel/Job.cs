﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class Job
    {
        string Name { get; set; }
        string Description { get; set; }
        DateTime DeadLine { get; set; }
        bool PriceType { get; set; }
        int Price { get; set; }
        List<WorkTime> WorkTimeList { get; set; }
    }
}
