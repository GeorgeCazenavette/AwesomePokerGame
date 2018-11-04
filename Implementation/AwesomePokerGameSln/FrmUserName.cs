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
        public FrmUserName()
        {
            InitializeComponent();
        }


        private void FrmUserName_Load(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logonBtn_Click(object sender, EventArgs e)
        {
            FrmTitle frmTitle = new FrmTitle();
            frmTitle.Show();
            Hide();
        }

        private void newUserBtn_Click(object sender, EventArgs e)
        {
            if(emailLabel.Visible != true)
            {
            emailLabel.Visible = true;
            emailBox.Visible = true;
            }

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
