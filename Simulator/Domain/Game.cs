namespace Simulator.Tests
{
    public class Game
    {
        public Player Player1 { get; }
        public Player Player2 { get; }

        private Game(Player player1, Player player2)
        {
            
            Player1 = player1;
            Player2 = player2;
        }

        public static Game NewGame()
        {
            var player1 = Player.Generate();
            var player2 = Player.Generate();
            var game = new Game(player1, player2);
            return game;
        }
    }
}