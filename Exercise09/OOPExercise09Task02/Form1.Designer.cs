namespace OOPExercise09Task02
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
            lblCurrentTime = new Label();
            lblTime = new Label();
            label3 = new Label();
            tbNumber = new TextBox();
            lblResult = new Label();
            btnCalculate = new Button();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblCurrentTime
            // 
            lblCurrentTime.AutoSize = true;
            lblCurrentTime.Location = new Point(12, 9);
            lblCurrentTime.Name = "lblCurrentTime";
            lblCurrentTime.Size = new Size(75, 15);
            lblCurrentTime.TabIndex = 0;
            lblCurrentTime.Text = "Curent Time:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(103, 9);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(38, 15);
            lblTime.TabIndex = 1;
            lblTime.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 45);
            label3.Name = "label3";
            label3.Size = new Size(221, 15);
            label3.TabIndex = 2;
            label3.Text = "How many numbers do you want to add";
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(14, 63);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(167, 23);
            tbNumber.TabIndex = 3;
            tbNumber.Text = "500000000";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(156, 124);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(48, 15);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result...";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 94);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(129, 55);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
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
            ClientSize = new Size(323, 161);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            Controls.Add(tbNumber);
            Controls.Add(label3);
            Controls.Add(lblTime);
            Controls.Add(lblCurrentTime);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCurrentTime;
        private Label lblTime;
        private Label label3;
        private TextBox tbNumber;
        private Label lblResult;
        private Button btnCalculate;
        private System.Windows.Forms.Timer timer;
    }
}
