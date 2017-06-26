using System.Collections.Generic;

namespace Business_Domain.DomainModels
{
    public class Column
    {
        public string Name { get; set; }
        public int ColumnId { get; }
        List<Job> Joblist { get; }


    }
}