namespace AwesomePokerGameSln {
  partial class FrmTitle {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.label1 = new System.Windows.Forms.Label();
      this.btnNewGame = new System.Windows.Forms.Button();
      this.btnViewRuleBook = new System.Windows.Forms.Button();
      this.btnQuit = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.picRulebook = new System.Windows.Forms.PictureBox();
      this.gamblingHelpLbl = new System.Windows.Forms.Label();
      this.buttonSettings = new System.Windows.Forms.Button();
      this.userNameTitleLabel = new System.Windows.Forms.Label();
      this.userNameBoxTitle = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.picRulebook)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold);
      this.label1.ForeColor = System.Drawing.Color.Yellow;
      this.label1.Location = new System.Drawing.Point(-2, -38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(736, 170);
      this.label1.TabIndex = 0;
      this.label1.Text = "Awesome";
      // 
      // btnNewGame
      // 
      this.btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNewGame.Location = new System.Drawing.Point(30, 497);
      this.btnNewGame.Name = "btnNewGame";
      this.btnNewGame.Size = new System.Drawing.Size(200, 107);
      this.btnNewGame.TabIndex = 1;
      this.btnNewGame.Text = "New Game";
      this.btnNewGame.UseVisualStyleBackColor = false;
      this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
      // 
      // btnViewRuleBook
      // 
      this.btnViewRuleBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.btnViewRuleBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnViewRuleBook.Location = new System.Drawing.Point(270, 497);
      this.btnViewRuleBook.Name = "btnViewRuleBook";
      this.btnViewRuleBook.Size = new System.Drawing.Size(227, 107);
      this.btnViewRuleBook.TabIndex = 2;
      this.btnViewRuleBook.Text = "View Rule Book";
      this.btnViewRuleBook.UseVisualStyleBackColor = false;
      this.btnViewRuleBook.Click += new System.EventHandler(this.btnViewRuleBook_Click);
      // 
      // btnQuit
      // 
      this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnQuit.Location = new System.Drawing.Point(812, 497);
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(200, 107);
      this.btnQuit.TabIndex = 3;
      this.btnQuit.Text = "Quit Game";
      this.btnQuit.UseVisualStyleBackColor = false;
      this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Bold);
      this.label2.ForeColor = System.Drawing.Color.Yellow;
      this.label2.Location = new System.Drawing.Point(30, 273);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(484, 170);
      this.label2.TabIndex = 4;
      this.label2.Text = "Game";
      // 
      // picRulebook
      // 
      this.picRulebook.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.rule_book;
      this.picRulebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.picRulebook.Location = new System.Drawing.Point(245, 99);
      this.picRulebook.Name = "picRulebook";
      this.picRulebook.Size = new System.Drawing.Size(563, 363);
      this.picRulebook.TabIndex = 5;
      this.picRulebook.TabStop = false;
      this.picRulebook.Visible = false;
      // 
      // gamblingHelpLbl
      // 
      this.gamblingHelpLbl.AutoSize = true;
      this.gamblingHelpLbl.BackColor = System.Drawing.Color.Transparent;
      this.gamblingHelpLbl.Cursor = System.Windows.Forms.Cursors.Hand;
      this.gamblingHelpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.gamblingHelpLbl.ForeColor = System.Drawing.SystemColors.ScrollBar;
      this.gamblingHelpLbl.Location = new System.Drawing.Point(521, 624);
      this.gamblingHelpLbl.Name = "gamblingHelpLbl";
      this.gamblingHelpLbl.Size = new System.Drawing.Size(491, 20);
      this.gamblingHelpLbl.TabIndex = 6;
      this.gamblingHelpLbl.Text = "Gambling Addition? Click or call 1-800-GAMBLER for more help.";
      this.gamblingHelpLbl.Click += new System.EventHandler(this.label3_Click);
      // 
      // buttonSettings
      // 
      this.buttonSettings.BackColor = System.Drawing.Color.Silver;
      this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonSettings.Location = new System.Drawing.Point(542, 497);
      this.buttonSettings.Name = "buttonSettings";
      this.buttonSettings.Size = new System.Drawing.Size(227, 107);
      this.buttonSettings.TabIndex = 7;
      this.buttonSettings.Text = "Settings";
      this.buttonSettings.UseVisualStyleBackColor = false;
      this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
      // 
      // userNameTitleLabel
      // 
      this.userNameTitleLabel.AutoSize = true;
      this.userNameTitleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.userNameTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
      this.userNameTitleLabel.Location = new System.Drawing.Point(0, 0);
      this.userNameTitleLabel.Name = "userNameTitleLabel";
      this.userNameTitleLabel.Size = new System.Drawing.Size(103, 39);
      this.userNameTitleLabel.TabIndex = 7;
      this.userNameTitleLabel.Text = "Blank";
      // 
      // userNameBoxTitle
      // 
      this.userNameBoxTitle.AutoSize = true;
      this.userNameBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
      this.userNameBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.userNameBoxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
      this.userNameBoxTitle.Location = new System.Drawing.Point(789, 58);
      this.userNameBoxTitle.Name = "userNameBoxTitle";
      this.userNameBoxTitle.Size = new System.Drawing.Size(92, 38);
      this.userNameBoxTitle.TabIndex = 8;
      this.userNameBoxTitle.Text = "Blank";
      // 
      // FrmTitle
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.title_screen;
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(1041, 653);
      this.Controls.Add(this.userNameBoxTitle);
      this.Controls.Add(this.buttonSettings);
      this.Controls.Add(this.gamblingHelpLbl);
      this.Controls.Add(this.picRulebook);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnQuit);
      this.Controls.Add(this.btnViewRuleBook);
      this.Controls.Add(this.btnNewGame);
      this.Controls.Add(this.label1);
      this.KeyPreview = true;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmTitle";
      this.Text = "Awesome Poker Game";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTitle_KeyDown);
      ((System.ComponentModel.ISupportInitialize)(this.picRulebook)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnNewGame;
    private System.Windows.Forms.Button btnViewRuleBook;
    private System.Windows.Forms.Button btnQuit;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.PictureBox picRulebook;
    private System.Windows.Forms.Label gamblingHelpLbl;
    private System.Windows.Forms.Button buttonSettings;
    private System.Windows.Forms.Label userNameTitleLabel;
    private System.Windows.Forms.Label userNameBoxTitle;
    }
}

