using Personal.Models.UniversalModels;
using System;
using System.Collections.Generic;

namespace Personal.Tests.Models
{
    class TestModels
    {
        public DealerModel GetDealerTest()
        {
            var dealer = new DealerModel();
            return dealer;
        }

        public DeckModel GetDeckTest()
        {
            var deck = new DeckModel(false);
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
            string[] names = { "Alpha", "Beta", "Charlie", "Delta", "Echo", "Foxtrot", "Golf", "Hotel" };
            

            for (var i = 0; i < amount; i++)
            {
                var playerName = names.GetValue(new Random().Next(1, 9));
                players.Add(GetPlayerTest(playerName.ToString()));
            }

            return players;
        }

        public TableModel GetTableTest(string name = "test")
        {
            var table = new TableModel
            {
                BetLimit = BetLimit.NoLimit,
                Dealer = GetDealerTest(),
                MaxBet = 5,
                MinBet = 1,
                MaxPlayers = 6,
                MinPlayers = 1,
                Name = name,
                Type = TableType.TexasHoldem,
                Pot = 0,
                Players = GetPlayersTest(2)
            };

            return table;
        }

        public List<TableModel> GetTablesTest()
        {
            var tables = new List<TableModel>();
            int total = 6;

            for (var i = 0; i < total; i++)
            {
                tables.Add(GetTableTest($"test table {i}"));
            }

            return tables;
        }
    }
}
