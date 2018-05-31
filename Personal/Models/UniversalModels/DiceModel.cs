using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Personal.Models.UniversalModels
{
    public class DiceModel
    {
        public Types Type { get; set; }
        public int MaxNumber { get { return MaxDiceNumber(); } }

        public DiceModel(Types type)
        {
            Type = type;
        }

        public int? Roll()
        {
            var random = new Random();
            return random.Next(1, MaxNumber);
        }

        private int MaxDiceNumber()
        {
            switch (Type)
            {
                case Types.D4:
                    return 4;

                case Types.D6:
                    return 6;

                case Types.D8:
                    return 8;

                case Types.D10:
                    return 10;

                case Types.D12:
                    return 12;

                case Types.D20:
                    return 20;

                case Types.Percent:
                    return 100;

                default:
                    throw new Exception();
            }
        }
    }

    public enum Types
    {
        D4,
        D6,
        D8,
        D10,
        D12,
        D20,
        Percent
    }
}