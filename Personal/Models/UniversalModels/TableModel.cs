using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Personal.Models.UniversalModels
{
    public class TableModel
    {
        public int MaxPlayers { get; set; }
        public int MinPlayers { get; set; }
        public int MaxBet { get; set; }
        public int MinBet { get; set; }
        public string Name { get; set; }
        public int Pot { get; set; }
        public TableType Type { get; set; }
        public BetLimit BetLimit { get; set; }

        public DealerModel Dealer { get; set; }
        public List<PlayerModel> Players { get; set; }

        #region Model Constructors
        public TableModel()
        {
            Players = new List<PlayerModel>();
        }

        public TableModel(DealerModel dealer)
        {
            Dealer = dealer;
            Players = new List<PlayerModel>();
        }
        #endregion
    }

    public enum TableType
    {
        [Display(Name = "Blackjack")]
        Blackjack,
        [Display(Name = "Texas Holdem'")]
        TexasHoldem,
    }

    public enum BetLimit
    {
        [Display(Name = "No Limit")]
        NoLimit,
        [Display(Name = "Pot Limit")]
        PotLimit
    }
}