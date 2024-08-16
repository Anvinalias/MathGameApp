

namespace MathGame
{
    internal class Option
    {
        int num1, num2;
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
                    Addition(num1, num2);
                    break;
                case "2":
                    Substraction(num1, num2);
                    break;
                case "3":
                    Multiplication(num1, num2);
                    break;
                case "4":
                    Division(num1, num2);
                    break;
                case "5":
                    DisplayHistory();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
