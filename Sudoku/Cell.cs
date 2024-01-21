using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Cell
    {
        public TextBox TxtBx { get; set; }
        private int _number = 0;

        public int Number
        {
            get { return _number; }
            set
            {
               
                if (IsValidNumber(value))
                {
                    _number = value;
                    TxtBx.Text = value.ToString();
                }
                else
                {
                   
                    TxtBx.Text = "";
                }
            }
        }

        private bool IsValidNumber(int number)
        {
            
            return Row.IsNumberUnique(number, this) &&
                   Column.IsNumberUnique(number, this) &&
                   Box.IsNumberUnique(number, this);
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
            if (!IsValidNumber(number))
            {
                TxtBx.BackColor = Color.Red;
            }
            else
            {
                TxtBx.BackColor = Color.White;
            }
            if(TxtBx.Text == "")
            {
                TxtBx.BackColor = Color.White;
            }
        }
        public void GetNumber()
        {
            List<int> numbers = Row.Numbers.ToList();
            numbers.Concat(Box.Numbers.ToList());
            numbers.Concat(Column.Numbers.ToList());
            numbers = numbers.Distinct().ToList();
            NumberPicker numberPicker = new NumberPicker(numbers);
            this.Number = numberPicker.PickNumber();

        }
        public void GenerateNumber()
        {
            Random random = new Random();
            bool numberSet = false;

            while (!numberSet)
            {
                int num = random.Next(1, 10);

                // Check if the number is unique across row, column, and box
                if (Row.IsNumberUnique(num, this) &&
                    Column.IsNumberUnique(num, this) &&
                    Box.IsNumberUnique(num, this))
                {
                    this.Number = num;
                    numberSet = true;
                }
            }
        }

    }
}
