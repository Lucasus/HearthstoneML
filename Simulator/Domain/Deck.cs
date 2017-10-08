using System.Collections.Generic;
using System.Linq;

namespace Simulator.Tests
{
    public class Deck
    {
        private IList<Card> _cards;

        private Deck(IList<Card> cards)
        {
            _cards = cards;
        }

        public int RemainingCardsCount => _cards.Count;

        public static Deck Generate()
        {
            var cards = Enumerable.Range(0, 30).Select(i => new Card(1)).ToList();
            var shuffledCards = CardShuffler.Shuffle(cards);
            return new Deck(cards);
        }
    }
}
