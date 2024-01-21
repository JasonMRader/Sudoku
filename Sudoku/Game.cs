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
        public Column[] Columns = new Column[9];
        public Box[] Boxes = new Box[9];
        private List<Control> controls = new List<Control>();
        public Cell[,] cells = new Cell[9, 9];
        public Game(List<Control> controls) 
        {
            this.controls = controls;
            CreateRows();
            CreateColumns();
            CreateBoxes();
            CreateCells();
            GenerateSolution();
        }
        private void CreateRows()
        {
            for(int i = 0; i < 9; i++) 
            {
                Row row = new Row();
                Rows[i] = row;
            }
        }
        private void CreateColumns()
        {
            for (int i = 0; i < 9; i++)
            {
                Column column = new Column();
                Columns[i] = column;
            }
        }
        private void CreateBoxes()
        {
            for(int i =0; i < 9; i++)
            {
                Box box = new Box();
                Boxes[i] = box;
            }
        }
        private void CreateCells()
        {
            for (int i =0; i < 9; i++)
            {
                for (int  j = 0; j < 9; j++)
                {
                    string textBoxName = $"txt{i + 1}_{j + 1}";
                    TextBox textBox = controls.OfType<TextBox>().FirstOrDefault(tb => tb.Name == textBoxName);

                    if (textBox != null)
                    {
                        Cell cell = new Cell(textBox);
                        cell.Row = Rows[i];
                        cell.Column = Columns[j];
                        
                        // Assuming you have an array or list in Row and Column to hold cells
                        int boxIndex = (i / 3) * 3 + (j / 3);
                        cell.Box = Boxes[boxIndex];

                        Rows[i].cells[j] = cell;
                        Columns[j].cells[i] = cell;
                        Boxes[boxIndex].cells[i % 3, j % 3] = cell; // 
                    }
                }
            }
        }
        private void GenerateSolution()
        {
            foreach(Row row in Rows)
            {
                foreach(Cell cell in row.cells)
                {
                    //cell.GenerateNumber();
                    cell.GetNumber();
                    

                }
            }
        }
    }
}
