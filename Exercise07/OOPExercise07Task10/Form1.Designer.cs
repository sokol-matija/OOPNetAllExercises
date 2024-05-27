namespace OOPExercise07Task10
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
			menuStrip1 = new MenuStrip();
			languageToolStripMenuItem = new ToolStripMenuItem();
			croatianToolStripMenuItem = new ToolStripMenuItem();
			englishToolStripMenuItem = new ToolStripMenuItem();
			germanToolStripMenuItem = new ToolStripMenuItem();
			btnStartCounting = new Button();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { languageToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(230, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// languageToolStripMenuItem
			// 
			languageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { croatianToolStripMenuItem, englishToolStripMenuItem, germanToolStripMenuItem });
			languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			languageToolStripMenuItem.Size = new Size(71, 20);
			languageToolStripMenuItem.Text = "Language";
			// 
			// croatianToolStripMenuItem
			// 
			croatianToolStripMenuItem.Name = "croatianToolStripMenuItem";
			croatianToolStripMenuItem.Size = new Size(180, 22);
			croatianToolStripMenuItem.Text = "Croatian";
			croatianToolStripMenuItem.Click += MiHR_Click;
			// 
			// englishToolStripMenuItem
			// 
			englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			englishToolStripMenuItem.Size = new Size(180, 22);
			englishToolStripMenuItem.Text = "English";
			englishToolStripMenuItem.Click += MiEN_Click;
			// 
			// germanToolStripMenuItem
			// 
			germanToolStripMenuItem.Name = "germanToolStripMenuItem";
			germanToolStripMenuItem.Size = new Size(180, 22);
			germanToolStripMenuItem.Text = "German";
			germanToolStripMenuItem.Click += MiDE_Click;
			// 
			// btnStartCounting
			// 
			btnStartCounting.Location = new Point(12, 27);
			btnStartCounting.Name = "btnStartCounting";
			btnStartCounting.Size = new Size(206, 130);
			btnStartCounting.TabIndex = 1;
			btnStartCounting.Text = "Start Counting";
			btnStartCounting.UseVisualStyleBackColor = true;
			btnStartCounting.Click += btnStartCounting_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(230, 169);
			Controls.Add(btnStartCounting);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Form1";
			Text = "Form1";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem languageToolStripMenuItem;
		private ToolStripMenuItem croatianToolStripMenuItem;
		private ToolStripMenuItem englishToolStripMenuItem;
		private ToolStripMenuItem germanToolStripMenuItem;
		private Button btnStartCounting;
	}
}
