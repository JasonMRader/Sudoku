using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Box
    {
        public int[] Numbers = new int[9];
        public Cell[,] cells = new Cell[3, 3];
    }
}
