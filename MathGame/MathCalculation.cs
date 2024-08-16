

namespace MathGame
{
    internal class Option
    {
        int num1, num2;
        int actualResult = 0;
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
                    break;
                case "2":
                    actualResult = Operation.Substraction(num1, num2);
                    break;
                case "3":
                    actualResult = Operation.Multiplication(num1, num2);
                    break;
                case "4":
                    actualResult = Operation.Division(num1, num2);
                    break;
                //case "5":
                //    Operation.DisplayHistory();
                //    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
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

        //public void DisplayHistory(List<string> listItems)
        //{
        //    foreach (string i in listItems)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
    }
}




