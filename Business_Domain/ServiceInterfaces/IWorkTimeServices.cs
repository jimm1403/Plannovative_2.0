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
        int CalculateTimeUsedADay(DateTime StartTime, DateTime EndTime);
        int CalculateTimeUsedForJob(List<DateTime> StartTimeList, List<DateTime> EndTimeList);
        float CalculatePriceforJob(bool PriceType, float TotalAmountOfWorkInHours);
    }
}
