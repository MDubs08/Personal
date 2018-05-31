using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Models.UniversalModels
{
    public class DeckModel
    {
        public List<CardModel> Cards { get; set; }

        #region Model Constructors
        public DeckModel(bool isDiscardDeck)
        {
            if (isDiscardDeck)
            {
                Cards = new List<CardModel>();
            }
            else
            {
                Cards = new List<CardModel>();
                SetCards();
                Shuffle();
            }
        }
        #endregion

        #region Model Actions
        /// <summary>
        /// Shuffles the Deck
        /// </summary>
        public void Shuffle()
        {
            var random = new Random();

            Cards = Cards
                .OrderBy(card => random.Next())
                .ToList();
        }

        /// <summary>
        /// Adds all 52 potential cards into Deck
        /// </summary>
        public void SetCards()
        {
            foreach (Suits suit in Enum.GetValues(typeof(Suits)))
            {
                foreach (Values value in Enum.GetValues(typeof(Values)))
                {
                    Cards.Add(new CardModel(suit, value));
                }
            }
        }
        #endregion
    }

    public class CardModel
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public bool IsFaceUp { get; set; }

        #region Model Constructors
        public CardModel(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }
        #endregion

        #region Getters
        /// <summary>
        /// Gets the image associated with the card
        /// </summary>
        /// <returns>Card Icon</returns>
        public string GetIcon()
        {
            string imagePath = "../Content/Images/";
            switch (Suit)
            {
                case Suits.Club:
                    return $"{imagePath}Club-Suit.svg";

                case Suits.Diamond:
                    return $"{imagePath}Diamond-Suit.svg";

                case Suits.Heart:
                    return $"{imagePath}Heart-Suit.svg";

                case Suits.Spade:
                    return $"{imagePath}Spade-Suit.svg";

                default:
                    throw new Exception();
            }
        }
        #endregion
    }

    public enum Suits
    {
        Club,
        Diamond,
        Heart,
        Spade
    }

    public enum Values
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
}