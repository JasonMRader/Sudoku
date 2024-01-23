namespace Sudoku
{
    public partial class form1 : Form
    {
        Game game;
        public form1()
        {
            InitializeComponent();
            List<Control> allControls = GetAllControls(this);
            game = new Game(allControls);
        }
        private List<Control> GetAllControls(Control parent)
        {
            List<Control> controlList = new List<Control>();
            foreach (Control c in parent.Controls)
            {
                controlList.Add(c);
                if (c.HasChildren)
                {
                    controlList.AddRange(GetAllControls(c));
                }
            }
            return controlList;
        }
        private void form1_Load(object sender, EventArgs e)
        {
            //Cell cell = new Cell(txt1_1);
            //cell.TxtBx.Text = cell.Number.ToString();



        }
    }
}