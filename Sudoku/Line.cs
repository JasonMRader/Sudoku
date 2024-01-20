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
        public bool SetNumber(int number, Cell cell)
        {
            if (Numbers.Contains(number))
            {
                return false; // Number already exists in the row
            }
            else
            {
                cell.Number = number; // Set the number for the cell
                                      // Update the Numbers array or any other necessary state
                                      // Assuming here that you keep track of numbers in the row
                Numbers[Array.IndexOf(cells, cell)] = number;
                return true; // Number was successfully set
            }
        }
        public bool IsNumberUnique(int number, Cell cell)
        {
            return !cells.Any(c => c != cell && c.Number == number);
        }


    }
}
