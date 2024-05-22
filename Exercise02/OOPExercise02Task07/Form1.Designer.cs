namespace OOPExercise02Task07
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            gamePanel = new Panel();
            scorePanel = new Panel();
            lblPoints = new Label();
            label2 = new Label();
            lblTime = new Label();
            label1 = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            scorePanel.SuspendLayout();
            SuspendLayout();
            // 
            // gamePanel
            // 
            gamePanel.Location = new Point(12, 12);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(624, 426);
            gamePanel.TabIndex = 0;
            // 
            // scorePanel
            // 
            scorePanel.Controls.Add(lblPoints);
            scorePanel.Controls.Add(label2);
            scorePanel.Controls.Add(lblTime);
            scorePanel.Controls.Add(label1);
            scorePanel.Location = new Point(642, 14);
            scorePanel.Name = "scorePanel";
            scorePanel.Size = new Size(146, 424);
            scorePanel.TabIndex = 1;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblPoints.ForeColor = Color.Green;
            lblPoints.Location = new Point(68, 160);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(40, 46);
            lblPoints.TabIndex = 3;
            lblPoints.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(22, 134);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 2;
            label2.Text = "Scored points:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblTime.Location = new Point(48, 38);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(60, 46);
            lblTime.TabIndex = 1;
            lblTime.Text = "10";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(22, 23);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Time Remaining [s]:";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 1000;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(scorePanel);
            Controls.Add(gamePanel);
            Name = "Form1";
            Text = "Form1";
            scorePanel.ResumeLayout(false);
            scorePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel gamePanel;
        private Panel scorePanel;
        private Label label1;
        private Label label2;
        private Label lblTime;
        private Label lblPoints;
        private System.Windows.Forms.Timer gameTimer;
    }
}
