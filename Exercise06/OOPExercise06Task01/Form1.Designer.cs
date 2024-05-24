namespace OOPExercise06Task01
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.BackColor = SystemColors.Highlight;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(150, 150);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.DragDrop += Button_DragDrop;
            button1.DragEnter += Button_DragEnter;
            button1.DragLeave += Button_DragLeave;
            button1.MouseDown += Button_MouseDown;
            // 
            // button2
            // 
            button2.AllowDrop = true;
            button2.BackColor = Color.Yellow;
            button2.Location = new Point(12, 288);
            button2.Name = "button2";
            button2.Size = new Size(150, 150);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.DragDrop += Button_DragDrop;
            button2.DragEnter += Button_DragEnter;
            button2.DragLeave += Button_DragLeave;
            button2.MouseDown += Button_MouseDown;
            // 
            // button3
            // 
            button3.AllowDrop = true;
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(328, 12);
            button3.Name = "button3";
            button3.Size = new Size(150, 150);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.DragDrop += Button_DragDrop;
            button3.DragEnter += Button_DragEnter;
            button3.DragLeave += Button_DragLeave;
            button3.MouseDown += Button_MouseDown;
            // 
            // button4
            // 
            button4.AllowDrop = true;
            button4.BackColor = Color.Yellow;
            button4.Location = new Point(328, 288);
            button4.Name = "button4";
            button4.Size = new Size(150, 150);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.DragDrop += Button_DragDrop;
            button4.DragEnter += Button_DragEnter;
            button4.DragLeave += Button_DragLeave;
            button4.MouseDown += Button_MouseDown;
            // 
            // lblInfo
            // 
            lblInfo.AllowDrop = true;
            lblInfo.Anchor = AnchorStyles.None;
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(173, 213);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(144, 25);
            lblInfo.TabIndex = 4;
            lblInfo.Text = "Drag and drop";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(490, 450);
            Controls.Add(lblInfo);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lblInfo;
    }
}
