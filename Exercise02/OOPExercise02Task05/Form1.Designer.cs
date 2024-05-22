namespace OOPExercise02Task05
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
            label1 = new Label();
            txtText = new TextBox();
            btnAddText = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Entered text:";
            // 
            // txtText
            // 
            txtText.BackColor = SystemColors.Info;
            txtText.Location = new Point(12, 27);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.ReadOnly = true;
            txtText.Size = new Size(391, 278);
            txtText.TabIndex = 1;
            // 
            // btnAddText
            // 
            btnAddText.Location = new Point(12, 311);
            btnAddText.Name = "btnAddText";
            btnAddText.Size = new Size(122, 39);
            btnAddText.TabIndex = 2;
            btnAddText.Text = "Add Text";
            btnAddText.UseVisualStyleBackColor = true;
            btnAddText.Click += btnAddText_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(140, 311);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 39);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(281, 311);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(122, 39);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 367);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnAddText);
            Controls.Add(txtText);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtText;
        private Button btnAddText;
        private Button btnDelete;
        private Button btnExit;
    }
}
