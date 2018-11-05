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
            this.buttonReturn = new System.Windows.Forms.Button();
            this.lblMuteText = new System.Windows.Forms.Label();
            this.picUnmute = new System.Windows.Forms.PictureBox();
            this.picMute = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picUnmute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).BeginInit();
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
            // buttonReturn
            // 
            this.buttonReturn.Location = new System.Drawing.Point(634, 389);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
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
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picMute);
            this.Controls.Add(this.picUnmute);
            this.Controls.Add(this.lblMuteText);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label1);
            this.KeyPreview = true;
            this.Name = "FrmSettings";
            this.Text = "Awesome Poker Game Settings";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSettings_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picUnmute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label lblMuteText;
        private System.Windows.Forms.PictureBox picUnmute;
        private System.Windows.Forms.PictureBox picMute;
    }
}