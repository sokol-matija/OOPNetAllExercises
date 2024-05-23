using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPExercise05Task01
{
    public partial class UpdatePictureForm : Form
    {
        public UpdatePictureForm(PictureBox picture)
        {
            InitializeComponent();

            imgNewPicture.Image = picture.Image;
        }

        private void ChangePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Pictures |*.jpg; *.jpeg; *.png; *.gif|All files|*,*"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgNewPicture.ImageLocation = ofd.FileName;
            }
        }

        public PictureBox GetNewpicture()
        {
            return imgNewPicture;
        }
    }
}
