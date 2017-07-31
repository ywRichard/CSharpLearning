using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _900_CardModel
{
    public class Cards : CollectionBase, ICloneable
    {
        public object Clone()
        {
            Cards newCards = new Cards();
            foreach (Card item in List)
            {
                newCards.List.Add(item.Clone() as Card);
            }

            return newCards;
        }
    }
}
