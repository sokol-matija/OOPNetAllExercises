using System.Globalization;

namespace OOPExercise07Task08
{
	public partial class Form1 : Form
	{

		private const string HR = "hr";
		private const string EN = "en";

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			SetCulture(HR);
			ShowLables();
		}

		private void SetCulture(string jezik)
		{
			var culture = new CultureInfo(jezik);

			Thread.CurrentThread.CurrentUICulture = culture;
			Thread.CurrentThread.CurrentCulture = culture;

			// Update the UI manually to change the button's text
			this.Controls.Clear();
			InitializeComponent();
		}

		private void ShowLables()
		{
			lblTime.Text = DateTime.Now.ToLongTimeString();
			lblDate.Text = DateTime.Now.ToLongDateString();

			if (Thread.CurrentThread.CurrentCulture.Name == HR)
			{
				btnChangeCulture.Text = "Promjeni kulturu";
			}
			else
			{
				btnChangeCulture.Text = "Change culture";
			}
		}

		private void btnChangeCulture_Click(object sender, EventArgs e)
		{
			if (Thread.CurrentThread.CurrentCulture.Name == HR)
			{
				SetCulture(EN);
			}
			else
			{
				SetCulture(HR);
			}

			ShowLables();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			ShowLables();
		}

	}
}