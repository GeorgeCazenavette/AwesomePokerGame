using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;


namespace AwesomePokerGameSln
{
    public partial class FrmUserName : Form
    {
    static string userName;
      
        public FrmUserName()
        {
            InitializeComponent();
        }

        private void FrmUserName_Load(object sender, EventArgs e)
        {

        }

        private void logonBtn_Click(object sender, EventArgs e)
        {
            string email;
            userName = userNameTextBox.Text;
            email = emailBox.Text;
            if(userName == "" || email == "")
            {
                MessageBox.Show("please enter a username and email");
            }
            else if(email.Contains('@') != true)
            {
                MessageBox.Show("please enter a valid email");
            }
            else
            {
                sendEmail(userName, email);
                FrmTitle frmTitle = new FrmTitle(userName);
                frmTitle.Show();
                Hide();
            }
        }

        private void sendEmail(string user, string email)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("AwesomePokerGameCyan@gmail.com");
                mail.To.Add(email);

                mail.Subject = "Awesome Poker Game";
                string bodyText = "Welcome to Awesome Poker Game, ! Thanks for playing.\n\n Good luck!";
                bodyText = bodyText.Insert(31, user);
                mail.Body = bodyText;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("AwesomePokerGameCyan@gmail.com", "drcherry");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
            }
            catch
            {
                MessageBox.Show("Could not send email");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Enter):
                    string email;
                    userName = userNameTextBox.Text;
                    email = emailBox.Text;
                    if (userName == "" || email == "")
                    {
                        MessageBox.Show("please enter a username and email");
                    }
                    else if (email.Contains('@') != true)
                    {
                        MessageBox.Show("please enter a valid email");
                    }
                    else
                    {
                        sendEmail(userName, email);
                        FrmTitle frmTitle = new FrmTitle(userName);
                        frmTitle.Show();
                        Hide();
                    }
                    return true;

                

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

    }
}
