namespace OOPExercise01Task08
{
    partial class CustomForm
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
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnMinimize
            // 
            btnMinimize.Location = new Point(21, 37);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(66, 62);
            btnMinimize.TabIndex = 0;
            btnMinimize.Text = "Minimize";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Location = new Point(205, 37);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(66, 62);
            btnMaximize.TabIndex = 1;
            btnMaximize.Text = "Maximize";
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(113, 37);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(66, 62);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // CustomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 141);
            Controls.Add(btnClose);
            Controls.Add(btnMaximize);
            Controls.Add(btnMinimize);
            Name = "CustomForm";
            Text = "CustomForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
    }
}