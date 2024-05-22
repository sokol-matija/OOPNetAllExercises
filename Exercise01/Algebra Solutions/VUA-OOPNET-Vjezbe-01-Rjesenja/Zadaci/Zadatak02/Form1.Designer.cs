namespace Zadatak02
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
            this.btn150x150 = new System.Windows.Forms.Button();
            this.btn100x100 = new System.Windows.Forms.Button();
            this.btn200x200 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn150x150
            // 
            this.btn150x150.Location = new System.Drawing.Point(12, 32);
            this.btn150x150.Name = "btn150x150";
            this.btn150x150.Size = new System.Drawing.Size(139, 128);
            this.btn150x150.TabIndex = 0;
            this.btn150x150.Text = "Otvori formu fiksne veličine 150x150";
            this.btn150x150.UseVisualStyleBackColor = true;
            this.btn150x150.Click += new System.EventHandler(this.btn150x150_Click);
            // 
            // btn100x100
            // 
            this.btn100x100.Location = new System.Drawing.Point(168, 32);
            this.btn100x100.Name = "btn100x100";
            this.btn100x100.Size = new System.Drawing.Size(139, 128);
            this.btn100x100.TabIndex = 1;
            this.btn100x100.Text = "Otvori formu crvene pozadine i veličine 100x100";
            this.btn100x100.UseVisualStyleBackColor = true;
            this.btn100x100.Click += new System.EventHandler(this.btn100x100_Click);
            // 
            // btn200x200
            // 
            this.btn200x200.Location = new System.Drawing.Point(325, 32);
            this.btn200x200.Name = "btn200x200";
            this.btn200x200.Size = new System.Drawing.Size(139, 128);
            this.btn200x200.TabIndex = 2;
            this.btn200x200.Text = "Otvori formu veličine 100x100 bez kontrolnih gumba";
            this.btn200x200.UseVisualStyleBackColor = true;
            this.btn200x200.Click += new System.EventHandler(this.btn200x200_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(12, 166);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(452, 112);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Zatvori aplikaciju";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 310);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn200x200);
            this.Controls.Add(this.btn100x100);
            this.Controls.Add(this.btn150x150);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn150x150;
        private System.Windows.Forms.Button btn100x100;
        private System.Windows.Forms.Button btn200x200;
        private System.Windows.Forms.Button btnExit;
    }
}

