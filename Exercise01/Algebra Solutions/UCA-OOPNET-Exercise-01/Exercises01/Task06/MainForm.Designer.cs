namespace Task06
{
    partial class MainForm
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
            this.btnAddPanel = new System.Windows.Forms.Button();
            this.btnAddButton = new System.Windows.Forms.Button();
            this.btnRemovePanels = new System.Windows.Forms.Button();
            this.btnRemoveButtons = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAddPanel
            // 
            this.btnAddPanel.Location = new System.Drawing.Point(12, 499);
            this.btnAddPanel.Name = "btnAddPanel";
            this.btnAddPanel.Size = new System.Drawing.Size(150, 50);
            this.btnAddPanel.TabIndex = 0;
            this.btnAddPanel.Text = "Add panel";
            this.btnAddPanel.UseVisualStyleBackColor = true;
            this.btnAddPanel.Click += new System.EventHandler(this.AddPanel_Click);
            // 
            // btnAddButton
            // 
            this.btnAddButton.Location = new System.Drawing.Point(215, 499);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(150, 50);
            this.btnAddButton.TabIndex = 1;
            this.btnAddButton.Text = "Add button";
            this.btnAddButton.UseVisualStyleBackColor = true;
            this.btnAddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // btnRemovePanels
            // 
            this.btnRemovePanels.Location = new System.Drawing.Point(418, 499);
            this.btnRemovePanels.Name = "btnRemovePanels";
            this.btnRemovePanels.Size = new System.Drawing.Size(150, 50);
            this.btnRemovePanels.TabIndex = 2;
            this.btnRemovePanels.Text = "Remove all panels";
            this.btnRemovePanels.UseVisualStyleBackColor = true;
            this.btnRemovePanels.Click += new System.EventHandler(this.RemovePanels_Click);
            // 
            // btnRemoveButtons
            // 
            this.btnRemoveButtons.Location = new System.Drawing.Point(621, 499);
            this.btnRemoveButtons.Name = "btnRemoveButtons";
            this.btnRemoveButtons.Size = new System.Drawing.Size(150, 50);
            this.btnRemoveButtons.TabIndex = 3;
            this.btnRemoveButtons.Text = "Remove all buttons";
            this.btnRemoveButtons.UseVisualStyleBackColor = true;
            this.btnRemoveButtons.Click += new System.EventHandler(this.RemoveButtons_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(784, 493);
            this.pnlContainer.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnRemoveButtons);
            this.Controls.Add(this.btnRemovePanels);
            this.Controls.Add(this.btnAddButton);
            this.Controls.Add(this.btnAddPanel);
            this.Name = "MainForm";
            this.Text = "Form";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddPanel;
        private Button btnAddButton;
        private Button btnRemovePanels;
        private Button btnRemoveButtons;
        private Panel pnlContainer;
    }
}