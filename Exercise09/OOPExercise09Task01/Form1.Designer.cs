namespace OOPExercise09Task01
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
            label1 = new Label();
            lblTime = new Label();
            label3 = new Label();
            txtNumber = new TextBox();
            btnCalculate = new Button();
            btnCancel = new Button();
            progressBar = new ProgressBar();
            lblPercentage = new Label();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            timer = new System.Windows.Forms.Timer(components);
            backgroundWorker = new System.ComponentModel.BackgroundWorker();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Curent time:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(91, 9);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(38, 15);
            lblTime.TabIndex = 1;
            lblTime.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 44);
            label3.Name = "label3";
            label3.Size = new Size(224, 15);
            label3.TabIndex = 2;
            label3.Text = "How many numbers do you want to add:";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(244, 36);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(228, 23);
            txtNumber.TabIndex = 3;
            txtNumber.Text = "500000000";
            txtNumber.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 89);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(311, 42);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(329, 89);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 42);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 164);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(460, 43);
            progressBar.TabIndex = 6;
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPercentage.Location = new Point(431, 178);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(24, 15);
            lblPercentage.TabIndex = 7;
            lblPercentage.Tag = "";
            lblPercentage.Text = "0%";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 239);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(484, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(144, 17);
            lblStatus.Text = "Click \"Calculate\" to start...";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // backgroundWorker
            // 
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += backgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(statusStrip1);
            Controls.Add(lblPercentage);
            Controls.Add(progressBar);
            Controls.Add(btnCancel);
            Controls.Add(btnCalculate);
            Controls.Add(txtNumber);
            Controls.Add(label3);
            Controls.Add(lblTime);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTime;
        private Label label3;
        private TextBox txtNumber;
        private Button btnCalculate;
        private Button btnCancel;
        private ProgressBar progressBar;
        private Label lblPercentage;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}
