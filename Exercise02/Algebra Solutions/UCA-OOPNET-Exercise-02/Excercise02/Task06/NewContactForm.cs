using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task06
{
    public partial class NewContactForm : Form
    {
        public NewContactForm()
        {
            InitializeComponent();
        }

        private void NewContactForm_Load(object sender, EventArgs e)
        {
            ActiveControl = txtName;
        }

        public Contact GetNewContact()
        {
            return new Contact {
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text
            };
        }
    }
}
