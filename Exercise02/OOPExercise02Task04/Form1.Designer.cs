namespace OOPExercise02Task04
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
            btnRed = new Button();
            btnGreen = new Button();
            btnBlue = new Button();
            txtEvents = new TextBox();
            SuspendLayout();
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRed.ForeColor = Color.White;
            btnRed.Location = new Point(46, 12);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(150, 150);
            btnRed.TabIndex = 0;
            btnRed.Text = "Red";
            btnRed.UseVisualStyleBackColor = false;
            btnRed.Click += btnRed_Click;
            btnRed.MouseClick += btnRed_MouseClick;
            btnRed.MouseDown += btn_MouseDown;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Green;
            btnGreen.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnGreen.ForeColor = Color.White;
            btnGreen.Location = new Point(228, 12);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(150, 150);
            btnGreen.TabIndex = 1;
            btnGreen.Text = "Green";
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += btnGreen_Click;
            btnGreen.MouseClick += btnGreen_MouseClick;
            btnGreen.MouseDown += btn_MouseDown;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.Blue;
            btnBlue.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnBlue.ForeColor = Color.White;
            btnBlue.Location = new Point(414, 12);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(150, 150);
            btnBlue.TabIndex = 2;
            btnBlue.Text = "Blue";
            btnBlue.UseVisualStyleBackColor = false;
            btnBlue.Click += btnBlue_Click;
            btnBlue.MouseClick += btnBlue_MouseClick;
            btnBlue.MouseDown += btn_MouseDown;
            // 
            // txtEvents
            // 
            txtEvents.BackColor = SystemColors.Info;
            txtEvents.Location = new Point(46, 180);
            txtEvents.Multiline = true;
            txtEvents.Name = "txtEvents";
            txtEvents.ReadOnly = true;
            txtEvents.ScrollBars = ScrollBars.Vertical;
            txtEvents.Size = new Size(518, 261);
            txtEvents.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 453);
            Controls.Add(txtEvents);
            Controls.Add(btnBlue);
            Controls.Add(btnGreen);
            Controls.Add(btnRed);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRed;
        private Button btnGreen;
        private Button btnBlue;
        private TextBox txtEvents;
    }
}
