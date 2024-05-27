using System.Globalization;

namespace OOPExercise07Task10
{
	public partial class Form1 : Form
	{
		private const string HR = "hr", EN = "en", DE = "de";
		private string culture;
		public Form1()
		{
			InitializeComponent();
			culture = EN;
		}

		private void MiHR_Click(object sender, EventArgs e)
		{

		}

		private void MiEN_Click(object sender, EventArgs e)
		{

		}

		private void MiDE_Click(object sender, EventArgs e)
		{

		}

		private void btnStartCounting_Click(object sender, EventArgs e)
		{
			new Counting(new CultureInfo(culture)).Show();
		}
	}
}
