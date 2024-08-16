

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
    }
}
