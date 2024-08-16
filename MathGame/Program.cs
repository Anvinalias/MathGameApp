namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? playerChoice;
            string? replayChoice;
            GameOption opt = new GameOption();

            do
            {
                Console.WriteLine("Choose from below choices ?");

                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. History");
                Console.WriteLine("6. Quit");

                playerChoice = Console.ReadLine();

                // if user want to quit
                if (playerChoice == "6")
                {
                    Environment.Exit(0);
                }

                opt.CreateOperands();
                opt.UserOption(playerChoice);

                Console.WriteLine("Press 'N' to quit, or any other key to play again.");
                replayChoice = Console.ReadLine();

            } while (replayChoice != "n" && replayChoice != "N");
        }
    }
}
