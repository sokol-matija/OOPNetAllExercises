
namespace OOPExecise01Task04
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
            btnChangeLocation = new Button();
            SuspendLayout();
            // 
            // btnChangeLocation
            // 
            btnChangeLocation.Location = new Point(217, 130);
            btnChangeLocation.Name = "btnChangeLocation";
            btnChangeLocation.Size = new Size(150, 100);
            btnChangeLocation.TabIndex = 0;
            btnChangeLocation.Text = "Change Location";
            btnChangeLocation.UseVisualStyleBackColor = true;
            btnChangeLocation.Click += this.btnChangeLocation_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(btnChangeLocation);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button btnChangeLocation;
    }
}
