namespace Task01
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
            this.btnShowMessage = new System.Windows.Forms.Button();
            this.btnCloseApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowMessage
            // 
            this.btnShowMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowMessage.Location = new System.Drawing.Point(12, 55);
            this.btnShowMessage.Name = "btnShowMessage";
            this.btnShowMessage.Size = new System.Drawing.Size(200, 150);
            this.btnShowMessage.TabIndex = 0;
            this.btnShowMessage.Text = "Show message";
            this.btnShowMessage.UseVisualStyleBackColor = true;
            this.btnShowMessage.Click += new System.EventHandler(this.ShowMessage_Click);
            // 
            // btnCloseApplication
            // 
            this.btnCloseApplication.BackColor = System.Drawing.Color.Red;
            this.btnCloseApplication.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCloseApplication.ForeColor = System.Drawing.Color.White;
            this.btnCloseApplication.Location = new System.Drawing.Point(272, 55);
            this.btnCloseApplication.Name = "btnCloseApplication";
            this.btnCloseApplication.Size = new System.Drawing.Size(200, 150);
            this.btnCloseApplication.TabIndex = 1;
            this.btnCloseApplication.Text = "Close application";
            this.btnCloseApplication.UseVisualStyleBackColor = false;
            this.btnCloseApplication.Click += new System.EventHandler(this.CloseApplication_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnCloseApplication);
            this.Controls.Add(this.btnShowMessage);
            this.Name = "MainForm";
            this.Text = "Task 01";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnShowMessage;
        private Button btnCloseApplication;
    }
}