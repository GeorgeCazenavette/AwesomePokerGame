using AwesomePokerGameSln.Code;
using AwesomePokerGameSln.Properties;
using System;
using System.Windows.Forms;

namespace AwesomePokerGameSln {
  public partial class FrmTitle : Form {
    //first initialization of the singleton so it actually creates it
    //public SoundHelper Sound_Helper = new SoundHelper();
    private string userName;

    public FrmTitle(string username = null) {
      //initializes a new sound helper if this has been visited for the first time
      SoundHelper.GetInstance();
      userName = username;
      InitializeComponent();
      //Sound_Helper = new SoundHelper();
      userNameBoxTitle.Text = "Hi, " + userName;
    }

    private void btnQuit_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void btnViewRuleBook_Click(object sender, EventArgs e) {
      if (btnViewRuleBook.Text.StartsWith("View", true, null)) {
        picRulebook.Visible = true;
        btnViewRuleBook.Text = "Close Rule Book";
      }
      else {
        picRulebook.Visible = false;
        btnViewRuleBook.Text = "View Rule Book";
      }
    }

    private void btnNewGame_Click(object sender, EventArgs e) {
      FrmPlaygame frmPlaygame = new FrmPlaygame(userName);
      frmPlaygame.Show();
      Hide();
    }

    private void label3_Click(object sender, EventArgs e) {
      System.Diagnostics.Process.Start("https://www.ncpgambling.org/");
    }



    /// <summary>
    /// Handles KeyDown Events within FrmTitle
    /// </summary>
    private void FrmTitle_KeyDown(object sender, KeyEventArgs e)
    {
      //M stands for mute
      if (e.KeyCode == Keys.M)
      {
        //get the singleton for soundhelper then mute or unmute it
        SoundHelper.GetInstance().mute_unmute();
      }
    }

    private void buttonSettings_Click(object sender, EventArgs e)
    {
        FrmSettings frmSettings = new FrmSettings(this);
        frmSettings.Show();
        Hide();
    }


    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        switch (keyData)
        {
            case (Keys.Shift | Keys.N):
                FrmPlaygame frmPlaygame = new FrmPlaygame(userName);
                frmPlaygame.Show();
                Hide();
                return true;

            case (Keys.Shift | Keys.R):
                if (btnViewRuleBook.Text.StartsWith("View", true, null))
                {
                    picRulebook.Visible = true;
                    btnViewRuleBook.Text = "Close Rule Book";
                }
                else
                {
                    picRulebook.Visible = false;
                    btnViewRuleBook.Text = "View Rule Book";
                }
                return true;

            case (Keys.Shift | Keys.S):
                FrmSettings frmSettings = new FrmSettings(this);
                frmSettings.Show();
                Hide();
                return true;

            case (Keys.Shift | Keys.Q):
                Application.Exit();
                return true;

                default:
                return base.ProcessCmdKey(ref msg, keyData);
        }
    }

    }

}
