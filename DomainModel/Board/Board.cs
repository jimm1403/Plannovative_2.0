using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class Board
    {
        public string Name { get; set; }
        int BoardId { get; }
        Board BoardSettings { get; set; }
        List<Column> ColumnList { get; }
        List<Customer> CustomerList { get; }

    }
}
