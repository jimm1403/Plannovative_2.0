using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [Serializable]
    public class HourlyJob : AbstractJob
    {
        public HourlyJob(string name, string description, DateTime deadline, int price) 
            : base(name, description, deadline, price, false)
        {
            //Time pris opgave
        }
    }
}
