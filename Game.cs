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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }



        private void HomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orbit homeForm = new Orbit();
            homeForm.FormClosed += (s, args) => this.Close();
            homeForm.Show();
        }
    }
}
