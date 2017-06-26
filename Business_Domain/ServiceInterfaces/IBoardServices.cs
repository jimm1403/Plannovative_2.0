using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Domain.ServiceInterfaces
{
    interface IBoardServices
    {
        Board CreateBoard(string Name, int BoardId);
        Board Refresh();
        List<Column> CreateColumn(int NumberOfColumns, int BoardId);
        void DeadLineChange(int BoardId);
        void ColourChange(int BoardId);

        

    }
}
