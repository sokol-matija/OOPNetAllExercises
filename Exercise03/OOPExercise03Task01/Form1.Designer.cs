namespace OOPExercise03Task01
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
            lblPlayersInPlay = new Label();
            lblPlayersOnBench = new Label();
            lbPlayersPlaying = new ListBox();
            lbPlayersBench = new ListBox();
            btnToBenchOne = new Button();
            btnToBenchAll = new Button();
            btnToPlayOne = new Button();
            btnToPlayAll = new Button();
            cbSort = new CheckBox();
            SuspendLayout();
            // 
            // lblPlayersInPlay
            // 
            lblPlayersInPlay.AutoSize = true;
            lblPlayersInPlay.Location = new Point(12, 9);
            lblPlayersInPlay.Name = "lblPlayersInPlay";
            lblPlayersInPlay.Size = new Size(85, 15);
            lblPlayersInPlay.TabIndex = 0;
            lblPlayersInPlay.Text = "Players in play:";
            // 
            // lblPlayersOnBench
            // 
            lblPlayersOnBench.AutoSize = true;
            lblPlayersOnBench.Location = new Point(493, 9);
            lblPlayersOnBench.Name = "lblPlayersOnBench";
            lblPlayersOnBench.Size = new Size(100, 15);
            lblPlayersOnBench.TabIndex = 1;
            lblPlayersOnBench.Text = "Players on bench:";
            // 
            // lbPlayersPlaying
            // 
            lbPlayersPlaying.FormattingEnabled = true;
            lbPlayersPlaying.ItemHeight = 15;
            lbPlayersPlaying.Location = new Point(12, 27);
            lbPlayersPlaying.Name = "lbPlayersPlaying";
            lbPlayersPlaying.SelectionMode = SelectionMode.MultiSimple;
            lbPlayersPlaying.Size = new Size(295, 379);
            lbPlayersPlaying.TabIndex = 2;
            // 
            // lbPlayersBench
            // 
            lbPlayersBench.FormattingEnabled = true;
            lbPlayersBench.ItemHeight = 15;
            lbPlayersBench.Location = new Point(493, 27);
            lbPlayersBench.Name = "lbPlayersBench";
            lbPlayersBench.SelectionMode = SelectionMode.MultiSimple;
            lbPlayersBench.Size = new Size(295, 379);
            lbPlayersBench.TabIndex = 3;
            // 
            // btnToBenchOne
            // 
            btnToBenchOne.Location = new Point(313, 27);
            btnToBenchOne.Name = "btnToBenchOne";
            btnToBenchOne.Size = new Size(174, 72);
            btnToBenchOne.TabIndex = 4;
            btnToBenchOne.Text = ">";
            btnToBenchOne.UseVisualStyleBackColor = true;
            btnToBenchOne.Click += btnToBenchOne_Click;
            // 
            // btnToBenchAll
            // 
            btnToBenchAll.Location = new Point(313, 113);
            btnToBenchAll.Name = "btnToBenchAll";
            btnToBenchAll.Size = new Size(174, 72);
            btnToBenchAll.TabIndex = 5;
            btnToBenchAll.Text = ">>";
            btnToBenchAll.UseVisualStyleBackColor = true;
            btnToBenchAll.Click += btnToBenchAll_Click;
            // 
            // btnToPlayOne
            // 
            btnToPlayOne.Location = new Point(313, 256);
            btnToPlayOne.Name = "btnToPlayOne";
            btnToPlayOne.Size = new Size(174, 72);
            btnToPlayOne.TabIndex = 6;
            btnToPlayOne.Text = "<";
            btnToPlayOne.UseVisualStyleBackColor = true;
            btnToPlayOne.Click += btnToPlayOne_Click;
            // 
            // btnToPlayAll
            // 
            btnToPlayAll.Location = new Point(313, 334);
            btnToPlayAll.Name = "btnToPlayAll";
            btnToPlayAll.Size = new Size(174, 72);
            btnToPlayAll.TabIndex = 7;
            btnToPlayAll.Text = "<<";
            btnToPlayAll.UseVisualStyleBackColor = true;
            btnToPlayAll.Click += btnToPlayAll_Click;
            // 
            // cbSort
            // 
            cbSort.AutoSize = true;
            cbSort.Location = new Point(359, 217);
            cbSort.Name = "cbSort";
            cbSort.Size = new Size(73, 19);
            cbSort.TabIndex = 8;
            cbSort.Text = "Sort Lists";
            cbSort.UseVisualStyleBackColor = true;
            cbSort.CheckedChanged += cbSort_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbSort);
            Controls.Add(btnToPlayAll);
            Controls.Add(btnToPlayOne);
            Controls.Add(btnToBenchAll);
            Controls.Add(btnToBenchOne);
            Controls.Add(lbPlayersBench);
            Controls.Add(lbPlayersPlaying);
            Controls.Add(lblPlayersOnBench);
            Controls.Add(lblPlayersInPlay);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPlayersInPlay;
        private Label lblPlayersOnBench;
        private ListBox lbPlayersPlaying;
        private ListBox lbPlayersBench;
        private Button btnToBenchOne;
        private Button btnToBenchAll;
        private Button btnToPlayOne;
        private Button btnToPlayAll;
        private CheckBox cbSort;
    }
}
