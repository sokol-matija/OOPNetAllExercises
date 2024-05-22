namespace OOPExercise03Task02
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
            ddlPlayers = new ComboBox();
            label2 = new Label();
            txtPlayers = new TextBox();
            btnSelect = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Players:";
            // 
            // ddlPlayers
            // 
            ddlPlayers.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlPlayers.FormattingEnabled = true;
            ddlPlayers.Location = new Point(12, 18);
            ddlPlayers.Name = "ddlPlayers";
            ddlPlayers.Size = new Size(279, 23);
            ddlPlayers.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Selected players:";
            // 
            // txtPlayers
            // 
            txtPlayers.Location = new Point(12, 75);
            txtPlayers.Multiline = true;
            txtPlayers.Name = "txtPlayers";
            txtPlayers.ScrollBars = ScrollBars.Vertical;
            txtPlayers.Size = new Size(341, 331);
            txtPlayers.TabIndex = 3;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(297, 18);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 23);
            btnSelect.TabIndex = 4;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 461);
            Controls.Add(btnSelect);
            Controls.Add(txtPlayers);
            Controls.Add(label2);
            Controls.Add(ddlPlayers);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox ddlPlayers;
        private Label label2;
        private TextBox txtPlayers;
        private Button btnSelect;
    }
}
