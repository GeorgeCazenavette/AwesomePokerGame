﻿using AwesomePokerGameSln.Code;
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
    public Deck deck;
    public bool hasAce;
    private int maxMulligan;
    public ArrayList cardsToMulligan = new ArrayList();

	  public Participant(PictureBox[] pics, Label label, Deck d)
	  {
      hand = new Hand(new Tuple<int, int>[5]);
      this.cardPics = pics;
      this.handLabel = label;
      this.deck = d;
    }

    public void drawCards(int[] cardIndices)
    {
      foreach (int i in cardIndices)
      {
        CardType card = deck.nextCard();
        hand.changeCard(i, card);
        cardPics[i].BackgroundImage = CardImageHelper.cardToBitmap(card);
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

    public void drawFreshHand()
    {
      drawCards(new int[] {0,1,2,3,4});
    }

    public void drawMulligan()
    {
      drawCards(cardsToMulligan.ToArray(typeof(int)) as int[]);
      cardsToMulligan = new ArrayList();
    }

    public Boolean canSelectMore()
    {
      return cardsToMulligan.Count < maxMulligan;
    }

    
  }

}