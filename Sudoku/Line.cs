using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public abstract class Line
    {
        public int[] Numbers = new int[9];
        public Cell[] cells = new Cell[9];
        public void SetNumber(int number, Cell cell)
        {
            if (Numbers.Contains(number))
            {
                return;
            }
            else
            {

            }
        }
    }
}
