namespace OOPExercise02Task06
{
    partial class AddContactForm
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
            gbContactData = new GroupBox();
            tbFirstName = new TextBox();
            lblName = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            tbLastName = new TextBox();
            label2 = new Label();
            tbGSM = new TextBox();
            lblGSM = new Label();
            tbEmail = new TextBox();
            label4 = new Label();
            gbContactData.SuspendLayout();
            SuspendLayout();
            // 
            // gbContactData
            // 
            gbContactData.Controls.Add(tbEmail);
            gbContactData.Controls.Add(label4);
            gbContactData.Controls.Add(tbGSM);
            gbContactData.Controls.Add(lblGSM);
            gbContactData.Controls.Add(tbLastName);
            gbContactData.Controls.Add(label2);
            gbContactData.Controls.Add(tbFirstName);
            gbContactData.Controls.Add(lblName);
            gbContactData.Location = new Point(12, 12);
            gbContactData.Name = "gbContactData";
            gbContactData.Size = new Size(301, 364);
            gbContactData.TabIndex = 0;
            gbContactData.TabStop = false;
            gbContactData.Text = "Contact Information:";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(37, 79);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(227, 23);
            tbFirstName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(37, 61);
            lblName.Name = "lblName";
            lblName.Size = new Size(65, 15);
            lblName.TabIndex = 0;
            lblName.Text = "First name:";
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(12, 382);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(87, 38);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(228, 382);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(87, 38);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(37, 149);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(227, 23);
            tbLastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 131);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 2;
            label2.Text = "Last name:";
            // 
            // tbGSM
            // 
            tbGSM.Location = new Point(37, 211);
            tbGSM.Name = "tbGSM";
            tbGSM.Size = new Size(227, 23);
            tbGSM.TabIndex = 5;
            // 
            // lblGSM
            // 
            lblGSM.AutoSize = true;
            lblGSM.Location = new Point(37, 193);
            lblGSM.Name = "lblGSM";
            lblGSM.Size = new Size(35, 15);
            lblGSM.TabIndex = 4;
            lblGSM.Text = "GSM:";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(37, 281);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(227, 23);
            tbEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 263);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "E-Mail:";
            // 
            // AddContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 428);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(gbContactData);
            Name = "AddContactForm";
            Text = "AddContactForm";
            Load += AddContactForm_Load;
            gbContactData.ResumeLayout(false);
            gbContactData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbContactData;
        private TextBox tbFirstName;
        private Label lblName;
        private Button btnOK;
        private Button btnCancel;
        private TextBox tbEmail;
        private Label label4;
        private TextBox tbGSM;
        private Label lblGSM;
        private TextBox tbLastName;
        private Label label2;
    }
}