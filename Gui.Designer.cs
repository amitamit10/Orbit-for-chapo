namespace Orbit
{
    partial class Gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            pix_board = new PictureBox();
            pictureBox1 = new PictureBox();
            HomeBtn = new Button();
            mainPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            blackStack = new Panel();
            label1 = new Label();
            whiteStack = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pix_board).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mainPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            blackStack.SuspendLayout();
            whiteStack.SuspendLayout();
            SuspendLayout();
            // 
            // pix_board
            // 
            pix_board.Anchor = AnchorStyles.None;
            pix_board.Image = Properties.Resources.orbitBoard;
            pix_board.Location = new Point(84, 90);
            pix_board.Name = "pix_board";
            pix_board.Size = new Size(253, 253);
            pix_board.SizeMode = PictureBoxSizeMode.StretchImage;
            pix_board.TabIndex = 0;
            pix_board.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(937, 105);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // HomeBtn
            // 
            HomeBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            HomeBtn.Location = new Point(909, 208);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(112, 34);
            HomeBtn.TabIndex = 2;
            HomeBtn.Text = "Home";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            // 
            // mainPanel
            // 
            mainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.BackColor = Color.FromArgb(192, 192, 255);
            mainPanel.Controls.Add(pix_board);
            mainPanel.Location = new Point(210, 3);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(408, 456);
            mainPanel.TabIndex = 3;
            mainPanel.Resize += mainPanel_Resize;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(mainPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(blackStack, 2, 0);
            tableLayoutPanel1.Controls.Add(whiteStack, 0, 0);
            tableLayoutPanel1.Location = new Point(56, 39);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(828, 462);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // blackStack
            // 
            blackStack.BackColor = SystemColors.ActiveCaption;
            blackStack.Controls.Add(label1);
            blackStack.Dock = DockStyle.Fill;
            blackStack.Location = new Point(624, 3);
            blackStack.Name = "blackStack";
            blackStack.Size = new Size(201, 456);
            blackStack.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 118);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // whiteStack
            // 
            whiteStack.BackColor = Color.FromArgb(255, 192, 192);
            whiteStack.Controls.Add(label2);
            whiteStack.Dock = DockStyle.Fill;
            whiteStack.Location = new Point(3, 3);
            whiteStack.Name = "whiteStack";
            whiteStack.Size = new Size(201, 456);
            whiteStack.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 78);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // Gui
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 526);
            Controls.Add(HomeBtn);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Name = "Gui";
            Text = "Game";
            Load += Game_Load;
            ((System.ComponentModel.ISupportInitialize)pix_board).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mainPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            blackStack.ResumeLayout(false);
            blackStack.PerformLayout();
            whiteStack.ResumeLayout(false);
            whiteStack.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pix_board;
        private PictureBox pictureBox1;
        private Button HomeBtn;
        private Panel mainPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel blackStack;
        private Label label1;
        private Panel whiteStack;
        private Label label2;
    }
}