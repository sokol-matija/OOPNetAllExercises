using System.ComponentModel;
using System.Drawing.Printing;
using System.Globalization;

namespace TaskPrintingLocalization
{
    public partial class Form1 : Form
    {
        private const string HR = "hr", EN = "en";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetCulture(EN);
        }

        private void SetCulture(string lang)
        {
            var culture = new CultureInfo(lang);

            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;

            UpdateUIInitializeComponent(culture);
            //UpdateUIResourceManager(culture);
        }

        private void UpdateUIInitializeComponent(CultureInfo culture)
        {
            this.Controls.Clear();
            InitializeComponent();
        }

        private void UpdateUIResourceManager(CultureInfo culture)
        {
             // Dynamically change localizations on all resources on the form

             // Note: if you need on all open forms, retrieve all forms
             // Application.OpenForms
             // and then call a method on all of them that does this
             // potentially inherit some MyForm(as in WebForms MyPage and define it there)
            foreach (Control ctrl in Controls)
            {
                ComponentResourceManager resursi = new(GetType());

                // It is important to change only the Text property on the controls, otherwise it will
                // resize controls and other properties
                var text = resursi.GetString(ctrl.Name + ".Text", culture);
                if (text is not null)
                {
                    ctrl.Text = text;
                }
            }
        }

        private void BtnChangeCulture_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentCulture.Name == HR)
            {
                SetCulture(EN);
            }
            else
            {
                SetCulture(HR);
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var x = e.MarginBounds.Left;
            var y = e.MarginBounds.Top;
            var bmp = new Bitmap(this.Size.Width, this.Size.Height);

            // each control has a defined DrawToBitmap method
            this.DrawToBitmap(bmp, new Rectangle
            {
                X = 0,
                Y = 0,
                Width = this.Size.Width,
                Height = this.Size.Height
            });
            e.Graphics?.DrawImage(bmp, x, y);
        }

        private void PrintDocument_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if (e.PrintAction == PrintAction.PrintToPreview)
            {
                MessageBox.Show(Resource.Strings.printingFinished);
            }
        }
    }
}