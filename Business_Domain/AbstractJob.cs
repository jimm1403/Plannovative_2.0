using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace Business_Domain
{
    public abstract class AbstractJob : IJob
    {
        private bool priceType;

        public DateTime DeadLine { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public bool PriceType { get { return priceType; } }
        public List<WorkTime> WorkTimeList { get; set; }

    }
}
