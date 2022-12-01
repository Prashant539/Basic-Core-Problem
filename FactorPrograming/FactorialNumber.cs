using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorPrograming
{
    public class FactorialNumber
    {
        public void CheckFactor()
        {
            int fact = 1;

            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of" + num + "is" + fact);
        }
    }
}

    

