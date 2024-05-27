namespace OOPExercise08Task01
{
	partial class SemaforUserControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			panel2 = new Panel();
			panel3 = new Panel();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			panel1.BackColor = Color.LightCoral;
			panel1.Location = new Point(14, 14);
			panel1.Name = "panel1";
			panel1.Size = new Size(161, 36);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			panel2.BackColor = Color.LightYellow;
			panel2.Location = new Point(14, 56);
			panel2.Name = "panel2";
			panel2.Size = new Size(161, 36);
			panel2.TabIndex = 1;
			// 
			// panel3
			// 
			panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			panel3.BackColor = Color.LightGreen;
			panel3.Location = new Point(14, 98);
			panel3.Name = "panel3";
			panel3.Size = new Size(161, 36);
			panel3.TabIndex = 1;
			// 
			// SemaforUserControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			BackColor = Color.White;
			Controls.Add(panel3);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "SemaforUserControl";
			Size = new Size(178, 153);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
	}
}
