using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo
{
    public class PowerOfTwo
    {
        public static void CheckPower()
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0 && number <= 31)
            {
                for (int i = 0; i < number; i++)
                {
                    Console.WriteLine(Math.Pow(i, 2));
                }
            }
            else
            {
                Console.WriteLine("Enter the number betwwen 2 to 31");
            }
        }
    }
}
