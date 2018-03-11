using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CardLibrary;

namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            for (int i = 0; i < 52; i++)
            {
                Console.Write(deck.GetCard(i).ToString() + "\t");
                if (i % 4 == 0) Console.WriteLine();
            }

            Console.WriteLine("\n--------------------------");

            deck.Shuffle();

            for (int i = 0; i < 52; i++)
            {
                Console.Write(deck.GetCard(i).ToString() + "\t");
                if (i % 4 == 0) Console.WriteLine();
            }

            Console.Read();
        }
    }
}
