namespace OOPExercise09Task03
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
            ddlUsers = new ComboBox();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // ddlUsers
            // 
            ddlUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlUsers.FormattingEnabled = true;
            ddlUsers.Location = new Point(12, 12);
            ddlUsers.Name = "ddlUsers";
            ddlUsers.Size = new Size(260, 23);
            ddlUsers.TabIndex = 0;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 10F);
            lblInfo.Location = new Point(12, 38);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(101, 19);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Fetching data...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 61);
            Controls.Add(lblInfo);
            Controls.Add(ddlUsers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ddlUsers;
        private Label lblInfo;
    }
}
