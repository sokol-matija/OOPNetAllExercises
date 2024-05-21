namespace Zadatak01
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sHowPicturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monkeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tigerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.pictureContainer = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmsPicture = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.foxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.monkeyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tigerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContainer)).BeginInit();
            this.cmsPicture.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sHowPicturesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1053, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1053, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 705);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1053, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sHowPicturesToolStripMenuItem
            // 
            this.sHowPicturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foxToolStripMenuItem,
            this.monkeyToolStripMenuItem,
            this.tigerToolStripMenuItem});
            this.sHowPicturesToolStripMenuItem.Name = "sHowPicturesToolStripMenuItem";
            this.sHowPicturesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.sHowPicturesToolStripMenuItem.Text = "Show pictures";
            // 
            // foxToolStripMenuItem
            // 
            this.foxToolStripMenuItem.Image = global::Zadatak01.Properties.Resources.fox;
            this.foxToolStripMenuItem.Name = "foxToolStripMenuItem";
            this.foxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.foxToolStripMenuItem.Text = "Fox";
            this.foxToolStripMenuItem.Click += new System.EventHandler(this.OnPictureSelectEventhandler);
            // 
            // monkeyToolStripMenuItem
            // 
            this.monkeyToolStripMenuItem.Image = global::Zadatak01.Properties.Resources.monkey;
            this.monkeyToolStripMenuItem.Name = "monkeyToolStripMenuItem";
            this.monkeyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monkeyToolStripMenuItem.Text = "Monkey";
            this.monkeyToolStripMenuItem.Click += new System.EventHandler(this.OnPictureSelectEventhandler);
            // 
            // tigerToolStripMenuItem
            // 
            this.tigerToolStripMenuItem.Image = global::Zadatak01.Properties.Resources.tiger;
            this.tigerToolStripMenuItem.Name = "tigerToolStripMenuItem";
            this.tigerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tigerToolStripMenuItem.Text = "Tiger";
            this.tigerToolStripMenuItem.Click += new System.EventHandler(this.OnPictureSelectEventhandler);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Zadatak01.Properties.Resources.fox;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Fox";
            this.toolStripButton1.Click += new System.EventHandler(this.OnPictureSelectEventhandler);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Zadatak01.Properties.Resources.monkey;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Monkey";
            this.toolStripButton2.Click += new System.EventHandler(this.OnPictureSelectEventhandler);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Zadatak01.Properties.Resources.tiger;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Tiger";
            this.toolStripButton3.Click += new System.EventHandler(this.OnPictureSelectEventhandler);
            // 
            // pictureContainer
            // 
            this.pictureContainer.ContextMenuStrip = this.cmsPicture;
            this.pictureContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureContainer.Image = global::Zadatak01.Properties.Resources.start;
            this.pictureContainer.Location = new System.Drawing.Point(0, 49);
            this.pictureContainer.Name = "pictureContainer";
            this.pictureContainer.Size = new System.Drawing.Size(1053, 656);
            this.pictureContainer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureContainer.TabIndex = 3;
            this.pictureContainer.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // cmsPicture
            // 
            this.cmsPicture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foxToolStripMenuItem1,
            this.monkeyToolStripMenuItem1,
            this.tigerToolStripMenuItem1,
            this.resetToolStripMenuItem});
            this.cmsPicture.Name = "cmsPicture";
            this.cmsPicture.Size = new System.Drawing.Size(118, 92);
            // 
            // foxToolStripMenuItem1
            // 
            this.foxToolStripMenuItem1.Image = global::Zadatak01.Properties.Resources.fox;
            this.foxToolStripMenuItem1.Name = "foxToolStripMenuItem1";
            this.foxToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.foxToolStripMenuItem1.Text = "Fox";
            this.foxToolStripMenuItem1.Click += new System.EventHandler(this.OnPictureSelectEventhandler);
            // 
            // monkeyToolStripMenuItem1
            // 
            this.monkeyToolStripMenuItem1.Image = global::Zadatak01.Properties.Resources.monkey;
            this.monkeyToolStripMenuItem1.Name = "monkeyToolStripMenuItem1";
            this.monkeyToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.monkeyToolStripMenuItem1.Text = "Monkey";
            this.monkeyToolStripMenuItem1.Click += new System.EventHandler(this.OnPictureSelectEventhandler);
            // 
            // tigerToolStripMenuItem1
            // 
            this.tigerToolStripMenuItem1.Image = global::Zadatak01.Properties.Resources.tiger;
            this.tigerToolStripMenuItem1.Name = "tigerToolStripMenuItem1";
            this.tigerToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.tigerToolStripMenuItem1.Text = "Tiger";
            this.tigerToolStripMenuItem1.Click += new System.EventHandler(this.OnPictureSelectEventhandler);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Image = global::Zadatak01.Properties.Resources.start;
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.OnPictureSelectEventhandler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 727);
            this.Controls.Add(this.pictureContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureContainer)).EndInit();
            this.cmsPicture.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sHowPicturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monkeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tigerToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripStatusLabel lblInfo;
        private System.Windows.Forms.PictureBox pictureContainer;
        private System.Windows.Forms.ContextMenuStrip cmsPicture;
        private System.Windows.Forms.ToolStripMenuItem foxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem monkeyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tigerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}

