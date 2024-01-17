namespace Sudoku
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }
        Game game = new Game();
        private void form1_Load(object sender, EventArgs e)
        {
            Cell cell = new Cell(txt1_1);
            cell.txtBx.Text = cell.Number.ToString();
            game = new Game();


        }
    }
}