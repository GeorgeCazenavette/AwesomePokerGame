using AwesomePokerGameSln.Code;
using AwesomePokerGameSln.Properties;
using System;
using System.Windows.Forms;

namespace AwesomePokerGameSln {
  public partial class FrmTitle : Form {
    //first initialization of the singleton so it actually creates it
    public SoundHelper Sound_Helper = new SoundHelper();

    public FrmTitle() {
      InitializeComponent();
      //Sound_Helper = new SoundHelper();
      
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
      FrmPlaygame frmPlaygame = new FrmPlaygame();
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

    
  }
}
