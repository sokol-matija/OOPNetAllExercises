namespace Task03
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.clbPlayers = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected players:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 397);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(164, 52);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load all players";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(208, 397);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(164, 52);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove selected players";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // clbPlayers
            // 
            this.clbPlayers.CheckOnClick = true;
            this.clbPlayers.FormattingEnabled = true;
            this.clbPlayers.Location = new System.Drawing.Point(12, 27);
            this.clbPlayers.Name = "clbPlayers";
            this.clbPlayers.Size = new System.Drawing.Size(360, 364);
            this.clbPlayers.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.clbPlayers);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnLoad;
        private Button btnRemove;
        private CheckedListBox clbPlayers;
    }
}