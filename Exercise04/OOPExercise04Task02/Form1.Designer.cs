namespace OOPExercise04Task02
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
            cmsForm = new ContextMenuStrip(components);
            createToolStripMenuItem = new ToolStripMenuItem();
            panelToolStripMenuItem = new ToolStripMenuItem();
            panelsToolStripMenuItem = new ToolStripMenuItem();
            panelsToolStripMenuItem1 = new ToolStripMenuItem();
            removeAllPanelsToolStripMenuItem = new ToolStripMenuItem();
            cmsPanel = new ContextMenuStrip(components);
            removeToolStripMenuItem = new ToolStripMenuItem();
            changeColorToolStripMenuItem = new ToolStripMenuItem();
            cmsForm.SuspendLayout();
            cmsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // cmsForm
            // 
            cmsForm.Items.AddRange(new ToolStripItem[] { createToolStripMenuItem, removeAllPanelsToolStripMenuItem });
            cmsForm.Name = "cmsForm";
            cmsForm.Size = new Size(170, 48);
            // 
            // createToolStripMenuItem
            // 
            createToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { panelToolStripMenuItem, panelsToolStripMenuItem, panelsToolStripMenuItem1 });
            createToolStripMenuItem.Name = "createToolStripMenuItem";
            createToolStripMenuItem.Size = new Size(169, 22);
            createToolStripMenuItem.Text = "Create";
            // 
            // panelToolStripMenuItem
            // 
            panelToolStripMenuItem.Name = "panelToolStripMenuItem";
            panelToolStripMenuItem.Size = new Size(123, 22);
            panelToolStripMenuItem.Tag = "1";
            panelToolStripMenuItem.Text = "1 panel";
            panelToolStripMenuItem.Click += panelToolStripMenuItem_Click;
            // 
            // panelsToolStripMenuItem
            // 
            panelsToolStripMenuItem.Name = "panelsToolStripMenuItem";
            panelsToolStripMenuItem.Size = new Size(123, 22);
            panelsToolStripMenuItem.Tag = "5";
            panelsToolStripMenuItem.Text = "5 panels";
            panelsToolStripMenuItem.Click += panelToolStripMenuItem_Click;
            // 
            // panelsToolStripMenuItem1
            // 
            panelsToolStripMenuItem1.Name = "panelsToolStripMenuItem1";
            panelsToolStripMenuItem1.Size = new Size(123, 22);
            panelsToolStripMenuItem1.Tag = "10";
            panelsToolStripMenuItem1.Text = "10 panels";
            panelsToolStripMenuItem1.Click += panelToolStripMenuItem_Click;
            // 
            // removeAllPanelsToolStripMenuItem
            // 
            removeAllPanelsToolStripMenuItem.Name = "removeAllPanelsToolStripMenuItem";
            removeAllPanelsToolStripMenuItem.Size = new Size(169, 22);
            removeAllPanelsToolStripMenuItem.Text = "Remove all panels";
            removeAllPanelsToolStripMenuItem.Click += removeAllPanelsToolStripMenuItem_Click;
            // 
            // cmsPanel
            // 
            cmsPanel.Items.AddRange(new ToolStripItem[] { removeToolStripMenuItem, changeColorToolStripMenuItem });
            cmsPanel.Name = "cmsPanel";
            cmsPanel.Size = new Size(181, 70);
            cmsPanel.Opened += cmsPanel_Opened;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(180, 22);
            removeToolStripMenuItem.Text = "Remove";
            removeToolStripMenuItem.Click += removeToolStripMenuItem_Click;
            // 
            // changeColorToolStripMenuItem
            // 
            changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            changeColorToolStripMenuItem.Size = new Size(180, 22);
            changeColorToolStripMenuItem.Text = "Change Color";
            changeColorToolStripMenuItem.Click += changeColorToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = cmsForm;
            Name = "Form1";
            Text = "Form1";
            cmsForm.ResumeLayout(false);
            cmsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip cmsForm;
        private ToolStripMenuItem createToolStripMenuItem;
        private ToolStripMenuItem panelToolStripMenuItem;
        private ToolStripMenuItem panelsToolStripMenuItem;
        private ToolStripMenuItem panelsToolStripMenuItem1;
        private ToolStripMenuItem removeAllPanelsToolStripMenuItem;
        private ContextMenuStrip cmsPanel;
        private ToolStripMenuItem removeToolStripMenuItem;
        private ToolStripMenuItem changeColorToolStripMenuItem;
    }
}
