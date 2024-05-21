namespace OOPExercise01Task02
{
    partial class MainForm
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
            btnOpenNewForm250Size = new Button();
            btnOpenNewForm300Size = new Button();
            btnOpenNewFormNoControls = new Button();
            btnCloseApp = new Button();
            SuspendLayout();
            // 
            // btnOpenNewForm250Size
            // 
            btnOpenNewForm250Size.Location = new Point(51, 49);
            btnOpenNewForm250Size.Name = "btnOpenNewForm250Size";
            btnOpenNewForm250Size.Size = new Size(150, 150);
            btnOpenNewForm250Size.TabIndex = 0;
            btnOpenNewForm250Size.Text = "Open a new form 250x250 ";
            btnOpenNewForm250Size.UseVisualStyleBackColor = true;
            btnOpenNewForm250Size.Click += OpenNewForm250Size_Click;
            // 
            // btnOpenNewForm300Size
            // 
            btnOpenNewForm300Size.Location = new Point(222, 49);
            btnOpenNewForm300Size.Name = "btnOpenNewForm300Size";
            btnOpenNewForm300Size.Size = new Size(150, 150);
            btnOpenNewForm300Size.TabIndex = 1;
            btnOpenNewForm300Size.Text = "Open a new form 300x300 ";
            btnOpenNewForm300Size.UseVisualStyleBackColor = true;
            btnOpenNewForm300Size.Click += OpenNewForm300Size_Click;
            // 
            // btnOpenNewFormNoControls
            // 
            btnOpenNewFormNoControls.Location = new Point(398, 49);
            btnOpenNewFormNoControls.Name = "btnOpenNewFormNoControls";
            btnOpenNewFormNoControls.Size = new Size(150, 150);
            btnOpenNewFormNoControls.TabIndex = 2;
            btnOpenNewFormNoControls.Text = "Open a new form 300x300 without control buttons";
            btnOpenNewFormNoControls.UseVisualStyleBackColor = true;
            btnOpenNewFormNoControls.Click += OpenNewFormNoControls_Click;
            // 
            // btnCloseApp
            // 
            btnCloseApp.Location = new Point(51, 221);
            btnCloseApp.Name = "btnCloseApp";
            btnCloseApp.Size = new Size(501, 75);
            btnCloseApp.TabIndex = 3;
            btnCloseApp.Text = "Close App";
            btnCloseApp.UseVisualStyleBackColor = true;
            btnCloseApp.Click += CloseApp_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 345);
            Controls.Add(btnCloseApp);
            Controls.Add(btnOpenNewFormNoControls);
            Controls.Add(btnOpenNewForm300Size);
            Controls.Add(btnOpenNewForm250Size);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenNewForm250Size;
        private Button btnOpenNewForm300Size;
        private Button btnOpenNewFormNoControls;
        private Button btnCloseApp;
    }
}
