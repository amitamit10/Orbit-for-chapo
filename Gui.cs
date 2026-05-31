using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Orbit
{
    public partial class Gui : Form
    {
        public Gui()
        {
            InitializeComponent();
        }



        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            orbitWin homeForm = new orbitWin();
            homeForm.FormClosed += (s, args) => this.Close();
            homeForm.Show();
        }

        private void mainPanel_Resize(object sender, EventArgs e)
        {
            int minSize = Math.Min(mainPanel.Width, mainPanel.Height);
            int w, h;
            w = h = minSize - 20; // Subtract some padding
            pix_board.Size = new Size(w, h);
            int left = (mainPanel.Width - w) / 2;
            int top = (mainPanel.Height - h) / 2;
            pix_board.Location = new Point(left, top);

        }

        private void Game_Load(object sender, EventArgs e)
        {
            mainPanel_Resize(null, null);
        }

        public void deleteFromStack()
        {

        }
    }
}
