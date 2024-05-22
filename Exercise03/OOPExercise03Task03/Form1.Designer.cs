namespace OOPExercise03Task03
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
            clbPlayers = new CheckedListBox();
            btnLoadAllPlayers = new Button();
            btnRemoveSelectedPlayers = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Selected players";
            // 
            // clbPlayers
            // 
            clbPlayers.FormattingEnabled = true;
            clbPlayers.Location = new Point(12, 27);
            clbPlayers.Name = "clbPlayers";
            clbPlayers.Size = new Size(302, 346);
            clbPlayers.TabIndex = 1;
            // 
            // btnLoadAllPlayers
            // 
            btnLoadAllPlayers.Location = new Point(12, 379);
            btnLoadAllPlayers.Name = "btnLoadAllPlayers";
            btnLoadAllPlayers.Size = new Size(128, 46);
            btnLoadAllPlayers.TabIndex = 2;
            btnLoadAllPlayers.Text = "Load All Players";
            btnLoadAllPlayers.UseVisualStyleBackColor = true;
            btnLoadAllPlayers.Click += btnLoadAllPlayers_Click;
            // 
            // btnRemoveSelectedPlayers
            // 
            btnRemoveSelectedPlayers.Location = new Point(183, 379);
            btnRemoveSelectedPlayers.Name = "btnRemoveSelectedPlayers";
            btnRemoveSelectedPlayers.Size = new Size(128, 46);
            btnRemoveSelectedPlayers.TabIndex = 3;
            btnRemoveSelectedPlayers.Text = "Remove selected players";
            btnRemoveSelectedPlayers.UseVisualStyleBackColor = true;
            btnRemoveSelectedPlayers.Click += btnRemoveSelectedPlayers_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 437);
            Controls.Add(btnRemoveSelectedPlayers);
            Controls.Add(btnLoadAllPlayers);
            Controls.Add(clbPlayers);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox clbPlayers;
        private Button btnLoadAllPlayers;
        private Button btnRemoveSelectedPlayers;
    }
}
