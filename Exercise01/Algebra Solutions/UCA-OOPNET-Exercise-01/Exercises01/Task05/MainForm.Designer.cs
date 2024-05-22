namespace Task05
{
    partial class MainForm
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
            this.btnShowTaskbar = new System.Windows.Forms.Button();
            this.btnShowTopMost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowTaskbar
            // 
            this.btnShowTaskbar.Location = new System.Drawing.Point(124, 105);
            this.btnShowTaskbar.Name = "btnShowTaskbar";
            this.btnShowTaskbar.Size = new System.Drawing.Size(150, 150);
            this.btnShowTaskbar.TabIndex = 0;
            this.btnShowTaskbar.Text = "Don\'t show in Taskbar";
            this.btnShowTaskbar.UseVisualStyleBackColor = true;
            this.btnShowTaskbar.Click += new System.EventHandler(this.ShowTaskbar_Click);
            // 
            // btnShowTopMost
            // 
            this.btnShowTopMost.Location = new System.Drawing.Point(310, 105);
            this.btnShowTopMost.Name = "btnShowTopMost";
            this.btnShowTopMost.Size = new System.Drawing.Size(150, 150);
            this.btnShowTopMost.TabIndex = 1;
            this.btnShowTopMost.Text = "Show as Top Most Window";
            this.btnShowTopMost.UseVisualStyleBackColor = true;
            this.btnShowTopMost.Click += new System.EventHandler(this.ShowTopMost_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnShowTopMost);
            this.Controls.Add(this.btnShowTaskbar);
            this.Name = "MainForm";
            this.Text = "Form";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnShowTaskbar;
        private Button btnShowTopMost;
    }
}