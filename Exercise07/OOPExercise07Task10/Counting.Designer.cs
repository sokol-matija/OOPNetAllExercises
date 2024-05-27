namespace OOPExercise07Task10
{
	partial class Counting
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			lblNumber = new Label();
			timer1 = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// lblNumber
			// 
			lblNumber.AutoSize = true;
			lblNumber.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			lblNumber.Location = new Point(81, 104);
			lblNumber.Name = "lblNumber";
			lblNumber.Size = new Size(98, 28);
			lblNumber.TabIndex = 0;
			lblNumber.Text = "number...";
			// 
			// timer1
			// 
			timer1.Enabled = true;
			timer1.Interval = 1000;
			timer1.Tick += timer1_Tick;
			// 
			// Counting
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(265, 235);
			Controls.Add(lblNumber);
			Name = "Counting";
			Text = "Counting";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblNumber;
		private System.Windows.Forms.Timer timer1;
	}
}