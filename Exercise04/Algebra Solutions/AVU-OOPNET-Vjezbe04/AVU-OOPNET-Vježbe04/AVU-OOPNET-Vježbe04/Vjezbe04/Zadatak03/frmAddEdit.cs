using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadatak03.Models;

namespace Zadatak03
{
    public partial class frmAddEdit : Form
    {
        public frmAddEdit()
        {
            InitializeComponent();
            InitSetup("Add");
        }

        public frmAddEdit(Person person)
        {
            InitializeComponent();
            InitSetup("Edit");
            txtFirsName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtEmail.Text = person.Email;
        }

        private void InitSetup(string text)
        {
            this.Text = text;
            btnAction.Text = text;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public Person GetPerson()
        {
            return new Person
            {
                FirstName = txtFirsName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text
            };
        }
    }
}
