namespace Zadatak08
{
    partial class CustomForma
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
            this.btnMinimiziraj = new System.Windows.Forms.Button();
            this.btnMaksimiziraj = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMinimiziraj
            // 
            this.btnMinimiziraj.Location = new System.Drawing.Point(13, 29);
            this.btnMinimiziraj.Name = "btnMinimiziraj";
            this.btnMinimiziraj.Size = new System.Drawing.Size(75, 75);
            this.btnMinimiziraj.TabIndex = 0;
            this.btnMinimiziraj.Text = "Minimiziraj";
            this.btnMinimiziraj.UseVisualStyleBackColor = true;
            this.btnMinimiziraj.Click += new System.EventHandler(this.btnMinimiziraj_Click);
            // 
            // btnMaksimiziraj
            // 
            this.btnMaksimiziraj.Location = new System.Drawing.Point(198, 29);
            this.btnMaksimiziraj.Name = "btnMaksimiziraj";
            this.btnMaksimiziraj.Size = new System.Drawing.Size(75, 75);
            this.btnMaksimiziraj.TabIndex = 1;
            this.btnMaksimiziraj.Text = "Maksimiziraj";
            this.btnMaksimiziraj.UseVisualStyleBackColor = true;
            this.btnMaksimiziraj.Click += new System.EventHandler(this.btnMaksimiziraj_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Red;
            this.btnX.ForeColor = System.Drawing.Color.White;
            this.btnX.Location = new System.Drawing.Point(106, 32);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 75);
            this.btnX.TabIndex = 2;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // CustomForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnMaksimiziraj);
            this.Controls.Add(this.btnMinimiziraj);
            this.Name = "CustomForma";
            this.Text = "CustomForma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMinimiziraj;
        private System.Windows.Forms.Button btnMaksimiziraj;
        private System.Windows.Forms.Button btnX;
    }
}