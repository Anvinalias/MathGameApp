

namespace MathGame
{
    internal class Option
    {
        int num1, num2;
        string question = "", outputString = "";
        int actualResult = 0, userInput = 0;
        List<string> items = new List<string>();

        Random ran = new Random();
        public void CreateOperands()
        {
            num1 = ran.Next(0, 100);
            num2 = ran.Next(0, 100);
        }

        public void CreateQuestion(string choice)
        {
            switch (choice)
            {
                case "1":
                    actualResult = Operation.Addition(num1, num2);
                    question = $"What is {num1} + {num2} ?";
                    Console.WriteLine(question);
                    userInput = Convert.ToInt32(Console.ReadLine());
                    outputString = Operation.CheckResult(actualResult, userInput);
                    break;
                case "2":
                    actualResult = Operation.Substraction(num1, num2);
                    question = $"What is {num1} - {num2} ?";
                    Console.WriteLine(question);
                    userInput = Convert.ToInt32(Console.ReadLine());
                    outputString = Operation.CheckResult(actualResult, userInput);
                    break;
                case "3":
                    actualResult = Operation.Multiplication(num1, num2);
                    question = $"What is {num1} * {num2} ?";
                    Console.WriteLine(question);
                    userInput = Convert.ToInt32(Console.ReadLine());
                    outputString = Operation.CheckResult(actualResult, userInput);
                    break;
                case "4":
                    actualResult = Operation.Division(num1, num2);
                    question = $"What is {num1} / {num2} ?";
                    Console.WriteLine(question);
                    userInput = Convert.ToInt32(Console.ReadLine());
                    outputString = Operation.CheckResult(actualResult, userInput);
                    break;
                case "5":
                    Operation.DisplayHistory(items);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            items.Add($"Question: {question} Player response: {userInput} Result: {outputString}");
        }
    }
    internal class Operation
    {
        public static int Addition(int num1, int num2)
        {
            return num1 + num2; ;
        }

        public static int Substraction(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static int Division(int x, int y)
        {
            try
            {
                return x / y;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

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

        public static void DisplayHistory(List<string> listItems)
        {
          

            foreach (string i in listItems)
            {
                Console.WriteLine(i);
            }
        }
    }
}




