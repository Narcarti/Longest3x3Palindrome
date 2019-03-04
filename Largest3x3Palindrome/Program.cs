using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest3x3Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            long Pnumbers = 0;
            long LargestPNum = 0;
            int num3 = 0;
            int num4 = 0;

            for (int num = 100; num < 1000; num++)
            {
                for (int num2 = 999; num2 >= 100; num2--)
                {
                    Pnumbers = num * num2;
                    string newnum = Pnumbers.ToString().Reverse().Aggregate("", (s, c) => s+c);
                    
                    if (Pnumbers == Convert.ToInt64(newnum))
                    {
                        if (Pnumbers > LargestPNum)
                        {
                            num3 = num;
                            num4 = num2;
                            LargestPNum = Pnumbers;
                        }
                    }
                }
            }
            Console.WriteLine(LargestPNum);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.ReadKey();
        }
    }
}
