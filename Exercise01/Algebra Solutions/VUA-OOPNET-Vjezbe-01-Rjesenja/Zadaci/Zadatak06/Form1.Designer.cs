namespace Zadatak06
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
            this.btnDodajPanel = new System.Windows.Forms.Button();
            this.btnDodajGumb = new System.Windows.Forms.Button();
            this.btnUkloniSvePanele = new System.Windows.Forms.Button();
            this.btnUkloniSveGumbe = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnDodajPanel
            // 
            this.btnDodajPanel.Location = new System.Drawing.Point(12, 503);
            this.btnDodajPanel.Name = "btnDodajPanel";
            this.btnDodajPanel.Size = new System.Drawing.Size(185, 46);
            this.btnDodajPanel.TabIndex = 0;
            this.btnDodajPanel.Text = "Dodaj panel";
            this.btnDodajPanel.UseVisualStyleBackColor = true;
            this.btnDodajPanel.Click += new System.EventHandler(this.btnDodajPanel_Click);
            // 
            // btnDodajGumb
            // 
            this.btnDodajGumb.Location = new System.Drawing.Point(203, 503);
            this.btnDodajGumb.Name = "btnDodajGumb";
            this.btnDodajGumb.Size = new System.Drawing.Size(185, 46);
            this.btnDodajGumb.TabIndex = 1;
            this.btnDodajGumb.Text = "Dodaj gumb";
            this.btnDodajGumb.UseVisualStyleBackColor = true;
            this.btnDodajGumb.Click += new System.EventHandler(this.btnDodajGumb_Click);
            // 
            // btnUkloniSvePanele
            // 
            this.btnUkloniSvePanele.Location = new System.Drawing.Point(396, 503);
            this.btnUkloniSvePanele.Name = "btnUkloniSvePanele";
            this.btnUkloniSvePanele.Size = new System.Drawing.Size(185, 46);
            this.btnUkloniSvePanele.TabIndex = 2;
            this.btnUkloniSvePanele.Text = "Ukolni sve panele";
            this.btnUkloniSvePanele.UseVisualStyleBackColor = true;
            this.btnUkloniSvePanele.Click += new System.EventHandler(this.btnUkloniSvePanele_Click);
            // 
            // btnUkloniSveGumbe
            // 
            this.btnUkloniSveGumbe.Location = new System.Drawing.Point(587, 503);
            this.btnUkloniSveGumbe.Name = "btnUkloniSveGumbe";
            this.btnUkloniSveGumbe.Size = new System.Drawing.Size(185, 46);
            this.btnUkloniSveGumbe.TabIndex = 3;
            this.btnUkloniSveGumbe.Text = "Ukloni sve gumbe";
            this.btnUkloniSveGumbe.UseVisualStyleBackColor = true;
            this.btnUkloniSveGumbe.Click += new System.EventHandler(this.btnUkloniSveGumbe_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(784, 497);
            this.pnlContainer.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnUkloniSveGumbe);
            this.Controls.Add(this.btnUkloniSvePanele);
            this.Controls.Add(this.btnDodajGumb);
            this.Controls.Add(this.btnDodajPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajPanel;
        private System.Windows.Forms.Button btnDodajGumb;
        private System.Windows.Forms.Button btnUkloniSvePanele;
        private System.Windows.Forms.Button btnUkloniSveGumbe;
        private System.Windows.Forms.Panel pnlContainer;
    }
}

