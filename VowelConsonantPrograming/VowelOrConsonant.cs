using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelConsonantPrograming
{
    public class VowelOrConsonant
    {
        public void Display()
        {
            Console.WriteLine("Enter the any character");
            char ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch + "is vowel");
            }
            else
            {
                Console.WriteLine(ch + "is consonant ");
            }


        }
    }
}
    
