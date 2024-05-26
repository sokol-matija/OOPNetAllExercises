namespace OOPExercise06Task03
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pbContainer = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lbInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadPicturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRecycle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbContainer)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.BackColor = System.Drawing.Color.Black;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.pbContainer);
            this.splitContainer.Size = new System.Drawing.Size(1064, 530);
            this.splitContainer.SplitterDistance = 154;
            this.splitContainer.TabIndex = 0;
            // 
            // pbContainer
            // 
            this.pbContainer.Location = new System.Drawing.Point(3, 0);
            this.pbContainer.Name = "pbContainer";
            this.pbContainer.Size = new System.Drawing.Size(900, 524);
            this.pbContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbContainer.TabIndex = 0;
            this.pbContainer.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.lbInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 599);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // lbInfo
            // 
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadPicturesToolStripMenuItem});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(146, 26);
            // 
            // loadPicturesToolStripMenuItem
            // 
            this.loadPicturesToolStripMenuItem.Name = "loadPicturesToolStripMenuItem";
            this.loadPicturesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.loadPicturesToolStripMenuItem.Text = "Load Pictures";
            this.loadPicturesToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // lbRecycle
            // 
            this.lbRecycle.BackColor = System.Drawing.Color.Orange;
            this.lbRecycle.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRecycle.Location = new System.Drawing.Point(0, 533);
            this.lbRecycle.Name = "lbRecycle";
            this.lbRecycle.Size = new System.Drawing.Size(1064, 66);
            this.lbRecycle.TabIndex = 3;
            this.lbRecycle.Text = "Recycle Bin";
            this.lbRecycle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 621);
            this.Controls.Add(this.lbRecycle);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbContainer)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer splitContainer;
        private PictureBox pbContainer;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar progressBar;
        private ToolStripStatusLabel lbInfo;
        private ContextMenuStrip cms;
        private ToolStripMenuItem loadPicturesToolStripMenuItem;
        private Label lbRecycle;
    }
}