namespace RPSGame
{
    partial class Game_Page
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
            this.RestartButton = new System.Windows.Forms.Button();
            this.RockButton = new System.Windows.Forms.Button();
            this.PaperButton = new System.Windows.Forms.Button();
            this.ScissorButton = new System.Windows.Forms.Button();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.PlayerScoreLabel = new System.Windows.Forms.Label();
            this.CypherLabel = new System.Windows.Forms.Label();
            this.cypherScoreLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.playerChoice = new System.Windows.Forms.Label();
            this.cpuChoice = new System.Windows.Forms.Label();
            this.RoundCount = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.countDown = new System.Windows.Forms.Timer(this.components);
            this.cypherImage = new System.Windows.Forms.PictureBox();
            this.playerImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cypherImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.Location = new System.Drawing.Point(349, 398);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(103, 40);
            this.RestartButton.TabIndex = 2;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // RockButton
            // 
            this.RockButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RockButton.Location = new System.Drawing.Point(12, 304);
            this.RockButton.Name = "RockButton";
            this.RockButton.Size = new System.Drawing.Size(75, 38);
            this.RockButton.TabIndex = 3;
            this.RockButton.Text = "Rock";
            this.RockButton.UseVisualStyleBackColor = true;
            this.RockButton.Click += new System.EventHandler(this.RockButton_Click);
            // 
            // PaperButton
            // 
            this.PaperButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaperButton.Location = new System.Drawing.Point(93, 304);
            this.PaperButton.Name = "PaperButton";
            this.PaperButton.Size = new System.Drawing.Size(72, 38);
            this.PaperButton.TabIndex = 4;
            this.PaperButton.Text = "Paper";
            this.PaperButton.UseVisualStyleBackColor = true;
            this.PaperButton.Click += new System.EventHandler(this.PaperButton_Click);
            // 
            // ScissorButton
            // 
            this.ScissorButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScissorButton.Location = new System.Drawing.Point(171, 304);
            this.ScissorButton.Name = "ScissorButton";
            this.ScissorButton.Size = new System.Drawing.Size(86, 38);
            this.ScissorButton.TabIndex = 5;
            this.ScissorButton.Text = "Scissor";
            this.ScissorButton.UseVisualStyleBackColor = true;
            this.ScissorButton.Click += new System.EventHandler(this.ScissorButton_Click);
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerNameLabel.Location = new System.Drawing.Point(266, 105);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(72, 22);
            this.playerNameLabel.TabIndex = 6;
            this.playerNameLabel.Text = "Player :";
            // 
            // PlayerScoreLabel
            // 
            this.PlayerScoreLabel.AutoSize = true;
            this.PlayerScoreLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScoreLabel.Location = new System.Drawing.Point(345, 105);
            this.PlayerScoreLabel.Name = "PlayerScoreLabel";
            this.PlayerScoreLabel.Size = new System.Drawing.Size(20, 22);
            this.PlayerScoreLabel.TabIndex = 7;
            this.PlayerScoreLabel.Text = "0";
            // 
            // CypherLabel
            // 
            this.CypherLabel.AutoSize = true;
            this.CypherLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CypherLabel.Location = new System.Drawing.Point(427, 103);
            this.CypherLabel.Name = "CypherLabel";
            this.CypherLabel.Size = new System.Drawing.Size(77, 22);
            this.CypherLabel.TabIndex = 8;
            this.CypherLabel.Text = "Cypher :";
            // 
            // cypherScoreLabel
            // 
            this.cypherScoreLabel.AutoSize = true;
            this.cypherScoreLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cypherScoreLabel.Location = new System.Drawing.Point(510, 103);
            this.cypherScoreLabel.Name = "cypherScoreLabel";
            this.cypherScoreLabel.Size = new System.Drawing.Size(20, 22);
            this.cypherScoreLabel.TabIndex = 9;
            this.cypherScoreLabel.Text = "0";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(365, 59);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(58, 24);
            this.ScoreLabel.TabIndex = 10;
            this.ScoreLabel.Text = "Score";
            // 
            // playerChoice
            // 
            this.playerChoice.AutoSize = true;
            this.playerChoice.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerChoice.Location = new System.Drawing.Point(68, 265);
            this.playerChoice.Name = "playerChoice";
            this.playerChoice.Size = new System.Drawing.Size(131, 24);
            this.playerChoice.TabIndex = 11;
            this.playerChoice.Text = "Player Choice";
            // 
            // cpuChoice
            // 
            this.cpuChoice.AutoSize = true;
            this.cpuChoice.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuChoice.Location = new System.Drawing.Point(606, 274);
            this.cpuChoice.Name = "cpuChoice";
            this.cpuChoice.Size = new System.Drawing.Size(138, 24);
            this.cpuChoice.TabIndex = 12;
            this.cpuChoice.Text = "Cypher Choice";
            // 
            // RoundCount
            // 
            this.RoundCount.AutoSize = true;
            this.RoundCount.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoundCount.Location = new System.Drawing.Point(331, 249);
            this.RoundCount.Name = "RoundCount";
            this.RoundCount.Size = new System.Drawing.Size(94, 24);
            this.RoundCount.TabIndex = 13;
            this.RoundCount.Text = "Rounds : ";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(431, 249);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(21, 24);
            this.countLabel.TabIndex = 14;
            this.countLabel.Text = "0";
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(14, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 36);
            this.backButton.TabIndex = 15;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(386, 171);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(24, 26);
            this.timerLabel.TabIndex = 18;
            this.timerLabel.Text = "5";
            // 
            // countDown
            // 
            this.countDown.Interval = 1000;
            this.countDown.Tick += new System.EventHandler(this.countDown_Tick);
            // 
            // cypherImage
            // 
            this.cypherImage.Image = global::RPSGame.Properties.Resources.questionMark;
            this.cypherImage.Location = new System.Drawing.Point(556, 81);
            this.cypherImage.Name = "cypherImage";
            this.cypherImage.Size = new System.Drawing.Size(218, 181);
            this.cypherImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cypherImage.TabIndex = 17;
            this.cypherImage.TabStop = false;
            // 
            // playerImage
            // 
            this.playerImage.Image = global::RPSGame.Properties.Resources.questionMark;
            this.playerImage.Location = new System.Drawing.Point(14, 81);
            this.playerImage.Name = "playerImage";
            this.playerImage.Size = new System.Drawing.Size(218, 181);
            this.playerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerImage.TabIndex = 16;
            this.playerImage.TabStop = false;
            // 
            // Game_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.cypherImage);
            this.Controls.Add(this.playerImage);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.RoundCount);
            this.Controls.Add(this.cpuChoice);
            this.Controls.Add(this.playerChoice);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.cypherScoreLabel);
            this.Controls.Add(this.CypherLabel);
            this.Controls.Add(this.PlayerScoreLabel);
            this.Controls.Add(this.playerNameLabel);
            this.Controls.Add(this.ScissorButton);
            this.Controls.Add(this.PaperButton);
            this.Controls.Add(this.RockButton);
            this.Controls.Add(this.RestartButton);
            this.Name = "Game_Page";
            this.Text = "Game Page";
            ((System.ComponentModel.ISupportInitialize)(this.cypherImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button RockButton;
        private System.Windows.Forms.Button PaperButton;
        private System.Windows.Forms.Button ScissorButton;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label PlayerScoreLabel;
        private System.Windows.Forms.Label CypherLabel;
        private System.Windows.Forms.Label cypherScoreLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label playerChoice;
        private System.Windows.Forms.Label cpuChoice;
        private System.Windows.Forms.Label RoundCount;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox playerImage;
        private System.Windows.Forms.PictureBox cypherImage;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer countDown;
    }
}