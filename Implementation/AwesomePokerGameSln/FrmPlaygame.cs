using AwesomePokerGameSln.Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

    public FrmPlaygame() {
      InitializeComponent();
      deck = new Deck();
      playerCardPics = new PictureBox[5];
      for (int c = 1; c <= 5; c++) {
        playerCardPics[c - 1] = this.Controls.Find("picCard" + c.ToString(), true)[0] as PictureBox;
      }
      dealerCardPics = new PictureBox[5];
      for (int c = 1; c <= 5; c++) {
        dealerCardPics[c - 1] = this.Controls.Find("pictureBox" + c.ToString(), true)[0] as PictureBox;
      }

      player = new Participant(playerCardPics, lblHandType, deck);
      // replace "null" with handle for displaying dealer hand type
      dealer = new Participant(dealerCardPics, null, deck);
    }

    private void dealCards() {
      hasMulliganed = false;
      deck.shuffleDeck();
      player.drawFreshHand();
      dealer.drawFreshHand();
    }
    

    private void processCardClick(int index)
    {
      if (selectedCards[index])
      {
        removeCardToMulligan(index);
        return;
      }
      else if (player.canSelectMore())
      {
        addCardToMulligan(index);
      }
      
    }

    private void addCardToMulligan(int index)
    {
      player.cardsToMulligan.Add(index);
    }

    private void removeCardToMulligan(int index)
    {
      player.cardsToMulligan.Remove(index);
    }



    private void FrmPlaygame_FormClosed(object sender, FormClosedEventArgs e) {
      foreach (Form f in Application.OpenForms)
        f.Close();
    }

    private void FrmPlaygame_Load(object sender, EventArgs e) {
      dealCards();
    }

    private void button1_Click(object sender, EventArgs e) {
      dealCards();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (hasMulliganed == false)
      {
        hasMulliganed = true;
        // placeholder param
        player.drawMulligan();
      }
    }

    private void picCard5_Click(object sender, EventArgs e)
    {
      processCardClick(4);
    }

    private void picCard4_Click(object sender, EventArgs e)
    {
      processCardClick(3);
    }

    private void picCard3_Click(object sender, EventArgs e)
    {
      processCardClick(2);
    }

    private void picCard2_Click(object sender, EventArgs e)
    {
      processCardClick(1);
    }

    private void picCard1_Click(object sender, EventArgs e)
    {
      processCardClick(0);
    }
  }

    
}
