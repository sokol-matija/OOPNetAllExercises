namespace Task02
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
            this.btnOpenFirst = new System.Windows.Forms.Button();
            this.btnOpenSecond = new System.Windows.Forms.Button();
            this.btnOpenThird = new System.Windows.Forms.Button();
            this.btnCloseApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFirst
            // 
            this.btnOpenFirst.Location = new System.Drawing.Point(61, 27);
            this.btnOpenFirst.Name = "btnOpenFirst";
            this.btnOpenFirst.Size = new System.Drawing.Size(150, 150);
            this.btnOpenFirst.TabIndex = 0;
            this.btnOpenFirst.Text = "Open form size of 250x250";
            this.btnOpenFirst.UseVisualStyleBackColor = true;
            this.btnOpenFirst.Click += new System.EventHandler(this.OpenFirstForm_Click);
            // 
            // btnOpenSecond
            // 
            this.btnOpenSecond.Location = new System.Drawing.Point(217, 27);
            this.btnOpenSecond.Name = "btnOpenSecond";
            this.btnOpenSecond.Size = new System.Drawing.Size(150, 150);
            this.btnOpenSecond.TabIndex = 1;
            this.btnOpenSecond.Text = "Open red form size of 300x300";
            this.btnOpenSecond.UseVisualStyleBackColor = true;
            this.btnOpenSecond.Click += new System.EventHandler(this.OpenSecondForm_Click);
            // 
            // btnOpenThird
            // 
            this.btnOpenThird.Location = new System.Drawing.Point(373, 27);
            this.btnOpenThird.Name = "btnOpenThird";
            this.btnOpenThird.Size = new System.Drawing.Size(150, 150);
            this.btnOpenThird.TabIndex = 2;
            this.btnOpenThird.Text = "Open form without control box size of 300x300";
            this.btnOpenThird.UseVisualStyleBackColor = true;
            this.btnOpenThird.Click += new System.EventHandler(this.OpenThirdForm_Click);
            // 
            // btnCloseApplication
            // 
            this.btnCloseApplication.BackColor = System.Drawing.Color.Red;
            this.btnCloseApplication.ForeColor = System.Drawing.Color.White;
            this.btnCloseApplication.Location = new System.Drawing.Point(61, 183);
            this.btnCloseApplication.Name = "btnCloseApplication";
            this.btnCloseApplication.Size = new System.Drawing.Size(462, 150);
            this.btnCloseApplication.TabIndex = 3;
            this.btnCloseApplication.Text = "Close application";
            this.btnCloseApplication.UseVisualStyleBackColor = false;
            this.btnCloseApplication.Click += new System.EventHandler(this.CloseApplication_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnCloseApplication);
            this.Controls.Add(this.btnOpenThird);
            this.Controls.Add(this.btnOpenSecond);
            this.Controls.Add(this.btnOpenFirst);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnOpenFirst;
        private Button btnOpenSecond;
        private Button btnOpenThird;
        private Button btnCloseApplication;
    }
}