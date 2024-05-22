namespace OOPExercise02Task05
{
    partial class TextInput
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
            btnOK = new Button();
            btnCancel = new Button();
            txtTxt = new TextBox();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(12, 46);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(108, 23);
            btnOK.TabIndex = 1;
            btnOK.Text = "Add";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(166, 46);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtTxt
            // 
            txtTxt.Location = new Point(12, 12);
            txtTxt.Name = "txtTxt";
            txtTxt.Size = new Size(262, 23);
            txtTxt.TabIndex = 2;
            // 
            // TextInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 81);
            Controls.Add(txtTxt);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Name = "TextInput";
            Text = "TextInput";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Button btnCancel;
        private TextBox txtTxt;
    }
}