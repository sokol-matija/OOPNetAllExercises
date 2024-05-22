namespace Zadatak03
{
    partial class MainForm
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
            this.ddlPersons = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ddlPersons
            // 
            this.ddlPersons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlPersons.FormattingEnabled = true;
            this.ddlPersons.Location = new System.Drawing.Point(14, 14);
            this.ddlPersons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ddlPersons.Name = "ddlPersons";
            this.ddlPersons.Size = new System.Drawing.Size(370, 23);
            this.ddlPersons.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(14, 60);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(64, 25);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "label1";
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 99);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.ddlPersons);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GlavnaForma";
            this.Text = "Async Await RESTful API";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlPersons;
        private System.Windows.Forms.Label lblInfo;
    }
}

