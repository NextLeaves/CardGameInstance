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


            Console.WriteLine("---------------------------");

            Random rand = new Random();
            int x = 0, y = 0;
            for (int i = 0; i < 10; i++)
            {
                x = rand.Next(52);
                y = rand.Next(52);
                Console.WriteLine($"{deck.GetCard(x).ToString()} \t : {deck.GetCard(y).ToString()} \t\t => {deck.GetCard(x) > deck.GetCard(y)}");
            }

            Console.Read();
        }
    }
}
