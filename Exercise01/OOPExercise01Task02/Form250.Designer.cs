namespace OOPExercise01Task02
{
    partial class Form250
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
            btnCloseForm = new Button();
            SuspendLayout();
            // 
            // btnCloseForm
            // 
            btnCloseForm.Location = new Point(64, 66);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(107, 78);
            btnCloseForm.TabIndex = 0;
            btnCloseForm.Text = "Close Form";
            btnCloseForm.UseVisualStyleBackColor = true;
            btnCloseForm.Click += CloseForm_Click;
            // 
            // Form250
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 211);
            Controls.Add(btnCloseForm);
            Name = "Form250";
            Text = "Form250";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCloseForm;
    }
}