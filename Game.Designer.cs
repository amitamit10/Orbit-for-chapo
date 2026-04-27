namespace Orbit
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            board = new PictureBox();
            pictureBox1 = new PictureBox();
            HomeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)board).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // board
            // 
            board.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            board.Image = Properties.Resources.orbitBoard;
            board.Location = new Point(135, 3);
            board.Name = "board";
            board.Size = new Size(478, 435);
            board.SizeMode = PictureBoxSizeMode.StretchImage;
            board.TabIndex = 0;
            board.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(619, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // HomeBtn
            // 
            HomeBtn.Location = new Point(660, 391);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(112, 34);
            HomeBtn.TabIndex = 2;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HomeBtn);
            Controls.Add(pictureBox1);
            Controls.Add(board);
            Name = "Game";
            Text = "Game";
            ((System.ComponentModel.ISupportInitialize)board).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox board;
        private PictureBox pictureBox1;
        private Button HomeBtn;
    }
}