namespace OOPExercise01Task06
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
            btnAddPanel = new Button();
            btnAddButton = new Button();
            btnRemoveAllPanels = new Button();
            btnRemoveAllButtons = new Button();
            pnlContainer = new Panel();
            SuspendLayout();
            // 
            // btnAddPanel
            // 
            btnAddPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddPanel.Location = new Point(42, 374);
            btnAddPanel.Name = "btnAddPanel";
            btnAddPanel.Size = new Size(152, 51);
            btnAddPanel.TabIndex = 0;
            btnAddPanel.Text = "Add Panel";
            btnAddPanel.UseVisualStyleBackColor = true;
            btnAddPanel.Click += btnAddPanel_Click;
            // 
            // btnAddButton
            // 
            btnAddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddButton.Location = new Point(227, 374);
            btnAddButton.Name = "btnAddButton";
            btnAddButton.Size = new Size(152, 51);
            btnAddButton.TabIndex = 1;
            btnAddButton.Text = "Add Button";
            btnAddButton.UseVisualStyleBackColor = true;
            btnAddButton.Click += btnAddButton_Click;
            // 
            // btnRemoveAllPanels
            // 
            btnRemoveAllPanels.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveAllPanels.Location = new Point(412, 374);
            btnRemoveAllPanels.Name = "btnRemoveAllPanels";
            btnRemoveAllPanels.Size = new Size(152, 51);
            btnRemoveAllPanels.TabIndex = 2;
            btnRemoveAllPanels.Text = "Remove All Panels";
            btnRemoveAllPanels.UseVisualStyleBackColor = true;
            btnRemoveAllPanels.Click += btnRemoveAllPanels_Click;
            // 
            // btnRemoveAllButtons
            // 
            btnRemoveAllButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveAllButtons.Location = new Point(597, 374);
            btnRemoveAllButtons.Name = "btnRemoveAllButtons";
            btnRemoveAllButtons.Size = new Size(152, 51);
            btnRemoveAllButtons.TabIndex = 3;
            btnRemoveAllButtons.Text = "Remove All Buttons";
            btnRemoveAllButtons.UseVisualStyleBackColor = true;
            btnRemoveAllButtons.Click += btnRemoveAllButtons_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.Dock = DockStyle.Top;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(800, 368);
            pnlContainer.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContainer);
            Controls.Add(btnRemoveAllButtons);
            Controls.Add(btnRemoveAllPanels);
            Controls.Add(btnAddButton);
            Controls.Add(btnAddPanel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddPanel;
        private Button btnAddButton;
        private Button btnRemoveAllPanels;
        private Button btnRemoveAllButtons;
        private Panel pnlContainer;
    }
}
