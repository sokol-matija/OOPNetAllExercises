namespace OOPExercise01Task05
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
            btnShowInTaskbar = new Button();
            btnTopmost = new Button();
            SuspendLayout();
            // 
            // btnShowInTaskbar
            // 
            btnShowInTaskbar.Location = new Point(55, 73);
            btnShowInTaskbar.Name = "btnShowInTaskbar";
            btnShowInTaskbar.Size = new Size(216, 139);
            btnShowInTaskbar.TabIndex = 0;
            btnShowInTaskbar.Text = "Dont Show In Taskbar";
            btnShowInTaskbar.UseVisualStyleBackColor = true;
            btnShowInTaskbar.Click += ShowInTaskbar_Click;
            // 
            // btnTopmost
            // 
            btnTopmost.Location = new Point(346, 73);
            btnTopmost.Name = "btnTopmost";
            btnTopmost.Size = new Size(216, 139);
            btnTopmost.TabIndex = 1;
            btnTopmost.Text = "Show as Top Most Windows";
            btnTopmost.UseVisualStyleBackColor = true;
            btnTopmost.Click += Topmost_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 285);
            Controls.Add(btnTopmost);
            Controls.Add(btnShowInTaskbar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowInTaskbar;
        private Button btnTopmost;
    }
}
