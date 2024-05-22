namespace OOPExercise02Task03
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
            btnChangeBackColor = new Button();
            btnChangeWinState = new Button();
            btnAddButton = new Button();
            SuspendLayout();
            // 
            // btnChangeBackColor
            // 
            btnChangeBackColor.Location = new Point(117, 30);
            btnChangeBackColor.Name = "btnChangeBackColor";
            btnChangeBackColor.Size = new Size(150, 50);
            btnChangeBackColor.TabIndex = 0;
            btnChangeBackColor.Text = "Change Back Color";
            btnChangeBackColor.UseVisualStyleBackColor = true;
            btnChangeBackColor.Click += btnChangeBackColor_Click;
            // 
            // btnChangeWinState
            // 
            btnChangeWinState.Location = new Point(117, 105);
            btnChangeWinState.Name = "btnChangeWinState";
            btnChangeWinState.Size = new Size(150, 50);
            btnChangeWinState.TabIndex = 1;
            btnChangeWinState.Text = "Change Windows State";
            btnChangeWinState.UseVisualStyleBackColor = true;
            btnChangeWinState.Click += btnChangeWinState_Click;
            // 
            // btnAddButton
            // 
            btnAddButton.Location = new Point(117, 180);
            btnAddButton.Name = "btnAddButton";
            btnAddButton.Size = new Size(150, 50);
            btnAddButton.TabIndex = 2;
            btnAddButton.Text = "Add Button";
            btnAddButton.UseVisualStyleBackColor = true;
            btnAddButton.Click += btnAddButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 261);
            Controls.Add(btnAddButton);
            Controls.Add(btnChangeWinState);
            Controls.Add(btnChangeBackColor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnChangeBackColor;
        private Button btnChangeWinState;
        private Button btnAddButton;
    }
}
