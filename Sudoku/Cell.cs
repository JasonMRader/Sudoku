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
        public Row Row { get; set; }
        public Column Column { get; set; }
        public Box Box { get; set; }
        public Cell() { }   
        public Cell(TextBox txt)
        {
            txtBx = txt;
        }
    }
}
