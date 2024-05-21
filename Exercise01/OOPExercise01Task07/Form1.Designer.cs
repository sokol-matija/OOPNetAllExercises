namespace OOPExecise01Task07
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
            btnCreatePanel = new Button();
            btnUp = new Button();
            btnDown = new Button();
            btnLeft = new Button();
            btnRight = new Button();
            SuspendLayout();
            // 
            // btnCreatePanel
            // 
            btnCreatePanel.Location = new Point(330, 218);
            btnCreatePanel.Name = "btnCreatePanel";
            btnCreatePanel.Size = new Size(125, 125);
            btnCreatePanel.TabIndex = 0;
            btnCreatePanel.Text = "Create Panel";
            btnCreatePanel.UseVisualStyleBackColor = true;
            btnCreatePanel.Click += CreatePanel_Click;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(357, 157);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(75, 55);
            btnUp.TabIndex = 1;
            btnUp.Text = "Up";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += Up_Click;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(357, 349);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(75, 55);
            btnDown.TabIndex = 2;
            btnDown.Text = "Down";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += Down_Click;
            // 
            // btnLeft
            // 
            btnLeft.Location = new Point(249, 253);
            btnLeft.Name = "btnLeft";
            btnLeft.Size = new Size(75, 55);
            btnLeft.TabIndex = 3;
            btnLeft.Text = "Left";
            btnLeft.UseVisualStyleBackColor = true;
            btnLeft.Click += Left_Click;
            // 
            // btnRight
            // 
            btnRight.Location = new Point(461, 253);
            btnRight.Name = "btnRight";
            btnRight.Size = new Size(75, 55);
            btnRight.TabIndex = 4;
            btnRight.Text = "Right";
            btnRight.UseVisualStyleBackColor = true;
            btnRight.Click += Right_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(btnRight);
            Controls.Add(btnLeft);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(btnCreatePanel);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreatePanel;
        private Button btnUp;
        private Button btnDown;
        private Button btnLeft;
        private Button btnRight;
    }
}
