namespace OOPExercise05Task01Practice01
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
            btnChangePicture = new Button();
            btnOk = new Button();
            btnCancel = new Button();
            imageNewPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imageNewPicture).BeginInit();
            SuspendLayout();
            // 
            // btnChangePicture
            // 
            btnChangePicture.Location = new Point(290, 12);
            btnChangePicture.Name = "btnChangePicture";
            btnChangePicture.Size = new Size(182, 42);
            btnChangePicture.TabIndex = 0;
            btnChangePicture.Text = "Change Picture";
            btnChangePicture.UseVisualStyleBackColor = true;
            btnChangePicture.Click += ChangePicture_Click;
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(12, 307);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(182, 42);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(290, 307);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(182, 42);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // imageNewPicture
            // 
            imageNewPicture.Location = new Point(12, 57);
            imageNewPicture.Name = "imageNewPicture";
            imageNewPicture.Size = new Size(460, 244);
            imageNewPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            imageNewPicture.TabIndex = 3;
            imageNewPicture.TabStop = false;
            // 
            // UpdatePictureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(imageNewPicture);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(btnChangePicture);
            Name = "UpdatePictureForm";
            Text = "UpdatePictureForm";
            ((System.ComponentModel.ISupportInitialize)imageNewPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnChangePicture;
        private Button btnOk;
        private Button btnCancel;
        private PictureBox imageNewPicture;
    }
}