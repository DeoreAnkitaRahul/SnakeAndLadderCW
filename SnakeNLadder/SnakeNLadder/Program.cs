namespace SnakeNLadder
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to the Snake and Ladder Game");
            Position newGame = new Position();
            newGame.GameMethod();
        }
    }
}