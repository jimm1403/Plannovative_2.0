using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Domain.DomainServices
{
    interface IWorkTimeServices
    {
        List<WorkTime> ShowWorkTimes();
        int CalculateTimeUsedADay(TimeSpan StartTime, TimeSpan EndTime);
        int CalculateTimeUsedForJob(List<TimeSpan> StartTimeList, List<TimeSpan> EndTimeList);
        float CalculatePriceforJob(bool PriceType, float TotalAmountOfWorkInHours);
    }
}
