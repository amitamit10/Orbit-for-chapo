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

        private PictureBox[, ] pictureBoxes = new PictureBox[GameConsts.BOARD_SIZE, GameConsts.BOARD_SIZE];
        private PictureBox[, ] blackBalls = new PictureBox[GameConsts.BOARD_SIZE, GameConsts.BOARD_SIZE];
        private PictureBox[, ] whiteBalls = new PictureBox[GameConsts.BOARD_SIZE, GameConsts.BOARD_SIZE];

        private void InitBoard()
        {

        }
    }
}
