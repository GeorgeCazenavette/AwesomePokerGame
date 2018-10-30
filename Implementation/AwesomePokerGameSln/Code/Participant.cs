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
namespace AwesomePokerGameSln

{
  public class Participant
  {
    public Hand hand;
    public PictureBox[] cardPics;
    public Label handLabel;
	  public Participant()
	  {
      Hand = new Hand(new Tuple<int, int>[5]);
    }

    public void drawHand(Deck d, int[] cardIndices)
    {
      foreach (int i in cardIndices)
      {
        CardType card = d.nextCard();
        hand[i] = card;
        cardPics[i].BackgroundImage = CardImageHelper.cardToBitmap(card);
      }
    }
  }

}
