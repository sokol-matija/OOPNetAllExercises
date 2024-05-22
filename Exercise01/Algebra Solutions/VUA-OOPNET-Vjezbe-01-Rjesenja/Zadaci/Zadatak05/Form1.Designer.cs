namespace Zadatak05
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
            this.btnTaskBar = new System.Windows.Forms.Button();
            this.btnOnTop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTaskBar
            // 
            this.btnTaskBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTaskBar.Location = new System.Drawing.Point(12, 71);
            this.btnTaskBar.Name = "btnTaskBar";
            this.btnTaskBar.Size = new System.Drawing.Size(186, 145);
            this.btnTaskBar.TabIndex = 0;
            this.btnTaskBar.Text = "Ne prikazuj u TaskBar-u";
            this.btnTaskBar.UseVisualStyleBackColor = true;
            this.btnTaskBar.Click += new System.EventHandler(this.btnTaskBar_Click);
            // 
            // btnOnTop
            // 
            this.btnOnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOnTop.Location = new System.Drawing.Point(212, 71);
            this.btnOnTop.Name = "btnOnTop";
            this.btnOnTop.Size = new System.Drawing.Size(186, 145);
            this.btnOnTop.TabIndex = 1;
            this.btnOnTop.Text = "Ne prikazuj iznad ostalih prozora";
            this.btnOnTop.UseVisualStyleBackColor = true;
            this.btnOnTop.Click += new System.EventHandler(this.btnOnTop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 322);
            this.Controls.Add(this.btnOnTop);
            this.Controls.Add(this.btnTaskBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTaskBar;
        private System.Windows.Forms.Button btnOnTop;
    }
}

