namespace AwesomePokerGameSln
{
    partial class FrmUserName
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.logonBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.emailLabel.Location = new System.Drawing.Point(70, 236);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(85, 29);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email:";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userNameLabel.Location = new System.Drawing.Point(70, 89);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(148, 29);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "User Name:";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userNameTextBox.Location = new System.Drawing.Point(75, 151);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(268, 36);
            this.userNameTextBox.TabIndex = 3;
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.emailBox.Location = new System.Drawing.Point(75, 298);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(268, 36);
            this.emailBox.TabIndex = 4;
            // 
            // logonBtn
            // 
            this.logonBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.logonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.logonBtn.Location = new System.Drawing.Point(541, 289);
            this.logonBtn.Name = "logonBtn";
            this.logonBtn.Size = new System.Drawing.Size(144, 53);
            this.logonBtn.TabIndex = 5;
            this.logonBtn.Text = "Logon";
            this.logonBtn.UseVisualStyleBackColor = false;
            this.logonBtn.Click += new System.EventHandler(this.logonBtn_Click);
            // 
            // FrmUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logonBtn);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Name = "FrmUserName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logon";
            this.Load += new System.EventHandler(this.FrmUserName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button logonBtn;
    }
}