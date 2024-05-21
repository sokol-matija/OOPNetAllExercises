namespace Task02
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.pnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.contextMenuColor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(532, 566);
            this.pnlContainer.TabIndex = 0;
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.Color.Yellow;
            this.colorDialog.FullOpen = true;
            // 
            // contextMenuColor
            // 
            this.contextMenuColor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuColor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectColorToolStripMenuItem,
            this.deleteColorToolStripMenuItem});
            this.contextMenuColor.Name = "cms";
            this.contextMenuColor.Size = new System.Drawing.Size(161, 52);
            // 
            // selectColorToolStripMenuItem
            // 
            this.selectColorToolStripMenuItem.Name = "selectColorToolStripMenuItem";
            this.selectColorToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.selectColorToolStripMenuItem.Text = "Select color";
            this.selectColorToolStripMenuItem.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // deleteColorToolStripMenuItem
            // 
            this.deleteColorToolStripMenuItem.Name = "deleteColorToolStripMenuItem";
            this.deleteColorToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.deleteColorToolStripMenuItem.Text = "Delete color";
            this.deleteColorToolStripMenuItem.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 566);
            this.Controls.Add(this.pnlContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Task 02";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlContainer;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuColor;
        private System.Windows.Forms.ToolStripMenuItem selectColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteColorToolStripMenuItem;
    }
}

