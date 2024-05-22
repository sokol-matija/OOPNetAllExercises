namespace Task01
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
            this.btnAddButton = new System.Windows.Forms.Button();
            this.btnControlHierarchy = new System.Windows.Forms.Button();
            this.btnAddPanel = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnAddButton
            // 
            this.btnAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddButton.Location = new System.Drawing.Point(218, 575);
            this.btnAddButton.Name = "btnAddButton";
            this.btnAddButton.Size = new System.Drawing.Size(200, 50);
            this.btnAddButton.TabIndex = 1;
            this.btnAddButton.Text = "Add Button";
            this.btnAddButton.UseVisualStyleBackColor = true;
            this.btnAddButton.Click += new System.EventHandler(this.btnAddButton_Click);
            // 
            // btnControlHierarchy
            // 
            this.btnControlHierarchy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnControlHierarchy.Location = new System.Drawing.Point(424, 575);
            this.btnControlHierarchy.Name = "btnControlHierarchy";
            this.btnControlHierarchy.Size = new System.Drawing.Size(200, 50);
            this.btnControlHierarchy.TabIndex = 2;
            this.btnControlHierarchy.Text = "Control Hierarchy (Task 02)";
            this.btnControlHierarchy.UseVisualStyleBackColor = true;
            this.btnControlHierarchy.Click += new System.EventHandler(this.btnControlHierarchy_Click);
            // 
            // btnAddPanel
            // 
            this.btnAddPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPanel.Location = new System.Drawing.Point(12, 575);
            this.btnAddPanel.Name = "btnAddPanel";
            this.btnAddPanel.Size = new System.Drawing.Size(200, 50);
            this.btnAddPanel.TabIndex = 3;
            this.btnAddPanel.Text = "Add Panel";
            this.btnAddPanel.UseVisualStyleBackColor = true;
            this.btnAddPanel.Click += new System.EventHandler(this.btnAddPanel_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(953, 557);
            this.flowLayoutPanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 637);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btnAddPanel);
            this.Controls.Add(this.btnAddButton);
            this.Controls.Add(this.btnControlHierarchy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnAddButton;
        private Button btnControlHierarchy;
        private Button btnAddPanel;
        private FlowLayoutPanel flowLayoutPanel;
    }
}