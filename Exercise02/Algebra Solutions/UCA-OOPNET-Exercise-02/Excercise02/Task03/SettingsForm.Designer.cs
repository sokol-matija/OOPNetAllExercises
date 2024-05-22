namespace Task03
{
    partial class SettingsForm
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
            this.btnChangeBackColor = new System.Windows.Forms.Button();
            this.btnChangeWindowState = new System.Windows.Forms.Button();
            this.btnAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeBackColor
            // 
            this.btnChangeBackColor.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeBackColor.Location = new System.Drawing.Point(163, 19);
            this.btnChangeBackColor.Name = "btnChangeBackColor";
            this.btnChangeBackColor.Size = new System.Drawing.Size(362, 105);
            this.btnChangeBackColor.TabIndex = 0;
            this.btnChangeBackColor.Text = "Change BackColor";
            this.btnChangeBackColor.UseVisualStyleBackColor = true;
            this.btnChangeBackColor.Click += new System.EventHandler(this.btnChangeBackColor_Click);
            // 
            // btnChangeWindowState
            // 
            this.btnChangeWindowState.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeWindowState.Location = new System.Drawing.Point(163, 156);
            this.btnChangeWindowState.Name = "btnChangeWindowState";
            this.btnChangeWindowState.Size = new System.Drawing.Size(362, 105);
            this.btnChangeWindowState.TabIndex = 1;
            this.btnChangeWindowState.Text = "Change WindowState";
            this.btnChangeWindowState.UseVisualStyleBackColor = true;
            this.btnChangeWindowState.Click += new System.EventHandler(this.btnChangeWindowState_Click);
            // 
            // btnAddButton
            // 
            this.btnAddButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddButton.Location = new System.Drawing.Point(163, 294);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(362, 105);
            this.btnAddButton.TabIndex = 2;
            this.btnAddButton.Text = "Add Button";
            this.btnAddButton.UseVisualStyleBackColor = true;
            this.btnAddButton.Click += new System.EventHandler(this.btnAddButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 437);
            this.Controls.Add(this.btnAddButton);
            this.Controls.Add(this.btnChangeWindowState);
            this.Controls.Add(this.btnChangeBackColor);
            this.Name = "SettingsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnChangeBackColor;
        private Button btnChangeWindowState;
        private Button btnAddButton;
    }
}