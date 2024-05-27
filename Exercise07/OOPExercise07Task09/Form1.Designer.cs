namespace OOPExercise07Task09
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
			label1 = new Label();
			lblAmount = new Label();
			lblPrice = new Label();
			label3 = new Label();
			lblTime = new Label();
			label4 = new Label();
			lblDate = new Label();
			lbl = new Label();
			label2 = new Label();
			ddlCulture = new ComboBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.Location = new Point(12, 172);
			label1.Name = "label1";
			label1.Size = new Size(55, 15);
			label1.TabIndex = 0;
			label1.Text = "Amount:";
			// 
			// lblAmount
			// 
			lblAmount.AutoSize = true;
			lblAmount.Location = new Point(78, 172);
			lblAmount.Name = "lblAmount";
			lblAmount.Size = new Size(32, 15);
			lblAmount.TabIndex = 1;
			lblAmount.Text = "label";
			// 
			// lblPrice
			// 
			lblPrice.AutoSize = true;
			lblPrice.Location = new Point(78, 135);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(32, 15);
			lblPrice.TabIndex = 3;
			lblPrice.Text = "label";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label3.Location = new Point(12, 135);
			label3.Name = "label3";
			label3.Size = new Size(38, 15);
			label3.TabIndex = 2;
			label3.Text = "Price:";
			// 
			// lblTime
			// 
			lblTime.AutoSize = true;
			lblTime.Location = new Point(78, 100);
			lblTime.Name = "lblTime";
			lblTime.Size = new Size(32, 15);
			lblTime.TabIndex = 5;
			lblTime.Text = "label";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label4.Location = new Point(12, 100);
			label4.Name = "label4";
			label4.Size = new Size(38, 15);
			label4.TabIndex = 4;
			label4.Text = "Time:";
			// 
			// lblDate
			// 
			lblDate.AutoSize = true;
			lblDate.Location = new Point(78, 66);
			lblDate.Name = "lblDate";
			lblDate.Size = new Size(32, 15);
			lblDate.TabIndex = 7;
			lblDate.Text = "label";
			// 
			// lbl
			// 
			lbl.AutoSize = true;
			lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			lbl.Location = new Point(12, 66);
			lbl.Name = "lbl";
			lbl.Size = new Size(37, 15);
			lbl.TabIndex = 6;
			lbl.Text = "Date:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 10);
			label2.Name = "label2";
			label2.Size = new Size(62, 15);
			label2.TabIndex = 8;
			label2.Text = "SetCulture";
			// 
			// ddlCulture
			// 
			ddlCulture.DropDownStyle = ComboBoxStyle.DropDownList;
			ddlCulture.FormattingEnabled = true;
			ddlCulture.Location = new Point(12, 28);
			ddlCulture.Name = "ddlCulture";
			ddlCulture.Size = new Size(198, 23);
			ddlCulture.TabIndex = 9;
			ddlCulture.SelectedIndexChanged += ddlCulture_SelectedIndexChanged;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(222, 207);
			Controls.Add(ddlCulture);
			Controls.Add(label2);
			Controls.Add(lblDate);
			Controls.Add(lbl);
			Controls.Add(lblTime);
			Controls.Add(label4);
			Controls.Add(lblPrice);
			Controls.Add(label3);
			Controls.Add(lblAmount);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label lblAmount;
		private Label lblPrice;
		private Label label3;
		private Label lblTime;
		private Label label4;
		private Label lblDate;
		private Label lbl;
		private Label label2;
		private ComboBox ddlCulture;
	}
}
