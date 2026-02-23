namespace Orbit
{
    public partial class Orbit : Form
    {
        public Orbit()
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
            Game gameForm = new Game();
            gameForm.FormClosed += (s, args) => this.Close();
            gameForm.Show();
            this.Hide();
        }
    }
}
