namespace OOPExercise03Task04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox = new PictureBox();
            trackBar = new TrackBar();
            lblPercentage = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(12, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(300, 200);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // trackBar
            // 
            trackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackBar.LargeChange = 10;
            trackBar.Location = new Point(14, 347);
            trackBar.Maximum = 200;
            trackBar.Minimum = 10;
            trackBar.Name = "trackBar";
            trackBar.Size = new Size(774, 45);
            trackBar.SmallChange = 5;
            trackBar.TabIndex = 1;
            trackBar.TickFrequency = 10;
            trackBar.Value = 100;
            trackBar.Scroll += trackBar_Scroll_1;
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPercentage.Location = new Point(362, 329);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(38, 15);
            lblPercentage.TabIndex = 2;
            lblPercentage.Text = "100%";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 392);
            Controls.Add(lblPercentage);
            Controls.Add(trackBar);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private TrackBar trackBar;
        private Label lblPercentage;
    }
}
