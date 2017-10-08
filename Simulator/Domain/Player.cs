using System.Collections.Generic;

namespace Simulator.Tests
{
    public class Player
    {
        public Deck Deck { get; }

        public Player(Deck deck)
        {
            Deck = deck;
        }

        public static Player Generate()
        {
            return new Player(Deck.Generate());
        }
    }
}