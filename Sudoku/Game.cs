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
        public Game() 
        {
            CreateRows();
            CreateColumns();
            CreateCells();
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
        private void CreateCells()
        {
            for (int i =0; i < 9; i++)
            {
                for (int  j = 0; j < 9; j++)
                {
                    Cell cell = new Cell();
                    cell.Row = Rows[i];
                    cell.Column = Columns[j];
                }
            }
        }
    }
}
