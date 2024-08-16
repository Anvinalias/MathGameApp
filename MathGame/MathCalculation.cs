using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class MathCalculation
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
