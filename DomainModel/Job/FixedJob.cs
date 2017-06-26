using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    [Serializable]
    public class FixedJob : AbstractJob
    {
        public FixedJob(string name, string description, DateTime deadline, int price) 
            : base(name, description, deadline, price, true)
        {
            //Fast pris opgave
        }
    }
}
