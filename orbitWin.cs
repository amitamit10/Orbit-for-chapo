namespace Orbit
{
    public partial class orbitWin : Form
    {
        public orbitWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gui gameForm = new Gui();
            gameForm.FormClosed += (s, args) => this.Close();
            gameForm.Show();
            this.Hide();
        }
    }
}
