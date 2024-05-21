namespace Zadatak02
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
            this.cmsFrm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paneluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paneleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukloniSvePaneleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ukloniMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFrm.SuspendLayout();
            this.cmsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsFrm
            // 
            this.cmsFrm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajToolStripMenuItem,
            this.ukloniSvePaneleToolStripMenuItem});
            this.cmsFrm.Name = "cmsFrm";
            this.cmsFrm.Size = new System.Drawing.Size(181, 70);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paneluToolStripMenuItem,
            this.paneleToolStripMenuItem,
            this.panelaToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            // 
            // paneluToolStripMenuItem
            // 
            this.paneluToolStripMenuItem.Name = "paneluToolStripMenuItem";
            this.paneluToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paneluToolStripMenuItem.Tag = "1";
            this.paneluToolStripMenuItem.Text = "1 panelu";
            this.paneluToolStripMenuItem.Click += new System.EventHandler(this.dodajPaneluEventhandler);
            // 
            // paneleToolStripMenuItem
            // 
            this.paneleToolStripMenuItem.Name = "paneleToolStripMenuItem";
            this.paneleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paneleToolStripMenuItem.Tag = "5";
            this.paneleToolStripMenuItem.Text = "5 panela";
            this.paneleToolStripMenuItem.Click += new System.EventHandler(this.dodajPaneluEventhandler);
            // 
            // panelaToolStripMenuItem
            // 
            this.panelaToolStripMenuItem.Name = "panelaToolStripMenuItem";
            this.panelaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.panelaToolStripMenuItem.Tag = "10";
            this.panelaToolStripMenuItem.Text = "10 panela";
            this.panelaToolStripMenuItem.Click += new System.EventHandler(this.dodajPaneluEventhandler);
            // 
            // ukloniSvePaneleToolStripMenuItem
            // 
            this.ukloniSvePaneleToolStripMenuItem.Name = "ukloniSvePaneleToolStripMenuItem";
            this.ukloniSvePaneleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ukloniSvePaneleToolStripMenuItem.Text = "Ukloni sve panele";
            this.ukloniSvePaneleToolStripMenuItem.Click += new System.EventHandler(this.ukloniSvePaneleToolStripMenuItem_Click);
            // 
            // cmsPanel
            // 
            this.cmsPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ukloniMeToolStripMenuItem});
            this.cmsPanel.Name = "cmsPanel";
            this.cmsPanel.Size = new System.Drawing.Size(129, 26);
            this.cmsPanel.Opened += new System.EventHandler(this.cmsPanel_Opened);
            // 
            // ukloniMeToolStripMenuItem
            // 
            this.ukloniMeToolStripMenuItem.Name = "ukloniMeToolStripMenuItem";
            this.ukloniMeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ukloniMeToolStripMenuItem.Text = "Ukloni me";
            this.ukloniMeToolStripMenuItem.Click += new System.EventHandler(this.ukloniMeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 572);
            this.Name = "Form1";
            this.Text = "Form1";
            this.cmsFrm.ResumeLayout(false);
            this.cmsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsFrm;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paneluToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paneleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukloniSvePaneleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsPanel;
        private System.Windows.Forms.ToolStripMenuItem ukloniMeToolStripMenuItem;
    }
}

