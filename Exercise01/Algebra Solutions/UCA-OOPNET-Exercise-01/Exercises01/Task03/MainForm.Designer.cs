namespace Task03
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
            this.btnChangeValues = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeValues
            // 
            this.btnChangeValues.Location = new System.Drawing.Point(12, 12);
            this.btnChangeValues.Name = "btnChangeValues";
            this.btnChangeValues.Size = new System.Drawing.Size(100, 100);
            this.btnChangeValues.TabIndex = 0;
            this.btnChangeValues.Text = "Change color and size";
            this.btnChangeValues.UseVisualStyleBackColor = true;
            this.btnChangeValues.Click += new System.EventHandler(this.ChangeValues_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btnChangeValues);
            this.Name = "MainForm";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnChangeValues;
    }
}