using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Domain.DomainServices
{
    class JobFactory
    {
        public enum PriceType
        {
            Fixed,
            Hourly
        }

        public static IJob Create(JobFactory.PriceType type, string name, string description, 
            DateTime deadline, int price)
        {
            if (type == PriceType.Fixed)
            {
                return new FixedJob(name, description, deadline, price);
            }
            else
            {
                return new HourlyJob(name, description, deadline, price);
            }
        }

        public static IJob Create(string name, string description,
            DateTime deadline, int price, bool priceType)
        {
            return JobFactory.Create
                (priceType ? PriceType.Hourly : PriceType.Fixed, name, description, deadline, price);
        }

        private JobFactory()
        {
        }
    }
}
