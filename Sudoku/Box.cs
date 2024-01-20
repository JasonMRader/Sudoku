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
        public bool IsNumberUnique(int number, Cell cell)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (cells[i, j] != cell && cells[i, j].Number == number)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
