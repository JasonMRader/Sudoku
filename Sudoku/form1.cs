namespace Sudoku
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void form1_Load(object sender, EventArgs e)
        {
            Cell cell = new Cell(txt1_1);
            cell.txtBx.Text = cell.Number.ToString();
            Game game = new Game();


        }
    }
}