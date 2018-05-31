using Personal.Models.UniversalModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal.Tests.Models
{
    class TestModels
    {
        public DealerModel GetDealerTest()
        {
            var dealer = new DealerModel
            {
                Decks = GetDeckTest()
            };

            return dealer;
        }

        public DeckModel GetDeckTest()
        {
            var deck = new DeckModel();
            return deck;
        }

        public PlayerModel GetPlayerTest(string name = "Test")
        {
            var player = new PlayerModel(name);
            return player;
        }

        public List<PlayerModel> GetPlayersTest(int amount = 1)
        {
            var players = new List<PlayerModel>();
            var random = new Random(9).Next();
            string[] names = { "Alpha", "Beta", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel" };
            var playerName = names.GetValue(random);

            for (var i = 0; i < amount; i++)
            {
                players.Add(GetPlayerTest(playerName.ToString()));
            }

            return players;
        }

        public TableModel GetTableTest()
        {
            var table = new TableModel
            {
                Dealer = GetDealerTest(),
                MaxBet = 5,
                MinBet = 1,
                MaxPlayers = 6,
                MinPlayers = 1,
                Name = "Texas Holdem'",
                Type = TableType.PotLimit,
                Pot = 0,
                Players = GetPlayersTest()
            };

            return table;
        }
    }
}
