namespace Task03
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
            this.customProgressBar1 = new Task03.CustomProgressBar();
            this.customProgressBar2 = new Task03.CustomProgressBar();
            this.btnIncreaseProgress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customProgressBar1
            // 
            this.customProgressBar1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.customProgressBar1.BorderColor = System.Drawing.Color.Gray;
            this.customProgressBar1.Location = new System.Drawing.Point(12, 12);
            this.customProgressBar1.Name = "customProgressBar1";
            this.customProgressBar1.OutputFormat = "{0}%";
            this.customProgressBar1.PercentageFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customProgressBar1.Size = new System.Drawing.Size(467, 122);
            this.customProgressBar1.TabIndex = 0;
            // 
            // customProgressBar2
            // 
            this.customProgressBar2.BackgroundColor = System.Drawing.Color.DarkViolet;
            this.customProgressBar2.BorderColor = System.Drawing.Color.IndianRed;
            this.customProgressBar2.Location = new System.Drawing.Point(12, 140);
            this.customProgressBar2.Name = "customProgressBar2";
            this.customProgressBar2.OutputFormat = "{0}%";
            this.customProgressBar2.PercentageFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customProgressBar2.Size = new System.Drawing.Size(467, 50);
            this.customProgressBar2.TabIndex = 1;
            // 
            // btnIncreaseProgress
            // 
            this.btnIncreaseProgress.Location = new System.Drawing.Point(301, 196);
            this.btnIncreaseProgress.Name = "btnIncreaseProgress";
            this.btnIncreaseProgress.Size = new System.Drawing.Size(178, 50);
            this.btnIncreaseProgress.TabIndex = 2;
            this.btnIncreaseProgress.Text = "Increase Progress";
            this.btnIncreaseProgress.UseVisualStyleBackColor = true;
            this.btnIncreaseProgress.Click += new System.EventHandler(this.btnIncreaseProgress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 272);
            this.Controls.Add(this.btnIncreaseProgress);
            this.Controls.Add(this.customProgressBar2);
            this.Controls.Add(this.customProgressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomProgressBar customProgressBar1;
        private CustomProgressBar customProgressBar2;
        private Button btnIncreaseProgress;
    }
}