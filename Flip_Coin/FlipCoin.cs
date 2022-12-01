using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flip_Coin
{
    public class FlipCoin
    {
        int headcount = 0;
        int tailcount = 0;
        double headpercentage = 0;
        double tailpercentage = 0;
        public void Flip()
        {
            Console.WriteLine("Enter the value for Number of Flips");
            int numberoffFlip = Convert.ToInt32(Console.ReadLine());

            if (numberoffFlip > 0)
            {
                for (int i = 0; i < numberoffFlip; i++ )
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    Console.WriteLine(number);
                    if (number == 0)
                    {
                        tailcount = tailcount + 1;
                    }
                    else
                    {
                        headcount++;
                    }
                }
                headpercentage = headcount + 100 / numberoffFlip;

                tailpercentage = tailcount + 100 / numberoffFlip;

                Console.WriteLine("Head Percentage " + headpercentage);
                Console.WriteLine("Tail Percentage " + tailpercentage);
            }
            else
            {
                Console.WriteLine("The number of Flip is not Valid");
                Console.ReadLine();
            }


        }
    }
}

               
    





