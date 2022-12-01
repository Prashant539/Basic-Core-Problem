using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddProgram
{
    public class EvenOrOdd
    {
        

            public void Dispaly()
            {
                int remainder = 0;
                Console.WriteLine("Enter the number");
                int num = Convert.ToInt32(Console.ReadLine());

                remainder = num % 2;
                if (remainder == 0)
                {
                    Console.WriteLine("Number is even");
                }
                else
                {
                    Console.WriteLine("Number is odd");
                }
            }
        }
    }
 


