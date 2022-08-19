﻿

namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                string[] output = CardPicker.PickSomeCards(numberOfCards);
                foreach (string card in output)
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("Your input was wrong, get with the program :)");
                
            }
        }
    }
}