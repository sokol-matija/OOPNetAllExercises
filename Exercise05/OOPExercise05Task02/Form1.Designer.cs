namespace OOPExercise05Task02
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
            pnlContainer = new FlowLayoutPanel();
            cmsPanel = new ContextMenuStrip(components);
            selectColorToolStripMenuItem = new ToolStripMenuItem();
            resetColorToolStripMenuItem = new ToolStripMenuItem();
            colorDialog = new ColorDialog();
            cmsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.AutoScroll = true;
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(800, 450);
            pnlContainer.TabIndex = 0;
            // 
            // cmsPanel
            // 
            cmsPanel.Items.AddRange(new ToolStripItem[] { selectColorToolStripMenuItem, resetColorToolStripMenuItem });
            cmsPanel.Name = "cmsPanel";
            cmsPanel.Size = new Size(181, 70);
            // 
            // selectColorToolStripMenuItem
            // 
            selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            selectColorToolStripMenuItem.Size = new Size(180, 22);
            selectColorToolStripMenuItem.Text = "Select color";
            selectColorToolStripMenuItem.Click += SelectColor_Click;
            // 
            // resetColorToolStripMenuItem
            // 
            resetColorToolStripMenuItem.Name = "resetColorToolStripMenuItem";
            resetColorToolStripMenuItem.Size = new Size(180, 22);
            resetColorToolStripMenuItem.Text = "Reset color";
            resetColorToolStripMenuItem.Click += ResetColor_Click;
            // 
            // colorDialog
            // 
            colorDialog.AnyColor = true;
            colorDialog.Color = SystemColors.ActiveCaption;
            colorDialog.FullOpen = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContainer);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            cmsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlContainer;
        private ContextMenuStrip cmsPanel;
        private ColorDialog colorDialog;
        private ToolStripMenuItem selectColorToolStripMenuItem;
        private ToolStripMenuItem resetColorToolStripMenuItem;
    }
}
