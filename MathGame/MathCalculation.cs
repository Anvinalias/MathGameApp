

namespace MathGame
{
    internal class GameOption
    {
        int num1, num2;
        string question = "", outputString = "", optionOperator = "";
        int actualResult = 0, userInput = 0;

        // a list to store game history
        List<string> gameHistory = new List<string>();

        // create object of random class
        Random ran = new Random();

        // generate random variables
        public void CreateOperands()
        {
            num1 = ran.Next(0, 100);
            num2 = ran.Next(0, 100);
        }

        public void UserOption(string choice)
        {
            switch (choice)
            {
                case "1":
                    // perform math operation
                    actualResult = Operation.Addition(num1, num2);
                    optionOperator = "+";
                    // generate and store question
                    question = Operation.CreateQuestion(num1, num2, optionOperator);
                    // get user answer
                    userInput = Operation.GetUserResponse();
                    // store game result
                    outputString = Operation.CheckResult(actualResult, userInput);
                    break;

                case "2":
                    actualResult = Operation.Subtraction(num1, num2);
                    optionOperator = "-";
                    question = Operation.CreateQuestion(num1, num2, optionOperator);
                    userInput = Operation.GetUserResponse();
                    outputString = Operation.CheckResult(actualResult, userInput);
                    break;

                case "3":
                    actualResult = Operation.Multiplication(num1, num2);
                    optionOperator = "*";
                    question = Operation.CreateQuestion(num1, num2, optionOperator);
                    userInput = Operation.GetUserResponse();
                    outputString = Operation.CheckResult(actualResult, userInput);
                    break;

                case "4":
                    actualResult = Operation.Division(num1, num2);
                    optionOperator = "/";
                    question = Operation.CreateQuestion(num1, num2, optionOperator);
                    userInput = Operation.GetUserResponse();
                    outputString = Operation.CheckResult(actualResult, userInput);
                    break;

                case "5":
                    Operation.DisplayHistory(gameHistory);
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            // add game history to the list
            gameHistory.Add($"Question: {question} Player response: {userInput} Result: {outputString}");
        }
    }
    internal class Operation
    {

        // math operation
        public static int Addition(int num1, int num2)
        {
            return num1 + num2; ;
        }

        public static int Subtraction(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static int Division(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Cannot divide by zero");
            }

            return x / y;
        }

        public static string CreateQuestion(int num1, int num2, string op)
        {
            string question = "";

            question = $"What is {num1} {op} {num2} ?";
            Console.WriteLine(question);
            return question;
        }

        public static int GetUserResponse()
        {
            int userResponse;

            while (!int.TryParse(Console.ReadLine(), out userResponse))
            {
                Console.WriteLine("Please enter a valid number.");
            }
            return userResponse;
        }

        // validate user answer with correct result
        public static string CheckResult(int actualResult, int userInput)
        {
            string resultString = "";

            if (actualResult == userInput)
            {
                resultString = $"{userInput} is Correct";
                Console.WriteLine(resultString);
                return resultString;
                 
            }
            else
            {
                resultString = $"{userInput} is Incorrect";
                Console.WriteLine(resultString);
                Console.WriteLine($"Correct Answer is {actualResult}");
                return resultString;
            }
        }

        // display game history
        public static void DisplayHistory(List<string> game)
        {
            foreach (string history in game)
            {
                Console.WriteLine(history);
            }
        }
    }
}




