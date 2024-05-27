namespace OOPExercise07Task01_05
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
            btnPrint = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            nudCopyesCount = new NumericUpDown();
            printDocument = new System.Drawing.Printing.PrintDocument();
            printDialog = new PrintDialog();
            printPreviewDialog = new PrintPreviewDialog();
            pageSetupDialog = new PageSetupDialog();
            ((System.ComponentModel.ISupportInitialize)nudCopyesCount).BeginInit();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(12, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(360, 271);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += Print_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 289);
            button2.Name = "button2";
            button2.Size = new Size(174, 23);
            button2.TabIndex = 1;
            button2.Text = "Select Margins";
            button2.UseVisualStyleBackColor = true;
            button2.Click += SelectMargin_Click;
            // 
            // button3
            // 
            button3.Location = new Point(198, 289);
            button3.Name = "button3";
            button3.Size = new Size(174, 23);
            button3.TabIndex = 2;
            button3.Text = "Preview";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Preview_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 315);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // nudCopyesCount
            // 
            nudCopyesCount.Location = new Point(12, 333);
            nudCopyesCount.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nudCopyesCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCopyesCount.Name = "nudCopyesCount";
            nudCopyesCount.Size = new Size(360, 23);
            nudCopyesCount.TabIndex = 4;
            nudCopyesCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // printDocument
            // 
            printDocument.EndPrint += printDocument_EndPrint;
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // printDialog
            // 
            printDialog.Document = printDocument;
            printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Enabled = true;
            printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
            printPreviewDialog.Name = "printPreviewDialog";
            printPreviewDialog.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(nudCopyesCount);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnPrint);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudCopyesCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrint;
        private Button button2;
        private Button button3;
        private Label label1;
        private NumericUpDown nudCopyesCount;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintDialog printDialog;
        private PrintPreviewDialog printPreviewDialog;
        private PageSetupDialog pageSetupDialog;
    }
}
