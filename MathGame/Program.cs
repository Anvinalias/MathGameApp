namespace MathGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? playerChoice;
            string? replayChoice;
            Option opt = new Option();

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
                    break;
                }

                opt.CreateOperands();
                opt.CreateQuestion(playerChoice);

                Console.WriteLine("Do you want to replay? Y or N ");
                replayChoice = Console.ReadLine();

            } while (replayChoice != "n" && replayChoice != "N");
        }
    }
}
