using System.Collections.Generic;

namespace Business_Domain.DomainModels
{
    class Column
    {
        public string Name { get; set; }
        public int ColumnId { get; }
        List<Job> Joblist { get; }


    }
}