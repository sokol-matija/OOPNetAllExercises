namespace Zadatak04
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
            this.btnPromiijeniPolozaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPromiijeniPolozaj
            // 
            this.btnPromiijeniPolozaj.Location = new System.Drawing.Point(60, 65);
            this.btnPromiijeniPolozaj.Name = "btnPromiijeniPolozaj";
            this.btnPromiijeniPolozaj.Size = new System.Drawing.Size(158, 96);
            this.btnPromiijeniPolozaj.TabIndex = 0;
            this.btnPromiijeniPolozaj.Text = "Promijeni položaj";
            this.btnPromiijeniPolozaj.UseVisualStyleBackColor = true;
            this.btnPromiijeniPolozaj.Click += new System.EventHandler(this.btnPromiijeniPolozaj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPromiijeniPolozaj);
            this.Name = "Form1";
            this.Text = "Mijenjam položaj :)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPromiijeniPolozaj;
    }
}

