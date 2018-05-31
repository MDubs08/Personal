using Personal.Models.UniversalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Models.GameModels
{
    public class CardGameModel
    {
        public List<CardModel> BurnCards { get; set; }
        public List<DeckModel> Decks { get; set; }
        public List<CardModel> PlayCards { get; set; }

        #region Model Actions
        /// <summary>
        /// Shuffles all decks and adds all cards from all decks to PlayCards
        /// </summary>
        public void ShufflePlayCards()
        {
            var rng = new Random();

            foreach (var deck in Decks)
            {
                deck.Shuffle();

                foreach (var card in deck.Cards)
                {
                    PlayCards.Add(card);
                }
            }

            PlayCards = PlayCards
                .OrderBy(card => rng.Next())
                .ToList();
        }

        /// <summary>
        /// Adds a 'burn' card to the burn card list
        /// </summary>
        /// <param name="burnCard">A card to be discarded / burned</param>
        public void AddCardToBurnCards(CardModel burnCard)
        {
            BurnCards.Add(burnCard);
        }

        /// <summary>
        /// Removes the card from the PlayCards and adds them to Player's cards
        /// </summary>
        /// <param name="card">The card to be added / removed</param>
        /// <param name="player">The player to receive the card</param>
        public void Deal(CardModel card, PlayerModel player)
        {
            PlayCards.Remove(card);
            player.Cards.Add(card);
        }
        #endregion
    }
}