namespace OOPExercise05Task01
{
    partial class UpdatePictureForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            imgNewPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgNewPicture).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(333, 12);
            button1.Name = "button1";
            button1.Size = new Size(139, 29);
            button1.TabIndex = 0;
            button1.Text = "Change picture";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ChangePicture_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(31, 307);
            button2.Name = "button2";
            button2.Size = new Size(171, 43);
            button2.TabIndex = 1;
            button2.Text = "OK";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.DialogResult = DialogResult.Cancel;
            button3.Location = new Point(305, 307);
            button3.Name = "button3";
            button3.Size = new Size(171, 42);
            button3.TabIndex = 2;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // imgNewPicture
            // 
            imgNewPicture.Location = new Point(12, 51);
            imgNewPicture.Name = "imgNewPicture";
            imgNewPicture.Size = new Size(460, 250);
            imgNewPicture.TabIndex = 3;
            imgNewPicture.TabStop = false;
            // 
            // UpdatePictureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(imgNewPicture);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "UpdatePictureForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdatePictureForm";
            ((System.ComponentModel.ISupportInitialize)imgNewPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox imgNewPicture;
    }
}