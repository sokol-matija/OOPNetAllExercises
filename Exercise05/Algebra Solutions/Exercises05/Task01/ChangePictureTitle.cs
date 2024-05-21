using Task01.Models;

namespace Task01
{
    public partial class ChangePictureTitle : Form
    {
        public ChangePictureTitle(PictureBox selectedPicture)
        {
            InitializeComponent();
            InitSetup(selectedPicture);
        }

        private void InitSetup(PictureBox selectedPicture)
        {
            var pictureTitle = Utility.GetControl<Label>(selectedPicture.Parent).Text;
            txtTitle.Text = pictureTitle;
            this.Text = $"Edit {pictureTitle}";
            pb.Image = selectedPicture.Image;
        }

        public PictureBox GetUpdatedPicture()
        {
            pb.Tag = txtTitle.Text;
            return pb;
        }

        private void btnChangePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Pictures|*.bmp;*.jpg;*.jpeg;*.png;|All files|*.*";
            ofd.InitialDirectory = Application.StartupPath;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pb.ImageLocation = ofd.FileName;
            }
        }
    }
}
