namespace Sudoku
{
    public partial class form1 : Form
    {
        Game game;

        private bool isDraggingForm = false;
        private System.Drawing.Point lastLocation;

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
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDraggingForm = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggingForm)
            {
                this.Location = new System.Drawing.Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingForm = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            List<Control> allControls = GetAllControls(this);
            game = new Game(allControls);
        }
    }
}