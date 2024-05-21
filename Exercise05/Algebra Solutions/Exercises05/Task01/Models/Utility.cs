namespace Task01.Models
{
    public class Utility
    {
        // 2 pictures in a row
        public static Size GetPictureSize(Control parent)
        {
            double scale = 2 / 3.0;
            // half of panel container
            var width = parent.Width / 2;
            var height = (int)(width * scale);
            return new Size(width, height);
        }


        public static Label GetPictureTitle(string fileName, Control mainParent)
        {
            var titleWidth = GetPictureSize(mainParent).Width;
            var titleHeigh = 50;

            Label lblPictureTitle = new Label()
            {
                Name = "lblPictureTitle",
                Text = Path.GetFileNameWithoutExtension(fileName).ToUpper(),
                // light grey
                BackColor = ColorTranslator.FromHtml("#333"),
                Font = new Font("Arial", 12),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(titleWidth, titleHeigh)
            };
            

            return lblPictureTitle;
        }

        public static PictureBox GetPictureBox(string filePath, Control mainParent)
        {
            PictureBox pb = new PictureBox
            {
                ImageLocation = filePath,
                Size = GetPictureSize(mainParent),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            return pb;
        }

        public static FlowLayoutPanel GetPictureContainer(Label title, PictureBox picture)
        {
            FlowLayoutPanel flp = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.TopDown,                
                Size = new Size(picture.Width, picture.Height + title.Height),
                WrapContents = false,
                // 2 pictures have to fit in the same row
                Margin = new Padding(0)
            };

            flp.Controls.Add(title);
            flp.Controls.Add(picture);
            return flp;
        }

        public static void SetPictureBoxMode(PictureBox pb, PictureMode mode)
        {
            // Parent is FlowLayoutPanel containing Label and PictureBox
            var lblPictureTitle = GetControl<Label>(pb.Parent);

            switch (mode)
            {
                case PictureMode.Mark:
                    pb.BorderStyle = BorderStyle.FixedSingle;
                    lblPictureTitle.BackColor = Color.DarkRed;
                    break;
                case PictureMode.Unmark:
                    pb.BorderStyle = BorderStyle.None;
                    // light grey
                    lblPictureTitle.BackColor = ColorTranslator.FromHtml("#333");
                    break;
            }
        }


        public static T GetControl<T>(Control parent)
        {
            foreach (var ctrl in parent.Controls)
            {
                if (ctrl is T)
                {
                    return (T)ctrl;
                }
            }
            return default;
        }

    }
}
