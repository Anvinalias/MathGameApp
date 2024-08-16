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
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. History");
                Console.WriteLine("6. Quit");

                playerChoice = Console.ReadLine();

                if (playerChoice == "6")
                {
                    Environment.Exit(0);
                }

                opt.CreateOperands();
                opt.UserOption(playerChoice);

                Console.WriteLine("Press 'Y' to playagain 'N' to quit");
                replayChoice = Console.ReadLine();

            } while (replayChoice != "n" && replayChoice != "N");
        }
    }
}
