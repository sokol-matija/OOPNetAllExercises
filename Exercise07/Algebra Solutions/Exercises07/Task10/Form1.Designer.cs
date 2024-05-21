namespace Task10
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHR = new System.Windows.Forms.ToolStripMenuItem();
            this.miEN = new System.Windows.Forms.ToolStripMenuItem();
            this.miDE = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStartCounting = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(331, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHR,
            this.miEN,
            this.miDE});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // miHR
            // 
            this.miHR.Name = "miHR";
            this.miHR.Size = new System.Drawing.Size(180, 22);
            this.miHR.Text = "Croatian";
            this.miHR.Click += new System.EventHandler(this.MiHR_Click);
            // 
            // miEN
            // 
            this.miEN.Name = "miEN";
            this.miEN.Size = new System.Drawing.Size(180, 22);
            this.miEN.Text = "English";
            this.miEN.Click += new System.EventHandler(this.MiEN_Click);
            // 
            // miDE
            // 
            this.miDE.Name = "miDE";
            this.miDE.Size = new System.Drawing.Size(180, 22);
            this.miDE.Text = "German";
            this.miDE.Click += new System.EventHandler(this.MiDE_Click);
            // 
            // btnStartCounting
            // 
            this.btnStartCounting.Location = new System.Drawing.Point(14, 31);
            this.btnStartCounting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStartCounting.Name = "btnStartCounting";
            this.btnStartCounting.Size = new System.Drawing.Size(303, 256);
            this.btnStartCounting.TabIndex = 1;
            this.btnStartCounting.Text = "Start counting";
            this.btnStartCounting.UseVisualStyleBackColor = true;
            this.btnStartCounting.Click += new System.EventHandler(this.BtnZapocniOdbrojavanje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 301);
            this.Controls.Add(this.btnStartCounting);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miHR;
        private System.Windows.Forms.ToolStripMenuItem miEN;
        private System.Windows.Forms.ToolStripMenuItem miDE;
        private System.Windows.Forms.Button btnStartCounting;
    }
}

