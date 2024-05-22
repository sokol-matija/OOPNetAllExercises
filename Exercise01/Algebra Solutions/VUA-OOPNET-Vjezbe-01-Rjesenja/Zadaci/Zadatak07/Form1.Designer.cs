namespace Zadatak07
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
            this.btnKreirajPanelu = new System.Windows.Forms.Button();
            this.btnDesno = new System.Windows.Forms.Button();
            this.btnLijevo = new System.Windows.Forms.Button();
            this.btnGore = new System.Windows.Forms.Button();
            this.btnDole = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKreirajPanelu
            // 
            this.btnKreirajPanelu.Location = new System.Drawing.Point(394, 289);
            this.btnKreirajPanelu.Name = "btnKreirajPanelu";
            this.btnKreirajPanelu.Size = new System.Drawing.Size(112, 63);
            this.btnKreirajPanelu.TabIndex = 0;
            this.btnKreirajPanelu.Text = "KreirajPanelu";
            this.btnKreirajPanelu.UseVisualStyleBackColor = true;
            this.btnKreirajPanelu.Click += new System.EventHandler(this.btnKreirajPanelu_Click);
            // 
            // btnDesno
            // 
            this.btnDesno.Location = new System.Drawing.Point(512, 289);
            this.btnDesno.Name = "btnDesno";
            this.btnDesno.Size = new System.Drawing.Size(63, 63);
            this.btnDesno.TabIndex = 1;
            this.btnDesno.Text = ">>>";
            this.btnDesno.UseVisualStyleBackColor = true;
            this.btnDesno.Click += new System.EventHandler(this.btnDesno_Click);
            // 
            // btnLijevo
            // 
            this.btnLijevo.Location = new System.Drawing.Point(325, 289);
            this.btnLijevo.Name = "btnLijevo";
            this.btnLijevo.Size = new System.Drawing.Size(63, 63);
            this.btnLijevo.TabIndex = 2;
            this.btnLijevo.Text = "<<<";
            this.btnLijevo.UseVisualStyleBackColor = true;
            this.btnLijevo.Click += new System.EventHandler(this.btnLijevo_Click);
            // 
            // btnGore
            // 
            this.btnGore.Location = new System.Drawing.Point(394, 220);
            this.btnGore.Name = "btnGore";
            this.btnGore.Size = new System.Drawing.Size(112, 63);
            this.btnGore.TabIndex = 3;
            this.btnGore.Text = "^";
            this.btnGore.UseVisualStyleBackColor = true;
            this.btnGore.Click += new System.EventHandler(this.btnGore_Click);
            // 
            // btnDole
            // 
            this.btnDole.Location = new System.Drawing.Point(394, 358);
            this.btnDole.Name = "btnDole";
            this.btnDole.Size = new System.Drawing.Size(112, 63);
            this.btnDole.TabIndex = 4;
            this.btnDole.Text = "v";
            this.btnDole.UseVisualStyleBackColor = true;
            this.btnDole.Click += new System.EventHandler(this.btnDole_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 695);
            this.Controls.Add(this.btnDole);
            this.Controls.Add(this.btnGore);
            this.Controls.Add(this.btnLijevo);
            this.Controls.Add(this.btnDesno);
            this.Controls.Add(this.btnKreirajPanelu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKreirajPanelu;
        private System.Windows.Forms.Button btnDesno;
        private System.Windows.Forms.Button btnLijevo;
        private System.Windows.Forms.Button btnGore;
        private System.Windows.Forms.Button btnDole;
    }
}

