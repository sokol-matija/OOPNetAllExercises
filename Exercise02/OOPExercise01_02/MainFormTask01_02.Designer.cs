namespace OOPExercise01_02
{
    partial class MainFormTask01_02
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
            btnControl = new Button();
            pnlContainer = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnAddPanel
            // 
            btnAddPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddPanel.Location = new Point(12, 388);
            btnAddPanel.Name = "btnAddPanel";
            btnAddPanel.Size = new Size(150, 50);
            btnAddPanel.TabIndex = 0;
            btnAddPanel.Text = "Add panel";
            btnAddPanel.UseVisualStyleBackColor = true;
            btnAddPanel.Click += btnAddPanel_Click;
            // 
            // btnAddButton
            // 
            btnAddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddButton.Location = new Point(188, 388);
            btnAddButton.Name = "btnAddButton";
            btnAddButton.Size = new Size(150, 50);
            btnAddButton.TabIndex = 1;
            btnAddButton.Text = "Add Button";
            btnAddButton.UseVisualStyleBackColor = true;
            btnAddButton.Click += btnAddButton_Click;
            // 
            // btnControl
            // 
            btnControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnControl.Location = new Point(638, 388);
            btnControl.Name = "btnControl";
            btnControl.Size = new Size(150, 50);
            btnControl.TabIndex = 2;
            btnControl.Text = "Control Hierarchy";
            btnControl.UseVisualStyleBackColor = true;
            btnControl.Click += btnControl_Click;
            // 
            // pnlContainer
            // 
            pnlContainer.AutoScroll = true;
            pnlContainer.Dock = DockStyle.Top;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(800, 382);
            pnlContainer.TabIndex = 3;
            // 
            // MainFormTask01_02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContainer);
            Controls.Add(btnControl);
            Controls.Add(btnAddButton);
            Controls.Add(btnAddPanel);
            Name = "MainFormTask01_02";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddPanel;
        private Button btnAddButton;
        private Button btnControl;
        private FlowLayoutPanel pnlContainer;
    }
}
