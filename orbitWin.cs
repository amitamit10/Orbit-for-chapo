using System;
using System.Drawing;
using System.Windows.Forms;

namespace Orbit
{
    public partial class orbitWin : Form
    {
        public orbitWin()
        {
            InitializeComponent();
            aiTrainingButton.Click += button1_Click;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            this.BackColor = Color.FromArgb(13, 13, 28);

            // Title label
            var title = new Label
            {
                Text = "ORBIT",
                Font = new Font("Segoe UI", 42, FontStyle.Bold),
                ForeColor = Color.FromArgb(110, 170, 255),
                BackColor = Color.Transparent,
                AutoSize = true,
                Anchor = AnchorStyles.None
            };

            // Subtitle label
            var subtitle = new Label
            {
                Text = "Strategy Board Game  —  4×4 Rotating Board",
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.FromArgb(130, 130, 175),
                BackColor = Color.Transparent,
                AutoSize = true,
                Anchor = AnchorStyles.None
            };

            // Footer label
            var footer = new Label
            {
                Text = "Each turn: place a piece, then the board rotates. First to 4 in a row wins.",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(80, 80, 115),
                BackColor = Color.Transparent,
                AutoSize = true,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };

            this.Controls.Add(title);
            this.Controls.Add(subtitle);
            this.Controls.Add(footer);

            StyleButton(twoPlayersButton, Color.FromArgb(35, 110, 65),  Color.FromArgb(55, 145, 90));
            StyleButton(onePlayerbutton,  Color.FromArgb(35, 70,  140), Color.FromArgb(55, 100, 180));
            StyleButton(aiTrainingButton, Color.FromArgb(90, 40,  90),  Color.FromArgb(120, 60, 120));

            this.Load += (s, e) =>
            {
                int cx = this.ClientSize.Width / 2;
                title.Location    = new Point(cx - title.Width / 2,    28);
                subtitle.Location = new Point(cx - subtitle.Width / 2, 100);
                footer.Location   = new Point(cx - footer.Width / 2,   this.ClientSize.Height - 30);

                // Center buttons
                int totalW = twoPlayersButton.Width + onePlayerbutton.Width + aiTrainingButton.Width + 40;
                int startX = cx - totalW / 2;
                int btnY   = 160;
                twoPlayersButton.Location = new Point(startX, btnY);
                onePlayerbutton.Location  = new Point(startX + twoPlayersButton.Width + 20, btnY);
                aiTrainingButton.Location = new Point(startX + twoPlayersButton.Width + onePlayerbutton.Width + 40, btnY);
            };
        }

        private static void StyleButton(Button btn, Color bg, Color border)
        {
            btn.BackColor = bg;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = border;
            btn.FlatAppearance.BorderSize  = 1;
            btn.Font   = new Font("Segoe UI", 11);
            btn.Cursor = Cursors.Hand;
            btn.Size   = new Size(130, 50);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AI Training mode coming soon!", "Coming Soon",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AI opponent coming soon!\nOpening two-player mode.", "One Player",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            LaunchGame();
        }

        private void button3_Click(object sender, EventArgs e) => LaunchGame();

        private void LaunchGame()
        {
            var g = new Gui();
            g.FormClosed += (s, a) => this.Close();
            g.Show();
            this.Hide();
        }
    }
}
