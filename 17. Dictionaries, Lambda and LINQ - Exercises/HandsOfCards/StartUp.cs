namespace HandsOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var cards = new Dictionary<string, List<string>>();
            var cardsPower = new Dictionary<string, int>();

            while (input != "JOKER")
            {
                var inputLine = input
                    .Split(new string[] { ": ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var name = inputLine[0];
                var hand = inputLine.Skip(1).Take(inputLine.Length).ToList();

                if (!cards.ContainsKey(name))
                {
                    cards.Add(name, new List<string>());
                    cardsPower.Add(name, 0);
                }
                
                foreach (var card in hand)
                {
                    if (!cards[name].Contains(card))
                    {
                        cards[name].Add(card);
                        var handPower = CalculateHandPower(card);
                        cardsPower[name] += handPower;
                    }
                }                 

                input = Console.ReadLine();
            }

            foreach (var player in cardsPower)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }
        }

        public static int CalculateHandPower(string card)
        {
            var handPower = 0;
            var cardValue = 0;
            var cardPower = 0;

            switch (card.First())
            {
                case '2': cardValue = 2; break;
                case '3': cardValue = 3; break;
                case '4': cardValue = 4; break;
                case '5': cardValue = 5; break;
                case '6': cardValue = 6; break;
                case '7': cardValue = 7; break;
                case '8': cardValue = 8; break;
                case '9': cardValue = 9; break;
                case '1': cardValue = 10; break;
                case 'J': cardValue = 11; break;
                case 'Q': cardValue = 12; break;
                case 'K': cardValue = 13; break;
                case 'A': cardValue = 14; break;
            }

            switch (card.Last())
            {
                case 'C': cardPower = 1; break;
                case 'D': cardPower = 2; break;
                case 'H': cardPower = 3; break;
                case 'S': cardPower = 4; break;
            }

            handPower = cardValue * cardPower;          

            return handPower;
        }
    }
}
