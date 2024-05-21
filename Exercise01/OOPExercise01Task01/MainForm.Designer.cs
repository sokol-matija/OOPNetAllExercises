namespace OOPExercise01Task01
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
            btnShowMsg = new Button();
            btnCloseApp = new Button();
            SuspendLayout();
            // 
            // btnShowMsg
            // 
            btnShowMsg.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnShowMsg.Location = new Point(96, 138);
            btnShowMsg.Name = "btnShowMsg";
            btnShowMsg.Size = new Size(158, 85);
            btnShowMsg.TabIndex = 0;
            btnShowMsg.Text = "Show Message";
            btnShowMsg.UseVisualStyleBackColor = true;
            btnShowMsg.Click += ShowMsg_Click;
            // 
            // btnCloseApp
            // 
            btnCloseApp.BackColor = Color.Red;
            btnCloseApp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCloseApp.ForeColor = Color.White;
            btnCloseApp.Location = new Point(330, 138);
            btnCloseApp.Name = "btnCloseApp";
            btnCloseApp.Size = new Size(158, 85);
            btnCloseApp.TabIndex = 1;
            btnCloseApp.Text = "Close App";
            btnCloseApp.UseVisualStyleBackColor = false;
            btnCloseApp.Click += CloseApp_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(btnCloseApp);
            Controls.Add(btnShowMsg);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowMsg;
        private Button btnCloseApp;
    }
}
