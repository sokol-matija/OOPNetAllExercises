namespace OOPExercise02Task06
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
            lblContacts = new Label();
            txtContacts = new TextBox();
            btnAddContact = new Button();
            btnDeleteAllContacts = new Button();
            SuspendLayout();
            // 
            // lblContacts
            // 
            lblContacts.AutoSize = true;
            lblContacts.Location = new Point(12, 9);
            lblContacts.Name = "lblContacts";
            lblContacts.Size = new Size(57, 15);
            lblContacts.TabIndex = 0;
            lblContacts.Text = "Contacts:";
            // 
            // txtContacts
            // 
            txtContacts.Location = new Point(12, 27);
            txtContacts.Multiline = true;
            txtContacts.Name = "txtContacts";
            txtContacts.ReadOnly = true;
            txtContacts.ScrollBars = ScrollBars.Vertical;
            txtContacts.Size = new Size(463, 333);
            txtContacts.TabIndex = 1;
            // 
            // btnAddContact
            // 
            btnAddContact.Location = new Point(12, 366);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(196, 40);
            btnAddContact.TabIndex = 2;
            btnAddContact.Text = "Add new contact";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // btnDeleteAllContacts
            // 
            btnDeleteAllContacts.Location = new Point(279, 366);
            btnDeleteAllContacts.Name = "btnDeleteAllContacts";
            btnDeleteAllContacts.Size = new Size(196, 40);
            btnDeleteAllContacts.TabIndex = 3;
            btnDeleteAllContacts.Text = "Delete All Contacts";
            btnDeleteAllContacts.UseVisualStyleBackColor = true;
            btnDeleteAllContacts.Click += btnDeleteAllContacts_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 418);
            Controls.Add(btnDeleteAllContacts);
            Controls.Add(btnAddContact);
            Controls.Add(txtContacts);
            Controls.Add(lblContacts);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacts;
        private TextBox txtContacts;
        private Button btnAddContact;
        private Button btnDeleteAllContacts;
    }
}
