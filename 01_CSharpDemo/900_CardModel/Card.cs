using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _900_CardModel
{
    public class Card
    {
        public readonly Suit suit;
        public readonly Rank rank;

        private Card()
        {

        }

        public Card(Suit newSuit, Rank newRank)
        {
            suit = newSuit;
            rank = newRank;
        }

        public override string ToString()
        {
            return "The" + rank + "of" + suit + "s";
        }
    }
}
