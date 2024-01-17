using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Game
    {
        public Row[] Rows = new Row[9];
        public Game() 
        {
            CreateRows();
        }
        private void CreateRows()
        {
            for(int i = 0; i < 9; i++) 
            {
                Row row = new Row();
                Rows[i] = row;
            }
        }
    }
}
