namespace Task07
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
            this.btnAddPanel = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddPanel
            // 
            this.btnAddPanel.Location = new System.Drawing.Point(342, 255);
            this.btnAddPanel.Name = "btnAddPanel";
            this.btnAddPanel.Size = new System.Drawing.Size(100, 50);
            this.btnAddPanel.TabIndex = 0;
            this.btnAddPanel.Text = "Add panel";
            this.btnAddPanel.UseVisualStyleBackColor = true;
            this.btnAddPanel.Click += new System.EventHandler(this.AddPanel_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(342, 199);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 50);
            this.btnUp.TabIndex = 1;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.Up_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(342, 311);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(100, 50);
            this.btnDown.TabIndex = 2;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.Down_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(236, 255);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(100, 50);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.Left_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(448, 255);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(100, 50);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.Right_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnAddPanel);
            this.Name = "MainForm";
            this.Text = "Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddPanel;
        private Button btnUp;
        private Button btnDown;
        private Button btnLeft;
        private Button btnRight;
    }
}