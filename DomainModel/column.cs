using System.Collections.Generic;

namespace DomainModel
{
    public class Column
    {
        public string Name { get; set; }
        public int ColumnId { get; }
        List<Job> Joblist { get; }


    }
}