using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Models.UniversalModels
{
    public class PlayerModel
    {
        public string Name { get; set; }
        public int? Balance { get; set; }
        public TableModel Table { get; set; }
        public List<CardModel> Cards { get; set; }

        public PlayerModel(string name, TableModel table)
        {
            Name = name;
            Balance = 500;
            Table = table;
            Cards = new List<CardModel>();
        }

        public PlayerModel(string name)
        {
            Name = name;
            Balance = 500;
            Cards = new List<CardModel>();
        }

        public void ReceiveCard(CardModel card)
        {
            Cards.Add(card);
        }

        public void Bet(int amount)
        {
            Balance = Balance - amount;
            Table.Pot = Table.Pot + amount;
        }

        public void Win(int amount)
        {
            Balance = Balance + amount;
            Table.Pot = Table.Pot - amount;
        }

        public void Check()
        {
            
        }

        public void Fold()
        {
            Cards.Clear();
        }

        public void ShowHand(bool showHand = true)
        {
            if (showHand)
            {
                
            }
            else
            {

            }
        }
    }
}