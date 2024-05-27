namespace OOPExercise08Task01
{
	partial class DigitalClockUC
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
			components = new System.ComponentModel.Container();
			timer = new System.Windows.Forms.Timer(components);
			label1 = new Label();
			SuspendLayout();
			// 
			// timer
			// 
			timer.Enabled = true;
			timer.Tick += timer_Tick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Arial", 18F);
			label1.Location = new Point(17, 11);
			label1.Name = "label1";
			label1.Size = new Size(77, 27);
			label1.TabIndex = 0;
			label1.Text = "label1";
			// 
			// DigitalClockUC
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			Controls.Add(label1);
			Name = "DigitalClockUC";
			Size = new Size(461, 137);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.Timer timer;
		private Label label1;
	}
}
