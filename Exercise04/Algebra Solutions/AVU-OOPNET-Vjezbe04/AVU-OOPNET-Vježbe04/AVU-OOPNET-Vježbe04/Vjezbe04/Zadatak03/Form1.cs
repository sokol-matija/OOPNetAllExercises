using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zadatak03.Models;

namespace Zadatak03
{
    public partial class Form1 : Form
    {
        private List<Person> personList;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            LoadData();
        }

        private void LoadData()
        {
            personList = Repo.GetPersonFromFile().ToList();
            ShowData();
        }

        private void ShowData()
        {
            flpContainer.Controls.Clear();
            foreach (Person person in personList)
            {
                flpContainer.Controls.Add(PersonPanel(person));
            }
        }

        private Control PersonPanel(Person person)
        {
            FlowLayoutPanel flpPerson = new FlowLayoutPanel();
            flpPerson.Tag = person.Id;
            flpPerson.BorderStyle = BorderStyle.FixedSingle;
            flpPerson.FlowDirection = FlowDirection.TopDown;

            flpPerson.Controls.Add(GetLabel(person.FirstName));
            flpPerson.Controls.Add(GetLabel(person.LastName));
            flpPerson.Controls.Add(GetLinkLabel(person.Email));
            flpPerson.Click += FlpPerson_Click;
            flpPerson.ContextMenuStrip = cms;
            return flpPerson;
        }
        private FlowLayoutPanel selectedPerson = null;
        private void FlpPerson_Click(object sender, EventArgs e)
        {
            if (selectedPerson != null)
                selectedPerson.BackColor = SystemColors.Control;

            if (sender is FlowLayoutPanel)
                selectedPerson = sender as FlowLayoutPanel;
            else
                selectedPerson = (sender as Label).Parent as FlowLayoutPanel;

            selectedPerson.BackColor = Color.Aqua;
        }

        private Control GetLinkLabel(string linkLabelText)
        {
            LinkLabel mailLink = new LinkLabel();
            mailLink.Text = linkLabelText;
            mailLink.Click += MailLink_Click;
            return mailLink;
        }

        private void MailLink_Click(object sender, EventArgs e)
        {
            LinkLabel mailLink = sender as LinkLabel;
            Process.Start($"mailto:{mailLink.Text}");
        }

        private Control GetLabel(string labelText)
        {
            Label lbl = new Label();
            lbl.Text = labelText;
            lbl.Click += FlpPerson_Click;
            return lbl;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAddEdit f = new frmAddEdit();
            f.StartPosition = FormStartPosition.CenterScreen;

            if(f.ShowDialog() == DialogResult.OK)
            {
                personList.Add(f.GetPerson());
                SaveToFile();
                ShowData();
            }
        }

        private void SaveToFile()
        {
            try
            {
                Repo.SaveToFile(personList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error\n{ex.Message}");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            EditPerson();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DeletePerson();
        }

        private void cmsEventhandler(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            switch (item.Text.ToLower())
            {
                case "edit":
                    EditPerson();
                    break;
                case "delete":
                    DeletePerson();
                    break;
            }
        }

        private void DeletePerson()
        {
            var personId = new Guid(selectedPerson.Tag.ToString());
            var person = personList.Single(p => p.Id == personId);

            if (MessageBox.Show($"Delete {person.FirstName} {person.LastName}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                personList.Remove(person);
                SaveToFile();
                ShowData();
            }
        }

        private void EditPerson()
        {
            var personId = new Guid(selectedPerson.Tag.ToString());
            var person = personList.Single(p => p.Id == personId);

            frmAddEdit f = new frmAddEdit(person);
            f.StartPosition = FormStartPosition.CenterScreen;

            if (f.ShowDialog() == DialogResult.OK)
            {
                var updatedData = f.GetPerson();
                person.FirstName = updatedData.FirstName;
                person.LastName = updatedData.LastName;
                person.Email = updatedData.Email;

                SaveToFile();
                ShowData();
            }
        }
    }
}
