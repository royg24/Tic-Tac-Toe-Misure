namespace Reversed_Tic_Tac_Toe
{
    partial class GameSettingsForm
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
            this.PlayersLabel = new System.Windows.Forms.Label();
            this.Player1TextBox = new System.Windows.Forms.TextBox();
            this.Player1Label = new System.Windows.Forms.Label();
            this.Player2CheckBox = new System.Windows.Forms.CheckBox();
            this.Player2TextBox = new System.Windows.Forms.TextBox();
            this.BaordSizeLabel = new System.Windows.Forms.Label();
            this.RowsLabel = new System.Windows.Forms.Label();
            this.ColsLabel = new System.Windows.Forms.Label();
            this.RowsUpDown = new System.Windows.Forms.NumericUpDown();
            this.ColsUpDown = new System.Windows.Forms.NumericUpDown();
            this.ButtonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RowsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayersLabel
            // 
            this.PlayersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayersLabel.AutoSize = true;
            this.PlayersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayersLabel.Location = new System.Drawing.Point(39, 9);
            this.PlayersLabel.Name = "PlayersLabel";
            this.PlayersLabel.Size = new System.Drawing.Size(75, 22);
            this.PlayersLabel.TabIndex = 1;
            this.PlayersLabel.Text = "Players:";
            this.PlayersLabel.Click += new System.EventHandler(this.PlayersLabel_Click);
            // 
            // Player1TextBox
            // 
            this.Player1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player1TextBox.Location = new System.Drawing.Point(194, 41);
            this.Player1TextBox.Name = "Player1TextBox";
            this.Player1TextBox.Size = new System.Drawing.Size(136, 26);
            this.Player1TextBox.TabIndex = 2;
            this.Player1TextBox.TextChanged += new System.EventHandler(this.Player1TextBox_TextChanged);
            // 
            // Player1Label
            // 
            this.Player1Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player1Label.AutoSize = true;
            this.Player1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Label.Location = new System.Drawing.Point(74, 46);
            this.Player1Label.Name = "Player1Label";
            this.Player1Label.Size = new System.Drawing.Size(69, 20);
            this.Player1Label.TabIndex = 3;
            this.Player1Label.Text = "Player 1:";
            this.Player1Label.Click += new System.EventHandler(this.Plaer1Label_Click);
            // 
            // Player2CheckBox
            // 
            this.Player2CheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2CheckBox.AutoSize = true;
            this.Player2CheckBox.Location = new System.Drawing.Point(78, 85);
            this.Player2CheckBox.Name = "Player2CheckBox";
            this.Player2CheckBox.Size = new System.Drawing.Size(95, 24);
            this.Player2CheckBox.TabIndex = 4;
            this.Player2CheckBox.Text = "Player 2:";
            this.Player2CheckBox.UseVisualStyleBackColor = true;
            this.Player2CheckBox.CheckedChanged += new System.EventHandler(this.Player2CheckBox_CheckedChanged);
            // 
            // Player2TextBox
            // 
            this.Player2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2TextBox.Enabled = false;
            this.Player2TextBox.Location = new System.Drawing.Point(194, 83);
            this.Player2TextBox.Name = "Player2TextBox";
            this.Player2TextBox.Size = new System.Drawing.Size(136, 26);
            this.Player2TextBox.TabIndex = 5;
            this.Player2TextBox.Text = "[Computer]";
            // 
            // BaordSizeLabel
            // 
            this.BaordSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BaordSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaordSizeLabel.Location = new System.Drawing.Point(20, 131);
            this.BaordSizeLabel.Name = "BaordSizeLabel";
            this.BaordSizeLabel.Size = new System.Drawing.Size(93, 26);
            this.BaordSizeLabel.TabIndex = 6;
            this.BaordSizeLabel.Text = "Board Size:";
            this.BaordSizeLabel.Click += new System.EventHandler(this.BaordSizeLabel_Click);
            // 
            // RowsLabel
            // 
            this.RowsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RowsLabel.AutoSize = true;
            this.RowsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RowsLabel.Location = new System.Drawing.Point(35, 173);
            this.RowsLabel.Name = "RowsLabel";
            this.RowsLabel.Size = new System.Drawing.Size(60, 22);
            this.RowsLabel.TabIndex = 7;
            this.RowsLabel.Text = "Rows:";
            // 
            // ColsLabel
            // 
            this.ColsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColsLabel.AutoSize = true;
            this.ColsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColsLabel.Location = new System.Drawing.Point(190, 173);
            this.ColsLabel.Name = "ColsLabel";
            this.ColsLabel.Size = new System.Drawing.Size(51, 22);
            this.ColsLabel.TabIndex = 8;
            this.ColsLabel.Text = "Cols:";
            this.ColsLabel.Click += new System.EventHandler(this.ColsLabel_Click);
            // 
            // RowsUpDown
            // 
            this.RowsUpDown.AllowDrop = true;
            this.RowsUpDown.Location = new System.Drawing.Point(101, 173);
            this.RowsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RowsUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.RowsUpDown.Name = "RowsUpDown";
            this.RowsUpDown.Size = new System.Drawing.Size(57, 26);
            this.RowsUpDown.TabIndex = 9;
            this.RowsUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.RowsUpDown.ValueChanged += new System.EventHandler(this.RowsUpDown_ValueChanged);
            // 
            // ColsUpDown
            // 
            this.ColsUpDown.AllowDrop = true;
            this.ColsUpDown.Location = new System.Drawing.Point(257, 173);
            this.ColsUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ColsUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ColsUpDown.Name = "ColsUpDown";
            this.ColsUpDown.Size = new System.Drawing.Size(57, 26);
            this.ColsUpDown.TabIndex = 10;
            this.ColsUpDown.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ColsUpDown.ValueChanged += new System.EventHandler(this.ColsUpDown_ValueChanged);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonStart.Location = new System.Drawing.Point(66, 229);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(198, 29);
            this.ButtonStart.TabIndex = 11;
            this.ButtonStart.Text = "Start!";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Clicked);
            // 
            // GameSettingsForm
            // 
            this.AcceptButton = this.ButtonStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(337, 266);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ColsUpDown);
            this.Controls.Add(this.RowsUpDown);
            this.Controls.Add(this.ColsLabel);
            this.Controls.Add(this.RowsLabel);
            this.Controls.Add(this.BaordSizeLabel);
            this.Controls.Add(this.Player2TextBox);
            this.Controls.Add(this.Player2CheckBox);
            this.Controls.Add(this.Player1Label);
            this.Controls.Add(this.Player1TextBox);
            this.Controls.Add(this.PlayersLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.Load += new System.EventHandler(this.GameSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RowsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PlayersLabel;
        private System.Windows.Forms.TextBox Player1TextBox;
        private System.Windows.Forms.Label Player1Label;
        private System.Windows.Forms.CheckBox Player2CheckBox;
        private System.Windows.Forms.TextBox Player2TextBox;
        private System.Windows.Forms.Label BaordSizeLabel;
        private System.Windows.Forms.Label RowsLabel;
        private System.Windows.Forms.Label ColsLabel;
        private System.Windows.Forms.NumericUpDown RowsUpDown;
        private System.Windows.Forms.NumericUpDown ColsUpDown;
        private System.Windows.Forms.Button ButtonStart;
    }
}

