
using Utilities;

namespace OOPExercise06Task03
{
    public partial class Form1 : Form
    {
        private OpenFileDialog ofd = new OpenFileDialog();
        private FlowLayoutPanel flp = new FlowLayoutPanel();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            AddThumbnailFLP();
            InitOpenFileDialog();
            InitDnD();
        }

        private void InitDnD()
        {
            pbContainer.AllowDrop = true;
            pbContainer.DragEnter += PictureContainer_DragEnter;
            pbContainer.DragDrop += PictureContainer_DragDrop;

            lbRecycle.AllowDrop = true;
            lbRecycle.DragEnter += lbRecycle_DragEnter;
            lbRecycle.DragLeave += lbRecycle_DragLeave;
            lbRecycle.DragDrop += lbRecycle_DragDrop;
        }


        private void AddThumbnailFLP()
        {
            int w = splitContainer.Panel1.Width;
            int h = splitContainer.Panel1.Height;
            flp.Size = new Size(w, h);
            flp.ContextMenuStrip = cms;

            splitContainer.Panel1.Controls.Add(flp);
        }

        private void InitOpenFileDialog()
        {
            ofd.Filter = "Pictures|*.jpeg;*.jpg;*.png;|All files|*.*";
            ofd.Multiselect = true;
            ofd.Title = "Load pictures...";
            ofd.InitialDirectory = Application.StartupPath;
        }
        private void LoadPictures()
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var maxPictures = 5 - flp.Controls.Count;
                if (ofd.FileNames.Length > maxPictures)
                {
                    MessageBox.Show($"A maximum of 5 images are allowed.\nOnly {maxPictures} pictures will be added.");
                }
                foreach (var file in ofd.FileNames)
                {
                    if (flp.Controls.Count >= 5) return;
                    if (FileAlreadyLoaded(file)) continue;

                    ShowThumbnail(file);
                }
            }
        }

        private void ShowThumbnail(string file)
        {
            var thumbnail = ViewUtils.GetThumbnailPicture(file, flp);

            var thumbnailPicture = thumbnail.Controls.OfType<PictureBox>().First();
            thumbnailPicture.Tag = file;
            thumbnailPicture.MouseDown += Thumbnail_MouseDown;

            flp.Controls.Add(thumbnail);
            ShowPictureCount();
        }

        private bool FileAlreadyLoaded(string filePath)
        {
            foreach (var thumbnailCanvas in flp.Controls.OfType<Panel>())
            {
                var thumbnailPicture = thumbnailCanvas.Controls[0] as PictureBox;
                if (thumbnailPicture.Tag.ToString() == filePath)
                    return true;
            }
            return false;
        }

        private void ShowPictureCount()
        {
            progressBar.Value = flp.Controls.Count;
            lbInfo.Text = $"Picture count: {progressBar.Value}";
        }

        private void Thumbnail_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            pb.DoDragDrop(pb, DragDropEffects.Copy);
        }
        private void PictureContainer_DragDrop(object sender, DragEventArgs e)
        {
            var pb = (PictureBox)e.Data.GetData(typeof(PictureBox));
            pbContainer.Image = pb.Image;
            pbContainer.Tag = pb.Tag;
            lbInfo.Text = pb.Tag.ToString();
        }

        private void lbRecycle_DragDrop(object sender, DragEventArgs e)
        {
            var pb = (PictureBox)e.Data.GetData(typeof(PictureBox));
            if (pbContainer.Tag == pb.Tag) pbContainer.Image = null;

            var canvas = pb.Parent;
            flp.Controls.Remove(canvas);

            ResetRecycleBin();
        }

        private void ResetRecycleBin()
        {
            lbRecycle.BackColor = Color.Orange;
            lbRecycle.ForeColor = Color.Black;
            ShowPictureCount();
        }

        private void PictureContainer_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.Copy;
        private void lbRecycle_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            lbRecycle.BackColor = Color.Black;
            lbRecycle.ForeColor = Color.Yellow;
        }
        private void lbRecycle_DragLeave(object sender, EventArgs e) => ResetRecycleBin();

        private void toolStripButton1_Click(object sender, EventArgs e) => LoadPictures();

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => SaveData();
        private void Form1_Load(object sender, EventArgs e) => LoadData();

        private string dataFile = "data.txt";
        private void SaveData()
        {
            if (!File.Exists(dataFile)) return;

            using (StreamWriter w = new StreamWriter(dataFile))
            {
                foreach (var thumbnailCanvas in flp.Controls.OfType<Panel>())
                {
                    var thumbnailPicture = thumbnailCanvas.Controls[0] as PictureBox;
                    w.WriteLine(thumbnailPicture.Tag.ToString());
                }
            }
        }
        private void LoadData()
        {
            if (!File.Exists(dataFile)) return;

            using (StreamReader r = new StreamReader(dataFile))
            {
                while (!r.EndOfStream)
                {
                    var filePath = r.ReadLine();
                    if (File.Exists(filePath))
                        ShowThumbnail(filePath);
                }
            }
        }
    }
}