namespace Orbit
{
    partial class orbitWin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            aiTrainingButton = new Button();
            onePlayerbutton = new Button();
            twoPlayersButton = new Button();
            SuspendLayout();
            // 
            // aiTrainingButton
            // 
            aiTrainingButton.Location = new Point(568, 162);
            aiTrainingButton.Name = "aiTrainingButton";
            aiTrainingButton.Size = new Size(115, 55);
            aiTrainingButton.TabIndex = 0;
            aiTrainingButton.Text = "AI training";
            aiTrainingButton.UseVisualStyleBackColor = true;
            // 
            // onePlayerbutton
            // 
            onePlayerbutton.Location = new Point(368, 162);
            onePlayerbutton.Name = "onePlayerbutton";
            onePlayerbutton.Size = new Size(115, 55);
            onePlayerbutton.TabIndex = 1;
            onePlayerbutton.Text = "one player";
            onePlayerbutton.UseVisualStyleBackColor = true;
            onePlayerbutton.Click += button2_Click;
            // 
            // twoPlayersButton
            // 
            twoPlayersButton.Location = new Point(173, 162);
            twoPlayersButton.Name = "twoPlayersButton";
            twoPlayersButton.Size = new Size(115, 55);
            twoPlayersButton.TabIndex = 2;
            twoPlayersButton.Text = "two players";
            twoPlayersButton.UseVisualStyleBackColor = true;
            twoPlayersButton.Click += button3_Click;
            // 
            // Orbit
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(twoPlayersButton);
            Controls.Add(onePlayerbutton);
            Controls.Add(aiTrainingButton);
            Name = "Orbit";
            Text = "Orbit";
            ResumeLayout(false);
        }

        #endregion

        private Button aiTrainingButton;
        private Button onePlayerbutton;
        private Button twoPlayersButton;
    }
}
