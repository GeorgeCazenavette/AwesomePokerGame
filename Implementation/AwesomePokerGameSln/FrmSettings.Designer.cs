namespace AwesomePokerGameSln
{
    partial class FrmSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblMuteText = new System.Windows.Forms.Label();
            this.picUnmute = new System.Windows.Forms.PictureBox();
            this.picMute = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picBlueCard = new System.Windows.Forms.PictureBox();
            this.picOrangeCard = new System.Windows.Forms.PictureBox();
            this.picPurpleCard = new System.Windows.Forms.PictureBox();
            this.picWhiteCard = new System.Windows.Forms.PictureBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picUnmute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrangeCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPurpleCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhiteCard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings";
            // 
            // lblMuteText
            // 
            this.lblMuteText.AutoSize = true;
            this.lblMuteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblMuteText.Location = new System.Drawing.Point(32, 51);
            this.lblMuteText.Name = "lblMuteText";
            this.lblMuteText.Size = new System.Drawing.Size(169, 20);
            this.lblMuteText.TabIndex = 2;
            this.lblMuteText.Text = "Press M to mute music";
            this.lblMuteText.Click += new System.EventHandler(this.lblMuteText_Click);
            // 
            // picUnmute
            // 
            this.picUnmute.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.unmute_small;
            this.picUnmute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUnmute.Location = new System.Drawing.Point(55, 85);
            this.picUnmute.Name = "picUnmute";
            this.picUnmute.Size = new System.Drawing.Size(40, 40);
            this.picUnmute.TabIndex = 6;
            this.picUnmute.TabStop = false;
            this.picUnmute.Visible = false;
            // 
            // picMute
            // 
            this.picMute.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.mute_small;
            this.picMute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMute.Location = new System.Drawing.Point(55, 85);
            this.picMute.Name = "picMute";
            this.picMute.Size = new System.Drawing.Size(40, 40);
            this.picMute.TabIndex = 7;
            this.picMute.TabStop = false;
            this.picMute.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(32, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Click to select theme";
            // 
            // picBlueCard
            // 
            this.picBlueCard.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.card_back_blue;
            this.picBlueCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBlueCard.Location = new System.Drawing.Point(55, 196);
            this.picBlueCard.Name = "picBlueCard";
            this.picBlueCard.Size = new System.Drawing.Size(100, 145);
            this.picBlueCard.TabIndex = 10;
            this.picBlueCard.TabStop = false;
            this.picBlueCard.Click += new System.EventHandler(this.picBlueCard_Click);
            // 
            // picOrangeCard
            // 
            this.picOrangeCard.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.card_back_orange;
            this.picOrangeCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picOrangeCard.Location = new System.Drawing.Point(189, 196);
            this.picOrangeCard.Name = "picOrangeCard";
            this.picOrangeCard.Size = new System.Drawing.Size(100, 145);
            this.picOrangeCard.TabIndex = 11;
            this.picOrangeCard.TabStop = false;
            this.picOrangeCard.Click += new System.EventHandler(this.picOrangeCard_Click);
            // 
            // picPurpleCard
            // 
            this.picPurpleCard.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.card_back_purple;
            this.picPurpleCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPurpleCard.Location = new System.Drawing.Point(327, 196);
            this.picPurpleCard.Name = "picPurpleCard";
            this.picPurpleCard.Size = new System.Drawing.Size(100, 145);
            this.picPurpleCard.TabIndex = 12;
            this.picPurpleCard.TabStop = false;
            this.picPurpleCard.Click += new System.EventHandler(this.picPurpleCard_Click);
            // 
            // picWhiteCard
            // 
            this.picWhiteCard.BackgroundImage = global::AwesomePokerGameSln.Properties.Resources.card_back_white;
            this.picWhiteCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWhiteCard.Location = new System.Drawing.Point(460, 196);
            this.picWhiteCard.Name = "picWhiteCard";
            this.picWhiteCard.Size = new System.Drawing.Size(100, 145);
            this.picWhiteCard.TabIndex = 13;
            this.picWhiteCard.TabStop = false;
            this.picWhiteCard.Click += new System.EventHandler(this.picWhiteCard_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(596, 336);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(168, 87);
            this.buttonReturn.TabIndex = 14;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.picWhiteCard);
            this.Controls.Add(this.picPurpleCard);
            this.Controls.Add(this.picOrangeCard);
            this.Controls.Add(this.picBlueCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picMute);
            this.Controls.Add(this.picUnmute);
            this.Controls.Add(this.lblMuteText);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmSettings";
            this.Text = "Awesome Poker Game Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSettings_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picUnmute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrangeCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPurpleCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhiteCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMuteText;
        private System.Windows.Forms.PictureBox picUnmute;
        private System.Windows.Forms.PictureBox picMute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBlueCard;
        private System.Windows.Forms.PictureBox picOrangeCard;
        private System.Windows.Forms.PictureBox picPurpleCard;
        private System.Windows.Forms.PictureBox picWhiteCard;
        private System.Windows.Forms.Button buttonReturn;
    }
}