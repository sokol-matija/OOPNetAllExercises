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
            this.label1 = new System.Windows.Forms.Label();
            this.lbPlayersPlaying = new System.Windows.Forms.ListBox();
            this.lbPlayersBanch = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnToBanchOne = new System.Windows.Forms.Button();
            this.btnToBanchAll = new System.Windows.Forms.Button();
            this.btnInGameOne = new System.Windows.Forms.Button();
            this.btnInGameAll = new System.Windows.Forms.Button();
            this.cbSort = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Players playing";
            // 
            // lbPlayersPlaying
            // 
            this.lbPlayersPlaying.FormattingEnabled = true;
            this.lbPlayersPlaying.ItemHeight = 15;
            this.lbPlayersPlaying.Location = new System.Drawing.Point(12, 27);
            this.lbPlayersPlaying.Name = "lbPlayersPlaying";
            this.lbPlayersPlaying.Size = new System.Drawing.Size(300, 409);
            this.lbPlayersPlaying.TabIndex = 1;
            // 
            // lbPlayersBanch
            // 
            this.lbPlayersBanch.FormattingEnabled = true;
            this.lbPlayersBanch.ItemHeight = 15;
            this.lbPlayersBanch.Location = new System.Drawing.Point(488, 27);
            this.lbPlayersBanch.Name = "lbPlayersBanch";
            this.lbPlayersBanch.Size = new System.Drawing.Size(300, 409);
            this.lbPlayersBanch.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(488, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Players on banch";
            // 
            // btnToBanchOne
            // 
            this.btnToBanchOne.Location = new System.Drawing.Point(318, 27);
            this.btnToBanchOne.Name = "btnToBanchOne";
            this.btnToBanchOne.Size = new System.Drawing.Size(164, 51);
            this.btnToBanchOne.TabIndex = 4;
            this.btnToBanchOne.Text = ">";
            this.btnToBanchOne.UseVisualStyleBackColor = true;
            this.btnToBanchOne.Click += new System.EventHandler(this.BtnToBanchOne_Click);
            // 
            // btnToBanchAll
            // 
            this.btnToBanchAll.Location = new System.Drawing.Point(318, 84);
            this.btnToBanchAll.Name = "btnToBanchAll";
            this.btnToBanchAll.Size = new System.Drawing.Size(164, 51);
            this.btnToBanchAll.TabIndex = 5;
            this.btnToBanchAll.Text = ">>";
            this.btnToBanchAll.UseVisualStyleBackColor = true;
            this.btnToBanchAll.Click += new System.EventHandler(this.BtnToBanchAll_Click);
            // 
            // btnInGameOne
            // 
            this.btnInGameOne.Location = new System.Drawing.Point(318, 385);
            this.btnInGameOne.Name = "btnInGameOne";
            this.btnInGameOne.Size = new System.Drawing.Size(164, 51);
            this.btnInGameOne.TabIndex = 6;
            this.btnInGameOne.Text = "<";
            this.btnInGameOne.UseVisualStyleBackColor = true;
            this.btnInGameOne.Click += new System.EventHandler(this.BtnInGameOne_Click);
            // 
            // btnInGameAll
            // 
            this.btnInGameAll.Location = new System.Drawing.Point(318, 328);
            this.btnInGameAll.Name = "btnInGameAll";
            this.btnInGameAll.Size = new System.Drawing.Size(164, 51);
            this.btnInGameAll.TabIndex = 7;
            this.btnInGameAll.Text = "<<";
            this.btnInGameAll.UseVisualStyleBackColor = true;
            this.btnInGameAll.Click += new System.EventHandler(this.BtnInGameAll_Click);
            // 
            // cbSort
            // 
            this.cbSort.AutoSize = true;
            this.cbSort.Location = new System.Drawing.Point(359, 216);
            this.cbSort.Name = "cbSort";
            this.cbSort.Size = new System.Drawing.Size(70, 19);
            this.cbSort.TabIndex = 8;
            this.cbSort.Text = "Sort lists";
            this.cbSort.UseVisualStyleBackColor = true;
            this.cbSort.CheckedChanged += new System.EventHandler(this.CbSort_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbSort);
            this.Controls.Add(this.btnInGameAll);
            this.Controls.Add(this.btnInGameOne);
            this.Controls.Add(this.btnToBanchAll);
            this.Controls.Add(this.btnToBanchOne);
            this.Controls.Add(this.lbPlayersBanch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPlayersPlaying);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListBox lbPlayersPlaying;
        private ListBox lbPlayersBanch;
        private Label label2;
        private Button btnToBanchOne;
        private Button btnToBanchAll;
        private Button btnInGameOne;
        private Button btnInGameAll;
        private CheckBox cbSort;
    }
}