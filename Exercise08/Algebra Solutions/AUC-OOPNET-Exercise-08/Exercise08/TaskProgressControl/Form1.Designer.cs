namespace TaskProgressControl
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
            this.btnIncrement = new System.Windows.Forms.Button();
            this.btnDecrement = new System.Windows.Forms.Button();
            this.progressBar = new TaskProgressControl.CustomProgressControl();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAddProgressBar = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnIncrement
            // 
            this.btnIncrement.Location = new System.Drawing.Point(12, 79);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(165, 50);
            this.btnIncrement.TabIndex = 0;
            this.btnIncrement.Text = "Increment";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // btnDecrement
            // 
            this.btnDecrement.Location = new System.Drawing.Point(189, 79);
            this.btnDecrement.Name = "btnDecrement";
            this.btnDecrement.Size = new System.Drawing.Size(165, 50);
            this.btnDecrement.TabIndex = 1;
            this.btnDecrement.Text = "Decrement";
            this.btnDecrement.UseVisualStyleBackColor = true;
            this.btnDecrement.Click += new System.EventHandler(this.btnDecrement_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(342, 53);
            this.progressBar.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 135);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(342, 50);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print Percentage";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAddProgressBar
            // 
            this.btnAddProgressBar.Location = new System.Drawing.Point(12, 399);
            this.btnAddProgressBar.Name = "btnAddProgressBar";
            this.btnAddProgressBar.Size = new System.Drawing.Size(342, 50);
            this.btnAddProgressBar.TabIndex = 4;
            this.btnAddProgressBar.Text = "Add Progress Bar";
            this.btnAddProgressBar.UseVisualStyleBackColor = true;
            this.btnAddProgressBar.Click += new System.EventHandler(this.btnAddProgressBar_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlContainer.Location = new System.Drawing.Point(12, 191);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(342, 202);
            this.pnlContainer.TabIndex = 5;
            this.pnlContainer.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 463);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnAddProgressBar);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnDecrement);
            this.Controls.Add(this.btnIncrement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnIncrement;
        private Button btnDecrement;
        private CustomProgressControl progressBar;
        private Button btnPrint;
        private Button btnAddProgressBar;
        private FlowLayoutPanel pnlContainer;
    }
}