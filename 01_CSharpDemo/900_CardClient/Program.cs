using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _900_CardModel;

namespace _900_CardClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck myDeck = new Deck();
            myDeck.Shuttle();
            for (int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.GetDeck(i);
                Console.Write(tempCard.ToString());
                if (i!=51)
                {
                    Console.Write("'");
                }
                else
                {
                    Console.WriteLine();
                }

            }
        }
    }
}
