namespace OOPExercise01Task03
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
            btnChangeCollorAndSize = new Button();
            SuspendLayout();
            // 
            // btnChangeCollorAndSize
            // 
            btnChangeCollorAndSize.Location = new Point(325, 150);
            btnChangeCollorAndSize.Name = "btnChangeCollorAndSize";
            btnChangeCollorAndSize.Size = new Size(150, 150);
            btnChangeCollorAndSize.TabIndex = 0;
            btnChangeCollorAndSize.Text = "Change color and size";
            btnChangeCollorAndSize.UseVisualStyleBackColor = true;
            btnChangeCollorAndSize.Click += ChangeCollorAndSize_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnChangeCollorAndSize);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button btnChangeCollorAndSize;
    }
}
