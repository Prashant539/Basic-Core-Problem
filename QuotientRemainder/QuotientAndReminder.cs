using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotientRemainder
{
    public class QuotientAndReminder
    {
        public void CheckQuotientAndRemainder()
        {
            int divident = 50, divisor = 8;

            int quotient = divident / divisor;
            int remainder = divident % divisor;
            Console.WriteLine("Divident : {0} Divisor : {1}", divident, divisor);
            Console.WriteLine("Quotient :" + quotient);
            Console.WriteLine("Remainder : " + remainder);
        }
    }
}
    

