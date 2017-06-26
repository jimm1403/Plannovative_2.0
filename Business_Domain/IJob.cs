using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Domain
{
    class IJob
    {
        #region
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }
        public bool PriceType { get; set; }
        public int Price { get; set; }
        public List<WorkTimes> WorkTimeList { get; set; }
        #endregion

        public List<WorkTimes> ShowListOfTimes()
        {
            return WorkTimeList;
        }
        public void ShowPriceType(bool PriceType) { }









    }
}
