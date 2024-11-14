namespace RPSGame
{
    partial class Home_Page
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
            this.welcomLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.PlayerNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.numberRoundsLabel = new System.Windows.Forms.Label();
            this.roundsInput = new System.Windows.Forms.TextBox();
            this.lastNameInput = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.numerLabel = new System.Windows.Forms.Label();
            this.phoneNumberInput = new System.Windows.Forms.MaskedTextBox();
            this.saveProfileButton = new System.Windows.Forms.Button();
            this.restoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomLabel
            // 
            this.welcomLabel.AutoSize = true;
            this.welcomLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomLabel.Location = new System.Drawing.Point(155, 9);
            this.welcomLabel.Name = "welcomLabel";
            this.welcomLabel.Size = new System.Drawing.Size(489, 33);
            this.welcomLabel.TabIndex = 0;
            this.welcomLabel.Text = "Welcome to Rock Paper Scissor Gamne";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(157, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(119, 24);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "First Name :";
            // 
            // PlayerNameInput
            // 
            this.PlayerNameInput.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameInput.Location = new System.Drawing.Point(311, 64);
            this.PlayerNameInput.Name = "PlayerNameInput";
            this.PlayerNameInput.Size = new System.Drawing.Size(158, 32);
            this.PlayerNameInput.TabIndex = 2;
            this.PlayerNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "VS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cypher - CPU";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(80, 370);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(111, 46);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuitButton.Location = new System.Drawing.Point(640, 370);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(94, 46);
            this.QuitButton.TabIndex = 6;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // numberRoundsLabel
            // 
            this.numberRoundsLabel.AutoSize = true;
            this.numberRoundsLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberRoundsLabel.Location = new System.Drawing.Point(141, 236);
            this.numberRoundsLabel.Name = "numberRoundsLabel";
            this.numberRoundsLabel.Size = new System.Drawing.Size(192, 24);
            this.numberRoundsLabel.TabIndex = 7;
            this.numberRoundsLabel.Text = "Number Of Rounds :";
            // 
            // roundsInput
            // 
            this.roundsInput.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundsInput.Location = new System.Drawing.Point(339, 234);
            this.roundsInput.Name = "roundsInput";
            this.roundsInput.Size = new System.Drawing.Size(111, 32);
            this.roundsInput.TabIndex = 8;
            // 
            // lastNameInput
            // 
            this.lastNameInput.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameInput.Location = new System.Drawing.Point(311, 113);
            this.lastNameInput.Name = "lastNameInput";
            this.lastNameInput.Size = new System.Drawing.Size(158, 32);
            this.lastNameInput.TabIndex = 10;
            this.lastNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.Location = new System.Drawing.Point(157, 116);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(116, 24);
            this.lastNameLabel.TabIndex = 9;
            this.lastNameLabel.Text = "Last Name :";
            // 
            // numerLabel
            // 
            this.numerLabel.AutoSize = true;
            this.numerLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerLabel.Location = new System.Drawing.Point(127, 166);
            this.numerLabel.Name = "numerLabel";
            this.numerLabel.Size = new System.Drawing.Size(154, 24);
            this.numerLabel.TabIndex = 12;
            this.numerLabel.Text = "Phone Number :";
            // 
            // phoneNumberInput
            // 
            this.phoneNumberInput.BackColor = System.Drawing.SystemColors.Window;
            this.phoneNumberInput.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberInput.Location = new System.Drawing.Point(311, 163);
            this.phoneNumberInput.Mask = "(999) 000-0000";
            this.phoneNumberInput.Name = "phoneNumberInput";
            this.phoneNumberInput.Size = new System.Drawing.Size(151, 32);
            this.phoneNumberInput.TabIndex = 13;
            // 
            // saveProfileButton
            // 
            this.saveProfileButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveProfileButton.Location = new System.Drawing.Point(12, 282);
            this.saveProfileButton.Name = "saveProfileButton";
            this.saveProfileButton.Size = new System.Drawing.Size(132, 45);
            this.saveProfileButton.TabIndex = 14;
            this.saveProfileButton.Text = "Save Profile";
            this.saveProfileButton.UseVisualStyleBackColor = true;
            this.saveProfileButton.Click += new System.EventHandler(this.saveProfileButton_Click);
            // 
            // restoreButton
            // 
            this.restoreButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restoreButton.Location = new System.Drawing.Point(150, 282);
            this.restoreButton.Name = "restoreButton";
            this.restoreButton.Size = new System.Drawing.Size(133, 43);
            this.restoreButton.TabIndex = 15;
            this.restoreButton.Text = "View Profile";
            this.restoreButton.UseVisualStyleBackColor = true;
            this.restoreButton.Click += new System.EventHandler(this.restoreButton_Click);
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restoreButton);
            this.Controls.Add(this.saveProfileButton);
            this.Controls.Add(this.phoneNumberInput);
            this.Controls.Add(this.numerLabel);
            this.Controls.Add(this.lastNameInput);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.roundsInput);
            this.Controls.Add(this.numberRoundsLabel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlayerNameInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.welcomLabel);
            this.Name = "Home_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home_Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox PlayerNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Label numberRoundsLabel;
        private System.Windows.Forms.TextBox roundsInput;
        private System.Windows.Forms.TextBox lastNameInput;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label numerLabel;
        private System.Windows.Forms.MaskedTextBox phoneNumberInput;
        private System.Windows.Forms.Button saveProfileButton;
        private System.Windows.Forms.Button restoreButton;
    }
}

