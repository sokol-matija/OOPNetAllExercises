namespace Task04
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
            this.btnChangeLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeLocation
            // 
            this.btnChangeLocation.Location = new System.Drawing.Point(192, 105);
            this.btnChangeLocation.Name = "btnChangeLocation";
            this.btnChangeLocation.Size = new System.Drawing.Size(200, 150);
            this.btnChangeLocation.TabIndex = 0;
            this.btnChangeLocation.Text = "Change location";
            this.btnChangeLocation.UseVisualStyleBackColor = true;
            this.btnChangeLocation.Click += new System.EventHandler(this.ChangeLocation_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnChangeLocation);
            this.Name = "MainForm";
            this.Text = "Form";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnChangeLocation;
    }
}