using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DomainModel
{
    public class Board
    {
        public string Name { get; set; }
        public int BoardId { get; set; }
        public Board BoardSettings { get; set; }
        public List<Column> ColumnList { get; }
        public List<Customer> CustomerList { get; }
        public Board(string name, int boardId)
        {
            this.Name = name;
            this.BoardId = boardId;

        }

    }
}
