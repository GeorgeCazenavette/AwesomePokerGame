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
  /// <summary>
  /// This class represents a participant in the poker game. Both teh player an dealer are instances of this class.
  /// </summary>
  public class Participant
  {
    public Hand hand;
    public PictureBox[] cardPics;
    public Label handLabel;
    public Deck deck;
    public bool hasAce;
    private int maxMulligan;
    public ArrayList cardsToMulligan = new ArrayList();
    public int money;
    public bool showHand = true;

	public Participant(PictureBox[] pics, Label label, Deck d)
	{
      hand = new Hand(new Tuple<int, int>[5]);
      this.cardPics = pics;
      this.handLabel = label;
      this.deck = d;
      this.money = 0;
    }

    /// <summary>
    /// Discards the cards specified by "cardIndices" and draws new cards to replace them.
    /// Replaces the appripriate cart images.
    /// </summary>
    /// <param name="cardIndices">Indices of cards to replace.</param>
    public void drawCards(int[] cardIndices)
    {
      foreach (int i in cardIndices)
      {
        CardType card = deck.nextCard();
        hand.changeCard(i, card);
        if (this.showHand)
          cardPics[i].BackgroundImage = CardImageHelper.cardToBitmap(card);
        else
          cardPics[i].BackgroundImage = CardImageHelper.cardBackToBitmap();
    }
      foreach (CardType card in hand.getCards())
      {
        if (card.Item1 == 12)
        {
          hasAce = true;
          maxMulligan = 4;
          break;
        }
        else
        {
          hasAce = false;
          maxMulligan = 3;
        }
      }
      if (handLabel != null)
      {
        handLabel.Text = hand.getHandType().ToString();
      }
    }

    /// <summary>
    /// Discards and replaecs all cards.
    /// </summary>
    public void drawFreshHand()
    {
      drawCards(new int[] {0,1,2,3,4});
    }

    /// <summary>
    /// Discards the selected cards and replaces them.
    /// </summary>
    public void drawMulligan()
    {
      drawCards(cardsToMulligan.ToArray(typeof(int)) as int[]);
      cardsToMulligan = new ArrayList();
    }

    /// <summary>
    /// Returns whether or not the participant can select more cards to mulligan.
    /// </summary>
    /// <returns>Boolean</returns>
    public Boolean canSelectMore()
    {
      return cardsToMulligan.Count < maxMulligan;
    }

    /// <summary>
    /// Clears the list of cards to mulligan.
    /// </summary>
    public void clearMulliganList()
    {
      cardsToMulligan = new ArrayList();
    }

  }

}
