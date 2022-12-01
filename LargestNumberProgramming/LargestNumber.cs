using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumberProgramming
{
    public class LargestNumber
    {
        public void CheckLargestNumber()
        {
            Console.WriteLine("Find the largest of three Number");


            Console.WriteLine("Input the 1st number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 2nd number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the 3rd number:");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(" The 1st number is the greest among three");
                }
                else
                {
                    Console.WriteLine(" The 3rd number is the greest among three");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine(" The 2nd number is the greest among three");
            }
            else
            {
                Console.WriteLine(" The 3rd number is the greest among three");
            }

        }
    }
}
    

