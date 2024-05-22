using Model;

namespace OOPExercise02Task06
{
    public partial class AddContactForm : Form
    {
        public AddContactForm()
        {
            InitializeComponent();
        }

        private void AddContactForm_Load(object sender, EventArgs e)
        {
            ActiveControl = tbFirstName;
        }

        public Contacts GetContact()
        {
            return new Model.Contacts
            {
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                Email = tbEmail.Text,
                Phone = tbGSM.Text
            };
        }
    }
}
