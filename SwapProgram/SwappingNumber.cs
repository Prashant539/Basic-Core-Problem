using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapProgram
{
    public class SwappingNumber
    {
        public void CheckSwap()
        {
            int a = 10;
            int b = 20;
            int temp;

            Console.WriteLine("Before swapping value of a={0},b={1}", a, b);

            temp = a;
            a = b;
            b = temp;

            Console.WriteLine("After the swapping value of a={0},b={1}", a, b);
        }
    }
}
    

