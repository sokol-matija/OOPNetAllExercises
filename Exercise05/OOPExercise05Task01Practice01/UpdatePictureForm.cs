using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPExercise05Task01Practice01
{
    public partial class UpdatePictureForm : Form
    {
        public UpdatePictureForm(PictureBox picture)
        {
            InitializeComponent();
            imageNewPicture.Image = picture.Image;
        }

        private void ChangePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "All Files|*.*|Image Files|*.jpg;*.jpeg;*.png;*.gif"
            };
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                imageNewPicture.ImageLocation = ofd.FileName;
            }
        }

        public PictureBox GetNewPicture()
        {
            return imageNewPicture;
        }
    }
}
