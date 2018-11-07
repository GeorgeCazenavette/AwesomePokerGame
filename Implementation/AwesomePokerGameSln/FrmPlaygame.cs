using AwesomePokerGameSln.Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardType = System.Tuple<int, int>;

namespace AwesomePokerGameSln {
  public partial class FrmPlaygame : Form {
    private Deck deck;
    private PictureBox[] playerCardPics;
    private PictureBox[] dealerCardPics;
    private Participant player;
    private Participant dealer;
    private Hand playerHand;
    private Hand dealerHand;
    private bool hasMulliganed = false;
    private ArrayList cardsToMulligan = new ArrayList();
    private bool[] selectedCards = { false, false, false, false, false };
    private string userName;

    public FrmPlaygame( string username = null) {
      InitializeComponent();
      this.BackColor = ThemeHelper.GetInstance().GetBackgroundColor();

      userName = username;
      //SoundHelper.GetInstance().stopBgMusic();
      //InitializeBackgroundMusic();
      
      deck = new Deck();
      playerCardPics = new PictureBox[5];
      for (int c = 1; c <= 5; c++) {
        playerCardPics[c - 1] = this.Controls.Find("picCard" + c.ToString(), true)[0] as PictureBox;
      }
      dealerCardPics = new PictureBox[5];
      for (int c = 1; c <= 5; c++) {
        dealerCardPics[c - 1] = this.Controls.Find("pictureBox" + c.ToString(), true)[0] as PictureBox;
      }

      player = new Participant(playerCardPics, lblHandType, deck, true, 500);
      dealer = new Participant(dealerCardPics, dealerHandLabel, deck, false, 500);
      updateMoneyLabel();
      randDealerBet();
    }


    //private void InitializeBackgroundMusic()
    //{
    //  System.IO.Stream str = Properties.Resources.background_music;
    //  System.Media.SoundPlayer sp = new System.Media.SoundPlayer(str);
    //  ////we want the music to loop
    //  ////sp.Play();
    //  sp.PlayLooping();
      
    //}



    /// <summary>
    /// Deals cards and resets mulligan mechanic.
    /// Shuffles deck and gives the player and dealer new hands.
    /// Resets mulligan button.
    /// </summary>
    private void dealCards() {
      dealer.showHand = false;
      hasMulliganed = false;
      clearSelections();
      button2.Enabled = true;
      button3.Enabled = true;
      deck.shuffleDeck();
      player.drawFreshHand();
      dealer.drawFreshHand();
    }

    /// <summary>
    /// Clear card selections and mulligan list.
    /// </summary>
    private void clearSelections()
    {
      selectedCards = new bool[] { false, false, false, false, false };
      foreach (PictureBox picBox in playerCardPics)
      {
        picBox.BorderStyle = BorderStyle.None;
      }
      player.clearMulliganList();
    }

    /// <summary>
    /// Processes the ccard click.
    /// Checks if it should be added to mulligan list, removed from mulligan list, or nothing.
    /// </summary>
    /// <param name="index">Index of clicked card.</param>
    /// <param name="picBox"></param>
    private void processCardClick(int index, PictureBox picBox)
    {
      if (hasMulliganed)
      {
        return;
      }
      else if (selectedCards[index])
      {
        removeCardToMulligan(index);
        picBox.BorderStyle = BorderStyle.None;
        return;
      }
      else if (player.canSelectMore())
      {
        addCardToMulligan(index);
        picBox.BorderStyle = BorderStyle.Fixed3D;
      }

    }

    /// <summary>
    /// Adds the specified card to the mulligan list.
    /// </summary>
    /// <param name="index"></param>
    private void addCardToMulligan(int index)
    {
      player.cardsToMulligan.Add(index);
      selectedCards[index] = true;
    }

    /// <summary>
    /// Removes the specified cars from the mulligan list.
    /// </summary>
    /// <param name="index"></param>
    private void removeCardToMulligan(int index)
    {
      player.cardsToMulligan.Remove(index);
      selectedCards[index] = false;
    }

    /// <summary>
    /// Wrapper for pressing mulligan button
    /// </summary>
    private void mulliganButtonClick()
    {
      if (hasMulliganed == false && player.cardsToMulligan.Count > 0)
      {
        hasMulliganed = true;
        // placeholder param
        player.drawMulligan();
        clearSelections();
        button2.Enabled = false;
      }
    }

        /// <summary>
        /// Wrapper for pressing redeal button
        /// </summary>
        private void redealButtonClick()
        {
            //SoundHelper.GetInstance().playSoundEffect(SoundHelper.sound_effects.shuffle);
            dealCards();
            AllInButton.Enabled = true;
            winnerLabel.Text = "Your Turn";
        }

    private void revealButtonClick()
    {
      string bet = betTextBox.Text;
      int betInt;

      string str = dealerBetLabel.Text;
      string[] arr = str.Split(':');
      int dealerBet;
      Int32.TryParse(arr[1], out dealerBet);

      if (int.TryParse(bet, out betInt) && betInt >= 5 && betInt <= player.money)
      {
        button2.Enabled = false;
        button3.Enabled = false;
        AllInButton.Enabled = false;
        dealer.showCards();
        int result = getWin();
        if (result == 1)
        {
          player.money += dealerBet;
          dealer.money -= dealerBet;
        }
        else if (result == 0)
        {
          player.money += ((betInt + dealerBet) / 2) - betInt;
          dealer.money += ((betInt + dealerBet) / 2) - dealerBet;
        }
        else
        {
          player.money -= betInt;
          dealer.money += betInt;
          if (player.money < 0)
          {
            player.money = 0;
          }
          else if (dealer.money < 0)
          {
            dealer.money = 0;
          }
        }
        moneyLabel.Text = "Money: " + player.money;
        dealerMoneyLabel.Text = "Dealer Money: " + dealer.money;
        if (player.money <= 5)
        {
          gameOver();
        }
        else if (dealer.money <= 5)
        {
          gameOverWin();
        }

      }
      else
      {
        MessageBox.Show("Please enter an integer between 5 and your current money in the \"Bet\" box.");
      }

            betTextBox.Text = 0.ToString();
        }

    private void gameOver()
    {
      MessageBox.Show("You can no longer afford the minimum bet.\nPlease return to the main menu to begin a new game.");
      button1.Enabled = false;
    }
    private void gameOverWin()
    {
      MessageBox.Show("Congratulations! You beat the dealer!\nPlease return to the main menu to begin a new game.");
      button1.Enabled = false;
    }

    private void updateMoneyLabel()
    {
      moneyLabel.Text = "Money: " + player.money;
      dealerMoneyLabel.Text = "Dealer Money: " + dealer.money;
    }

    public void randDealerBet()
    {
      Random rand = new Random();
      int dealerBet = rand.Next(5, dealer.money);
      dealerBetLabel.Text = "Dealer Bet: " + dealerBet;
    }      

    private void FrmPlaygame_FormClosed(object sender, FormClosedEventArgs e) {
      Application.Exit();
    }

    private void FrmPlaygame_Load(object sender, EventArgs e) {
      dealCards();
    }

    private void button1_Click(object sender, EventArgs e) {
      redealButtonClick();
      randDealerBet();
    }

    /// <summary>
    /// Mulligan Button
    /// Discards selected cards.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void button2_Click(object sender, EventArgs e)
    {
      mulliganButtonClick();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      revealButtonClick();
    }

    private void picCard5_Click(object sender, EventArgs e)
    {
      processCardClick(4, (PictureBox)(sender));
    }

    private void picCard4_Click(object sender, EventArgs e)
    {
      processCardClick(3, (PictureBox)(sender));
    }

    private void picCard3_Click(object sender, EventArgs e)
    {
      processCardClick(2, (PictureBox)(sender));
    }

    private void picCard2_Click(object sender, EventArgs e)
    {
      processCardClick(1, (PictureBox)(sender));
    }

    private void picCard1_Click(object sender, EventArgs e)
    {
      processCardClick(0, (PictureBox)(sender));
    }

    /// <summary>
    /// Handles hotkeys
    /// </summary>
    /// <param name="msg"></param>
    /// <param name="keyData"></param>
    /// <returns></returns>
    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      switch (keyData)
      {
        case (Keys.Shift | Keys.M):
          mulliganButtonClick();
          return true;

        case (Keys.Shift | Keys.D):
          redealButtonClick();
          return true;

        case (Keys.Shift | Keys.R):
            button2.Enabled = false;
            button3.Enabled = false;
            dealer.showCards();
            getWin();
            return true;

        case (Keys.Shift | Keys.Q):
            FrmTitle frmTitle = new FrmTitle(userName);
            frmTitle.Show();
            Hide();
            return true;

                default:
          return base.ProcessCmdKey(ref msg, keyData);
      }
    }
    /// <summary>
    /// Handles KeyDown Events within FrmPlayGame
    /// </summary>
    private void FrmPlaygame_KeyDown(object sender, KeyEventArgs e)
    {
      //M stands for mute
      if (e.KeyCode == Keys.M)
      {
        SoundHelper.GetInstance().mute_unmute();
      }
    }

    private void dealerHandLabel_Click(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {
      FrmTitle frmTitle = new FrmTitle(userName);
      frmTitle.Show();
      Hide();
    }

    /// <summary>
    /// Determines if player wins or lose
    /// </summary>
    public int getWin()
    {
      // converts enum HandType to interger
      // lower number is better rank, i.e. Royal Flush = 0
      int p = (int)player.hand.getHandType();
      int d = (int)dealer.hand.getHandType();
      List<int> phand = player.hand.getFaces();
      List<int> dhand = dealer.hand.getFaces();
      phand = phand.OrderBy(o => o).ToList();
      dhand = dhand.OrderBy(o => o).ToList();

      if (p < d)
      {
        winnerLabel.Text = "You Win";
        return 1;
      }
      else if (p == d && p == 9) // high: highest card -> 2nd highest -> 3rd highest..
      {
        return highCardBreaker(5, phand, dhand);

      }
      else if (p == d && p == 8) // pair: higest pair -> high card out of 3 distinct cards
      {
        List<int> pDistinct= phand;
        List<int> dDistinct= dhand;
        List<int> pGroup = phand;
        List<int> dGroup = dhand;
        int pPair = pGroup.GroupBy(x => x).Where(group => group.Count() > 1).Select(group => group.Key).First();
        int dPair = dGroup.GroupBy(x => x).Where(group => group.Count() > 1).Select(group => group.Key).First();
        pDistinct.RemoveAll(item => item == pPair);
        dDistinct.RemoveAll(item => item == dPair);

        if (pPair > dPair)
        {
          winnerLabel.Text = "You Win";
          return 1;
        }
        else if (pPair < dPair)
        {
          winnerLabel.Text = "You Lose";
          return -1;
        }
        else
        {
          return highCardBreaker(3, pDistinct, dDistinct);
        }
      }

      else if (p == d && p != 9 && p != 8)
      {
        // 2pair: highest pair -> second pair -> high card
        // 3kind: highest 3kind -> highest card
        // straight: highest straight
        // flush: high card
        // full house: 3kind
        winnerLabel.Text = "It's a tie";
        return 0;
      }
      else //if (p > d)
      {
        winnerLabel.Text = "You Lose";
        return -1;
      }

    }

    public int highCardBreaker(int numCards, List<int> phand, List<int> dhand)
    {
      for (int i = (numCards-1); i > 0; i--)
      {
        if (phand[i] > dhand[i])
        {
          winnerLabel.Text = "You Win";
          return 1;
        }
        else if (phand[i] < dhand[i])
        {
          winnerLabel.Text = "You Lose";
          return -1;
        }

      }
      winnerLabel.Text = "It's a tie";
      return 0;
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void allin_Click(object sender, EventArgs e)
    {

        betTextBox.Text = player.money.ToString();
    }
  }
}
