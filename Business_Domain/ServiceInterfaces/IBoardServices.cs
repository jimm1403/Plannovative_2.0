using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business_Domain.ServiceInterfaces
{
    interface IBoardServices
    {
        Board CreateBoard();
        Board Refresh();
        Column CreateColumn();
        void DeadLineChange(int BoardId);
        void ColourChange(int BoardId);

        

    }
}
