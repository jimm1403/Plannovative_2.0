using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using Business_Domain.ServiceInterfaces;

namespace Business_Domain.DomainServices
{
    class BoardServices : IBoardServices
    {
        List<Board> BoardList = new List<Board>();
        public void ColourChange(int BoardId)
        {
            throw new NotImplementedException();
        }

        public Board CreateBoard(string Name, int BoardId)
        {
            Board newBoard = new Board(Name,BoardId);
            newBoard.BoardId++;

            return newBoard;
        }

        public List<Column> CreateColumn(int NumbersOfColumns,int BoardId)
        {

               for (int i = 0; i < NumbersOfColumns; i++)
              {
                Column newColumn = new Column();
                BoardList.Add(newColumn);
                
               
              }
            return BoardList;







        }

        public void DeadLineChange(int BoardId)
        {
            throw new NotImplementedException();
        }

        public Board Refresh()
        {
            throw new NotImplementedException();
        }
    }
}
