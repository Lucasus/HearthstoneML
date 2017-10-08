using System;
using Xunit;
using FluentAssertions;
using System.Linq;

namespace Simulator.Tests
{

    public class GameTests
    {
        [Fact]
        public void WhenGameIsPrepared_ThenEachPlayerHadThirtyCardsInDeck()
        {
            var game = Game.NewGame();
            game.Player1.Deck.RemainingCardsCount.Should().Be(30);
            game.Player2.Deck.RemainingCardsCount.Should().Be(30);
        }

        [Fact]
        public void WhenGameStarts_ThenFirstPlayerGetsRandomThreeCards()
        {

        }
    }
}
