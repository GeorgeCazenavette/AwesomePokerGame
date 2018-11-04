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
            this.newUserBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.emailLabel.Visible = false;
            this.emailLabel.Click += new System.EventHandler(this.emailLabel_Click);
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
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.userNameTextBox.Location = new System.Drawing.Point(75, 151);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(268, 36);
            this.userNameTextBox.TabIndex = 3;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.emailBox.Location = new System.Drawing.Point(75, 298);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(268, 36);
            this.emailBox.TabIndex = 4;
            this.emailBox.Visible = false;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
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
            // newUserBtn
            // 
            this.newUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.newUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.newUserBtn.Location = new System.Drawing.Point(541, 142);
            this.newUserBtn.Name = "newUserBtn";
            this.newUserBtn.Size = new System.Drawing.Size(144, 56);
            this.newUserBtn.TabIndex = 6;
            this.newUserBtn.Text = "New User";
            this.newUserBtn.UseVisualStyleBackColor = false;
            this.newUserBtn.Click += new System.EventHandler(this.newUserBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(224, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "click logon to continue!!!!";
            // 
            // FrmUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newUserBtn);
            this.Controls.Add(this.logonBtn);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.emailLabel);
            this.Name = "FrmUserName";
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
        private System.Windows.Forms.Button newUserBtn;
        private System.Windows.Forms.Label label1;
    }
}