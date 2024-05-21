namespace Zadatak08
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
            this.btnPrikaziFormu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrikaziFormu
            // 
            this.btnPrikaziFormu.Location = new System.Drawing.Point(12, 28);
            this.btnPrikaziFormu.Name = "btnPrikaziFormu";
            this.btnPrikaziFormu.Size = new System.Drawing.Size(199, 173);
            this.btnPrikaziFormu.TabIndex = 0;
            this.btnPrikaziFormu.Text = "Prikazi novu formu";
            this.btnPrikaziFormu.UseVisualStyleBackColor = true;
            this.btnPrikaziFormu.Click += new System.EventHandler(this.btnPrikaziFormu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 326);
            this.Controls.Add(this.btnPrikaziFormu);
            this.Name = "Form1";
            this.Text = "Zadatak 08";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaziFormu;
    }
}

