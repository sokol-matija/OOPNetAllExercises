using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPExercise08Task01
{
	[DefaultEvent(nameof(Click))]
	public partial class SemaforUserControl : UserControl
	{
		public SemaforUserControl()
		{
			InitializeComponent();
			Light = ColorType.Red;
		}

		public ColorType _light;
		public ColorType Light
		{
			get
			{
				return _light;
			}
			set
			{
				panel1.BackColor = Color.LightCoral;
				panel2.BackColor = Color.LightYellow;
				panel3.BackColor = Color.LightGreen;
				switch (value)
				{
					case ColorType.Red:
						panel1.BackColor = Color.Red;
						break;
					case ColorType.Yellow:
						panel2.BackColor = Color.Yellow;
						break;
					case ColorType.Green:
						panel3.BackColor = Color.Green;
						break;
					default:
						break;
				
				}
				_light = value;
			}
		}

	}
}
