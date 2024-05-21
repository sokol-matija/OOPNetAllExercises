namespace OOPExercise01Task08
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
            btnShowNewForm = new Button();
            SuspendLayout();
            // 
            // btnShowNewForm
            // 
            btnShowNewForm.Location = new Point(79, 68);
            btnShowNewForm.Name = "btnShowNewForm";
            btnShowNewForm.Size = new Size(200, 200);
            btnShowNewForm.TabIndex = 0;
            btnShowNewForm.Text = "Show New Form";
            btnShowNewForm.UseVisualStyleBackColor = true;
            btnShowNewForm.Click += btnShowNewForm_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 336);
            Controls.Add(btnShowNewForm);
            Name = "MainForm";
            Text = "Task08";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowNewForm;
    }
}
