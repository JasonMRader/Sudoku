using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Cell
    {
        public TextBox TxtBx {  get; set; }
        public int Number
        {
            get
            {
                int.TryParse(TxtBx.Text, out int number);
                return number;
            }
            set
            {
                TxtBx.Text = value.ToString();
            }
        }
        public Row Row { get; set; }
        public Column Column { get; set; }
        public Box Box { get; set; }
        public Cell() { }   
        public Cell(TextBox txt)
        {
            TxtBx = txt;
            TxtBx.TextChanged += TxtBx_TextChanged;
        }
        private void TxtBx_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(TxtBx.Text, out int number);
            // Additional logic if needed when text changes
        }
        public void GenerateNumber()
        {
            Random random = new Random();
            bool numberSet = false;

            while (!numberSet)
            {
                int num = random.Next(1, 10);

                // Attempt to set the number on the Row
                numberSet = Row.SetNumber(num, this);
            }
        }
    }
}
