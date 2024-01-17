using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Cell
    {
        public TextBox txtBx {  get; set; }
        public int Number = 0;
        public Cell(TextBox txt)
        {
            txtBx = txt;
        }
    }
}
