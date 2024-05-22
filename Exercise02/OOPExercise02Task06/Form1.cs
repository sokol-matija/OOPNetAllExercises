using Model;

namespace OOPExercise02Task06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            AddContactForm contactForm = new AddContactForm();
            DialogResult dialogResult = contactForm.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Contacts contact = contactForm.GetContact();
                txtContacts.AppendText(contact.ToString() + Environment.NewLine);
            }
        }

        private void btnDeleteAllContacts_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Text = "Are you sure you want to delete all contacts?", "Delete all contacts", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                txtContacts.Clear();
            }
        }
    }
}
