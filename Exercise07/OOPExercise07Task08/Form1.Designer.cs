namespace OOPExercise07Task08
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			btnChangeCulture = new Button();
			lblTime = new Label();
			lblDate = new Label();
			timer = new System.Windows.Forms.Timer(components);
			SuspendLayout();
			// 
			// btnChangeCulture
			// 
			btnChangeCulture.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			btnChangeCulture.Location = new Point(12, 12);
			btnChangeCulture.Name = "btnChangeCulture";
			btnChangeCulture.Size = new Size(454, 43);
			btnChangeCulture.TabIndex = 0;
			btnChangeCulture.Text = "Promijeni Kulturu";
			btnChangeCulture.UseVisualStyleBackColor = true;
			btnChangeCulture.Click += btnChangeCulture_Click;
			// 
			// lblTime
			// 
			lblTime.AutoSize = true;
			lblTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblTime.Location = new Point(12, 73);
			lblTime.Name = "lblTime";
			lblTime.Size = new Size(57, 21);
			lblTime.TabIndex = 1;
			lblTime.Text = "label1";
			// 
			// lblDate
			// 
			lblDate.AutoSize = true;
			lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
			lblDate.Location = new Point(12, 114);
			lblDate.Name = "lblDate";
			lblDate.Size = new Size(57, 21);
			lblDate.TabIndex = 2;
			lblDate.Text = "label1";
			// 
			// timer
			// 
			timer.Enabled = true;
			timer.Interval = 1000;
			timer.Tick += timer_Tick;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(478, 144);
			Controls.Add(lblDate);
			Controls.Add(lblTime);
			Controls.Add(btnChangeCulture);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnChangeCulture;
        private Label lblTime;
        private Label lblDate;
        private System.Windows.Forms.Timer timer;
    }
}
