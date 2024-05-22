namespace Task06
{
    public partial class ContactsForm : Form
    {
        public ContactsForm()
        {
            InitializeComponent();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            NewContactForm newContactForm = new NewContactForm();
            if (newContactForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtContacts.AppendText(newContactForm.GetNewContact().ToString());
                txtContacts.AppendText(Environment.NewLine);
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete all contacts?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                txtContacts.Clear();
            }
        }
    }
}