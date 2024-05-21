namespace OOPExercise01Task02
{
    partial class FormNoControlls
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
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(92, 80);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 100);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += Close_Click;
            // 
            // FormNoControlls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 261);
            ControlBox = false;
            Controls.Add(btnClose);
            Name = "FormNoControlls";
            Text = "FormNoControlls";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
    }
}