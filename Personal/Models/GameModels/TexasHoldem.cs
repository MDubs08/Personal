using Personal.Models.UniversalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Personal.Games.CardGames
{
    public class TexasHoldem
    {
        public List<PlayerModel> Players { get; set; }
        public DealerModel Dealer { get; set; }

        public void Start()
        {

        }

        public void SetBlindsRound()
        {

        }

        public void DealCards()
        {
            foreach (var player in Players)
            {
                Dealer.Deal(2);
            }
        }

        public void FlopRound()
        {
            BurnCard();
            var flop = Dealer.Decks.Cards.GetRange(0, 3);

            foreach (var card in flop)
            {
                Dealer.DisplayCard(card);
            }
        }

        public void TurnRound()
        {
            BurnCard();
            var turnCard = Dealer.Decks.Cards.FirstOrDefault();
            Dealer.DisplayCard(turnCard);
        }

        public void RiverRound()
        {
            BurnCard();
            var riverCard = Dealer.Decks.Cards.FirstOrDefault();
            Dealer.DisplayCard(riverCard);
        }

        public void ShowdownRound()
        {
            foreach (var player in Players)
            {
                
            }
        }

        public void BettingRound()
        {
            foreach (var player in Players)
            {
                if (player.Cards.Count > 0)
                {
                    
                }
            }
        }

        public void BurnCard()
        {
            var burnCard = Dealer.Decks.Cards.FirstOrDefault();
            Dealer.Decks.Cards.Remove(burnCard);
            Dealer.BurnCards.Cards.Add(burnCard);
        }
    }
}