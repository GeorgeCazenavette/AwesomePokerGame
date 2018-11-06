using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
            //string userName, email;
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
                // Use Dictionary as a map.
                var userNameMap = new Dictionary<string, string>();

                // ... Add some keys and values.
                userNameMap.Add(userName, email);

                // ... Loop over the map.
                foreach (var pair in userNameMap)
                {
                    string key = pair.Key;
                    string value = pair.Value;
                    Console.WriteLine(key + "/" + value);
                }

                FrmTitle frmTitle = new FrmTitle(userName);
                frmTitle.Show();
                Hide();

            }

        }

    }
}
