using AwesomePokerGameSln.Code;
using System;
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
    private Hand playerHand;
    private Hand dealerHand;

    public FrmPlaygame() {
      InitializeComponent();
      playerCardPics = new PictureBox[5];
      for (int c = 1; c <= 5; c++) {
        playerCardPics[c - 1] = this.Controls.Find("picCard" + c.ToString(), true)[0] as PictureBox;
      }
      dealerCardPics = new PictureBox[5];
      for (int c = 1; c <= 5; c++) {
        dealerCardPics[c - 1] = this.Controls.Find("pictureBox" + c.ToString(), true)[0] as PictureBox;
      }
    }

    private void dealCards() {
      deck.shuffleDeck();
      drawHand(playerHand, playerCardPics, lblHandType);
      drawHand(dealerHand, dealerCardPics, null);
    }
    
    private void drawHand(Hand hand, PictureBox[] cardPics, Label label)
    {
        Tuple<int, int>[] cards = new Tuple<int, int>[5];
        int index = 0;
        foreach (PictureBox cardPic in cardPics)
        {
            CardType card = deck.nextCard();
            cards[index++] = card;
            cardPic.BackgroundImage = CardImageHelper.cardToBitmap(card);
        }
        hand = new Hand(cards);
        if (label != null)
        {
            label.Text = hand.getHandType().ToString();
        }
    }

    private void FrmPlaygame_FormClosed(object sender, FormClosedEventArgs e) {
      foreach (Form f in Application.OpenForms)
        f.Close();
    }

    private void FrmPlaygame_Load(object sender, EventArgs e) {
      deck = new Deck();
      dealCards();
    }

    private void button1_Click(object sender, EventArgs e) {
      dealCards();
    }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
