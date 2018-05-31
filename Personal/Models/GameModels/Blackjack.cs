using Personal.Models.UniversalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Models.GameModels
{
    public class Blackjack : CardGameModel
    {
        public void Start()
        {

        }

        public void SplitHand()
        {

        }

        public int GetHandScore(List<CardModel> cards)
        {
            int score = 0;

            foreach (var card in cards)
            {
                if (card.Value == Values.Ace)
                {
                    GetAceValue(score);
                }
                else
                {
                    score += GetCardValue(card);
                }
            }

            return score;
        }

        public int GetCardValue(CardModel card)
        {
            switch (card.Value)
            {
                case Values.Jack:
                case Values.Queen:
                case Values.King:
                    return 10;

                case Values.Ace:
                    return GetAceValue();

                default:
                    return (int)card.Value;
            }
        }

        public int GetAceValue(int currentScore = 0)
        {
            if (currentScore > 10) { return 1; }
            else { return 11; }
        }
    }
}