namespace OOPExercise07Task06
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
            menuStrip1 = new MenuStrip();
            printToolStripMenuItem = new ToolStripMenuItem();
            setupPagesToolStripMenuItem = new ToolStripMenuItem();
            choosePrinterToolStripMenuItem = new ToolStripMenuItem();
            previewToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem1 = new ToolStripMenuItem();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            pageSetupDialog1 = new PageSetupDialog();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { printToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setupPagesToolStripMenuItem, choosePrinterToolStripMenuItem, previewToolStripMenuItem, printToolStripMenuItem1 });
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(44, 20);
            printToolStripMenuItem.Text = "Print";
            // 
            // setupPagesToolStripMenuItem
            // 
            setupPagesToolStripMenuItem.Name = "setupPagesToolStripMenuItem";
            setupPagesToolStripMenuItem.Size = new Size(152, 22);
            setupPagesToolStripMenuItem.Text = "Setup pages";
            setupPagesToolStripMenuItem.Click += SetupPages_Click;
            // 
            // choosePrinterToolStripMenuItem
            // 
            choosePrinterToolStripMenuItem.Name = "choosePrinterToolStripMenuItem";
            choosePrinterToolStripMenuItem.Size = new Size(152, 22);
            choosePrinterToolStripMenuItem.Text = "Choose printer";
            choosePrinterToolStripMenuItem.Click += choosePrinterToolStripMenuItem_Click;
            // 
            // previewToolStripMenuItem
            // 
            previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            previewToolStripMenuItem.Size = new Size(152, 22);
            previewToolStripMenuItem.Text = "Preview";
            previewToolStripMenuItem.Click += previewToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem1
            // 
            printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            printToolStripMenuItem1.Size = new Size(152, 22);
            printToolStripMenuItem1.Text = "Print";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // pageSetupDialog1
            // 
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.EnableMetric = true;
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem setupPagesToolStripMenuItem;
        private ToolStripMenuItem choosePrinterToolStripMenuItem;
        private ToolStripMenuItem previewToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
