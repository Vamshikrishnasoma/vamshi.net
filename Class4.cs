using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revnumber
{
    class Class4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int start = 1;
            int sum = 0;
            while (start <= num)
            {
                if (num % start == 0)
                {
                    sum = sum + start;
                }
                start++;
            }
            Console.WriteLine($"sum of factors is:{sum}");
        }
    }
}
